using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    public partial class Mostrar_Empleados : Form
    {
        Metodos m = new Metodos();
        public Mostrar_Empleados()
        {
            InitializeComponent();
            mostrar_txt.Text = m.Mostrar();
            b_cerrar.Text = "Cerrar";
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            Ingresar i = new Ingresar();
            i.Show();
            Close();
        }
    }
}
