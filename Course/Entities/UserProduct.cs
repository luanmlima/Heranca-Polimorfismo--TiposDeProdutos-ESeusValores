using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course.Entities
{
    class UserProduct : Product
    {
        public DateTime Date { get; set; }

        public UserProduct()
        {
        }

        public UserProduct(string name, double price, DateTime date)
            : base(name, price)
        {
            Date = date;
        }

        public override string PriceTag()
        {
            return Name 
                + " (used) $ " 
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: " 
                + Date.ToString("dd/MM/yyyy")
                +")";
        }
        
    }
}
