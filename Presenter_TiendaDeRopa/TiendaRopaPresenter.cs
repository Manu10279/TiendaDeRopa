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
        //Atributos de la Tienda
        private string nombre = "Quark", direccion = "Emilio Civit 484, Mendoza";
        private ArrayList listadoPrendas = new ArrayList();
        private Pantalon pantalon;
        private Camisa camisa;

        //Propiedades de la Tienda
        public string Nombre { get => nombre; }
        public string Direccion { get => direccion; }
        public ArrayList ListadoPrendas { get => listadoPrendas; }
        
        //Métodos de la Tienda
        public TiendaRopaPresenter() //Constructor instancia Pantalones y Camisas
        {
            //Instanciando Pantalones
            for (int i = 0; i < 250; i++) //Pantalon Común
            {
                pantalon = new PantalonComun("Standard");
                listadoPrendas.Add(pantalon);
                pantalon = new PantalonComun("Premium");
                listadoPrendas.Add(pantalon);
            }
            for (int i = 0; i < 750; i++) //Pantalon Chupin
            {
                pantalon = new PantalonChupin("Standard");
                listadoPrendas.Add(pantalon);
                pantalon = new PantalonChupin("Premium");
                listadoPrendas.Add(pantalon);
            }

            //Instanciando Camisas
            for (int i = 0; i < 150; i++) //Camisa Manga Corta cuello común
            {
                camisa = new CamisaMangaCorta("Standard", "Cuello Común");
                listadoPrendas.Add(camisa);
                camisa = new CamisaMangaCorta("Premium", "Cuello Común");
                listadoPrendas.Add(camisa);
            }
            for (int i = 0; i < 100; i++) //Camisa Manga Corta cuello mao
            {
                camisa = new CamisaMangaCorta("Standard", "Cuello Mao");
                listadoPrendas.Add(camisa);
                camisa = new CamisaMangaCorta("Premium", "Cuello Mao");
                listadoPrendas.Add(camisa);
            }
            for (int i = 0; i < 175; i++) //Camisa Manga Larga cuello común
            {
                camisa = new CamisaMangaLarga("Standard", "Cuello Común");
                listadoPrendas.Add(camisa);
                camisa = new CamisaMangaLarga("Premium", "Cuello Común");
                listadoPrendas.Add(camisa);
            }
            for (int i = 0; i < 75; i++) //Camisa Manga Larga cuello mao
            {
                camisa = new CamisaMangaLarga("Standard", "Cuello Mao");
                listadoPrendas.Add(camisa);
                camisa = new CamisaMangaLarga("Premium", "Cuello Mao");
                listadoPrendas.Add(camisa);
            }
        }

        public int ObtenerPrenda(string tipo, string calidad, string cuello) //Obtiene la Cantidad de una Prenda Específica
        {
            foreach (object prendaDesconocida in listadoPrendas) //Recorriendo listadoPrendas e identificando sus Propiedades
            {
                Type tipoPrenda = prendaDesconocida.GetType();
                switch (tipoPrenda.Name)
                {
                    case "PantalonComun":
                        PantalonComun pantalonComun = (PantalonComun)prendaDesconocida;
                        if (tipo == "Pantalon Común")
                        {
                            pantalonComun.DatosSolicitados(calidad);
                            return pantalonComun.Cantidad;
                        }
                        break;
                    case "PantalonChupin":
                        PantalonChupin pantalonChupin = (PantalonChupin)prendaDesconocida;
                        if (tipo == "Pantalon Chupin")
                        {
                            pantalonChupin.DatosSolicitados(calidad);
                            return pantalonChupin.Cantidad;
                        }
                        break;
                    case "CamisaMangaCorta":
                        CamisaMangaCorta camisaMangaCorta = (CamisaMangaCorta)prendaDesconocida;
                        if (tipo == "Camisa Manga Corta")
                        {
                            camisaMangaCorta.DatosSolicitados(calidad, cuello);
                            return camisaMangaCorta.Cantidad;
                        }
                        break;
                    case "CamisaMangaLarga":
                        CamisaMangaLarga camisaMangaLarga = (CamisaMangaLarga)prendaDesconocida;
                        if (tipo == "Camisa Manga Larga")
                        {
                            camisaMangaLarga.DatosSolicitados(calidad, cuello);
                            return camisaMangaLarga.Cantidad;
                        }
                        break;
                    default:
                        break;
                }
            }
            return 0;
        }
    }
}
