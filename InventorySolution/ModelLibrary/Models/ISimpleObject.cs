using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    public interface ISimpleObject : IBaseObject
    {
        string Description { get; set; }
    }
}
