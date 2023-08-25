using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Moneda
    {
        private string iCodigoISO;
        private string iNombre;
        private string iSimbolo;

        public Moneda(string pCodigoISO, string pNombre, string pSimbolo)
        {
            this.iCodigoISO = pCodigoISO;
            this.iNombre = pNombre;
            this.iSimbolo = pSimbolo;
        }

        public string CodigoISO()
        {
           return this.iCodigoISO;
        }

        public string Nombre()
        {
            return this.iNombre;
        }

        public string Simbolo()
        {
            return this.iSimbolo;
        }
    }
}
