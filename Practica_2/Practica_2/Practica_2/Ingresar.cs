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
    public partial class Ingresar : Form
    {
        Metodos m = new Metodos();
        public Ingresar()
        {
            InitializeComponent();
            no_sist.Text = "Sistema 2";
            no_version.Text = "Versión 1.0";
            txt_nombre.Text = "Nombre:";
            txt_saldo.Text = "Saldo:";
            ckb_pension.Text = "Pensión Alimenticia";
            creador.Text = "Elaborado por:\nRubén Verduzco López";
            b_guardar.Text = "Guardar";
            b_mostrar.Text = "Mostrar Usuarios";
            b_cerrar.Text = "Cerrar";
        }

        private void b_guardar_Click(object sender, EventArgs e)
        {
            m.Guardar(txb_nombre.Text, txb_saldo.Text, Convert.ToString(ckb_pension.Checked),m.Numero_Empleados());
            m.Agregar_Empleado();
        }

        private void b_mostrar_Click(object sender, EventArgs e)
        {
            Mostrar_Empleados mu = new Mostrar_Empleados();
            mu.Show();
            Hide();
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
