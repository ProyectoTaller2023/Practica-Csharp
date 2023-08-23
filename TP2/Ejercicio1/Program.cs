namespace Ejercicio1;

class Program
{
    static void Main(string[] args)
    {
        string[] opciones = { "Operar triangulo", "Operar circulo", "Operar punto" };
        int eleccion = Program.getEleccionDesdeMenu(opciones);
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
        int eleccion = Program.getEleccionDesdeMenu(opciones);

        Console.WriteLine("Ingrese los puntos del triangulo: ");
        Punto punto1 = LeerPuntoXY();
        Punto punto2 = LeerPuntoXY();
        Punto punto3 = LeerPuntoXY();

        var triangulo = new Triangulo(punto1, punto2, punto3);
        switch (eleccion)
        {
            case 1:
                Program.MostrarResultado("El area del triangulo es: " + triangulo.Area());
                break;

            case 2:
                Program.MostrarResultado("El perimetro del triangulo es: " + triangulo.Perimetro());
                break;
        }
    }

    static void ManejarOpcionCirculo()
    {
        string[] opciones = { "Obtener area", "Obtener perimetro" };
        int eleccion = Program.getEleccionDesdeMenu(opciones);

        Console.WriteLine("Ingrese centro del circulo: ");
        Punto punto = LeerPuntoXY();

        Console.WriteLine("Ingrese radio del circulo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        var circulo = new Circulo(punto, radio);

        switch (eleccion)
        {
            case 1:
                Program.MostrarResultado("El area del circulo es: " + circulo.Area());
                break;

            case 2:
                Program.MostrarResultado("El perimetro del circulo es: " + circulo.Perimetro());
                break;
        }
    }

    static void ManejarOpcionPunto()
    {
        string[] opciones = { "Obtener distancia a otro punto" };
        int eleccion = Program.getEleccionDesdeMenu(opciones);

        Console.WriteLine("Ingrese punto 1: ");
        Punto punto = LeerPuntoXY();

        switch (eleccion)
        {
            case 1:
                Console.WriteLine("Ingrese punto 2: ");
                Punto punto2 = LeerPuntoXY();
                Program.MostrarResultado("La distancia entre puntos es: " + punto.CalcularDistanciaDesde(punto2));
                break;
        }
    }

    static int getEleccionDesdeMenu(string[] opciones)
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

    static Punto LeerPuntoXY()
    {
        Console.WriteLine("Ingrese coordenada X: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese coordenada Y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        return new Punto(x, y);
    }

    static void MostrarResultado(string resultado)
    {
        Console.WriteLine(resultado);
        Console.ReadKey();
    }
}