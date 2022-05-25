using System.Collections.Generic;

namespace ModelLibrary.Models
{
    public class Category : DbSimpleObject, ISimpleObject
    {
        public Category(int id, string name, string description) : base(id, name, description) { }

        public Category(string name, string description) : base(name, description) { }
    }

    public class CompareCategoriesByName : IComparer<Category>
    {
        public int Compare(Category x, Category y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}
