using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    // se alinea con el patrón GRASP de "Controlador" ya que tiene la informacion para calcular distancia a otro punto (esencial para formar rectas)
    // y es responsable de proporcionar este metodo a las clases 'Triangulo' y 'Circulo' para que lo utilicen como quieran.
    internal class Punto
    {
        private double _x { get; set; }
        private double _y { get; set; }

        public Punto(double x, double y)
        {
            this._x = x;
            this._y = y;
        }

        public double x
        {
            get { return this._x; }
        }

        public double y
        {
            get { return this._y; }
        }

        public double CalcularDistanciaDesde(Punto otroPunto)
        {
            return Math.Sqrt(Math.Pow(this.x - otroPunto.x, 2) + Math.Pow(this.y - otroPunto.y, 2));
        }
    }
}
