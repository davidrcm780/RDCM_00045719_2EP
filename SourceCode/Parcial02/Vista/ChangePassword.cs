using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }


        private void ChangePassword_Load(object sender, EventArgs e)
        {
            var usuarios = Connection.ExecuteQuery("SELECT username FROM appuser");
            var usuariosCombo = new List<string>();

            foreach (DataRow dr in usuarios.Rows)
            {
                usuariosCombo.Add(dr[0].ToString());
            }

            comboBox1.DataSource = usuariosCombo;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool actualIgual = comboBox1.SelectedValue.Equals(textBox1.Text);
            bool nuevaIgual = textBox2.Text.Equals(textBox3.Text);
            bool nuevavalida = textBox2.Text.Length > 0;

            if (actualIgual && nuevaIgual && nuevavalida)
            {
                try
                {
                    UsuarioDAO.updatepassword(comboBox1.Text, textBox2.Text);

                    MessageBox.Show("Contraseña actulizada correctamente", "Hugo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Contraseña no actualizada. Por favor intente de nuevo", "Hugo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Verifique los datos ingresados", "Hugo", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}