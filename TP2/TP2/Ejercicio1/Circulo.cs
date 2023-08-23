using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Circulo
    {
        private Punto _punto { get; set; }

        private double _x { get; set; }
        private double _y { get; set; }
        private double _radio { get; set; }

        public Circulo(Punto punto, double radio)
        {
            this._punto = punto;
            this._radio = radio;
        }

        public Circulo(double x, double y, double radio)
        {
            this._punto = new Punto(x, y);
            this._radio = radio;
        }
       
        public double Radio { get { return this._radio; } }

       public Punto Centro()
        {
            return this._punto;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public double Perimetro()
        {
            return Math.PI * Radio * 2;
        }
    }
}
