using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4B
{
    public class Metodos
    {
        public static string[] equipos = new string[8];
        public static byte[] puntos_totales = new byte[8];

        public static string[] o_equipos = new string[8];
        public static byte[] o_puntos_totales = new byte[8];
        string j = "";

        public static byte num_equipo = 0;
        public void Guardar_Equipos(string equipo, string victorias, string derrotas)
        {
            byte empate = 0;
            byte num_v = Convert.ToByte(victorias);
            byte num_d = Convert.ToByte(derrotas);
            byte suma = (byte)(num_v + num_d);
            if (suma < 7)
                empate = (byte)(suma - 7);
            if (num_equipo >= 8)
            {
                MessageBox.Show("Se ha excedido el límite de jugadores para guardar.");
                num_equipo = 8;
            }
            else
            {
                equipos[num_equipo] = equipo;
                puntos_totales[num_equipo] = (byte)((num_v * 3) + (empate * 1));
                o_equipos[num_equipo] = equipo;
                o_puntos_totales[num_equipo] = puntos_totales[num_equipo];
                num_equipo += 1;
            }
        }
        public string Mostrar_Equipos()
        {
            return Convert.ToString(num_equipo);
        }

        public string Marcador_Normal()
        {
            string retornar = "";
            for(byte v=0;v<8;v++)
            {
                retornar = retornar + "Nombre del equipo: " + equipos[v] + "          Puntaje: " + puntos_totales[v] + "\n";
            }
            return retornar;
        }

        public void Ordenar_Arreglo()
        {
            byte t;
            for (byte a = 1; a < 8; a++)
                for (byte b = (byte)(8 - 1); b >= a; b--)
                {
                    if (o_puntos_totales[b - 1] > o_puntos_totales[b])
                    {
                        t = o_puntos_totales[b - 1];
                        o_puntos_totales[b - 1] = o_puntos_totales[b];
                        o_puntos_totales[b] = t;

                        j = o_equipos[b - 1];
                        o_equipos[b - 1] = o_equipos[b];
                        o_equipos[b] = j;
                    }
                }
        }

        public string Mostrar_nombre_y_equipos()
        {
            Ordenar_Arreglo();
            Array.Reverse(o_equipos);
            Array.Reverse(o_puntos_totales);
            string muestra = "";
            for (byte i = 0; i < 8; i++)
            {
                if(i==0)
                {
                    muestra = muestra + "equipo:" + o_equipos[i] + " puntos:" + o_puntos_totales[i] + " INVICTO \n";
                }else if(i>0&&i<4)
                {
                    muestra = muestra + "equipo:" + o_equipos[i] + " puntos:" + o_puntos_totales[i] + " play-offs \n";
                }else if(i>4&&i<9)
                    muestra = muestra + "equipo:" + o_equipos[i] + " puntos:" + o_puntos_totales[i] + " equipo malo \n";
                else
                    muestra = muestra + "equipo:" + o_equipos[i] + " puntos:" + o_puntos_totales[i] + "\n";
            }
            return muestra;
        }
    }
}
