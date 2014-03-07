using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IDE.Abstractions;

namespace IDE.Windows
{
    public partial class FileCreate : Form
    {
        public ListViewGroup FileGroupProjects { get; private set; }
        public ListViewGroup FileGroupFiles { get; private set; }
        
        public FileCreate()
        {
            FileGroupProjects = new ListViewGroup("Проекты", HorizontalAlignment.Left);
            FileGroupFiles = new ListViewGroup("Файлы", HorizontalAlignment.Left);

            InitializeComponent();
            VisualizeRegisteredCreable(Program.Abstractions);
        }

        public void VisualizeRegisteredCreable(List<ICreable> items)
        {
            FileCreateDialogSelectedGroupItems.Groups.Clear();
            FileCreateDialogSelectedGroupItems.Items.Clear();

            FileCreateDialogSelectedGroupItems.Groups.Add(FileGroupProjects);
            FileCreateDialogSelectedGroupItems.Groups.Add(FileGroupFiles);

            foreach (ICreable item in items)
            {
                ListViewItem renderableItem = new ListViewItem(
                    item.Description,
                    (item is ISolution || item is IProject)
                        ? FileGroupProjects
                        : FileGroupFiles
                );

                renderableItem.SubItems.Add(item.Extension);

                FileCreateDialogSelectedGroupItems.Items.Add(renderableItem);
            }
        }

        private void FileCreate_Shown(object sender, EventArgs e)
        {
            this.FileCreateDialogTemplates.Nodes[0].Expand();
        }
    }
}
