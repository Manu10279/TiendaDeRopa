using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_TiendaDeRopa;

namespace Presenter_TiendaDeRopa
{
    public class FueraDeStock : Exception
    {
        public FueraDeStock(string mensaje) : base ("Error: " + mensaje) { }
    }

    public class VendedorPresenter
    {
        public double Cotizar(List<Prenda> listadoPrendas, string tipo, string calidad, int cantidadCotizar, int cantidad, double precioUnitario, string cuello)
        {
            if (cantidadCotizar < cantidad)
            {
                Cotizacion cotizacion = new Cotizacion(listadoPrendas, tipo, calidad, cantidadCotizar, precioUnitario, cuello);
                return cotizacion.PrecioFinal;
            }
            else
            {
                throw new FueraDeStock("No hay suficiente stock de ");
            }
        }
    }
}
