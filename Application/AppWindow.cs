using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            FileItem file = FileOpen.Open();

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
            else this.Editor.Text = file.Contents;
        }


        private void MenuServiceSettings_Click(object sender, EventArgs e)
        {
            Program.SettingsDialog.ShowDialog();
        }
    }
}
