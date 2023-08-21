using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class SwitchNumberAnalyzer
    {
        private string? _number { get; set; }

        public SwitchNumberAnalyzer(string? number)
        {
            this._number = number;
        }

        public string Analyze()
        {
            switch (_number)
            {
                case "1":
                    return "Uno";
                case "2":
                    return "Dos";
                case "3":
                    return "Tres";
                case "4":
                    return "Cuatro";
                case "5":
                    return "Cinco";
                case "6":
                    return "Seis";
                case "7":
                    return "Siete";
                case "8":
                    return "Ocho";
                case "9":
                    return "Nueve";
                default:
                    return "Otro";
            }
        }
    }
}
