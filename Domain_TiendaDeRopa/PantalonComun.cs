﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_TiendaDeRopa
{
    public class PantalonComun : Pantalon
    {
        private string calidad, tipo;
        private static string calidadPedida = "";
        private static int cantidadStandard = 0, cantidadPremium = 0;
        public static int Cantidad 
        { 
            get 
            {
                if (calidadPedida == "Standard")
                {
                    return cantidadStandard;
                }
                else if (calidadPedida == "Premium")
                {
                    return cantidadPremium;
                }
                return 0;
            }
        }

        public PantalonComun(string calidad)
        {
            if (calidad == "Standard")
            {
                cantidadStandard++;
            }
            else if (calidad == "Premium")
            {
                cantidadPremium++;
            }
            
            this.calidad = calidad;
            tipo = "Pantalon Común";
        }

        public override string Calidad
        {
            get
            {
                return calidad;
            }
        }
        public override string Tipo 
        { 
            get 
            { 
                return tipo; 
            } 
        }
        public override string Cuello
        {
            get
            {
                return "";
            }
        }

        public void PedirCalidad(string calidad)
        {
            calidadPedida = calidad;
        }
    }
}
