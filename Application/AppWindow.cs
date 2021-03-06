﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

using IDE.Abstractions;
using IDE.Abstractions.DTO;
using IDE.Windows;

namespace IDE
{
    public partial class AppWindow : Form
    {
        private string _currentFile;

        public IOBuffer Buffer { get; private set; }
        public IOTimeMachine History { get; private set; }

        public AppWindow()
        {
            InitializeComponent();

            Buffer = new IOBuffer();
            History = new IOTimeMachine();

            _initEdit();

            Logs.TabPages[Logs.TabPages.IndexOfKey("IDE")].Controls.Add(_initLogs());
            Logs.TabPages[Logs.TabPages.IndexOfKey("Output")].Controls.Add(_initLogs());
            Logs.TabPages[Logs.TabPages.IndexOfKey("SearchLog")].Controls.Add(_initLogs());
        }

        private void _initEdit()
        {
            MenuEditUndo.Click += History.OnUndo;
            MenuEditRedo.Click += History.OnRedo;
            //--------------------------------------
            MenuEditCopy.Click += Buffer.OnCopy;
            MenuEditCut.Click += Buffer.OnCut;
            MenuEditPaste.Click += Buffer.OnPaste;
            MenuEditDelete.Click += Buffer.OnDelete;
            //--------------------------------------
            MenuEditSelectAll.Click += (object sender, EventArgs e) => {
                RichTextBox textBox = Buffer.ActiveControl as RichTextBox;

                if (textBox == null)
                    textBox.SelectAll();
            };
        }

        private RichTextBox _initLogs()
        {
            RichTextBox logs = new RichTextBox();

            logs.Anchor = Anchors();
            logs.AutoWordSelection = false;
            logs.ReadOnly = true;
            logs.ShortcutsEnabled = true;

            logs.Size = new Size(767, 125);
            logs.Location = new Point(0, 0);

            logs.Font = new Font("Consolas", 8);
            logs.BorderStyle = BorderStyle.None;
            logs.Text = "";

            Buffer.Listen(logs);

            return logs;
        }


