using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class IfElseNumberAnalyzer
    {
        private string _number { get; set; }
        private Dictionary<string, string> NumberToWords = new Dictionary<string, string>()
        {
            {"1", "Uno"},
            {"2", "Dos"},
            {"3", "Tres"},
            {"4", "Cuatro"},
            {"5", "Cinco"},
            {"6", "Seis"},
            {"7", "Siete"},
            {"8", "Ocho"},
            {"9", "Nueve"}
        };

        public IfElseNumberAnalyzer(string? number)
        {
            number ??= ""; // Si number es null, asigna un string vacio
            this._number = number;
        }

        public string Analyze()
        {
           if (NumberToWords.ContainsKey(this._number))
            {
                return NumberToWords[this._number];
            } else
            {
                return "Otro";
            }
        }
    }
}
