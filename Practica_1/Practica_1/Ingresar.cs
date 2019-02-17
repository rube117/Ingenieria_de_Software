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
    public partial class Ingresar : Form
    {
        // Llamando al método de forma global
        Metodos mt = new Metodos();
        public Ingresar()
        {
            InitializeComponent();
            // Mostrar las variables que ya se asignaron
            num1.Text = mt.Retorno1();
            num2.Text = mt.Retorno2();
            sistema.Text = "Sistema 1";
            version.Text = "Versión 1.0";
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Checar_Guardar_Ingresar();
        }

        // Ingresar al menú comprobando los datos
        public void Checar_Guardar_Ingresar()
        {
            // Guardar valores
            double x = 0;
            try
            {
                // Probar datos guardados
                x = Convert.ToDouble(num1.Text) + Convert.ToDouble(num2.Text);
                mt.Guardar_Valores(num1.Text, num2.Text);

                // Ingresar al menú
                Menu m = new Menu();
                m.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        // Ingresar al menú con Enter
        private void num2_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
                Checar_Guardar_Ingresar();
        }
        private void num1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Checar_Guardar_Ingresar();
        }
    }
}