        private AnchorStyles Anchors()
        {
            return (AnchorStyles)
            (
                ((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right
            );
        }


        private void MenuFileCreate_Click(object sender, EventArgs e)
        {
            Program.FileCreate.ShowDialog();
        }


        private void MenuFileOpen_Click(object sender, EventArgs e)
        {
            FileItem file = FileIOUI.Open(this);

            if (file == null) return;

            if (file.Extension == "ns")
            {
                TabPage logsTab = Logs.TabPages[Logs.TabPages.IndexOfKey("IDE")];
                Logs.SelectedTab = logsTab;

                try
                {
                    Program.Solution = JsonConvert.DeserializeObject<SolutionDTO>(file.Contents);
                }
                catch (Exception ex)
                {
                    Program.Log("Can't parse solution file. Details: " + ex.Message);
                    Alert.Error("Невозможно распознать файл решения");
                }

                if (Program.Solution == null) return;

                Program.Solution.Location = file.Location;

                TreeNode solution = new TreeNode(Program.Solution.Name + " (проектов: " + Program.Solution.Projects.Count + ")");
                solution.ToolTipText = Program.Solution.Location;

                SolutionExplorer.Nodes.Clear();
                SolutionExplorer.Nodes.Add(solution);

                Control logs = logsTab.Controls[0];
                logs.Text = "";

                foreach (ProjectDTO project in Program.Solution.Projects)
                {
                    string projectDir = file.Location + "/" + project.Location + "/";
                    string projectText = project.Location + " (" + Program.Solution.Location + project.Location + ")";

                    TreeNode[] prjContents = FileItem.BuildDirectoryTree(projectDir);

                    if (prjContents == null)
                    {
                        SolutionExplorer.Nodes[0].Nodes.Add(new TreeNode(project.Location + " [Ошибка]"));

                        logs.Text += "[warn] Не удалось загрузить проект " + projectText + ". Каталог проекта не найден.";
                    }
                    else
                    {
                        TreeNode projectNode = new TreeNode(project.Location, prjContents);
                        projectNode.ToolTipText = projectDir;
                        projectNode.Expand();

                        SolutionExplorer.Nodes[0].Nodes.Add(projectNode);

                        logs.Text += "[ ok ] Загружен проект: " + projectText;
                    }

                    logs.Text += "\r\n";
                }

                SolutionExplorer.Sort();
                SolutionExplorer.Nodes[0].Expand();
            }
            else _openTab(file);
        }


        private void MenuServiceSettings_Click(object sender, EventArgs e)
        {
            Program.SettingsDialog.ShowDialog();
        }

        private void _openTab(FileItem file)
        {
            foreach (TabPage tab in WorkingFiles.TabPages)
            {
                if (tab.Name != file.Location + file.Name) continue;

                WorkingFiles.SelectedTab = tab;
                return;
            }

            TabPage newTab = new TabPage(file.Name);
            newTab.Name = file.Location + file.Name;
            newTab.Anchor = Anchors();
            newTab.Size = new Size(767, 317);

            RichTextBox textBox = new RichTextBox();

            textBox.Anchor = Anchors();
            textBox.AutoWordSelection = false;
            textBox.Size = new Size(767, 317);
            textBox.Location = new Point(0, 0);
            textBox.Font = new Font("Consolas", 9);
            textBox.BorderStyle = BorderStyle.None;

            textBox.Text = file.Contents;
            textBox.AcceptsTab = true;

            Buffer.Listen(textBox);
            History.Listen(textBox);

            newTab.Controls.Add(textBox);

            WorkingFiles.TabPages.Add(newTab);
            WorkingFiles.SelectedTab = newTab;

            textBox.Focus();
        }

        private void _tabMouseClick(object sender, MouseEventArgs e)
        {
            int index = -1;

            foreach (TabPage tab in WorkingFiles.TabPages)
            {
                index = WorkingFiles.TabPages.IndexOf(tab);

                if (!WorkingFiles.GetTabRect(index).Contains(e.Location)) continue;

                _currentFile = tab.Name;
                tab.Controls[0].Focus();

                if (e.Button == MouseButtons.Right)
                    WorkingFilesTabContextMenu.Show(WorkingFiles, e.X, e.Y);

                return;
            }
        }

        private void WorkingFilesTabContextMenuClose_Click(object sender, EventArgs e)
        {
            WorkingFiles.TabPages.RemoveByKey(_currentFile);
        }

        private void WorkingFilesTabContextMenuCloseLeft_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in WorkingFiles.TabPages)
            {
                if (tab.Name == _currentFile) return;

                WorkingFiles.TabPages.RemoveByKey(tab.Name);
            }
        }

        private void WorkingFilesTabContextMenuCloseRight_Click(object sender, EventArgs e)
        {
            bool found = false;

            foreach (TabPage tab in WorkingFiles.TabPages)
            {
                if (tab.Name != _currentFile && !found) continue;

                found = true;

                if (tab.Name != _currentFile)
                    WorkingFiles.TabPages.RemoveByKey(tab.Name);
            }
        }

