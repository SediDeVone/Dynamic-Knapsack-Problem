using System;
using System.Linq;
using System.Windows.Forms;

namespace zaladunek3
{
    public partial class ProductWindow : Form
    {
        public ProductWindow()
        {
            InitializeComponent();
            setProductBoxList();
            ProductBox.SelectedIndex = 0;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            Products list_of_products = new Products();
            Product product = list_of_products.getList().ElementAt(ProductBox.SelectedIndex);
            MainWindow.products.Add(product);
            MainWindow.refresh();
            try
            {
                ProductList.setList();
            }
            catch (Exception) { }
            MessageWindow message_window = new MessageWindow(product.getName() + " has been added to the list.");
            message_window.Show();
        }

        private void setProductBoxList()
        {
            Products products = new Products();
            foreach (Product product in products.getList())
            {
                ProductBox.Items.Add(product.getName() + " ($" + product.getValue() + " " + product.getSize() + " kg)");
            }
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
