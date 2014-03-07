using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE.Abstractions.Files
{
    public class DHeader : ICreable, IEditable
    {
        public string Description { get { return "Файл заголовков"; } }
        public string Extension { get { return ".di"; } }

        public string Contents { get; set; }
    }
}