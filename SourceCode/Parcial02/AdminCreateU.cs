using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class AdminCreateU : UserControl
    {
        public AdminCreateU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals("") ||
                textBox3.Text.Equals("") ||
                textBox4.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacíos");
            }
            else
            {
                try
                {
                    Connection.ExecuteNonQuery($"INSERT INTO APPUSER VALUES(" +
                                               $"'{textBox1.Text}'," +
                                               $"'{textBox2.Text}'," +
                                               $"'{textBox3.Text}'," +
                                               $"{textBox4.Text})");

                    MessageBox.Show("Se ha registrado el estudiante");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}