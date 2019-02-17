using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Menu : Form
    {
        // Llamando al método de forma global
        Metodos mt = new Metodos();
        public Menu()
        {
            InitializeComponent();
            // Mostrando variables
            probar1.Text = "Variable 1= "+mt.Retorno1();
            probar2.Text = "Variable 2= " + mt.Retorno2();
            creador.Text = "Elaborado por:\nRubén Verduzco López";
            elegir_variables.Text = "<-- Elegir otras variables";
        }

        private void salir_Click(object sender, EventArgs e)
        {
            // Salir del sistema
            Close();
        }

        private void suma_Click(object sender, EventArgs e)
        {
            // Realiza una suma
            operacion.Text = "Resultados:\n" + mt.Suma();
        }

        private void elegir_variables_Click(object sender, EventArgs e)
        {
            // Regresa para elegir otras variables
            Ingresar i = new Ingresar();
            i.Show();
            Hide();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            // Realiza una resta
            operacion.Text = "Resultados:\n" + mt.Resta();
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            // Realiza una multiplicación
            operacion.Text = "Resultados:\n" + mt.Multiplicacion();
        }

        private void division_Click(object sender, EventArgs e)
        {
            // Realiza una división
            operacion.Text = "Resultados:\n" + mt.Division();
        }

        private void raiz_cuadrada_Click(object sender, EventArgs e)
        {
            /* Menú para elegir una variable para calcular la raíz cuadrada
                de un número. */
            Raiz_Cuadrada rc = new Raiz_Cuadrada();
            rc.Show();
            Hide();
        }

        // Sirve para pulsar botónes con teclado
        private void Menu_KeyUp(object sender, KeyEventArgs e)
        {
            // Presionar 1
            if(e.KeyCode==Keys.NumPad1)
                operacion.Text = "Resultados:\n" + mt.Suma();

            // Presionar 2
            if (e.KeyCode == Keys.NumPad2)
                operacion.Text = "Resultados:\n" + mt.Resta();

            // Presionar 3
            if (e.KeyCode == Keys.NumPad3)
                operacion.Text = "Resultados:\n" + mt.Multiplicacion();

            // Presionar 4
            if (e.KeyCode == Keys.NumPad4)
                operacion.Text = "Resultados:\n" + mt.Division();

            // Presionar 5
            if (e.KeyCode == Keys.NumPad5)
            {
                Raiz_Cuadrada rc = new Raiz_Cuadrada();
                rc.Show();
                Hide();
            }

            // Presionar 6
            if (e.KeyCode == Keys.NumPad6)
                Close();

            // Elegir variables con Retroceso ( <- )
            if(e.KeyCode==Keys.Back)
            {
                Ingresar i = new Ingresar();
                i.Show();
                Hide();
            }
        }
    }
}
