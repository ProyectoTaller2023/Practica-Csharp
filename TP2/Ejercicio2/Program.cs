namespace Ejercicio2;
using MisUtilidades;

class Program
{
    ControladorBancas ControladorBancas = new ControladorBancas();
     static void Main(string[] args)
    {   
        Program program = new Program();
        
        bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=== Menú Principal ===");
                Console.WriteLine("1. Crear cuenta");
                Console.WriteLine("2. Consultar saldo");
                Console.WriteLine("3. Acreditar saldo ");
                Console.WriteLine("4. Debitar saldo ");
                Console.WriteLine("5. Salir");
                Console.Write("Selecciona una opción: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                       program.ManejarCrearCuenta();
                        break;

                    case "2":
                        program.ManejarMostrarSaldo();
                        break;

                    case "3":
                        program.ManejarAcreditarSaldo();
                        break;

                    case "4":
                    program.ManejarDebitarSaldo();
                    break;

                case "5":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Presiona una tecla para continuar.");
                        Console.ReadKey();
                        break;
                }
            }
    }

    void ManejarCrearCuenta()
    {
        Console.WriteLine("Ingrese su numero de documento");
        string dni = Console.ReadLine();
        Console.WriteLine("Ingrese su nombre");
        string nombre = Console.ReadLine();
        try
        {
        ControladorBancas.crearCuenta(dni, nombre);
        Utilidades.MostrarResultado("Cuenta creada con exito");
        } catch (Exception e)
        {
            Utilidades.MostrarResultado(e.Message);
        }
    }

    void ManejarMostrarSaldo()
    {
        Console.WriteLine("Ingrese el numero de documento del titular de la cuenta que desea ver");
        string dni = Console.ReadLine();
        Console.WriteLine("Ingrese el codigo ISO de la moneda que desea ver - Pesos argentinos = ARS, Dolar = USD");
        string codigoISO = Console.ReadLine();
        try
        {
            string saldo = ControladorBancas.obtenerSaldo(dni, codigoISO);
            Utilidades.MostrarResultado("El saldo de la cuenta es: " + saldo);
        } catch (Exception e)
        {
            Utilidades.MostrarResultado(e.Message);
        }
    }

    void ManejarAcreditarSaldo()
    {
        Console.WriteLine("Ingrese el numero de documento del titular de la cuenta que desea depositar");
        string dni = Console.ReadLine();
        Console.WriteLine("Ingrese el codigo ISO de la cuenta donde desea depositar - Pesos argentinos = ARS, Dolar = USD");
        string codigoISO = Console.ReadLine();
        Console.WriteLine("Ingrese el monto a depositar");
        string monto = Console.ReadLine();
        try
        {
            string resultado = ControladorBancas.acreditarSaldo(dni, codigoISO, double.Parse(monto));
            Utilidades.MostrarResultado(resultado);
        }
        catch (Exception e)
        {
            Utilidades.MostrarResultado(e.Message);
        }
    }

    void ManejarDebitarSaldo()
    {
        Console.WriteLine("Ingrese el numero de documento del titular de la cuenta a debitar");
        string dni = Console.ReadLine();
        Console.WriteLine("Ingrese el codigo ISO de la cuenta donde desea debitar - Pesos argentinos = ARS, Dolar = USD");
        string codigoISO = Console.ReadLine();
        Console.WriteLine("Ingrese el monto a debitar");
        string monto = Console.ReadLine();
        try
        {
            string resultado = ControladorBancas.debitarSaldo(dni, codigoISO, double.Parse(monto));
            Utilidades.MostrarResultado(resultado);
        }
        catch (Exception e)
        {
            Utilidades.MostrarResultado(e.Message);
        }
    }
}