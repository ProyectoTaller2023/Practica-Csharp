using Ejercicio5;

namespace Ejercicio3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el número de sumas de Fibonacci que desea calcular: ");
        int numberOfFiboSum = Convert.ToInt32(Console.ReadLine());
        var fibo = new Fibonacci(numberOfFiboSum);
        Console.Write($"El numero de sumas fibo hasta {numberOfFiboSum} es {fibo.getSummation()}");
    }
}