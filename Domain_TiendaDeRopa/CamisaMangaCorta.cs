using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_TiendaDeRopa
{
    public class CamisaMangaCorta : Camisa
    {
        private string calidad, tipo, cuello; //Propiedades de Objeto
        private static string calidadPedida = "", cuelloPedido = ""; //Input 
        private static int cantidadStandardComun = 0, cantidadPremiumComun = 0; //Cuello Común
        private static int cantidadStandardMao = 0, cantidadPremiumMao = 0; //Cuello Mao
        public override string Calidad
        {
            get
            {
                return calidad;
            }
        }
        public override string Tipo
        {
            get
            {
                return tipo;
            }
        }
        public override string Cuello
        {
            get
            {
                return cuello;
            }
        }

        public static int Cantidad
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

        public CamisaMangaCorta(string calidad, string cuello)
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
            this.cuello = cuello;
            tipo = "Camisa Manga Corta";
        }


        public void PedirCalidad(string calidad, string cuello)
        {
            calidadPedida = calidad;
            cuelloPedido = cuello;
        }
    }
}
