using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IDE.Abstractions;

namespace IDE.Compilers
{
    public class DMD2Compiler : ICompiler
    {
        public string Location { get; set; }

        public string HeadersEnabler { get { return "-H-Hd"; } }
    }
}