using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class DirectionUser : UserControl
    {
        public DirectionUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.ExecuteNonQuery($"INSERT INTO ADDRESS(idaddress, iduser, address VALUES(1, 1, '{textBox1.Text}')");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connection.ExecuteNonQuery($"DELETE FROM ADDRESS WHERE idAddress = '{comboBox1.Text}'");
        }

        private void DirectionUser_Load(object sender, EventArgs e)
        {
            var direccion = Connection.ExecuteQuery("SELECT address FROM address");
            var direccionCombo = new List<string>();

            foreach (DataRow dr in direccion.Rows)
            {
                direccionCombo.Add(dr[0].ToString());
            }

            comboBox1.DataSource = direccionCombo;
        }
    }
}