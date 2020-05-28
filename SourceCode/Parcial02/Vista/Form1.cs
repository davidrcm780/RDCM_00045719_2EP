using System;
using System.Windows.Forms;


namespace Parcial02
{
    public partial class Form1 : Form
    {
        private UserControl current;
        public Form1()
        {
            InitializeComponent();
            current = admin1;
        }
        
        private void Form1_Load_1(object sender, EventArgs e)
        {
            Usuario nombre = new Usuario();
            label1.Text = "Bienvenido " + nombre.username + " [" + (nombre.usertype ? "Administrrador" : "Usuario") +
                          "]";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Usuario nombre = new Usuario();
            if (MessageBox.Show("¡seguro que desea salir, " + nombre.username + "?", "Hugo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    e.Cancel = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error, favor intente dentro de un minuto.", "Hugo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}