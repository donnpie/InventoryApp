using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    public class Product : DbBaseObject, IBaseObject
    {
        public string Barcode { get; private set; }
        public string Comments { get; private set; }
        public GenericProductName Gpn { get; private set; }
        public Brand Brand { get; private set; }
        public string ImageFileName { get; private set; }

        public Product(int id, string name, string barcode, string comments, string imageFilename, GenericProductName gpn, Brand brand) : base(id, name)
        {
            Barcode = barcode;
            Comments = comments;
            ImageFileName = imageFilename;
            this.Gpn = gpn;
            this.Brand = brand;
        }

        public Product(string name, string barcode, string comments, string imageFilename, GenericProductName gpn, Brand brand) : base(name)
        {
            Barcode = barcode;
            Comments = comments;
            ImageFileName = imageFilename;
            this.Gpn = gpn;
            this.Brand = brand;
        }



        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Product name: {this.Name}");
            Console.WriteLine($"Barcode: {this.Barcode}");
            Console.WriteLine($"Comments: {this.Comments}");
            this.Gpn.Print();
            this.Brand.Print();
        }


    }
}
