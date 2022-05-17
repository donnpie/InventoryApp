using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    public class GenericProductName
    {
        private int id;
        public int Id
        {
            get { return id; }
            private set { if (IsValidId(value)) id = value; }
        }

        private bool IsValidId(int id)
        {
            if (id < 0) throw new ArgumentException("Id cannot be a negative value.");
            return true;
        }
        
        private string name;
        public string Name
        {
            get { return name; }
            private set { name = ValidateName(value); }
        }
        private string ValidateName(string name)
        {
            if (name == "") throw new ArgumentException("Name cannot be null");
            return (name.Length <= 50) ? this.name = name : this.name = name.Substring(0, 50);
        }

        public Group Group { get; private set; }

        public GenericProductName(int id, string name, Group group)
        {
            Id = id;
            Name = name;
            Group = group;
        }

        public void Print()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Generic Product Name: {Name}");
            Console.WriteLine("Group:");
            Group.Print();
        }

    }
}
