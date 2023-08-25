using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Banca
    {
        private Cuenta iCuentaEnPesos;
        private Cuenta iCuentaEnDolares;

        public string Titular { get; set; } 
        public string Numero { get; set; }

        public Banca(string pNumero, string pTitular)
        {
            this.iCuentaEnPesos = new Cuenta(new Moneda("ARS", "Peso Argentino", "$"));
            this.iCuentaEnDolares = new Cuenta(new Moneda("USD", "Dolar Estadounidense", "U$S"));
            this.Titular = pTitular;
            this.Numero = pNumero;
        }


        public Cuenta CuentaEnPesos(){
            return this.iCuentaEnPesos;
        }

        public Cuenta CuentaEnDolares()
        {
            return this.iCuentaEnDolares;
        }
    }
}
