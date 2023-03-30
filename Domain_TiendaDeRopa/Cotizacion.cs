using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_TiendaDeRopa
{
    public class Cotizacion
    {
        //Atributos de la Cotización
        private static int ultimoId = 1;
        private int id = 0, cantidad = 0;
        private string codigo = "", prenda = "";
        private double precioFinal = 0.0;
        private DateTime fecha = DateTime.Now;

        //Propiedades de la Cotización
        public int Id { get => id; }
        public DateTime Fecha { get => fecha; }
        public int Cantidad { get => cantidad; }
        public string Codigo { get => codigo; }
        public string Prenda { get => prenda; }
        public double PrecioFinal { get => precioFinal; }

        //Métodos de la Cotización
        public Cotizacion(string codigo, string tipo, string calidad, string cuello, int cantidadCotizar, double precioUnitario)
        {
            id = ultimoId++;
            this.codigo = codigo;
            prenda = $"{tipo} {calidad} {cuello}";
            cantidad = cantidadCotizar;

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
        }
    }
}
