using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class AdminViewOrders : UserControl
    {
        public AdminViewOrders()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacíos");
            }
            else
            {
                try
                {
                    var dt = Connection.ExecuteQuery($"SELECT * FROM APPORDER WHERE username = '{textBox1.Text}'");

                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Datos obtenidos correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un problema");
                }
            }
        }
    }
}