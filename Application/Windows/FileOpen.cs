using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IDE.Abstractions;

namespace IDE.Windows
{
    public class FileOpen
    {
        private static OpenFileDialog _dialog { get; set; }

        static FileOpen()
        {
            _dialog = new OpenFileDialog();
        }

        public static FileItem OpenInDialog()
        {
            FileStream file = null;
            string filter = "";
            
            foreach (ICreable item in Program.Abstractions)
            {
                if ((item is IEditable || item is ISolution) && item.Extension.Length != 0)
                    filter += item.Description + " (*" + item.Extension + ")|" + "*" + item.Extension + "|";
            }

            _dialog.Filter = filter.Substring(0, filter.Length - 2);
            _dialog.ShowDialog();

            try
            {
                file = (FileStream)_dialog.OpenFile();
                
                if (file == null)
                {
                    MessageBox.Show("Возникла ошибка при открытии файла. Не удалось прочитать файл.");
                    return null;
                }

                byte[] buffer = new byte[1024 * 1024 * 10];
                file.Read(buffer, 0, (int)file.Length);
                
                UTF8Encoding encoder = new UTF8Encoding();

                return new FileItem(file.Name, encoder.GetString(buffer));
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка! Невозможно открыть файл. Подробности: " + e.Message);
                return null;
            }
        }

        public static FileItem OpenInline(string file)
        {
            return new FileItem(file, File.ReadAllText(file));
        }
    }
}