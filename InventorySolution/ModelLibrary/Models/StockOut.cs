using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    public class StockOut
    {
        int _id;
        public int Id { get { return _id; } 
            set {
                if (value < 0)
                {
                    throw new ArgumentException("The value provided for Id is not valid");
                }               
                _id = value;
            } 
        }
        public string Barcode { get; set; }

        string _dateString;
        public string DateString
        {
            get { return _dateString; }
            set
            {
                DateTime d;
                bool isValidDateString = DateTime.TryParseExact(
                    value,
                    "yyyy-MM-dd",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out d
                 );

                if (!isValidDateString)
                {
                    throw new ArgumentException("Date argument is invalid");
                }
                _dateString = value;
            }
        }

        int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The value provided for Quantity is not valid");
                }
                _quantity = value;
            }
        }

        public StockOut(int id, string barcode, string dateString, int quantity)
        {
            Id = id;
            Barcode = barcode;
            DateString = dateString;
            Quantity = quantity;
        }

        public StockOut(string barcode, string dateString, int quantity)
        {
            Id = 0;
            Barcode = barcode;
            DateString = dateString;
            Quantity = quantity;
        }
    }
}
