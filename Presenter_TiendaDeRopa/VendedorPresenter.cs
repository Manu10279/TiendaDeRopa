using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_TiendaDeRopa;

namespace Presenter_TiendaDeRopa
{
    public class VendedorPresenter
    {
        public double Cotizar(string tipo, string calidad, int cantidadCotizar, int cantidad, double precioUnitario)
        {
            if (cantidadCotizar > cantidad)
            {
                Cotizacion cotizacion = new Cotizacion(tipo, calidad, cantidadCotizar, precioUnitario);
                return cotizacion.PrecioFinal;
            }
            else
            {
                Cotizacion cotizacion = new Cotizacion(tipo, calidad, cantidadCotizar, precioUnitario);
                return cotizacion.PrecioFinal;
            }
        }
    }
}
