using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace CourseProducts.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return Name +
                "(Used) $ " +
                Price.ToString("F2", CultureInfo.InvariantCulture) +
                 " (Manufactured date: " +
                 ManufactureDate.ToString("dd/MM/yyyy") +
                 ")";
                
        }
    }
}
