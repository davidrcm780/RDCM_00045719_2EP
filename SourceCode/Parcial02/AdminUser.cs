using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class AdminUser : UserControl
    {
        private UserControl current1;
        public AdminUser()
        {
            InitializeComponent();
            current1 = adminCreateU1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Remove(current1);
            current1 = new AdminCreateU();
            tableLayoutPanel2.Controls.Add(current1, 0, 0);
            tableLayoutPanel2.SetColumnSpan(current1, 5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Remove(current1);
            current1 = new AdminModifiedU();
            tableLayoutPanel2.Controls.Add(current1, 0, 0);
            tableLayoutPanel2.SetColumnSpan(current1, 5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Remove(current1);
            current1 = new AdminEliminateU();
            tableLayoutPanel2.Controls.Add(current1, 0, 0);
            tableLayoutPanel2.SetColumnSpan(current1, 5);
        }
    }
}