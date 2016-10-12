using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace zaladunek3
{
    public partial class MainWindow : Form
    {
        public static List<Product> products;
        public static Label number_of_items;

        public MainWindow()
        {
            InitializeComponent();
            setBinsBoxList();
            BinsBox.SelectedIndex = 0;
            products = new List<Product>();
            NumberOfItemsAdded.Text += products.Count;
            number_of_items = NumberOfItemsAdded;
        }

        public static void refresh()
        {
            number_of_items.Text = "Added items: " + products.Count;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SimulationButton_Click(object sender, EventArgs e)
        {
            int index = BinsBox.SelectedIndex;
            Bins bins = new Bins();
            Bin bin = bins.getList()[index];
            SimulationWindow simulation;
            if (checkBox.Checked)
                simulation = new SimulationWindow(MainWindow.products, bin.getSize(), true);
            else
                simulation = new SimulationWindow(MainWindow.products, bin.getSize(), false);
            simulation.Show();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            ProductWindow product_window = new ProductWindow();
            product_window.Show();
        }

        private void setBinsBoxList()
        {
            Bins bins =  new Bins();
            foreach (Bin bin in bins.getList())
            {
                BinsBox.Items.Add(bin.getType() + " (" + bin.getSize() + " kg)");
            }
        }

        private void ViewProductsButton_Click(object sender, EventArgs e)
        {
            ProductList list_of_products = new ProductList();
            list_of_products.Show();
        }

        private void RemoveProductButton_Click(object sender, EventArgs e)
        {
            RemoveItemForm remove_item_form = new RemoveItemForm();
            remove_item_form.Show();
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
    }
}
