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
        int cotizado = 0;
        public Cotizacion(List<Prenda> listadoPrendas, string tipo, string calidad, int cantidadCotizar, double precioUnitario, string cuello)
        {
            double precio = precioUnitario * cantidadCotizar;

            
            if (tipo == "Camisa Manga Corta" && cuello != "Cuello Mao") //RN1
            {
                precioFinal = precio * 0.90;
            }
            else if (cuello == "Cuello Mao" && tipo != "Camisa Manga Corta" ) //RN2
            {
                precioFinal = precio * 1.03;
            }
            else if (tipo == "Camisa Manga Corta" && cuello == "Cuello Mao") //RN3
            {
                precioFinal = precio * 0.90;
                precioFinal = precioFinal * 1.03;
            }
            else if (tipo == "Pantalon Chupin") //RN4
            {
                precioFinal = precio * 0.88;
            }
            else //Todas las Demás Posibilidades
            {
                precioFinal = precio * 1;
            }

            if (calidad == "Standard") //RN5
            {
                precioFinal = precioFinal * 1;
            }
            else if (calidad == "Premium") //RN6
            {
                precioFinal = precioFinal * 1.3;
            }

            PrecioFinal = precioFinal;
        }
    }
}
