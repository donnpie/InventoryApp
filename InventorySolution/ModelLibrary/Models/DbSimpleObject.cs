using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    public abstract class DbSimpleObject : DbBaseObject, ISimpleObject
    {
        public string Description { get; set; }
        public DbSimpleObject(int id, string name, string description) : base(id, name)
        {
            Description = description;
        }

        public DbSimpleObject(string name, string description) : base(name)
        {
            Description = description;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Description: {Description}");
        }
    }
}
