using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE.Abstractions.DTO
{
    public class ProjectDTO
    {
        public string Location { get; set; }
        public Target Target { get; set; }
        public List<string> Import { get; set; }

        public ProjectDTO()
        {
            Location = "";
            Target = Target.Unspecified;
            Import = new List<string>();
        }
    }
}