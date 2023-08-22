using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Fibonacci
    {
        private int _numberOfSums { get; set; }
        public Fibonacci(int numberOfSums) { 
            this._numberOfSums = numberOfSums;
        }

        public int getSummation()
        { 
            int[] fiboNumbers = new int[2];
            fiboNumbers[0] = 0;
            fiboNumbers[1] = 1;
            int sumLastTwo = 0;

            for (int i = 1; i < _numberOfSums; i++){
                sumLastTwo = fiboNumbers[0] + fiboNumbers[1];
                fiboNumbers[0] = fiboNumbers[1];
                fiboNumbers[1] = sumLastTwo;
            }

            return sumLastTwo;
        }
    }
}
