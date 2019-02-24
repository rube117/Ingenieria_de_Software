using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4B
{
    public partial class Marcadores : Form
    {
        Metodos m = new Metodos();
        public Marcadores()
        {
            InitializeComponent();
            marcador.Text = m.Marcador_Normal();
            ordenar.Text = "Ordenar";
            volver.Text = "Volver";
        }

        private void ordenar_Click(object sender, EventArgs e)
        {
            // Botón ordenar y mostrar bloques
            marcador.Text = m.Mostrar_nombre_y_equipos();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            // Volver
            Menu mn = new Menu();
            mn.Show();
            Hide();
        }
    }
}
