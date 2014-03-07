using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE.Abstractions.Projects
{
    public class Solution : ICreable, ISolution
    {
        public string Description { get { return "Решение"; } }
        public string Extension { get { return ".ns"; } }

        public string Location { get; set; }

        public List<IProject> Projects { get; set; }

        public Dictionary<string, string> Output { get; set; }
        public List<string> Import { get; set; }
    }
}