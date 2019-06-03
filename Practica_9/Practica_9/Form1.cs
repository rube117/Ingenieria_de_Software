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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int contador = 0;

        public void GotFocusCuenta(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nombre")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        public void LostFocusCuenta(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Nombre";
                textBox1.ForeColor = Color.Gray;
            }
        }

        public void GotFocusPassword(object sender, EventArgs e)
        {
            if (textBox2.Text == "Contraseña")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        public void LostFocusPassword(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Contraseña";
                textBox2.ForeColor = Color.Gray;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.GotFocus += new EventHandler(this.GotFocusCuenta);
            textBox1.LostFocus += new EventHandler(this.LostFocusCuenta);

            textBox2.GotFocus += new EventHandler(this.GotFocusPassword);
            textBox2.LostFocus += new EventHandler(this.LostFocusPassword);

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "123")
            {
                menu menu = new menu();
                menu.Show();

                Hide();
            }
            else
            {
                contador++;
                MessageBox.Show("Verifique su cuenta o contraseña.\nIntento: "+contador);
            }

            if (contador==3)
            {
                MessageBox.Show("Intentos superados, intente mas tarde...");
                button1.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void splitter3_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
