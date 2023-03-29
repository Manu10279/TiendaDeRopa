using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_TiendaDeRopa;

namespace Presenter_TiendaDeRopa
{
    public class VendedorPresenter
    {
        private string nombre = "", apellido = "", codigo = "";

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public string Codigo { get => codigo; }


        public class FueraDeStock : Exception
        {
            public FueraDeStock(string mensaje) : base("Error: " + mensaje) { }
        }


        public bool Utiles(string nombre, string apellido, string codigo)
        {
            bool valido = true;

            foreach (char caracter in nombre) //Verifica si el nombre son solo letras
            {
                if (nombre != "" && !Char.IsLetter(caracter) && !Char.IsWhiteSpace(caracter)) //Nombre Formato
                {
                    valido = false;
                }
            }
            foreach (char caracter in apellido) //Verifica si el apellido son solo letras
            {
                if (apellido != "" && !Char.IsLetter(caracter) && !Char.IsWhiteSpace(caracter)) //Nombre Formato
                {
                    valido = false;
                }
            }

            if (valido == true) //Si es válido le asigna los datos al Vendedor
            {
                codigo = "2AFJX8";
                CambiarDatos(nombre, apellido, codigo);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CambiarDatos(string nombre, string apellido, string codigo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.codigo = codigo;
        }

        public double Cotizar(List<Prenda> listadoPrendas, string tipo, string calidad, int cantidadCotizar, int cantidad, double precioUnitario, string cuello)
        {
            if (cantidadCotizar < cantidad)
            {
                Cotizacion cotizacion = new Cotizacion(listadoPrendas, tipo, calidad, cantidadCotizar, precioUnitario, cuello);
                return cotizacion.PrecioFinal;
            }
            else
            {
                throw new FueraDeStock("No hay suficiente stock de ");
            }
        }
    }
}
