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
    public class FileIOUI
    {
        private static OpenFileDialog _dialogOpen { get; set; }
        private static SaveFileDialog _dialogSave { get; set; }

        static FileIOUI()
        {
            _dialogOpen = new OpenFileDialog();
            _dialogSave = new SaveFileDialog();

            _dialogOpen.CheckFileExists = true;
            _dialogOpen.ValidateNames = false;

            _dialogSave.OverwritePrompt = true;
            _dialogSave.ValidateNames = false;
        }

        public static string Filter(List<ICreable> abstractions)
        {
            string filter = "";

            foreach (ICreable item in abstractions)
            {
                if ((item is IEditable || item is ISolution) && item.Extension.Length != 0)
                    filter += item.Description + " (*" + item.Extension + ")|" + "*" + item.Extension + "|";
            }

            return filter.Substring(0, filter.Length - 2);
        }

        public static FileItem Open(IWin32Window parent)
        {
            FileStream file = null;

            _dialogOpen.Filter = Filter(Program.Abstractions);

            try
            {
                _dialogOpen.ShowDialog(parent);
            }
            catch (Exception ex)
            {
                Program.Log("FileUIIO exception handler: " + ex.Message);
            }

            try
            {
                file = (FileStream)_dialogOpen.OpenFile();
                
                if (file == null)
                {
                    Alert.Error("Возникла ошибка при открытии файла. Не удалось прочитать файл.");
                    return null;
                }

                if (file.Name == null) return null;

                string data = "";

                if (file.Length > 0)
                {
                    byte[] buffer = new byte[1024 * 1024 * 10];
                    file.Read(buffer, 0, (int)file.Length);
                    
                    UTF8Encoding encoder = new UTF8Encoding();
                    data = encoder.GetString(buffer);
                }

                return new FileItem(file.Name, data);
            }
            catch (Exception e)
            {
                Program.Log("Unable to open file: " + e.Message, Program.LogLVL.WARN);
                return null;
            }
        }

        public static void Save(IWin32Window parent, string data)
        {
            try
            {
                _dialogSave.ShowDialog(parent);
            }
            catch (Exception ex)
            {
                Program.Log("FileUIIO exception handler: " + ex.Message);
            }

            File.WriteAllText(_dialogSave.FileName, data);
        }

        public static void Save(IWin32Window parent, FileItem file)
        {
            try
            {
                _dialogSave.ShowDialog(parent);
            }
            catch (Exception ex)
            {
                Program.Log("FileUIIO exception handler: " + ex.Message);
            }

            _dialogSave.FileName = file.Name;
            _dialogSave.DefaultExt = file.Extension;

            File.WriteAllText(_dialogSave.FileName, file.Contents);
        }
    }
}