using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributionShopLibrary
{
    public class Item
    {
        public string Title;
        public string Description;
        public decimal Price;
        public bool Sold;
        public bool PaymentDistributed;
        public Vendor Owner;

        public string Display
        {
            get
            {
                return string.Format("{0} - £{1}", Title, Price); //the first value (Title) goes to 0 the second value (Price) goes to 1
            }
        }

    }
}
