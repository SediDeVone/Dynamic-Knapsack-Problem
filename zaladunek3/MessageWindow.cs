using System;
using System.Windows.Forms;

namespace zaladunek3
{
    public partial class MessageWindow : Form
    {
        public MessageWindow(String text)
        {
            InitializeComponent();
            message.Text = text;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
