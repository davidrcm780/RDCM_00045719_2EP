using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class AddOrderU : UserControl
    {
        public AddOrderU()
        {
            InitializeComponent();
        }

        private void AddOrderU_Load(object sender, EventArgs e)
        {
            var direcciones = Connection.ExecuteQuery("SELECT address FROM address");
            var direccionesCombo = new List<string>();

            foreach (DataRow dr in direcciones.Rows)
            {
                direccionesCombo.Add(dr[0].ToString());
            }

            comboBox1.DataSource = direccionesCombo;
            
            var producto = Connection.ExecuteQuery("SELECT name FROM product");
            var productosCombo = new List<string>();

            foreach (DataRow dr in producto.Rows)
            {
                productosCombo.Add(dr[0].ToString());
            }

            comboBox2.DataSource = productosCombo;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Connection.ExecuteNonQuery($"INSERT INTO APPORDER(createDate, idProduct, idAddress VALUES('27-05-2020'," +
                                       $" '{comboBox1.Text}', '{comboBox2.Text}');");
        }
    }
}