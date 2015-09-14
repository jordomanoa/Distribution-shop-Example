using DistributionShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopUI
{
    public partial class Shop : Form
    {
        private Store store = new Store();
        private List<Item> basketData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource basketBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;

        public Shop()
        {
            InitializeComponent();
            setupData();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            ItemListBox.DataSource = itemsBinding;

            ItemListBox.DisplayMember = "Display";
            ItemListBox.ValueMember = "Display";

            basketBinding.DataSource = basketData;
            BasketListBox.DataSource = basketBinding;

            BasketListBox.DisplayMember = "Display";
            BasketListBox.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            VendorListBox.DataSource = vendorsBinding;

            VendorListBox.DisplayMember = "Display";
            VendorListBox.ValueMember = "Display";


        }

        private void Shop_Load(object sender, EventArgs e)
        {

        }

        private void headerTextlbl_Click(object sender, EventArgs e)
        {

        }

        private void setupData()
        {

            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
            store.Vendors.Add(new Vendor { FirstName = "Sam", LastName = "Johnson" });

            store.Items.Add(new Item
            {
                Title = "Samsung Galaxy Edge",
                Description = "Phone Made by samsung that has curved edges",
                Price = 400.00M,
                Owner = store.Vendors[0]
            });
            store.Items.Add(new Item
            {
                Title = "iPhone 5c",
                Description = "Phone made by Apple, newest in their line of phones",
                Price = 600.00M,
                Owner = store.Vendors[1]
            });
            store.Items.Add(new Item
            {
                Title = "HTC One A9",
                Description = "Phone Made by HTC, worlds most powerful smartphone",
                Price = 450.00M,
                Owner = store.Vendors[0]
            });
            store.Items.Add(new Item
            {
                Title = "Xperia Z5",
                Description = "Phone made by Sony, Newest in the sony line also waterproof",
                Price = 550.00M,
                Owner = store.Vendors[1]
            });

            store.Name = "Hand Me Phones";



        }

        private void AddToBasketbtn_Click(object sender, EventArgs e)
        {
            //Find out what is selected from the items list
            //copy item to basket
            // Do we remove the item from the item list? - no

            Item selectedItem = (Item)ItemListBox.SelectedItem;

            basketData.Add(selectedItem);

            basketBinding.ResetBindings(false);
        }

        private void Purchasebtn_Click(object sender, EventArgs e)
        {
            //mark each item in the basket as sold 
            //clear basket
            
            foreach (Item item in basketData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit += (1 - (decimal)item.Owner.Commission) * item.Price;
            


            }

            basketData.Clear();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            storeProfitValuelbl.Text = string.Format("£{0}", storeProfit);

            basketBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);

        }
    }
}
