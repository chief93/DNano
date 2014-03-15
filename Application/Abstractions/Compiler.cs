using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE.Abstractions
{
    public interface ICompiler
    {
        string Location { get; set; }
        string HeadersEnabler { get; }
    }

    public class Compiler
    {
        public class _input
        {
            public List<string> Import { get; set; }
            public List<FileItem> Files { get; set; }

            public _input()
            {
                Import = new List<string>();
                Files = new List<FileItem>();
            }
        }

        public class _output
        {
            public Target Target { get; set; }
            public FileItem Assembly { get; set; }
            public string Headers { get; set; }
        }

        private ICompiler _driver;

        public _input Input { get; private set; }
        public _output Output { get; private set; }

        public Action<Compiler> OnStart { get; set; }
        public Action<Compiler, string> OnBeforeCompile { get; set; }
        public Action<Compiler, string> OnCompile { get; set; }
        public Action<Compiler> OnSuccess { get; set; }
        public Action<Compiler, string> OnError { get; set; }

        public int Id { get; set; }
        public string WorkingDirectory { get; set; }
        public string Comand { get; private set; }
        public string Log { get; private set; }

        public Compiler(ICompiler driver)
        {
            _driver = driver;

            Input = new _input();
            Output = new _output();

            WorkingDirectory = "";
            Log = "Начало процесса компиляции:\r\n * Обнаружение компилятора\r\n";
            Comand = "-v -op -gc";
        }

        public void Call()
        {
            OnStart(this);

            //Log += " * Сбор файлов\r\n";

            foreach (FileItem file in Input.Files)
                Comand += " \"" + file.Location + file.Name + "\"";

            //Log += " * Сбор зависимостей\r\n";

            foreach (string import in Input.Import)
            {
                string clearImport = WorkingDirectory + import;

                if (!Directory.Exists(clearImport))
                    OnError(this, "Директория импорта " + clearImport + " не существует или отсутствуют права доступа.");
                
                Comand += " -I\"" + clearImport + "\"";
            }

            //Log += " * Включение дополнительных настроек компилятора\r\n";

            if (Output.Target == Target.Library) Comand += " -lib";

            Comand += " -of\"" + Output.Assembly.Location + "../test/" + Output.Assembly.Name + "\"";
            // parsing flags stuff

            //Log += "Компиляция:\r\n";

            OnBeforeCompile(this, Comand);

            Process compiler = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = _driver.Location,
                    Arguments = Comand,
                    CreateNoWindow = true,
                    UseShellExecute = false,

                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                }
            };

            compiler.Start();

            while (!compiler.StandardOutput.EndOfStream)
                OnCompile(this, compiler.StandardOutput.ReadToEnd());

            while (!compiler.StandardError.EndOfStream)
                OnError(this, compiler.StandardError.ReadToEnd());

            //Log += "Компиляция завершена\r\n";

            OnSuccess(this);
        }
    }
}