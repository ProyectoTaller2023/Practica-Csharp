using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lebniz = 0;
            Console.Write("Ingrese la cantidad de iteraciones: ");
            int cantIteraciones = int.Parse(Console.ReadLine());

            for(int n = 0; n<cantIteraciones; n++)
            {
                lebniz = lebniz + (4*Math.Pow(-1, n)) /(2.0*n+1.0);
            }
            Console.WriteLine("Valor calculado: " + lebniz);
            Console.WriteLine("Eficacia: "+(lebniz/Math.PI)*100);
            Console.ReadKey();
        }
    }
}
