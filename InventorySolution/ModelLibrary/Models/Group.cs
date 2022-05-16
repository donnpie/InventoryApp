using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    public class Group : DbSimpleObject, ISimpleObject
    {
        public Category Category { get; set; }

        public Group(int id, string name, string description) : base(id, name, description) { }
        public Group(int id, string name, string description, Category cat) : base(id, name, description) 
        {
            Category = cat;
        }

        public Group(string name, string description, Category cat) : base(name, description)
        {
            Category = cat;
        }

        public Group(string name, string description) : base(name, description) 
        { Category = null; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Category:");
            Category.Print();
        }
    }
}
