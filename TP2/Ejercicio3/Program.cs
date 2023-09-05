using Ejercicio3;

class Program
{
    Estacionamiento Estacionamiento = new();
    static void Main(string[] args)
    {
        Program program = new();

        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("=== Menú Principal ===");
            Console.WriteLine("1. Registrar Ingreso");
            Console.WriteLine("2. Registrar Egreso");
            Console.WriteLine("3. Salir");
            Console.Write("Selecciona una opción: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    program.ManejarIngresoVehiculo();
                    break;

                case "2":
                    program.ManejarEgresoVehiculo();
                    break;

                case "3":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Opción inválida. Ingrese otra para continuar.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    void ManejarIngresoVehiculo()
    {
        Console.WriteLine("Ingrese la patente del vehiculo");
        string patente = Console.ReadLine();
        int? lugar = Estacionamiento.RegistrarIngresoVehiculo(patente);
        if (lugar != null)
        {
            Console.WriteLine($"El vehiculo ingreso correctamente en el lugar {lugar}");
        }
        else
        {
            Console.WriteLine("No hay lugares disponibles");
        }
        Console.ReadKey();
    }

    void ManejarEgresoVehiculo()
    {
        Console.WriteLine("Ingrese la patente del vehiculo");
        string patente = Console.ReadLine();
        float? costo = Estacionamiento.CalcularCosto(patente);

        if (costo != null)
        {
            bool egresoExitoso = Estacionamiento.RegistrarEgresoVehiculo(patente);
            if (egresoExitoso)
            {
                Console.WriteLine($"El vehiculo egreso correctamente, tiene un costo de {costo}");

            }
            else
            {
                Console.WriteLine($"Ocurrio un error al registrar el egreso de un vehiculo con patente {patente}");
            }
        }
        else
        {
            Console.WriteLine($"Ocurrio un error en el registro del egreso del vehiculo con patente {patente}, error al calcular el costo, compruebe la patente ingresada.");
        }
        Console.ReadKey();
    }

}
