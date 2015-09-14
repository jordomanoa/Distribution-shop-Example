using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributionShopLibrary
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }
        public decimal PaymentDue;

        public string Display
        {
            get
            {
                return string.Format("{0} {1} - £{2}", FirstName, LastName, PaymentDue); //the first value (Title) goes to 0 the second value (Price) goes to 1
            }
        }


            public Vendor()
        {
                Commission = .5;
            }

        }
    }

