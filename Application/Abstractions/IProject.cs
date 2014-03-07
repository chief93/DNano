using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE.Abstractions
{
    public enum Target
    {
        Unspecified,
        Library,
        Executable
    }

    public interface IProject
    {
        Target Target { get; set; }
    }
}