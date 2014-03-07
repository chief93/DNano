using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE.Abstractions.Projects
{
    public class Executable : ICreable, IProject
    {
        public string Description { get { return "Проект консольного приложения"; } }
        public string Extension { get { return ".exe"; } }

        public Target Target { get; set; }

        public Executable()
        {
            Target = Target.Executable;
        }
    }
}