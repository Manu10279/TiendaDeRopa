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
            for (int i = 0; i < 250; i++)
            {
                prenda = new PantalonComun("Standard");
                listadoPrendas.Add(prenda);
                prenda = new PantalonComun("Premium");
                listadoPrendas.Add(prenda);
            }
            for (int i = 0; i < 750; i++)
            {
                prenda = new PantalonChupin("Standard");
                listadoPrendas.Add(prenda);
                prenda = new PantalonChupin("Premium");
                listadoPrendas.Add(prenda);
            }
        }

        public void ObtenerPantalon(string tipo, string calidad, out int cantidad)
        {
            int cantPantalonComunS = 0, cantPantalonChupinS = 0, cantPantalonComunP = 0, cantPantalonChupinP = 0;

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
            }

            //Estableciendo Cantidad de la Prenda Solicitada
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
