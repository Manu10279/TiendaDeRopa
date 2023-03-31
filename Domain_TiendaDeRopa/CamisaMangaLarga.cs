using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_TiendaDeRopa
{
    public class CamisaMangaLarga : Camisa
    {
        //Atributos
        private static int cantidadStandardComun = 0, cantidadPremiumComun = 0;
        private static int cantidadStandardMao = 0, cantidadPremiumMao = 0;

        //Propiedades
        public override int Cantidad
        {
            get
            {
                if (cuelloPedido == "Cuello Común")
                {
                    if (calidadPedida == "Standard")
                    {
                        return cantidadStandardComun;
                    }
                    else if (calidadPedida == "Premium")
                    {
                        return cantidadPremiumComun;
                    }
                }
                else if (cuelloPedido == "Cuello Mao")
                {
                    if (calidadPedida == "Standard")
                    {
                        return cantidadStandardMao;
                    }
                    else if (calidadPedida == "Premium")
                    {
                        return cantidadPremiumMao;
                    }
                }
                return 0;
            }
        }
        
        //Métodos
        public CamisaMangaLarga(string calidad, string cuello)
        {
            if (cuello == "Cuello Común")
            {
                if (calidad == "Standard")
                {
                    cantidadStandardComun++;
                }
                else if (calidad == "Premium")
                {
                    cantidadPremiumComun++;
                }
            }
            else if (cuello == "Cuello Mao")
            {
                if (calidad == "Standard")
                {
                    cantidadStandardMao++;
                }
                else if (calidad == "Premium")
                {
                    cantidadPremiumMao++;
                }
            }
            this.calidad = calidad;
        }
    }
}
