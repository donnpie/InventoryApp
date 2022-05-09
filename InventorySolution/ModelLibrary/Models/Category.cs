using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    public class Category : DbBaseObject
    {
        private string description;
        public Category(int id, string name, string description) : base(id, name)
        {
            this.description = description;
        }

        string Description { get; set; }

        public void Print()
        {
            base.Print();
            Console.WriteLine($"Description: {description}");
        }
    }
}
