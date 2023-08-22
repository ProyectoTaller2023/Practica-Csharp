using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1852; i <= 2023; i++)
            {
                if(i % 4 == 0)
                {
                    Console.WriteLine("El año " + i + " es bisiesto");
                }
            }
            Console.ReadKey();
        }
    }
}
