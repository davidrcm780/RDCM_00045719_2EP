using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class Admin : UserControl
    {
        private UserControl current = null;
        public Admin()
        {
            InitializeComponent();
            current = adminUser1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Remove(current);
            current = new AdminUser();
            tableLayoutPanel2.Controls.Add(current, 0, 0);
            tableLayoutPanel2.SetColumnSpan(current, 5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Remove(current);
            current = new AdminBussines();
            tableLayoutPanel2.Controls.Add(current, 0, 0);
            tableLayoutPanel2.SetColumnSpan(current, 5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Remove(current);
            current = new AdminProducts();
            tableLayoutPanel2.Controls.Add(current, 0, 0);
            tableLayoutPanel2.SetColumnSpan(current, 5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Remove(current);
            current = new AdminViewOrders();
            tableLayoutPanel2.Controls.Add(current, 0, 0);
            tableLayoutPanel2.SetColumnSpan(current, 5);
        }
    }
}