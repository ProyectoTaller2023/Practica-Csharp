using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Cuenta
    {
        private double iSaldo;
        private Moneda iMoneda;
        
        public Cuenta(double pSaldoInicial, Moneda pMoneda)
        {
            this.iSaldo = pSaldoInicial;
            this.iMoneda = pMoneda;
        }

        public Cuenta(Moneda pMoneda)
        {
            this.iSaldo = 0;
            this.iMoneda = pMoneda;
        }

        public double Saldo()
        {
            return this.iSaldo;
        }

        public void AcreditarSaldo(double pSaldo)
        {
            this.iSaldo += pSaldo;
        }   

        public bool DebitarSaldo(double pSaldo)
        {
            if (this.iSaldo < pSaldo)
            {
                return false;
            }
            
           this.iSaldo -= pSaldo;
           return true;
        }

    }
}
