using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_TiendaDeRopa
{
    public class PantalonComun : Pantalon
    {
        //Atributos
        private static int cantidadStandard = 0, cantidadPremium = 0;

        //Propiedades
        public override int Cantidad 
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

        //Métodos
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
        }
    }
}
