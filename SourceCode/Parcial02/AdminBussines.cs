using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class AdminBussines : UserControl
    {
        public AdminBussines()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacíos");
            }
            else
            {
                try
                {
                    Connection.ExecuteNonQuery($"INSERT INTO BUSINESS VALUES(" +
                                               $"'{textBox1.Text}'," +
                                               $"'{textBox2.Text}'");

                    MessageBox.Show("Se ha registrado el estudiante");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacíos", "Hugo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                Connection.ExecuteNonQuery($"DELETE FROM BUSINESS WHERE idBusiness = '{textBox3.Text}'");
            }
        }
    }
}