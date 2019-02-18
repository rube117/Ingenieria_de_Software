using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    public class Metodos
    {
        public static string[,] empleado = new string[25, 9];
        public static byte num_emp = 0;
        
        public void Agregar_Empleado()
        {
            num_emp += 1;
        }
        public byte Numero_Empleados()
        {
            if(num_emp>=25)
            {
                MessageBox.Show("Se ha excedido el límite de usuarios para guardar.");
                num_emp = 24;
            }
            return num_emp;
        }
        public void Guardar(string nombre,string saldo,string pen_alim,byte n_empleado)
        {
            empleado[n_empleado, 0] = nombre; // Nombre
            empleado[n_empleado, 1] = saldo; // Saldo
            empleado[n_empleado, 2] = Tipo_Saldo(Convert.ToDouble(saldo),pen_alim,false,false,false,false,false,false); // Porcentaje de la pensión
            empleado[n_empleado, 3] = Tipo_Saldo(Convert.ToDouble(saldo), pen_alim, true,false,false,false,false,false); // Clase de empleado
            empleado[n_empleado, 4] = Tipo_Saldo(Convert.ToDouble(saldo), pen_alim, false, true, false, false, false, false); // Adicional
            empleado[n_empleado, 5] = Tipo_Saldo(Convert.ToDouble(saldo), pen_alim, false, false, true, false, false, false); // ISR
            empleado[n_empleado, 6] = Tipo_Saldo(Convert.ToDouble(saldo), pen_alim, false, false, false, true, false, false); // Asistencia médica
            empleado[n_empleado, 7] = Tipo_Saldo(Convert.ToDouble(saldo), pen_alim, false, false, false, false, true, false); // Vivienda
            empleado[n_empleado, 8] = Tipo_Saldo(Convert.ToDouble(saldo), pen_alim, false, false, false, false, false, true); // Pensión Alimenticia (Saldo)
        }
        public string Tipo_Saldo(double s_empl,string pension_alim,bool clase,bool adicional,bool r_isr,bool asis_medica,bool vivienda,bool pen_alim_saldo)
        {
            string retorno = "";
            if(s_empl<0)
            {
                MessageBox.Show("Error: No se aceptan números negativos");
                num_emp -= 1;
            } // Excepción número negativo
            if(s_empl<10000)
            {
                if (s_empl > 5000 && Convert.ToBoolean(pension_alim))
                {
                    retorno = "0.2"; // 20 %
                }
                else if (Convert.ToBoolean(pension_alim))
                    retorno = "0.1"; // 10 %
                else
                    retorno = "0";
                if (clase)
                {
                    retorno = "Clase A";
                    MessageBox.Show("Empleado guardado con éxito.");
                }
                if(adicional)
                {
                    s_empl *= 0.1;
                    retorno = Convert.ToString(s_empl);
                }
                if(r_isr)
                {
                    s_empl *= 0.05;
                    retorno = Convert.ToString(s_empl);
                }
                if (asis_medica)
                {
                    s_empl *= 0.05;
                    retorno = Convert.ToString(s_empl);
                }
                if (vivienda)
                {
                    s_empl *= 0.05;
                    retorno = Convert.ToString(s_empl);
                }
                if((pen_alim_saldo)&&(Convert.ToBoolean(pension_alim)))
                {
                    s_empl = s_empl * Convert.ToDouble(retorno);
                    retorno = Convert.ToString(s_empl);
                }
            } // Menor de 10000
            if ((s_empl > 10000)&&(s_empl < 30000))
            {
                if (s_empl > 15000 && Convert.ToBoolean(pension_alim))
                {
                    retorno = "0.2"; // 20 %
                }
                else if (Convert.ToBoolean(pension_alim))
                    retorno = "0.1"; // 10 %
                else
                    retorno = "0";
                if (clase)
                {
                    retorno = "Clase B";
                    MessageBox.Show("Empleado guardado con éxito.");
                }
                if (adicional)
                {
                    s_empl *= 0.2;
                    retorno = Convert.ToString(s_empl);
                }
                if (r_isr)
                {
                    s_empl *= 0.1;
                    retorno = Convert.ToString(s_empl);
                }
                if (asis_medica)
                {
                    s_empl *= 0.07;
                    retorno = Convert.ToString(s_empl);
                }
                if (vivienda)
                {
                    s_empl *= 0.05;
                    retorno = Convert.ToString(s_empl);
                }
                if ((pen_alim_saldo) && (Convert.ToBoolean(pension_alim)))
                {
                    s_empl = s_empl * Convert.ToDouble(retorno);
                    retorno = Convert.ToString(s_empl);
                }
            } // Entre 10000 y 29999
            if ((s_empl >= 30000) && (s_empl < 50000))
            {
                if (s_empl > 45000 && Convert.ToBoolean(pension_alim))
                {
                    retorno = "0.2"; // 20 %
                }
                else if (Convert.ToBoolean(pension_alim))
                    retorno = "0.1"; // 10 %
                else
                    retorno = "0";
                if (clase)
                {
                    retorno = "Clase C";
                    MessageBox.Show("Empleado guardado con éxito.");
                }
                if (adicional)
                {
                    s_empl *= 0.2;
                    retorno = Convert.ToString(s_empl);
                }
                if (r_isr)
                {
                    s_empl *= 0.15;
                    retorno = Convert.ToString(s_empl);
                }
                if (asis_medica)
                {
                    s_empl *= 0.07;
                    retorno = Convert.ToString(s_empl);
                }
                if (vivienda)
                {
                    s_empl *= 0.05;
                    retorno = Convert.ToString(s_empl);
                }
                if ((pen_alim_saldo) && (Convert.ToBoolean(pension_alim)))
                {
                    s_empl = s_empl * Convert.ToDouble(retorno);
                    retorno = Convert.ToString(s_empl);
                }
            } // Entre 30000 y 49999
            if ((s_empl >= 50000) && (s_empl < 70000))
            {
                if (s_empl > 65000 && Convert.ToBoolean(pension_alim))
                {
                    retorno = "0.25"; // 25 %
                }
                else if (Convert.ToBoolean(pension_alim))
                    retorno = "0.20"; // 20 %
                else
                    retorno = "0";
                if (clase)
                {
                    retorno = "Clase D";
                    MessageBox.Show("Empleado guardado con éxito.");
                }
                if (adicional)
                {
                    s_empl *= 0.25;
                    retorno = Convert.ToString(s_empl);
                }
                if (r_isr)
                {
                    s_empl *= 0.2;
                    retorno = Convert.ToString(s_empl);
                }
                if (asis_medica)
                {
                    s_empl *= 0.1;
                    retorno = Convert.ToString(s_empl);
                }
                if (vivienda)
                {
                    s_empl *= 0.07;
                    retorno = Convert.ToString(s_empl);
                }
                if ((pen_alim_saldo) && (Convert.ToBoolean(pension_alim)))
                {
                    s_empl = s_empl * Convert.ToDouble(retorno);
                    retorno = Convert.ToString(s_empl);
                }
            } // Entre 50000 y 69999
            if ((s_empl >= 70000) && (s_empl <= 100000))
            {
                if (s_empl > 85000 && Convert.ToBoolean(pension_alim))
                {
                    retorno = "0.25"; // 20 %
                }
                else if (Convert.ToBoolean(pension_alim))
                    retorno = "0.2"; // 20 %
                else
                    retorno = "0";
                if (clase)
                {
                    retorno = "Clase E";
                    MessageBox.Show("Empleado guardado con éxito.");
                }
                if (adicional)
                {
                    s_empl *= 0.3;
                    retorno = Convert.ToString(s_empl);
                }
                if (r_isr)
                {
                    s_empl *= 0.3;
                    retorno = Convert.ToString(s_empl);
                }
                if (asis_medica)
                {
                    s_empl *= 0.15;
                    retorno = Convert.ToString(s_empl);
                }
                if (vivienda)
                {
                    s_empl *= 0.1;
                    retorno = Convert.ToString(s_empl);
                }
                if ((pen_alim_saldo) && (Convert.ToBoolean(pension_alim)))
                {
                    s_empl = s_empl * Convert.ToDouble(retorno);
                    retorno = Convert.ToString(s_empl);
                }
            } // Entre 70000 y 100000
            if (s_empl > 100000)
            {
                MessageBox.Show("Error: No se aceptan mayores a 100000"); 
                num_emp -= 1;
            } // Excepción mayores a 100000
            return retorno;
        }
        public string Mostrar()
        {
            byte no_empleado = 1;
            string retorno = "No. Empleado         Nombre          Clase          Saldo       Adicional        ISR       Asistencia Médica   Vivienda   Pensión Alimenticia\n";
            // Protege el colapso del sistema
            if (empleado[0, 0] == null)
                MessageBox.Show("Error: No se han ingresado los valores");
            else
            {
                // Mostrar empleados
                for(byte v=0;v<25;v++)
                {
                    if (num_emp < v)
                        break;
                    if(v==0)
                    {
                        no_empleado = v;
                        no_empleado += 1;
                    }
                    if (v > 0)
                        no_empleado += 1;
                    retorno = retorno +"            " +no_empleado+".-                 "+empleado[v,0]+"           "+empleado[v,3]+"        "+empleado[v,1]+"         "+empleado[v,4]+"           "+empleado[v,5]+"               "+empleado[v,6]+"                 "+empleado[v,7]+"             "+empleado[v,8]+"\n";
                }
            }
            return retorno;
        }
    }
}
