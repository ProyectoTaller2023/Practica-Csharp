using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Leibniz
    {
        private int _iterations { get; set; }

        public Leibniz(int iterations)
        {
            this._iterations = iterations;
        }

        public double getAproximationOfPi()
        {
            double piDividedByFour = 0;
            for (int n = 0; n < this._iterations; n++)
            {
                piDividedByFour += Math.Pow(-1, n) / (2 * n + 1);
            }
            return piDividedByFour * 4;
        }
    }
}
