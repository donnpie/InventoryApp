using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    public class StockIn
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

        int _storeId;
        public int StoreId
        {
            get { return _storeId; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The value provided for StoreId is not valid");                   
                }
                _storeId = value;
            }
        }

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

        float _price;
        public float Price
        {
            get { return _price; }
            set
            {
                if (value < 0.00)
                {
                    throw new ArgumentException("The value provided for Price is not valid");
                }
                _price = value;
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

        public StockIn(int id, string barcode, int storeId, string dateString, float price, int quantity)
        {
            Id = id;
            Barcode = barcode;
            StoreId = storeId;
            DateString = dateString;
            Price = price;
            Quantity = quantity;
        }

        public StockIn(string barcode, int storeId, string dateString, float price, int quantity)
        {
            Id = 0;
            Barcode = barcode;
            StoreId = storeId;
            DateString = dateString;
            Price = price;
            Quantity = quantity;
        }
    }
}
