using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2___While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un valor entero: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro valor entero: ");
            int b = int.Parse(Console.ReadLine());

            int limInferior = Math.Min(a, b);
            int limSuperior = Math.Max(a, b);

            int sumaTotal = 0;
            int i = limInferior;

            while (i <= limSuperior) {
                sumaTotal = sumaTotal + i;
                i++;
            }

            Console.WriteLine("Valor minimo: " + limInferior);
            Console.WriteLine("Valor maximo: " + limSuperior);
            Console.WriteLine("Promedio: " + (limInferior + limSuperior) / 2.0);
            Console.WriteLine("Suma total: " + sumaTotal);
            Console.ReadKey();
        }
    }
}
