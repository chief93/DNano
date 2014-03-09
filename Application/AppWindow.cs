using System;
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

        public AppWindow()
        {
            InitializeComponent();

            _initLogs();
        }

        private void _initLogs()
        {
            RichTextBox logs = new RichTextBox();

            logs.Anchor = Anchors();
            logs.ReadOnly = true;

            logs.Size = new Size(767, 140);
            logs.Location = new Point(0, 0);

            logs.Font = new Font("Consolas", 8);
            logs.BorderStyle = BorderStyle.None;

            Logs.TabPages[Logs.TabPages.IndexOfKey("IDE")].Controls.Add(logs);
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
            FileItem file = FileOpen.OpenInDialog();

            if (file.Extension == "ns")
            {
                TabPage logsTab = Logs.TabPages[Logs.TabPages.IndexOfKey("IDE")];
                Logs.SelectedTab = logsTab;

                Program.Solution = JsonConvert.DeserializeObject<SolutionDTO>(file.Contents);
                Program.Solution.Name = file.Name;
                Program.Solution.Location = file.Location;

                SolutionExplorer.Nodes.Clear();
                SolutionExplorer.Nodes.Add(Program.Solution.Name + " (" + Program.Solution.Location + ")");
                
                foreach (ProjectDTO project in Program.Solution.Projects)
                {
                    string prjText = project.Location + " (" + Program.Solution.Location + project.Location + ")";
                    Control logs = logsTab.Controls[0];

                    TreeNode[] prjContents = FileItem.BuildDirectoryTree(file.Location + "/" + project.Location + "/");

                    if (prjContents == null) logs.Text += "[warn] Не удалось загрузить проект " + prjText+ ". Каталог проекта не найден.";
                    else
                    {
                        TreeNode projectNode = new TreeNode(project.Location, prjContents);
                        projectNode.Expand();
                        
                        SolutionExplorer.Nodes[0].Nodes.Add(projectNode);

                        logs.Text += "[ ok ] Загружен проект: " + prjText;
                    }

                    logs.Text += "\r\n";
                }

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
            textBox.Size = new Size(767, 317);
            textBox.Location = new Point(0, 0);
            textBox.Font = new Font("Consolas", 9);
            textBox.BorderStyle = BorderStyle.None;

            textBox.Text = file.Contents;

            newTab.Controls.Add(textBox);

            WorkingFiles.TabPages.Add(newTab);
            WorkingFiles.SelectedTab = newTab;
        }

        private void _tabMouseClick(object sender, MouseEventArgs e)
        {
            int index = -1;

            foreach (TabPage tab in WorkingFiles.TabPages)
            {
                index = WorkingFiles.TabPages.IndexOf(tab);

                if (!WorkingFiles.GetTabRect(index).Contains(e.Location)) continue;

                _currentFile = tab.Name;

                if (e.Button == MouseButtons.Right)
                {
                    WorkingFilesTabContextMenu.Show(WorkingFiles, e.X, e.Y);
                    return;
                }
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
                _openTab(FileOpen.OpenInline(e.Node.ToolTipText));
        }

        private void SolutionExplorer_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            _currentFile = e.Node.ToolTipText;
            SolutionExplorer.SelectedNode = e.Node;

            Point target = e.Location;
            target.Offset(5, 50);

            ProjectItemsContextMenu.Show(target);
        }

        private void ProjectItemsContextMenuOpen_Click(object sender, EventArgs e)
        {
            _openTab(FileOpen.OpenInline(_currentFile));
        }

        private void ProjectItemsContextMenuOpenOut_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(_currentFile);
        }
    }
}