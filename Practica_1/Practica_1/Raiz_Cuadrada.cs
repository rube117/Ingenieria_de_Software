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
    public partial class Raiz_Cuadrada : Form
    {
        // Llamando al método de forma global
        Metodos mt = new Metodos();
        public Raiz_Cuadrada()
        {
            InitializeComponent();
            // Mostrando variables
            probar1.Text = "1. Variable 1= " + mt.Retorno1();
            probar2.Text = "2. Variable 2= " + mt.Retorno2();
            b_ingresar.Text= "<-- Elegir otras variables";
        }

        private void b_menu_Click(object sender, EventArgs e)
        {
            // Ingresar al menú
            Menu m = new Menu();
            m.Show();
            Hide();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            Checar_Calcular();
        }

        // Checar los RadioButtons para calcular una variable
        public void Checar_Calcular()
        {
            if (probar1.Checked == true)
            {
                operacion.Text = mt.Raiz_Cuadrada(true);
            }
            if (probar2.Checked == true)
            {
                operacion.Text = mt.Raiz_Cuadrada(false);
            }
            if (probar1.Checked == false && probar2.Checked == false)
            {
                MessageBox.Show("Error: No se ha seleccionado ninguna variable.");
            }
        }

        private void b_ingresar_Click(object sender, EventArgs e)
        {
            // Regresa para elegir otras variables
            Ingresar i = new Ingresar();
            i.Show();
            Hide();
        }

        // Sirve para pulsar botónes con teclado
        private void Raiz_Cuadrada_KeyUp(object sender, KeyEventArgs e)
        {
            // Seleccionar 1
            if (e.KeyCode == Keys.NumPad1)
            {
                probar1.Checked = true;
                probar2.Checked = false;
            }

            // Seleccionar 2
            if (e.KeyCode == Keys.NumPad2)
            {
                probar1.Checked = false;
                probar2.Checked = true;
            }

            // Calcular presionando 3
            if (e.KeyCode == Keys.NumPad3)
                Checar_Calcular();

            // Elegir variables con Retroceso ( <- )
            if (e.KeyCode==Keys.Back)
            {
                Ingresar i = new Ingresar();
                i.Show();
                Hide();
            }

        }
    }
}
