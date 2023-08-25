using MisUtilidades;

namespace Ejercicio1;

class Program
{
    static void Main(string[] args)
    {
        string[] opciones = { "Operar triangulo", "Operar circulo", "Operar punto" };
        int eleccion = Utilidades.getEleccionDesdeMenu(opciones);
        Program.SwitchOpciones(eleccion);
    }

    static void SwitchOpciones(int opcionElegida)
    {
        switch (opcionElegida)
        {
            case 1:
                ManejarOpcionTriangulo();
                break;

            case 2:
                ManejarOpcionCirculo();
                break;
            case 3:
                ManejarOpcionPunto();
                break;
        }
    }

    static void ManejarOpcionTriangulo()
    {
        string[] opciones = { "Obtener area", "Obtener perimetro" };
        int eleccion = Utilidades.getEleccionDesdeMenu(opciones);

        Console.WriteLine("Ingrese los puntos del triangulo: ");
        Punto punto1 = Utilidades.LeerPuntoXY();
        Punto punto2 = Utilidades.LeerPuntoXY();
        Punto punto3 = Utilidades.LeerPuntoXY();

        var triangulo = new Triangulo(punto1, punto2, punto3);
        switch (eleccion)
        {
            case 1:
                Utilidades.MostrarResultado("El area del triangulo es: " + triangulo.Area());
                break;

            case 2:
                Utilidades.MostrarResultado("El perimetro del triangulo es: " + triangulo.Perimetro());
                break;
        }
    }

    static void ManejarOpcionCirculo()
    {
        string[] opciones = { "Obtener area", "Obtener perimetro" };
        int eleccion = Utilidades.getEleccionDesdeMenu(opciones);

        Console.WriteLine("Ingrese centro del circulo: ");
        Punto punto = Utilidades.LeerPuntoXY();

        Console.WriteLine("Ingrese radio del circulo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        var circulo = new Circulo(punto, radio);

        switch (eleccion)
        {
            case 1:
                Utilidades.MostrarResultado("El area del circulo es: " + circulo.Area());
                break;

            case 2:
                Utilidades.MostrarResultado("El perimetro del circulo es: " + circulo.Perimetro());
                break;
        }
    }

    static void ManejarOpcionPunto()
    {
        string[] opciones = { "Obtener distancia a otro punto" };
        int eleccion = Utilidades.getEleccionDesdeMenu(opciones);

        Console.WriteLine("Ingrese punto 1: ");
        Punto punto = Utilidades.LeerPuntoXY();

        switch (eleccion)
        {
            case 1:
                Console.WriteLine("Ingrese punto 2: ");
                Punto punto2 = Utilidades.LeerPuntoXY();
                Utilidades.MostrarResultado("La distancia entre puntos es: " + punto.CalcularDistanciaDesde(punto2));
                break;
        }
    }
}