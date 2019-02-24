using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4A
{
    public class Metodos
    {
        public static string[] alumnos = new string[10];
        public static float[] promedios = new float[10];

        public static string[] o_alumnos = new string[10];
        public static float[] o_promedios = new float[10];
        string j = "";

        public static byte num_alumno = 0;
        public void Guardar_Alumno(string alumno, string promedio)
        {
            if (num_alumno >= 10)
            {
                MessageBox.Show("Se ha excedido el límite de alumnos para guardar.");
                num_alumno = 10;
            }
            else
            {
                alumnos[num_alumno] = alumno;
                promedios[num_alumno] =(float) Convert.ToDouble(promedio);
                o_alumnos[num_alumno] = alumno;
                o_promedios[num_alumno] = promedios[num_alumno];
                num_alumno += 1;
            }
        }
        public string Mostrar_Alumno()
        {
            return Convert.ToString(num_alumno);
        }

        public string Mostrar_Calificaciones()
        {
            string retornar = "";
            float p = 0;
            for (byte v = 0; v < 10; v++)
            {
                retornar = retornar + "Nombre del alumno: " + alumnos[v] + " Promedio: " + promedios[v] + "\n";
                p = p + promedios[v];
            }
            p /= 10;
            retornar = retornar + "\n" + "Promedio General: " + p;
            return retornar;
        }

        public void Ordenar_Arreglo()
        {
            float t;
            for (byte a = 1; a < 10; a++)
                for (byte b = (byte)(10 - 1); b >= a; b--)
                {
                    if (o_promedios[b - 1] > o_promedios[b])
                    {
                        t = o_promedios[b - 1];
                        o_promedios[b - 1] = o_promedios[b];
                        o_promedios[b] = t;

                        j = o_alumnos[b - 1];
                        o_alumnos[b - 1] = o_alumnos[b];
                        o_alumnos[b] = j;
                    }
                }
        }

        public string Mostrar_nombre_y_promedio()
        {
            float p = 0;
            Ordenar_Arreglo();
            Array.Reverse(o_alumnos);
            Array.Reverse(o_promedios);
            string muestra = "";
            for (byte i = 0; i < 10; i++)
            {
                muestra = muestra + "Nombre del alumno: " + o_alumnos[i] + " Promedio: " + o_promedios[i] + "\n";
                p = p + promedios[i];
            }
            p /= 10;
            muestra = muestra + "\n" + "Promedio General: " + p;
            return muestra;
        }
    }
}
