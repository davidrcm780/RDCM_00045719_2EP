using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Npgsql;


namespace Parcial02
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void Login_Load(object sender, EventArgs e)
        {
            var usuarios = Connection.ExecuteQuery("SELECT username FROM appuser");
            var usuariosCombo = new List<string>();

            foreach (DataRow dr in usuarios.Rows)
            {
                usuariosCombo.Add(dr[0].ToString());
            }

            comboBox1.DataSource = usuariosCombo;
            
            var contraseñas = Connection.ExecuteQuery("SELECT password FROM appuser");
            var contraseñasCombo = new List<string>();

            foreach (DataRow dr in usuarios.Rows)
            {
                contraseñasCombo.Add(dr[0].ToString());
            }

            comboBox2.DataSource = contraseñasCombo;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ChangePassword ventana1 = new ChangePassword();
            ventana1.ShowDialog();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Usuario use = (Usuario) comboBox1.SelectedItem;

            try
            {
                if (comboBox1.SelectedValue.Equals(textBox1.Text))
                {
                    if (use.usertype is true)
                    {
                        Form1 ventana = new Form1();
                        ventana.Show();
                        Hide();
                    }
                    else
                    {
                        User ventana = new User();
                        ventana.Show();
                        Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}