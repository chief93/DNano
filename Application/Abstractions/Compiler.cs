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
        public string SolutionDirectory { get; set; }
        public string Comand { get; private set; }

        public static bool IsLinux
        {
            get
            {
                PlatformID platform = Environment.OSVersion.Platform;

                return (platform == PlatformID.Unix || platform == PlatformID.MacOSX);
            }
        }

        public string LinkerLibSearchOption { get { return " -L" + (IsLinux ? "-L" : "+"); } }

        public string OutputExtension
        {
            get
            {
                return (Output.Target == Target.Library)
                    ? (IsLinux ? ".a" : ".lib")
                    : ""
                ;
            }
        }

        public Compiler(ICompiler driver)
        {
            _driver = driver;

            Input = new _input();
            Output = new _output();

            WorkingDirectory = "";
            Comand = "";
        }

        public void Call()
        {
            OnStart(this);

            if (Output.Target == Target.Library)
            {
                Comand += " -gc -op";
                Comand += " -lib";
                Comand += " -H -Hd\"" + Output.Headers + "\"";
            }

            Comand += " -of\"" + FileItem.BuildNormalizedPath(Output.Assembly.Location) + Output.Assembly.Name.Replace(".", "") + OutputExtension + "\"";
            
            foreach (string import in Input.Import)
            {
                string clearImport = SolutionDirectory + import;

                if (Output.Target == Target.Executable)
                    Comand += LinkerLibSearchOption + FileItem.BuildNormalizedPath(clearImport, true);
                
                Comand += " -I" + FileItem.BuildNormalizedPath(clearImport);
            }

            foreach (FileItem file in Input.Files)
                Comand += " \"" + file.Location + file.Name + "\"";

            Comand = Comand.Trim();

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

            FileItem.MoveMassive(WorkingDirectory, Output.Headers, "*.di");

            OnSuccess(this);
        }
    }
}