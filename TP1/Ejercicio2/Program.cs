namespace Ejercicio3;

class Program
{
    private static readonly double pi = Math.PI;
    static void Main(string[] args)
    {
        Console.Write("Introduce el número de iteraciones para aproximar PI: ");
        int iterations = Convert.ToInt32(Console.Read());
        double piAproximation = new Leibniz(iterations).getAproximationOfPi();
        Console.WriteLine();
        Console.WriteLine($"El valor aproximado de PI es: {piAproximation}");
        Console.WriteLine("El valor difiere de Math.PI en un " + CalculatePercentDifference(pi, piAproximation) + "%");
    }

    static double CalculatePercentDifference(double realValue, double approximation)
    {
        return Math.Abs((realValue - approximation) / realValue * 100);
    }
}