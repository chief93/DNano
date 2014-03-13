using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using IDE.Abstractions;
using IDE.Abstractions.DTO;
using IDE.Abstractions.Files;
using IDE.Abstractions.Projects;
using IDE.Windows;

namespace IDE
{
    static class Program
    {
        public static AppWindow AppWindow { get; private set; }

        public static List<ICreable> Abstractions { get; private set; }
        public static SolutionDTO Solution { get; set; }

        public static FileCreate FileCreate { get; private set; }
        public static ServiceSettings SettingsDialog { get; private set; }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            RegisterAbstractions();
            InitWindows();

            Application.Run(AppWindow);
        }

        [STAThread]
        public static void InitWindows()
        {
            AppWindow = new AppWindow();

            FileCreate = new FileCreate();
            SettingsDialog = new ServiceSettings();
        }

        [STAThread]
        public static void RegisterAbstractions()
        {
            Abstractions = new List<ICreable>();

            Abstractions.Add(new Solution());
            Abstractions.Add(new StaticLibrary());
            Abstractions.Add(new Executable());

            Abstractions.Add(new DSource());
            Abstractions.Add(new DHeader());
            Abstractions.Add(new DClass());
            Abstractions.Add(new DInterface());
        }

        public enum LogLVL
        {
            INFO,
            WARN,
            FATAL,
            DEBUG
        }

        public static void Log(string message, LogLVL lvl = LogLVL.INFO)
        {
            try
            {
                File.AppendAllText("log.txt", "[" + lvl.ToString() + "] " + message);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Unable to write log into log.txt: " + e.Message);
            }
        }
    }
}
