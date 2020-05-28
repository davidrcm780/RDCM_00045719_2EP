using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class AdminEliminateU : UserControl
    {
        public AdminEliminateU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacíos.", "Hugo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                Connection.ExecuteNonQuery($"DELETE FROM APP USER WHERE idUser = '{textBox1.Text}'");
            }
        }
    }
}