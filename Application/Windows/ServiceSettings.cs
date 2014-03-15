using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE.Windows
{
    public partial class ServiceSettings : Form
    {
        public ServiceSettings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            SettingsDialogTabs.TabPages[1].Controls["SettingsDialogBuildingCompilerPath"].Text = Program.Compiler.Location;
        }

        private void SettingsDialogButtonSave_Click(object sender, EventArgs e)
        {
            Program.Compiler.Location = SettingsDialogTabs.TabPages[1].Controls["SettingsDialogBuildingCompilerPath"].Text;
            Close();
        }
    }
}
