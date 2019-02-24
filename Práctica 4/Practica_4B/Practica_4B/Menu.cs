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
    public partial class Menu : Form
    {
        Metodos m = new Metodos();
        public Menu()
        {
            InitializeComponent();
            registrados.Text = "Registrados: " + m.Mostrar_Equipos();
            label1.Text = "Nombre de equipo:";
            label2.Text = "Número de victorias:";
            label3.Text = "Número de derrotas:";
            guardar.Text = "Guardar";
            mostrar.Text = "Mostrar";
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            // Botón guardar
            m.Guardar_Equipos(nombre_equipo.Text, victorias_equipo.Text, derrotas_equipo.Text);
            registrados.Text = "Registrados: " + m.Mostrar_Equipos();
        }

        private void mostrar_Click(object sender, EventArgs e)
        {
            // Botón mostrar
            Marcadores marc = new Marcadores();
            marc.Show();
            Hide();
        }
    }
}
