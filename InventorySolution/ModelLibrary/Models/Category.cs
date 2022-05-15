using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    public class Category : DbSimpleObject, ISimpleObject
    {
        public Category(int id, string name, string description) : base(id, name, description) { }

        public Category(string name, string description) : base(name, description) { }
    }
}
