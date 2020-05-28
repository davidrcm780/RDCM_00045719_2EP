using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class EliminateOrderU : UserControl
    {
        public EliminateOrderU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.ExecuteNonQuery($"DELETE FROM APPORDER WHERE idOrder = '{textBox1.Text}'");
        }
    }
}