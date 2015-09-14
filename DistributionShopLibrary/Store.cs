using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributionShopLibrary
{
    public class Store
    {
        public string Name;
        public List<Vendor> Vendors;
        public List<Item> Items;

        public Store()
        {
            Vendors = new List<Vendor>();
            Items = new List<Item>();
        }
    }
}
