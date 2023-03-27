using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_TiendaDeRopa
{
    public class Cotizacion
    {
        private double precioFinal;
        public double PrecioFinal { get; }
        public Cotizacion(string tipo, string calidad, int cantidadCotizar, double precioUnitario)
        {
            double precio = precioUnitario * cantidadCotizar;

            if (tipo == "Pantalon Chupin")
            {
                precioFinal = precio * 0.88;
            }
            else 
            {
                precioFinal = precio * 1;
            }

            if (calidad == "Premium")
            {
                precioFinal = precioFinal * 1.3;
            }

            PrecioFinal = precioFinal;
        }
    }
}
