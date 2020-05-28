using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class AdminModifiedU : UserControl
    {
        public AdminModifiedU()
        {
            InitializeComponent();
        }

        private void AdminModifiedU_Load(object sender, EventArgs e)
        {
            var usuario = Connection.ExecuteQuery("SELECT username FROM appuser");
            var usuariosCombo = new List<string>();

            foreach (DataRow dr in usuario.Rows)
            {
                usuariosCombo.Add(dr[0].ToString());
            }

            comboBox1.DataSource = usuariosCombo;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Connection.ExecuteNonQuery($"UPDATE APPUSER SET password = '{comboBox1.Text}' WHERE idUser = '{comboBox1.Text}'");
        }
    }
}