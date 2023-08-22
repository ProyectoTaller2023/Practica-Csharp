// Los parametros que se le pasan a la apps en la llamada desde consola en /bin/Debug/Net.7.0
// Ejercicio7.exe argumento1 argumento2 argumento3, usando el comando .\Ejercicio7.exe amor roma -> Es anagrama

using Ejercicio7;

namespace Ejercicio7;

class Program
{
    static void Main(string[] args)
    {        
        if (args.Length < 2)
        {
           Console.Write("Se necesitan suministrar 2 cadenas de texto para comprobar si es un anagrama!");
            return;
        }

        Console.Write(Program.EsAnagrama(args[0], args[1]) ? $"{args[0]} y {args[1]} son un anagrama" : $"{args[0]} y " +
            $"{args[1]} no son un anagrama");
    }

    static bool EsAnagrama(string cadena1, string cadena2)
    {
        char[] caracteresCadena1 = cadena1.Replace(" ","").ToCharArray();
        char[] caracteresCadena2 = cadena2.Replace(" ", "").ToCharArray();
        Array.Sort(caracteresCadena1);
        Array.Sort(caracteresCadena2);

        return new string(caracteresCadena2) == new string(caracteresCadena1);
    }
}