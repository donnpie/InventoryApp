using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    public class Store : DbSimpleObject
    {
        public Store(int id, string name, string description) : base(id, name, description) { }

        public Store(string name, string description) : base(name, description) { }
    }
}
