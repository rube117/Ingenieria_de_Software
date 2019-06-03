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
    public partial class automotor : Form
    {
        public automotor()
        {
            InitializeComponent();
        }

        Clase clase = new Clase();

        private void button1_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();

            Hide();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clase.guardar_autos(textBox1.Text, textBox2.Text, Convert.ToInt16(textBox3.Text), textBox4.Text, Convert.ToInt16(comboBox1.Text), textBox6.Text, Convert.ToInt16(textBox7.Text), Convert.ToSingle(textBox8.Text));
        }

        private void automotor_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clase.guardar_motos(textBox16.Text, textBox15.Text, comboBox2.Text, Convert.ToInt16(textBox13.Text), textBox14.Text, textBox11.Text, Convert.ToSingle(textBox10.Text), textBox9.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == null && textBox8.Text == null)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == null && textBox13.Text == null)
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (textBox17.Text == null && textBox5.Text == null)
            {
                button4.Enabled = false;
            }
            else
            {
                button4.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clase.guardar_camiones(textBox24.Text, textBox23.Text, Convert.ToInt16(textBox22.Text), textBox21.Text, textBox19.Text, Convert.ToSingle(textBox5.Text), Convert.ToInt16(textBox18.Text), Convert.ToSingle(textBox17.Text));
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
