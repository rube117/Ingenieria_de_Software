using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_9
{
    class Clase
    {
        public static string[,] control_autos= new string[8,8];
        public static string[,] control_motos = new string[8, 8];
        public static string[,] control_camiones = new string[8, 8];

        public static string[,] control_ventas_autos = new string[8, 9];
        public static string[,] control_ventas_motos = new string[8, 9];
        public static string[,] control_ventas_camiones = new string[8, 9];

        public static byte num_automotores = 0;
        public static byte num_moto = 0;
        public static byte num_camiones = 0;
        public static byte num_ventas = 0;

        public string precio_auto(String price)
        {
            string clasifica="";
            float precio = 0;
            precio = Convert.ToSingle(price);
            if (precio >= 700000)
            {
                clasifica = "Clase A";
            }
            else
            {
                if (precio >= 350000 && precio <= 699999)
                {
                    clasifica = "Clase B";
                }
                else
                {
                    if (precio >= 0 && precio <= 349999)
                    {
                        clasifica = "Clase C";
                    }
                }
            }
            return clasifica;
        }//Método precio_auto

        public string precio_moto(String price)
        {
            string clasifica = "";
            float precio = 0;
            precio = Convert.ToSingle(price);
            if (precio >= 700000)
            {
                clasifica = "Clase A";
            }
            else
            {
                if (precio >= 350000 && precio <= 699999)
                {
                    clasifica = "Clase B";
                }
                else
                {
                    if (precio >= 0 && precio <= 349999)
                    {
                        clasifica = "Clase C";
                    }
                }
            }
            return clasifica;
        }//Método precio_moto

        public string automovil_clasificacion(String año)
        {
            int clasificar = 0;
            string categoria = "";
            clasificar = Convert.ToInt16(año);
            if (clasificar <= 1980)
            {
                categoria = "Clásico";
            }
            else
            {
                if (clasificar >= 1981 && clasificar <= 2010)
                {
                    categoria = "Usado";
                }
                else
                {
                    if (clasificar >= 2011 && clasificar <= 2015)
                    {
                        categoria = "Seminuevo";
                    }
                    else
                    {
                        if (clasificar >= 2016 && clasificar <= 2018)
                        {
                            categoria = "Reciente";
                        }
                    }
                }
            }
            return categoria;
        }//Método automovil_clasificacion

        public string camion_clasificacion(String carga)
        {
            string clasifica = "";
            float peso = 0;
            peso = Convert.ToSingle(carga);
            if (peso >= 0 && peso <= 2000)
            {
                clasifica = "Ligero";
            }
            else
            {
                if (peso >= 2001 && peso <= 4500)
                {
                    clasifica = "Mediano";
                }
                else
                {
                    if (peso >= 4500 && peso <= 6000)
                    {
                        clasifica = "Pesado";
                    }
                    else
                    {
                        clasifica = "Error, capacidad de carga erronea...";
                    }
                }
            }
            return clasifica;
        }//Método camion_clasificacion

        public void guardar_autos(String marca, String modelo, int año, String color, int puertas, String pais, int ocupantes, float precio)
        {
            if (num_automotores>=8)
            {
                MessageBox.Show("Se ha excedido el límite de automoviles para guardar.");
            }
            else
            {
                control_autos[num_automotores, 0] = marca;
                control_autos[num_automotores, 1] = modelo;
                control_autos[num_automotores, 2] = automovil_clasificacion(año.ToString());
                control_autos[num_automotores, 3] = color;
                control_autos[num_automotores, 4] = puertas.ToString();
                control_autos[num_automotores, 5] = pais;
                control_autos[num_automotores, 6] = ocupantes.ToString();
                control_autos[num_automotores, 7] = precio_auto(precio.ToString());
                MessageBox.Show("¡Éxito al guardar!");

                num_automotores += 1;
            }
        }//Método guardar_autos

        public void guardar_motos(String marca, String modelo, String uso, int año, String color, String motor_CC, float precio, String pais)
        {
            if (num_moto >= 8)
            {
                MessageBox.Show("Se ha excedido el límite de motocicletas para guardar.");
            }
            else
            {
                control_motos[num_moto, 0] = marca;
                control_motos[num_moto, 1] = modelo;
                control_motos[num_moto, 2] = uso;
                control_motos[num_moto, 3] = año.ToString();
                control_motos[num_moto, 4] = color;
                control_motos[num_moto, 5] = motor_CC;
                control_motos[num_moto, 6] = precio_moto(precio.ToString());
                control_motos[num_moto, 7] = pais;
                MessageBox.Show("¡Éxito al guardar!");

                num_moto += 1;
            }
        }//Método guardar_motos

        public void guardar_camiones(String marca, String modelo, int año, String color, String pais, float carga, int ocupantes, float precio)
        {
            if (num_camiones >= 8)
            {
                MessageBox.Show("Se ha excedido el límite de camiones para guardar.");
            }
            else
            {
                control_camiones[num_camiones, 0] = marca;
                control_camiones[num_camiones, 1] = modelo;
                control_camiones[num_camiones, 2] = año.ToString();
                control_camiones[num_camiones, 3] = color;
                control_camiones[num_camiones, 4] = pais;
                control_camiones[num_camiones, 5] = camion_clasificacion(carga.ToString());
                control_camiones[num_camiones, 6] = precio_auto(precio.ToString());
                control_camiones[num_camiones, 7] = pais;
                MessageBox.Show("¡Éxito al guardar!");

                num_camiones += 1;
            }
        }//Método guardar_camiones

        public void guardar_ventas_autos(float precio, String f_pago, String marca, String modelo, int año, String color, int puertas, String pais, int ocupantes)
        {
            if (num_ventas >= 8)
            {
                MessageBox.Show("Se ha excedido el límite de autos para guardar.");
            }
            else
            {
                control_ventas_autos[num_ventas, 0] = precio.ToString();
                control_ventas_autos[num_ventas, 1] = f_pago;
                control_ventas_autos[num_ventas, 2] = marca;
                control_ventas_autos[num_ventas, 3] = modelo;
                control_ventas_autos[num_ventas, 4] = año.ToString();
                control_ventas_autos[num_ventas, 5] = color;
                control_ventas_autos[num_ventas, 6] = puertas.ToString();
                control_ventas_autos[num_ventas, 7] = pais;
                control_ventas_autos[num_ventas, 8] = ocupantes.ToString();
                MessageBox.Show("¡Venta realizada con éxito!");

                num_ventas += 1;
            }
        }//Método guardar_ventas_autos

        public void guardar_ventas_motos(float precio, String f_pago, String marca, String modelo, int año, String color, String pais, String motor_CC, String uso)
        {
            if (num_ventas >= 8)
            {
                MessageBox.Show("Se ha excedido el límite de motos para guardar.");
            }
            else
            {
                control_ventas_motos[num_ventas, 0] = precio.ToString();
                control_ventas_motos[num_ventas, 1] = f_pago;
                control_ventas_motos[num_ventas, 2] = marca;
                control_ventas_motos[num_ventas, 3] = modelo;
                control_ventas_motos[num_ventas, 4] = año.ToString();
                control_ventas_motos[num_ventas, 5] = color;
                control_ventas_motos[num_ventas, 6] = pais;
                control_ventas_motos[num_ventas, 7] = motor_CC;
                control_ventas_motos[num_ventas, 8] = uso;
                MessageBox.Show("¡Venta realizada con éxito!");

                num_ventas += 1;
            }
        }//Método guardar_ventas_motos

        public void guardar_ventas_camiones(float precio, String f_pago, String marca, String modelo, int año, String color, String pais, int ocupantes, float carga)
        {
            if (num_ventas >= 8)
            {
                MessageBox.Show("Se ha excedido el límite de camiones para guardar.");
            }
            else
            {
                control_ventas_camiones[num_ventas, 0] = precio.ToString();
                control_ventas_camiones[num_ventas, 1] = f_pago;
                control_ventas_camiones[num_ventas, 2] = marca;
                control_ventas_camiones[num_ventas, 3] = modelo;
                control_ventas_camiones[num_ventas, 4] = año.ToString();
                control_ventas_camiones[num_ventas, 5] = color;
                control_ventas_camiones[num_ventas, 6] = pais;
                control_ventas_camiones[num_ventas, 7] = ocupantes.ToString();
                control_ventas_camiones[num_ventas, 8] = ocupantes.ToString();
                MessageBox.Show("¡Venta realizada con éxito!");

                num_ventas += 1;
            }
        }//Método guardar_ventas_camiones

        public string Mostrar_autos()
        {
            string retornar_auto = "";
            for (byte i = 0; i < 8; i++)
            {
                retornar_auto = retornar_auto + control_autos[0, i] + "\n";
            }
            return retornar_auto;
        }//Método Mostrar_autos

        public string Mostrar_motos()
        {
            string retornar_moto = "";
            for (byte i = 0; i < 8; i++)
            {
                retornar_moto = retornar_moto + control_motos[0, i] + "\n";
            }
            return retornar_moto;
        }//Método Mostrar_motos

        public string Mostrar_camiones()
        {
            string retornar = "";
            for (byte i = 0; i < 8; i++)
            {
                retornar = retornar + control_camiones[0, i] + "\n";
            }
            return retornar;
        }//Método Mostrar_camiones

        public string Mostrar_ventas_autos()
        {
            string retornar = "";
            for (byte i = 0; i < 9; i++)
            {
                retornar = retornar + control_ventas_autos[0, i] + "\n";
            }
            return retornar;
        }//Método Mostrar_ventas_autos

        public string Mostrar_ventas_motos()
        {
            string retornar = "";
            for (byte i = 0; i < 9; i++)
            {
                retornar = retornar + control_ventas_motos[0, i] + "\n";
            }
            return retornar;
        }//Método Mostrar_ventas_motos

        public string Mostrar_ventas_camiones()
        {
            string retornar = "";
            for (byte i = 0; i < 9; i++)
            {
                retornar = retornar + control_ventas_camiones[0, i] + "\n";
            }
            return retornar;
        }//Método Mostrar_ventas_camiones


    }
}
