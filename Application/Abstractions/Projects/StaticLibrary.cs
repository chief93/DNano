using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE.Abstractions.Projects
{
    public class StaticLibrary : ICreable, IProject
    {
        public string Description { get { return "Проект статической библиотеки"; } }
        public string Extension { get { return ".lib, .a"; } }

        public Target Target { get; set; }

        public StaticLibrary()
        {
            Target = Target.Library;
        }
    }
}