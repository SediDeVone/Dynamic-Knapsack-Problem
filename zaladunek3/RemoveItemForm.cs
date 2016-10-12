using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace zaladunek3
{
    public partial class RemoveItemForm : Form
    {
        CheckedListBox productList;
        public RemoveItemForm()
        {
            InitializeComponent();
            productList = ProductCheckList;
            addItems();
        }

        public void addItems()
        {
            productList.Items.Clear();
            foreach( Product p in MainWindow.products)
            {
                productList.Items.Add(p.getName() + " ($" + p.getValue() + " " + p.getSize() + " kg)");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            List<int> indexes = reverseList(ProductCheckList.CheckedIndices);            
            foreach(int index in indexes)
            {
                MainWindow.products.RemoveAt(index);
            }
            addItems();
            MessageWindow message_window;
            if (indexes.Count == 0)
                message_window = new MessageWindow("None of the items have been removed.");
            else if (indexes.Count > 1)
                message_window = new MessageWindow("Chosen items have been removed.");
            else
                message_window = new MessageWindow("Chosen item have been removed.");
            MainWindow.refresh();
            message_window.Show();
            this.Close();
        }

        private List<int> reverseList(CheckedListBox.CheckedIndexCollection checked_indices)
        {
            List<int> indexes = new List<int>();
            foreach (int index in checked_indices)
            {
                indexes.Add(index);
            }

            indexes.Reverse();
            return indexes;
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
