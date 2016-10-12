using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace zaladunek3
{
    public partial class ProductList : Form
    {
        public static Label listOfProductsLabel;
        public ProductList()
        {
            InitializeComponent();
            listOfProductsLabel = ListOfProducts;
            setList();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            Panel my_panel = new Panel();
            VScrollBar vScroller = new VScrollBar();
            vScroller.Dock = DockStyle.Right;
            vScroller.Width = 30;
            vScroller.Height = 200;
            vScroller.Name = "VScrollBar1";
            my_panel.Controls.Add(vScroller);
        }

        public static void setList()
        {
            listOfProductsLabel.Text = "";
            if (MainWindow.products.Count > 0)
            {
                Dictionary<String, int> list_of_products = countObjects();
                foreach (KeyValuePair<String, int> product in list_of_products)
                {
                    listOfProductsLabel.Text += "\n " + product.Value + "x " + product.Key;
                }
            }
            else
            {
                listOfProductsLabel.Text = "No products have been added";
            }
        }

        public static Dictionary<String, int> countObjects()
        {
            List<String> products = getNameOfProducts(MainWindow.products);
            Dictionary<String, int> dictionary = products.GroupBy(str => str).ToDictionary(group => group.Key, group => group.Count());
            return dictionary;
        }

        public static List<String> getNameOfProducts(List<Product> products)
        {
            List<String> names_of_products = new List<String>();
            foreach (Product p in products)
            {
                names_of_products.Add(p.getName());
            }
            return names_of_products;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
