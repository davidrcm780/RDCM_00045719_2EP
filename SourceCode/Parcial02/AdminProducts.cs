using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class AdminProducts : UserControl
    {
        public AdminProducts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.ExecuteNonQuery($"INSERT INTO PRODUCT(idBusiness, name) VALUES(1, '{textBox1.Text}');");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connection.ExecuteNonQuery($"DELETE FROM PRODUCT WHERE idProduct = {textBox2.Text}");
        }
    }
}