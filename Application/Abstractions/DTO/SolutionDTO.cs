using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE.Abstractions.DTO
{
    public class SolutionDTO
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        public List<ProjectDTO> Projects { get; set; }

        public Dictionary<string, string> Output { get; set; }
        public List<string> Import { get; set; }

        public SolutionDTO()
        {
            Name = "";
            Extension = "";
            Location = "";
            Description = "";

            Projects = new List<ProjectDTO>();

            Output = new Dictionary<string, string>();
            Import = new List<string>();
        }
    }
}