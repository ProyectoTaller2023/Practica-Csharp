namespace Ejercicio1;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Ingrese un numero: ");
       string? numeroIngresado = Console.ReadLine();

            // Version 1: Usando Switch como estructura de control
       // var numberAnalyzer = new SwitchNumberAnalyzer(numeroIngresado);
            // Version 2: Usando if/else como estructura de control
       var numberAnalyzer = new IfElseNumberAnalyzer(numeroIngresado);
       Console.WriteLine(numberAnalyzer.Analyze());
    }
}