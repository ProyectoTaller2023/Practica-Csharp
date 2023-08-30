using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class ControladorBancas
    {
        private RepositorioBanca Bancas = new RepositorioBanca();

        public ControladorBancas()
        { 
        }

        public void crearCuenta(string pNumero, string pTitular)
        {
            Banca Banca = new Banca(pNumero, pTitular);
            Bancas.Agregar(Banca);
        }

        public string obtenerSaldo(string pNumero, string pCodigoISO)
        {
            Banca? Banca = Bancas.Obtener(pNumero);
            if (Banca != null)
            {
                if (pCodigoISO == "ARS")
                {
                    return Banca.CuentaEnPesos().Saldo().ToString();
                }
                else if (pCodigoISO == "USD")
                {
                    return Banca.CuentaEnDolares().Saldo().ToString();
                }
            }
            return "No se encontro la cuenta";
        }
        public string debitarSaldo(string pNumero, string pCodigoISO, double pSaldo)
        {
            Banca? Banca = Bancas.Obtener(pNumero);
            if (Banca != null)
            {
                if (pCodigoISO == "ARS")
                {
                   return Banca.CuentaEnPesos().DebitarSaldo(pSaldo) ? "Se debito el saldo ARS correctamente" : "No se pudo debitar el saldo ARS";
                }
                else if (pCodigoISO == "USD")
                {
                    return Banca.CuentaEnDolares().DebitarSaldo(pSaldo) ? "Se debito el saldo USD correctamente" : "No se pudo debitar el saldo USD";
                }
            }

            return "No se encontro la cuenta";
        }
        public string acreditarSaldo(string pNumero, string pCodigoISO, double pSaldo)
        {
            Banca? Banca = Bancas.Obtener(pNumero);
            if (Banca != null)
            {
                if (pCodigoISO == "ARS")
                {
                    Banca.CuentaEnPesos().AcreditarSaldo(pSaldo);
                    return "Se acredito el saldo ARS correctamente";
                }
                else if (pCodigoISO == "USD")
                {
                    Banca.CuentaEnDolares().AcreditarSaldo(pSaldo);
                    return "Se acredito el saldo USD correctamente";
                }
            }
            return "No se encontro la cuenta";
        }
    }
}
