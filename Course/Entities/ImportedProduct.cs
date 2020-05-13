using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return Name 
                + " $ " 
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) 
                + " (Customs fee: $ " 
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) 
                + ")";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        
    }
}
