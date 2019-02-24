using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4A
{
    public partial class Menu : Form
    {
        Metodos m = new Metodos();
        public Menu()
        {
            InitializeComponent();
            txt_nombre.Text = "Nombre:";
            txt_calificacion.Text = "Calificación:";
            txt_alumnos.Text = "Alumnos: 0";
            txt_mostrar.Text = "Mostrar";
            b_guardar.Text = "Guardar";
            b_mostrar.Text = "Mostrar";
            b_ordenar.Text = "Ordenar";
        }

        private void b_guardar_Click(object sender, EventArgs e)
        {
            m.Guardar_Alumno(tb_nombre.Text, tb_calificacion.Text);
            txt_alumnos.Text = "Alumnos: "+m.Mostrar_Alumno();
        }

        private void b_mostrar_Click(object sender, EventArgs e)
        {
            txt_mostrar.Text = m.Mostrar_Calificaciones();
        }

        private void b_ordenar_Click(object sender, EventArgs e)
        {
            txt_mostrar.Text = m.Mostrar_nombre_y_promedio();
        }
    }
}
