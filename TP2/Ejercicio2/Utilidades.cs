using Ejercicio2;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisUtilidades
{
    public static class Utilidades
    {
        public static int getEleccionDesdeMenu(string[] opciones)
        {
            int opcionElegida;
            string eleccion;

            Console.WriteLine("Ingrese una opcion: ");
            int iteracion = 0;

            foreach (var item in opciones)
            {
                iteracion++;
                Console.WriteLine(item + " - " + iteracion);
            }
            Console.Write("Opcion elegida: ");

            do
            {
                eleccion = Console.ReadLine();

                if (!int.TryParse(eleccion, out opcionElegida))
                {
                    Console.WriteLine("Error: Ingrese un número válido.");
                }
            } while (!int.TryParse(eleccion, out opcionElegida));
            Console.WriteLine("");

            return opcionElegida;
        }

       


        internal static void MostrarResultado(string resultado)
        {
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}

