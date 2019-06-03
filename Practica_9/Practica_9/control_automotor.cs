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
    public partial class control_automotor : Form
    {
        public control_automotor()
        {
            InitializeComponent();
            label1.Text = clase.Mostrar_autos();
            label2.Text = clase.Mostrar_motos();
            label3.Text = clase.Mostrar_camiones();
        }

        Clase clase = new Clase();

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void control_automotor_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();

            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
