using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_9
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            automotor aumotor = new automotor();
            aumotor.Show();

            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            control_automotor control = new control_automotor();
            control.Show();

            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ventas ventas = new ventas();
            ventas.Show();

            Hide();
        }
    }
}
