using Ejercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisUtilidades
{
    internal static class Utilidades
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

        internal static Punto LeerPuntoXY()
        {
            Console.WriteLine("Ingrese coordenada X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese coordenada Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            return new Punto(x, y);
        }
    }
}
