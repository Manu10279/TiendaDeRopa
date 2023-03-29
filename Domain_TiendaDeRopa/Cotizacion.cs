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

            for (int i = 0; i < cantidadCotizar; i++)
            {
                foreach (object prendaDesconocida in listadoPrendas)
                {
                    Type tipoPrenda = prendaDesconocida.GetType();

                    switch (tipoPrenda.Name)
                    {
                        case "PantalonComun":
                            PantalonComun pantalonComun = (PantalonComun)prendaDesconocida;
                            if (cotizado != cantidadCotizar && tipo == "Pantalon Común")
                            {
                                pantalonComun.Cotizar(calidad);
                                cotizado++;
                            }
                            break;
                        case "PantalonChupin":
                            PantalonChupin pantalonChupin = (PantalonChupin)prendaDesconocida;
                            if (cotizado != cantidadCotizar && tipo == "Pantalon Chupin")
                            {
                                pantalonChupin.Cotizar(calidad);
                                cotizado++;
                            }
                            break;
                        case "CamisaMangaCorta":
                            CamisaMangaCorta camisaMangaCorta = (CamisaMangaCorta)prendaDesconocida;
                            if (cotizado != cantidadCotizar && tipo == "Camisa Manga Corta")
                            {
                                camisaMangaCorta.Cotizar(calidad, cuello);
                                cotizado++;
                            }
                            break;
                        case "CamisaMangaLarga":
                            CamisaMangaLarga camisaMangaLarga = (CamisaMangaLarga)prendaDesconocida;
                            if (cotizado != cantidadCotizar && tipo == "Camisa Manga Larga")
                            {
                                camisaMangaLarga.Cotizar(calidad, cuello);
                                cotizado++;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }

            
        }
    }
}
