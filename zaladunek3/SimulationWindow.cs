using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace zaladunek3
{
    public partial class SimulationWindow : Form
    {
        public SimulationWindow(List<Product> list_of_products, int weight, bool decision)
        {
            InitializeComponent();

            if (decision)
            {
                BinPacking bp = new BinPacking(getListOfWeights(list_of_products), weight);
                result.Visible = true;
                ResultView.Visible = false;
                result.Text = "Number of products to pack: " + bp.getN() + "\nBins needed: " + bp.getBinCount();
            }
            else {
                Knapsack k = new Knapsack();
                result.Visible = false;
                ResultView.Visible = true;

                ResultView.View = View.Details;
                ResultView.Columns.Add("Name");
                ResultView.Columns.Add("Profit");
                ResultView.Columns.Add("Weight");
                ResultView.Columns.Add("Taken");

                bool[] taken = k.simulate(list_of_products, weight);
                for (int n = 1; n <= taken.Length; n++)
                {
                    int index = n - 1;
                    var product = new ListViewItem();
                    try
                    {
                        product = new ListViewItem(new[] { list_of_products[index].getName(), list_of_products[index].getValue().ToString(), list_of_products[index].getSize().ToString(), taken[n].ToString() });
                    }
                    catch (Exception) { }
                    ResultView.Items.Add(product);
                }                   
            }
        }

        public List<int> getListOfWeights(List<Product> list_of_products)
        {
            List<int> list_of_weights = new List<int>();
            foreach (Product product in list_of_products)
            {
                list_of_weights.Add(product.getSize());
            }
            return list_of_weights;
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