        private void WorkingFilesTabContextMenuCloseAllExceptThat_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in WorkingFiles.TabPages)
            {
                if (tab.Name == _currentFile) continue;

                WorkingFiles.TabPages.RemoveByKey(tab.Name);
            }
        }

        private void WorkingFilesTabContextMenuCloseAll_Click(object sender, EventArgs e)
        {

            foreach (TabPage tab in WorkingFiles.TabPages)
                WorkingFiles.TabPages.RemoveByKey(tab.Name);
        }

        private void SolutionExplorer_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (File.Exists(e.Node.ToolTipText))
                _openTab(new FileItem(e.Node.ToolTipText));
        }

        private void SolutionExplorer_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            _currentFile = e.Node.ToolTipText;
            SolutionExplorer.SelectedNode = e.Node;

            Point target = e.Location;
            target.Offset(5, 50);

            //int index = (Directory.Exists(e.Node.ToolTipText)) ? 2 : 1;
            //SolutionExplorerContextMenu.Items[SolutionExplorerContextMenu.Items.Count - index].Available = false;

            SolutionExplorerContextMenu.Show(target);

            //SolutionExplorerContextMenu.Items[SolutionExplorerContextMenu.Items.Count - index].Available = true;
        }

        private void ProjectItemsContextMenuOpen_Click(object sender, EventArgs e)
        {
            _openTab(new FileItem(_currentFile));
        }

        private void ProjectItemsContextMenuOpenOut_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(_currentFile);
            }
            catch (Exception ex)
            {
                Program.Log("Error opening file from solution tree. Details: " + ex.Message);
                Alert.Error("Невозможно открыть во внешней программе выбранный файл или каталог. Возможно он не существует.");
            }
        }



        private void SolutionExplorer_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move | DragDropEffects.Scroll);
        }

        private void SolutionExplorer_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move | DragDropEffects.Scroll;
        }

        private void SolutionExplorer_DragDrop(object sender, DragEventArgs e)
        {
            TreeView source = (TreeView)sender;
            Point bounds = source.PointToClient(new Point(e.X, e.Y));
            TreeNode target = source.GetNodeAt(bounds);

            TreeNode copy = (TreeNode)e.Data.GetData(typeof(TreeNode));

            if (copy.Index == 0 && copy.Parent == null) return;
            if (target.ToolTipText == copy.ToolTipText) return;
            if (!Directory.Exists(target.ToolTipText)) return;

            TreeNode final = (TreeNode)copy.Clone();

            if (copy.IsExpanded) final.Expand();

            target.Checked = true;
            target.Nodes.Add(final);
            target.Expand();
            target.TreeView.Sort();

            copy.Remove();
        }

        private void SolutionExplorerContextMenuAddFolder_Click(object sender, EventArgs e)
        {
            string name = "Новая папка";

            TreeNode node = new TreeNode(name);
            node.Name = name;

            if (Directory.Exists(_currentFile))
            {
                node.ToolTipText = SolutionExplorer.SelectedNode.ToolTipText + name;

                SolutionExplorer.SelectedNode.Nodes.Add(node);
                int index = SolutionExplorer.SelectedNode.Nodes.IndexOfKey(name);

                SolutionExplorer.SelectedNode.TreeView.Sort();
                SolutionExplorer.SelectedNode.Nodes[index].BeginEdit();
            }
            else
            {
                node.ToolTipText = SolutionExplorer.SelectedNode.Parent.ToolTipText + name;

                SolutionExplorer.SelectedNode.Parent.Nodes.Add(node);
                int index = SolutionExplorer.SelectedNode.Parent.Nodes.IndexOfKey(name);

                SolutionExplorer.SelectedNode.Parent.TreeView.Sort();
                SolutionExplorer.SelectedNode.Parent.Nodes[index].BeginEdit();
            }
        }

        private void SolutionExplorerContextMenuRename_Click(object sender, EventArgs e)
        {
            SolutionExplorer.SelectedNode.BeginEdit();
        }

        private void MenuFileSaveCurrent_Click(object sender, EventArgs e)
        {
            if (WorkingFiles.TabPages.Count == 0) return;

            FileItem file = new FileItem(WorkingFiles.SelectedTab.Name, WorkingFiles.SelectedTab.Controls[0].Text);
            file.Save();
        }

        private void MenuFileItemSaveAll_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in WorkingFiles.TabPages)
            {
                FileItem file = new FileItem(tab.Name, tab.Controls[0].Text);
                file.Save();
            }
        }

        private void MenuFileSaveCurrentAs_Click(object sender, EventArgs e)
        {
            FileIOUI.Save(this, new FileItem(WorkingFiles.SelectedTab.Name, WorkingFiles.SelectedTab.Controls[0].Text));
        }

        private void MenuFileExit_Click(object sender, EventArgs e)
        {
            AppWindow.ActiveForm.Close();
        }

        private void MenuBuildSolutionCleanAndRebuild_Click(object sender, EventArgs e)
        {
            Logs.TabPages[Logs.TabPages.IndexOfKey("Output")].Controls[0].Text = "Перестроение всех проектов начато\r\n";
            Logs.SelectedTab = Logs.TabPages[Logs.TabPages.IndexOfKey("Output")];

            int i = 0;

            if (Program.Solution == null)
            {
                Logs.TabPages[Logs.TabPages.IndexOfKey("Output")].Controls[0].Text += "Не обнаружено проектов для построения\r\n";
                return;
            }

            foreach (ProjectDTO project in Program.Solution.Projects)
            {
                Compiler compiler = new Compiler(Program.Compiler);
                compiler.Id = ++i;
                compiler.SolutionDirectory = Program.Solution.Location;
                compiler.WorkingDirectory = Program.Solution.Location + project.Location;

                compiler.OnStart += _onCompileStart;
                compiler.OnBeforeCompile += _onCompileReady;
                compiler.OnCompile += _onCompileProcess;
                compiler.OnError += _onCompileError;
                compiler.OnSuccess += _onCompileSuccess;

                compiler.Input.Files = FileItem.ObjectizeDirectory(Program.Solution.Location + project.Location);

                foreach (string import in Program.Solution.Import)
                    compiler.Input.Import.Add(import);

                foreach (string import in project.Import)
                    compiler.Input.Import.Add(import);

                compiler.Output.Assembly = new FileItem(Program.Solution.Location + Program.Solution.Output[project.Target.ToString()] + "/" + project.Location);
                compiler.Output.Headers = Program.Solution.Location + Program.Solution.Output["Headers"];
                compiler.Output.Target = project.Target;

                compiler.Call();
            }

            Logs.TabPages[Logs.TabPages.IndexOfKey("Output")].Controls[0].Text += "Перестроение всех проектов завершено\r\n";
        }

        private void _onCompileStart(Compiler compiler)
        {
            Logs.TabPages[Logs.TabPages.IndexOfKey("Output")].Controls[0].Text += compiler.Id + " >> [ ok ] " + compiler.Output.Assembly.Name + " Компиляция начата\r\n";
        }

        private void _onCompileReady(Compiler compiler, string comand)
        {
            //Logs.TabPages[Logs.TabPages.IndexOfKey("Output")].Controls[0].Text += compiler.Id + " >> [ ok ] " + compiler.Output.Assembly.Name + " Арументы компилятора: " + compiler.Comand + "\r\n";
            Program.Log("dmd " + comand, Program.LogLVL.DEBUG);
        }

        private void _onCompileProcess(Compiler compiler, string stdout)
        {
            //Logs.TabPages[Logs.TabPages.IndexOfKey("Output")].Controls[0].Text += compiler.Id + " >> " + compiler.Comand + ": " + stdout + "\r\n";
        }

        private void _onCompileError(Compiler compiler, string reason)
        {
            Logs.TabPages[Logs.TabPages.IndexOfKey("Output")].Controls[0].Text += compiler.Id + " >> [warn] " + compiler.Output.Assembly.Name + " " + reason + "\r\n";
        }

        private void _onCompileSuccess(Compiler compiler)
        {
            Logs.TabPages[Logs.TabPages.IndexOfKey("Output")].Controls[0].Text += compiler.Id + " >> [ ok ] " + compiler.Output.Assembly.Name + " Компиляция завершена\r\n";
        }

        private void Logs_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl logs = (TabControl)sender;
            logs.SelectedTab.Controls[0].Focus();
        }
    }
}