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
        Prenda prenda;
        public List<Prenda> listadoPrendas = new List<Prenda>();
        
        public TiendaRopaPresenter()
        {
            //Instanciando Pantalones
            for (int i = 0; i < 250; i++) //Pantalon Común
            {
                prenda = new PantalonComun("Standard");
                listadoPrendas.Add(prenda);
                prenda = new PantalonComun("Premium");
                listadoPrendas.Add(prenda);
            }
            for (int i = 0; i < 750; i++) //Pantalon Chupin
            {
                prenda = new PantalonChupin("Standard");
                listadoPrendas.Add(prenda);
                prenda = new PantalonChupin("Premium");
                listadoPrendas.Add(prenda);
            }

            //Instanciando Camisas
            for (int i = 0; i < 150; i++)
            {
                prenda = new CamisaMangaCorta("Standard", "Cuello Común");
                listadoPrendas.Add(prenda);
                prenda = new CamisaMangaCorta("Premium", "Cuello Común");
                listadoPrendas.Add(prenda);
            }
            for (int i = 0; i < 100; i++)
            {
                prenda = new CamisaMangaCorta("Standard", "Cuello Mao");
                listadoPrendas.Add(prenda);
                prenda = new CamisaMangaCorta("Premium", "Cuello Mao");
                listadoPrendas.Add(prenda);
            }
            for (int i = 0; i < 175; i++)
            {
                prenda = new CamisaMangaLarga("Standard", "Cuello Común");
                listadoPrendas.Add(prenda);
                prenda = new CamisaMangaLarga("Premium", "Cuello Común");
                listadoPrendas.Add(prenda);
            }
            for (int i = 0; i < 75; i++)
            {
                prenda = new CamisaMangaLarga("Standard", "Cuello Mao");
                listadoPrendas.Add(prenda);
                prenda = new CamisaMangaLarga("Premium", "Cuello Mao");
                listadoPrendas.Add(prenda);
            }
        }

        public void ObtenerPrenda(string tipo, string calidad, string cuello, out int cantidad)
        {
            int cantPantalonComunS = 0, cantPantalonChupinS = 0, cantPantalonComunP = 0, cantPantalonChupinP = 0;
            int cantCamisaCCS = 0, cantCamisaCCP = 0, cantCamisaCMS = 0, cantCamisaCMP = 0;
            int cantCamisaLCS = 0, cantCamisaLCP = 0, cantCamisaLMS = 0, cantCamisaLMP = 0;

            //Contando Tipos de Prenda
            foreach (Prenda prendaDesconocida in listadoPrendas)
            {
                Type tipoPrenda = prendaDesconocida.GetType();

                if (tipoPrenda.Name == "PantalonComun" && prendaDesconocida.Calidad == "Standard")
                {
                    cantPantalonComunS++;
                }
                else if (tipoPrenda.Name == "PantalonComun" && prendaDesconocida.Calidad == "Premium")
                {
                    cantPantalonComunP++;
                }
                else if (tipoPrenda.Name == "PantalonChupin" && prendaDesconocida.Calidad == "Standard")
                {
                    cantPantalonChupinS++;
                }
                else if (tipoPrenda.Name == "PantalonChupin" && prendaDesconocida.Calidad == "Premium")
                {
                    cantPantalonChupinP++;
                }
                else if (tipoPrenda.Name == "CamisaMangaCorta" && prendaDesconocida.Calidad == "Standard" && prendaDesconocida.Cuello == "Cuello Común")
                {
                    cantCamisaCCS++;
                }
                else if (tipoPrenda.Name == "CamisaMangaCorta" && prendaDesconocida.Calidad == "Premium" && prendaDesconocida.Cuello == "Cuello Común")
                {
                    cantCamisaCCP++;
                }
                else if (tipoPrenda.Name == "CamisaMangaCorta" && prendaDesconocida.Calidad == "Standard" && prendaDesconocida.Cuello == "Cuello Mao")
                {
                    cantCamisaCMS++;
                }
                else if (tipoPrenda.Name == "CamisaMangaCorta" && prendaDesconocida.Calidad == "Premium" && prendaDesconocida.Cuello == "Cuello Mao")
                {
                    cantCamisaCMP++;
                }
                else if (tipoPrenda.Name == "CamisaMangaLarga" && prendaDesconocida.Calidad == "Standard" && prendaDesconocida.Cuello == "Cuello Común")
                {
                    cantCamisaLCS++;
                }
                else if (tipoPrenda.Name == "CamisaMangaLarga" && prendaDesconocida.Calidad == "Premium" && prendaDesconocida.Cuello == "Cuello Común")
                {
                    cantCamisaLCP++;
                }
                else if (tipoPrenda.Name == "CamisaMangaLarga" && prendaDesconocida.Calidad == "Standard" && prendaDesconocida.Cuello == "Cuello Mao")
                {
                    cantCamisaLMS++;
                }
                else if (tipoPrenda.Name == "CamisaMangaLarga" && prendaDesconocida.Calidad == "Premium" && prendaDesconocida.Cuello == "Cuello Mao")
                {
                    cantCamisaLMP++;
                }
            }

            //Estableciendo Cantidad y Calidad de la Prenda Solicitada
            if (calidad == "Standard")
            {
                switch (tipo)
                {
                    case "Pantalon Común":
                        prenda.Cantidad = cantPantalonComunS;
                        break;
                    case "Pantalon Chupin":
                        prenda.Cantidad = cantPantalonChupinS;
                        break;
                    case "Camisa Manga Corta":
                        if (cuello == "Cuello Común")
                        {
                            prenda.Cantidad = cantCamisaCCS;
                        }
                        else if (cuello == "Cuello Mao")
                        {
                            prenda.Cantidad = cantCamisaCMS;
                        }
                        break;
                    case "Camisa Manga Larga":
                        if (cuello == "Cuello Común")
                        {
                            prenda.Cantidad = cantCamisaLCS;
                        }
                        else if (cuello == "Cuello Mao")
                        {
                            prenda.Cantidad = cantCamisaLMS;
                        }
                        break;
                    default:
                        cantidad = 0;
                        break;
                }
            }
            else if (calidad == "Premium")
            {
                switch (tipo)
                {
                    case "Pantalon Común":
                        prenda.Cantidad = cantPantalonComunP;
                        break;
                    case "Pantalon Chupin":
                        prenda.Cantidad = cantPantalonChupinP;
                        break;
                    case "Camisa Manga Corta":
                        if (cuello == "Cuello Común")
                        {
                            prenda.Cantidad = cantCamisaCCP;
                        }
                        else if (cuello == "Cuello Mao")
                        {
                            prenda.Cantidad = cantCamisaCMP;
                        }
                        break;
                    case "Camisa Manga Larga":
                        if (cuello == "Cuello Común")
                        {
                            prenda.Cantidad = cantCamisaLCP;
                        }
                        else if (cuello == "Cuello Mao")
                        {
                            prenda.Cantidad = cantCamisaLMP;
                        }
                        break;
                    default:
                        cantidad = 0;
                        break;
                }
            }
            
            //Devolviendo Cantidad de la Prenda Solicitada 
            cantidad = prenda.Cantidad;
        }
        
    }
}
