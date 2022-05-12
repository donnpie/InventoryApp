using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    public class DbBaseObject : IBaseObject
    {
        int id;
        string name;
        public int Id
        {
            get { return id; }
            set { if (IsValidId(value)) id = value; }
        }
        public string Name{ get { return name; }
            set { name = ValidateName(value); } } 
        //TODO: test that ensures name is truncated at 50 chars

        private bool IsValidId(int id)
        {
            if (id < 0) throw new ArgumentException("Id cannot be a negative value.");
            return true;
        }

        private string ValidateName(string name)
        {
            return (name.Length <= 50) ? this.name = name : this.name = name.Substring(0, 50);
        }

        public DbBaseObject()
        {
            Id = 0;
            Name = "";
        }
        public DbBaseObject(int id, string name)
        {
            //if (IsValidId(id)) this.id = id;
            Id = id;
            //this.name = ValidateName(name);
            Name = name;
        }

        public DbBaseObject(string name)
        {
            Id = 0;
            Name = name;
        }

        public virtual void Print()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Name: {name}");
        }
    }
}
