using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1___If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un valor por pantalla: ");
            string numero = Console.ReadLine();

            if (numero == "1") {
                Console.WriteLine("El valor ingresado fue UNO");
            }
            else {
                if (numero == "2")
                {
                    Console.WriteLine("El valor ingresado fue DOS");
                }
                else {
                    if (numero == "3")
                    {
                        Console.WriteLine("El valor ingresado fue TRES");
                    }
                    else {
                        if (numero == "4")
                        {
                            Console.WriteLine("El valor ingresado fue CUATRO");
                        }
                        else
                        {
                            if (numero == "5")
                            {
                                Console.WriteLine("El valor ingresado fue CINCO");
                            }
                            else
                            {
                                if (numero == "6")
                                {
                                    Console.WriteLine("El valor ingresado fue SEIS");
                                }
                                else
                                {
                                    if (numero == "7")
                                    {
                                        Console.WriteLine("El valor ingresado fue SIETE");
                                    }
                                    else
                                    {
                                        if (numero == "8")
                                        {
                                            Console.WriteLine("El valor ingresado fue OCHO");
                                        }
                                        else
                                        {
                                            if (numero == "9")
                                            {
                                                Console.WriteLine("El valor ingresado fue NUEVE");
                                            }
                                            else
                                            { 
                                                Console.WriteLine("El valor ingresado fue OTRO"); 
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
