using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Estacionamiento
    {
        // lugares representa el estacionamiento como tal
        private IngresoVehiculo?[] lugares = new IngresoVehiculo[10];
        private readonly float costoXhora = 200;

        public int? RegistrarIngresoVehiculo(string patente)
        {
            int lugarLibre = BuscarLugarLibre();
            if (lugarLibre != -1)
            {
                IngresoVehiculo ingreso = new IngresoVehiculo(patente, lugarLibre);
                using (EstacionamientoContext context = new EstacionamientoContext())
                {
                    context.Ingresos.Add(ingreso);
                    context.SaveChanges();
                }
                lugares[lugarLibre] = ingreso;
                return lugarLibre;
            }
            return null;
        }

        private int BuscarLugarLibre()
        {
            for (int i = 0; i < lugares.Length; i++)
            {
                if (lugares[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }   

        public bool RegistrarEgresoVehiculo(string patente)
        {
            IngresoVehiculo? ingreso = BuscarIngresoVehiculo(patente);
            if (ingreso != null)
            {
                using (EstacionamientoContext context = new EstacionamientoContext())
                {
                    ingreso.FechaEgreso = DateTime.Now; 
                    context.Ingresos.Update(ingreso);
                    context.SaveChanges();
                }
                lugares[ingreso.LugarAsignado] = null;
                return true;
            }

            return false;
        }

        public IngresoVehiculo? BuscarIngresoVehiculo(string patente)
        {
            foreach (IngresoVehiculo ingreso in lugares)
            {
                if (ingreso != null && ingreso.Patente == patente)
                {
                    return ingreso;
                }
            }
            return null;
        }

        public float? CalcularCosto(string patente)
        {
            IngresoVehiculo? ingreso = BuscarIngresoVehiculo(patente);
            if (ingreso != null)
            {
                float costoXmediaHora = costoXhora / 2; 
                int minutos = ingreso.MinutosDesdeIngreso();
                int mediasHoras = minutos / 30; 
                if (minutos % 30 != 0) 
                {
                    mediasHoras++;
                }
                return mediasHoras * costoXmediaHora;    
            }
            return null;
        }
    }
}
