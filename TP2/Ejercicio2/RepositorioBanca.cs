using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class RepositorioBanca
    {
        private List<Banca> bancas;

        public RepositorioBanca()
        {
              this.bancas = new List<Banca>();
        }

        public Banca? Obtener(string pNumero)
        {
              return this.bancas.Find(banca => banca.Numero == pNumero);
        }

        public void Agregar(Banca pBanca)
        {
              this.bancas.Add(pBanca);
        }
    }
}
