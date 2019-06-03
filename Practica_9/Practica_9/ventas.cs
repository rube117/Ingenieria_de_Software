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
    public partial class ventas : Form
    {
        public ventas()
        {
            InitializeComponent();
        }
        Clase clase = new Clase();

        private void label6_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();

            Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();

            Hide();
        }

        private void ventas_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            comboBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            comboBox2.Enabled = false;
            textBox10.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox1.Enabled = true;
                comboBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = false;
                comboBox2.Enabled = false;
                textBox10.Enabled = false;
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox1.Enabled = true;
                comboBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = false;
                textBox7.Enabled = true;
                textBox8.Enabled = false;
                textBox9.Enabled = true;
                comboBox2.Enabled = true;
                textBox10.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked==true)
            {
                textBox1.Enabled = true;
                comboBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = false;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = false;
                comboBox2.Enabled = false;
                textBox10.Enabled = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                clase.guardar_ventas_autos(Convert.ToSingle(textBox1.Text), comboBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt16(textBox4.Text), textBox5.Text, Convert.ToInt16(textBox6.Text), textBox7.Text, Convert.ToInt16(textBox8.Text));
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    clase.guardar_ventas_motos(Convert.ToSingle(textBox1.Text), comboBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt16(textBox4.Text), textBox5.Text, textBox7.Text, textBox9.Text, comboBox2.Text);
                }
                else
                {
                    if (radioButton3.Checked == true)
                    {
                        clase.guardar_ventas_camiones(Convert.ToSingle(textBox1.Text), comboBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt16(textBox4.Text), textBox5.Text, textBox7.Text, Convert.ToInt16(textBox8.Text),Convert.ToSingle(textBox10.Text));
                    }
                }
            }//Fin ciclo if
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            comboBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox8.Text = null;
            textBox9.Text = null;
            comboBox2.Text = null;
            textBox10.Text = null;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                clase.Mostrar_ventas_autos();
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    clase.Mostrar_ventas_motos();
                }
                else
                {
                    if (radioButton3.Checked == true)
                    {
                        clase.Mostrar_ventas_camiones();
                    }
                }
            }
            
        }
    }
}
