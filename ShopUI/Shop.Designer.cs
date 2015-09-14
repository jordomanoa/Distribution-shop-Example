namespace ShopUI
{
    partial class Shop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerTextlbl = new System.Windows.Forms.Label();
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.ItemsListBoxlbl = new System.Windows.Forms.Label();
            this.AddToBasketbtn = new System.Windows.Forms.Button();
            this.Basketlbl = new System.Windows.Forms.Label();
            this.BasketListBox = new System.Windows.Forms.ListBox();
            this.Purchasebtn = new System.Windows.Forms.Button();
            this.VendorListBoxlbl = new System.Windows.Forms.Label();
            this.VendorListBox = new System.Windows.Forms.ListBox();
            this.storePayoutlbl = new System.Windows.Forms.Label();
            this.storeProfitValuelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerTextlbl
            // 
            this.headerTextlbl.AutoSize = true;
            this.headerTextlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerTextlbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.headerTextlbl.Location = new System.Drawing.Point(12, 9);
            this.headerTextlbl.Name = "headerTextlbl";
            this.headerTextlbl.Size = new System.Drawing.Size(408, 42);
            this.headerTextlbl.TabIndex = 0;
            this.headerTextlbl.Text = "Distribution Shop Demo";
            this.headerTextlbl.Click += new System.EventHandler(this.headerTextlbl_Click);
            // 
            // ItemListBox
            // 
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.ItemHeight = 20;
            this.ItemListBox.Location = new System.Drawing.Point(29, 107);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(298, 124);
            this.ItemListBox.TabIndex = 1;
            // 
            // ItemsListBoxlbl
            // 
            this.ItemsListBoxlbl.AutoSize = true;
            this.ItemsListBoxlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsListBoxlbl.Location = new System.Drawing.Point(25, 84);
            this.ItemsListBoxlbl.Name = "ItemsListBoxlbl";
            this.ItemsListBoxlbl.Size = new System.Drawing.Size(103, 20);
            this.ItemsListBoxlbl.TabIndex = 2;
            this.ItemsListBoxlbl.Text = "Store Items";
            // 
            // AddToBasketbtn
            // 
            this.AddToBasketbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToBasketbtn.Location = new System.Drawing.Point(361, 169);
            this.AddToBasketbtn.Name = "AddToBasketbtn";
            this.AddToBasketbtn.Size = new System.Drawing.Size(125, 37);
            this.AddToBasketbtn.TabIndex = 3;
            this.AddToBasketbtn.Text = "Add To Basket ->";
            this.AddToBasketbtn.UseVisualStyleBackColor = true;
            this.AddToBasketbtn.Click += new System.EventHandler(this.AddToBasketbtn_Click);
            // 
            // Basketlbl
            // 
            this.Basketlbl.AutoSize = true;
            this.Basketlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Basketlbl.Location = new System.Drawing.Point(509, 84);
            this.Basketlbl.Name = "Basketlbl";
            this.Basketlbl.Size = new System.Drawing.Size(65, 20);
            this.Basketlbl.TabIndex = 5;
            this.Basketlbl.Text = "Basket";
            // 
            // BasketListBox
            // 
            this.BasketListBox.FormattingEnabled = true;
            this.BasketListBox.ItemHeight = 20;
            this.BasketListBox.Location = new System.Drawing.Point(513, 107);
            this.BasketListBox.Name = "BasketListBox";
            this.BasketListBox.Size = new System.Drawing.Size(298, 124);
            this.BasketListBox.TabIndex = 6;
            // 
            // Purchasebtn
            // 
            this.Purchasebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purchasebtn.Location = new System.Drawing.Point(723, 237);
            this.Purchasebtn.Name = "Purchasebtn";
            this.Purchasebtn.Size = new System.Drawing.Size(88, 37);
            this.Purchasebtn.TabIndex = 7;
            this.Purchasebtn.Text = "Purchase";
            this.Purchasebtn.UseVisualStyleBackColor = true;
            this.Purchasebtn.Click += new System.EventHandler(this.Purchasebtn_Click);
            // 
            // VendorListBoxlbl
            // 
            this.VendorListBoxlbl.AutoSize = true;
            this.VendorListBoxlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorListBoxlbl.Location = new System.Drawing.Point(25, 303);
            this.VendorListBoxlbl.Name = "VendorListBoxlbl";
            this.VendorListBoxlbl.Size = new System.Drawing.Size(76, 20);
            this.VendorListBoxlbl.TabIndex = 9;
            this.VendorListBoxlbl.Text = "Vendors";
            // 
            // VendorListBox
            // 
            this.VendorListBox.FormattingEnabled = true;
            this.VendorListBox.ItemHeight = 20;
            this.VendorListBox.Location = new System.Drawing.Point(29, 326);
            this.VendorListBox.Name = "VendorListBox";
            this.VendorListBox.Size = new System.Drawing.Size(298, 124);
            this.VendorListBox.TabIndex = 8;
            // 
            // storePayoutlbl
            // 
            this.storePayoutlbl.AutoSize = true;
            this.storePayoutlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storePayoutlbl.Location = new System.Drawing.Point(509, 303);
            this.storePayoutlbl.Name = "storePayoutlbl";
            this.storePayoutlbl.Size = new System.Drawing.Size(106, 20);
            this.storePayoutlbl.TabIndex = 10;
            this.storePayoutlbl.Text = "Store Profit:";
            // 
            // storeProfitValuelbl
            // 
            this.storeProfitValuelbl.AutoSize = true;
            this.storeProfitValuelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitValuelbl.Location = new System.Drawing.Point(616, 303);
            this.storeProfitValuelbl.Name = "storeProfitValuelbl";
            this.storeProfitValuelbl.Size = new System.Drawing.Size(54, 20);
            this.storeProfitValuelbl.TabIndex = 11;
            this.storeProfitValuelbl.Text = "£0.00";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 532);
            this.Controls.Add(this.storeProfitValuelbl);
            this.Controls.Add(this.storePayoutlbl);
            this.Controls.Add(this.VendorListBoxlbl);
            this.Controls.Add(this.VendorListBox);
            this.Controls.Add(this.Purchasebtn);
            this.Controls.Add(this.BasketListBox);
            this.Controls.Add(this.Basketlbl);
            this.Controls.Add(this.AddToBasketbtn);
            this.Controls.Add(this.ItemsListBoxlbl);
            this.Controls.Add(this.ItemListBox);
            this.Controls.Add(this.headerTextlbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Shop";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "Shop Demo";
            this.Load += new System.EventHandler(this.Shop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerTextlbl;
        private System.Windows.Forms.ListBox ItemListBox;
        private System.Windows.Forms.Label ItemsListBoxlbl;
        private System.Windows.Forms.Button AddToBasketbtn;
        private System.Windows.Forms.Label Basketlbl;
        private System.Windows.Forms.ListBox BasketListBox;
        private System.Windows.Forms.Button Purchasebtn;
        private System.Windows.Forms.Label VendorListBoxlbl;
        private System.Windows.Forms.ListBox VendorListBox;
        private System.Windows.Forms.Label storePayoutlbl;
        private System.Windows.Forms.Label storeProfitValuelbl;
    }
}

