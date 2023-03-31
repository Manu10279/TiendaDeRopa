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
        //Atributos
        private string nombre = "", apellido = "", codigo = "";
        private List<Cotizacion> cotizaciones = new List<Cotizacion>();
        private Cotizacion cotizacion;
        private TiendaRopaPresenter tiendaRopa;
        private Prenda prendaSeleccionada;

        //Propiedades
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public string Codigo { get => codigo; }
        public List<Cotizacion> Cotizaciones { get => cotizaciones; }

        //Métodos
        public VendedorPresenter(TiendaRopaPresenter tiendaRopa)
        {
            this.tiendaRopa = tiendaRopa;
        }

        public bool Utiles(string nombre, string apellido) //Detecta errores de formato
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

        public void CambiarDatos(string nombre, string apellido, string codigo) //Asignación de datos del Vendedor
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.codigo = codigo;
        }

        public bool Cotizar(string tipo, string calidad, int cantidadCotizar, int cantidad, double precioUnitario, string cuello) //Si existe stock cotiza
        {
            if (cantidadCotizar <= cantidad)
            {
                foreach (object prendaDesconocida in tiendaRopa.ListadoPrendas)
                {
                    Type tipoPrenda = prendaDesconocida.GetType();
                    switch (tipoPrenda.Name)
                    {
                        case "PantalonComun":
                            PantalonComun pantalonComun = (PantalonComun)prendaDesconocida;
                            if (tipo == "Pantalon Común")
                            {
                                pantalonComun.CambiarPrecio(precioUnitario);
                                prendaSeleccionada = pantalonComun;
                            }
                            break;
                        case "PantalonChupin":
                            PantalonChupin pantalonChupin = (PantalonChupin)prendaDesconocida;
                            if (tipo == "Pantalon Chupin")
                            {
                                pantalonChupin.CambiarPrecio(precioUnitario);
                                prendaSeleccionada = pantalonChupin;
                            }
                            break;
                        case "CamisaMangaCorta":
                            CamisaMangaCorta camisaMangaCorta = (CamisaMangaCorta)prendaDesconocida;
                            if (tipo == "Camisa Manga Corta")
                            {
                                camisaMangaCorta.CambiarPrecio(precioUnitario);
                                prendaSeleccionada = camisaMangaCorta;
                            }
                            break;
                        case "CamisaMangaLarga":
                            CamisaMangaLarga camisaMangaLarga = (CamisaMangaLarga)prendaDesconocida;
                            if (tipo == "Camisa Manga Larga")
                            {
                                camisaMangaLarga.CambiarPrecio(precioUnitario);
                                prendaSeleccionada = camisaMangaLarga;
                            }
                            break;
                        default:
                            break;
                    }
                    
                }

                cotizacion = new Cotizacion(prendaSeleccionada.Precio, calidad, Codigo, tipo, cuello, cantidadCotizar);
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
