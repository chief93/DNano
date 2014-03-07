using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE.Abstractions
{
    public interface ICreable
    {
        string Description { get; }
        string Extension { get; }
    }
}