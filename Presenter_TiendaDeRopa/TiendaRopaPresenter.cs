using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_TiendaDeRopa;

namespace Presenter_TiendaDeRopa
{
    public class TiendaRopaPresenter
    {
        private VendedorPresenter vendedor;
        private List<Prenda> listadoPrendas = new List<Prenda>();
        private Pantalon pantalonComun;
        private Pantalon pantalonChupin;
        private Camisa camisaMangaCorta;
        private Camisa camisaMangaLarga;
        

        public TiendaRopaPresenter(VendedorPresenter vendedor)
        {
            this.vendedor = vendedor;

            //Instanciando Pantalones
            for (int i = 0; i < 250; i++) //Pantalon Común
            {
                pantalonComun = new PantalonComun("Standard");
                listadoPrendas.Add(pantalonComun);
                pantalonComun = new PantalonComun("Premium");
                listadoPrendas.Add(pantalonComun);
            }
            pantalonComun = new PantalonComun("Premium");
            listadoPrendas.Add(pantalonComun);
            for (int i = 0; i < 750; i++) //Pantalon Chupin
            {
                pantalonChupin = new PantalonChupin("Standard");
                listadoPrendas.Add(pantalonChupin);
                pantalonChupin = new PantalonChupin("Premium");
                listadoPrendas.Add(pantalonChupin);
            }
            pantalonChupin = new PantalonChupin("Premium");
            listadoPrendas.Add(pantalonChupin);

            //Instanciando Camisas
            for (int i = 0; i < 150; i++)
            {
                camisaMangaCorta = new CamisaMangaCorta("Standard", "Cuello Común");
                listadoPrendas.Add(camisaMangaCorta);
                camisaMangaCorta = new CamisaMangaCorta("Premium", "Cuello Común");
                listadoPrendas.Add(camisaMangaCorta);
            }
            for (int i = 0; i < 100; i++)
            {
                camisaMangaCorta = new CamisaMangaCorta("Standard", "Cuello Mao");
                listadoPrendas.Add(camisaMangaCorta);
                camisaMangaCorta = new CamisaMangaCorta("Premium", "Cuello Mao");
                listadoPrendas.Add(camisaMangaCorta);
            }
            for (int i = 0; i < 175; i++)
            {
                camisaMangaLarga = new CamisaMangaLarga("Standard", "Cuello Común");
                listadoPrendas.Add(camisaMangaLarga);
                camisaMangaLarga = new CamisaMangaLarga("Premium", "Cuello Común");
                listadoPrendas.Add(camisaMangaLarga);
            }
            for (int i = 0; i < 75; i++)
            {
                camisaMangaLarga = new CamisaMangaLarga("Standard", "Cuello Mao");
                listadoPrendas.Add(camisaMangaLarga);
                camisaMangaLarga = new CamisaMangaLarga("Premium", "Cuello Mao");
                listadoPrendas.Add(camisaMangaLarga);
            }
        }


        public void ObtenerPrenda(string tipo, string calidad, string cuello, out int cantidad)
        {
            cantidad = 0;
            foreach (object prendaDesconocida in listadoPrendas)
            {
                Type tipoPrenda = prendaDesconocida.GetType();

                switch (tipoPrenda.Name)
                {
                    case "PantalonComun":
                        PantalonComun pantalonComun = (PantalonComun)prendaDesconocida;
                        if (tipo == "Pantalon Común")
                        {
                            pantalonComun.DatosSolicitados(calidad);
                            cantidad = PantalonComun.Cantidad;
                        }
                        break;
                    case "PantalonChupin":
                        PantalonChupin pantalonChupin = (PantalonChupin)prendaDesconocida;
                        if (tipo == "Pantalon Chupin")
                        {
                            pantalonChupin.DatosSolicitados(calidad);
                            cantidad = PantalonChupin.Cantidad;
                        }
                        break;
                    case "CamisaMangaCorta":
                        CamisaMangaCorta camisaMangaCorta = (CamisaMangaCorta)prendaDesconocida;
                        if (tipo == "Camisa Manga Corta")
                        {
                            camisaMangaCorta.DatosSolicitados(calidad, cuello);
                            cantidad = CamisaMangaCorta.Cantidad;
                        }
                        break;
                    case "CamisaMangaLarga":
                        CamisaMangaLarga camisaMangaLarga = (CamisaMangaLarga)prendaDesconocida;
                        if (tipo == "Camisa Manga Larga")
                        {
                            camisaMangaLarga.DatosSolicitados(calidad, cuello);
                            cantidad = CamisaMangaLarga.Cantidad;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        public List<Prenda> ObtenerListadoPrendas()
        {
            return listadoPrendas;
        }
    }
}
