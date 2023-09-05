﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class IngresoVehiculo
    {
        private string iPatente;
        private DateTime iFechaIngreso;
        private DateTime? iFechaEgreso;
        private int iLugarAsignado;

        public IngresoVehiculo(string patente, int lugarAsignado)
        {
            this.iPatente = patente;
            this.iFechaIngreso = DateTime.Now;
            this.iLugarAsignado = lugarAsignado;
            this.iFechaEgreso = null;
        }   

        public string Patente
        {
            get { return iPatente; }
        }

        public int LugarAsignado
        {
            get { return iLugarAsignado; }
        }

        public DateTime FechaIngreso
        {
            get { return iFechaIngreso; }
        }

        public DateTime? FechaEgreso
        {
            get { return iFechaEgreso; }
            set { iFechaEgreso = value; }
        }

        public int MinutosDesdeIngreso()
        {
            TimeSpan diferencia = DateTime.Now - iFechaIngreso;
            return (int)diferencia.TotalMinutes;
        }
    }
}