using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE.Abstractions.Files
{
    public class DInterface : ICreable, IEditable
    {
        public string Description { get { return "Интерфейс"; } }
        public string Extension { get { return ".d"; } }

        public string Contents { get; set; }
    }
}