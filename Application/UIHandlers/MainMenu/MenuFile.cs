using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE.UIHandlers.MainMenu
{
    public class MenuFile
    {
        private static OpenFileDialog _openFileDialog;

        static MenuFile()
        {
            _openFileDialog = new OpenFileDialog();
        }

        public static void FileCreate(object sender, EventArgs e)
        {

        }

        public static void FileOpen(object sender, EventArgs e)
        {

        }
    }
}