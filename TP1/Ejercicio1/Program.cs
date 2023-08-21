using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un valor por pantalla: ");
            string numero = Console.ReadLine();

            switch (numero)
            {
                case "1":
                    Console.WriteLine("El valor ingresado es UNO");
                    break;
                case "2":
                    Console.WriteLine("El valor ingresado es DOS");
                    break;
                case "3":
                    Console.WriteLine("El valor ingresado es TRES");
                    break;
                case "4":
                    Console.WriteLine("El valor ingresado es CUATRO");
                    break;
                case "5":
                    Console.WriteLine("El valor ingresado es CINCO");
                    break;
                case "6":
                    Console.WriteLine("El valor ingresado es SEIS");
                    break;
                case "7":
                    Console.WriteLine("El valor ingresado es SIETE");
                    break;
                case "8":
                    Console.WriteLine("El valor ingresado es OCHO");
                    break;
                case "9":
                    Console.WriteLine("El valor ingresado es NUEVE");
                    break;
                default:
                    Console.WriteLine("El valor ingresado fue OTRO");
                    break;
            }
            Console.ReadKey();
        }
    }
}
