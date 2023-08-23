using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Triangulo
    {
        private Punto _punto1 { get; set; }
        private Punto _punto2 { get; set; }
        private Punto _punto3 { get; set; }
        public Triangulo(Punto punto1, Punto punto2, Punto punto3)
        {
           this._punto1 = punto1;
           this._punto2 = punto2;
           this._punto3 = punto3;
        }

        public Punto punto1 { get { return _punto1; } }
        public Punto punto2 { get { return _punto2; } }
        public Punto punto3 { get { return _punto3; } }

        public double Area() // base*altura/2
        {
            return Math.Abs
           (punto1.CalcularDistanciaDesde(punto2) * punto2.CalcularDistanciaDesde(punto3))/2.0;
        }

        public double Perimetro()
        {
            return punto1.CalcularDistanciaDesde(punto2) + punto2.CalcularDistanciaDesde(punto3) + punto3.CalcularDistanciaDesde(punto1);
        }
    }
}
