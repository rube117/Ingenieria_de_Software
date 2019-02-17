using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public class Metodos
    {
        // Se inicializan las variables que se van a guardar
        public static string variable1, variable2;

        // Se guardan los valores a las variables estáticas
        public void Guardar_Valores(string v1,string v2)
        {
            variable1 = v1;
            variable2 = v2;
        }

        // Se regresan los valores que se guardaron
        public string Retorno1()
        {
            return variable1;
        }
        public string Retorno2()
        {
            return variable2;
        }

        // Métodos para las operaciones básicas
        public string Suma()
        {
            double x;
            x = Convert.ToDouble(variable1) + Convert.ToDouble(variable2);
            return variable1+" + "+variable2+" = "+x;
        }
        public string Resta()
        {
            double x;
            x = Convert.ToDouble(variable1) - Convert.ToDouble(variable2);
            return variable1 + " - " + variable2 + " = " + x;
        }
        public string Multiplicacion()
        {
            double x;
            x = Convert.ToDouble(variable1) * Convert.ToDouble(variable2);
            return variable1 + " * " + variable2 + " = " + x;
        }
        public string Division()
        {
            double x;
            string retorno = "Sin solución.";
            if(variable2=="0")
            {
                MessageBox.Show("Error: No se puede dividir entre 0.");
            }
            else
            {
                x = Convert.ToDouble(variable1) / Convert.ToDouble(variable2);
                retorno = variable1 + " / " + variable2 +  "= " + x;
            }
            return retorno;
        }
        public string Raiz_Cuadrada(bool var1)
        {
            string retornar = "Resultado:";
            int a = 0;
            if(var1)
            {
                a = Convert.ToInt32(variable1);
                if (a < 0)
                    MessageBox.Show("Error: No se permiten números negativos.");
                else if(variable1=="0")
                    MessageBox.Show("Error: No se permiten ceros (0).");
                else
                    retornar = "Resultados:\n" + Math.Sqrt(Convert.ToDouble(variable1));
            }
            else
            {
                a = Convert.ToInt32(variable2);
                if (a < 0)
                    MessageBox.Show("Error: No se permiten números negativos.");
                else if (variable2 == "0")
                    MessageBox.Show("Error: Se debe sustituir el valor 0.");
                else
                    retornar = "Resultados:\n" + Math.Sqrt(Convert.ToDouble(variable2));
            }
            return retornar;
        }
    }
}
