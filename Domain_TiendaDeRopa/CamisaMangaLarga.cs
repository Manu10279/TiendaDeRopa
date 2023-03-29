using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_TiendaDeRopa
{
    public class CamisaMangaLarga : Camisa
    {
        private string calidad, tipo, cuello; //Propiedades de Objeto
        private static string calidadPedida = "", cuelloPedido = ""; //Input 
        private static int cantidadStandardComun = 0, cantidadPremiumComun = 0; //Propiedad Cantidad Posible: Cuello Común
        private static int cantidadStandardMao = 0, cantidadPremiumMao = 0; //Propiedad Cantidad Posible: Cuello Mao

        public override string Calidad { get => calidad; }
        public override string Tipo { get => tipo; }
        public override string Cuello { get => cuello; }
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
            this.cuello = cuello;
            tipo = "Camisa Manga Larga";
        }

        public void DatosSolicitados(string calidad, string cuello)
        {
            calidadPedida = calidad;
            cuelloPedido = cuello;
        }

        public void Cotizar(string calidad, string cuello)
        {
            if (cuello == "Cuello Común")
            {
                if (calidad == "Standard")
                {
                    cantidadStandardComun--;
                }
                else if (calidad == "Premium")
                {
                    cantidadPremiumComun--;
                }
            }
            else if (cuello == "Cuello Mao")
            {
                if (calidad == "Standard")
                {
                    cantidadStandardMao--;
                }
                else if (calidad == "Premium")
                {
                    cantidadPremiumMao--;
                }
            }
        }
    }
}
