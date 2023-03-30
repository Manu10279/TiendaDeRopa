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
        //Atributos del Vendedor
        private string nombre = "", apellido = "", codigo = "";
        private TiendaRopaPresenter tiendaRopa;
        private List<Cotizacion> cotizaciones = new List<Cotizacion>();

        //Propiedades del Vendedor
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public string Codigo { get => codigo; }
        public TiendaRopaPresenter Tienda { get => tiendaRopa; }
        public List<Cotizacion> Cotizaciones { get => cotizaciones; }

        //Métodos del Vendedor
        public VendedorPresenter(TiendaRopaPresenter tiendaRopa) //Constructor Declara Propiedad Tienda
        {
            this.tiendaRopa = tiendaRopa;
        }

        public bool Utiles(string nombre, string apellido) //Detecta Errores de Formato
        {
            bool valido = true;

            foreach (char caracter in nombre) //Verifica si el nombre son solo letras
            {
                if (nombre != "" && !Char.IsLetter(caracter) && !Char.IsWhiteSpace(caracter))
                {
                    valido = false;
                }
            }
            foreach (char caracter in apellido) //Verifica si el apellido son solo letras
            {
                if (apellido != "" && !Char.IsLetter(caracter) && !Char.IsWhiteSpace(caracter))
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

        public void CambiarDatos(string nombre, string apellido, string codigo) //Asignación de Datos del Vendedor
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.codigo = codigo;
        }

        public bool Cotizar(string tipo, string calidad, int cantidadCotizar, int cantidad, double precioUnitario, string cuello) //Si Existe Stock Cotiza
        {
            if (cantidadCotizar < cantidad)
            {
                Cotizacion cotizacion = new Cotizacion(Codigo, tipo, calidad, cuello, cantidadCotizar, precioUnitario);
                cotizaciones.Add(cotizacion);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
