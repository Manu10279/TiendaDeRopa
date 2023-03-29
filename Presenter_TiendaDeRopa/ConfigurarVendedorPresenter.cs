using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_TiendaDeRopa;

namespace Presenter_TiendaDeRopa
{
    public class ConfigurarVendedorPresenter
    {
        Vendedor vendedor;

        public ConfigurarVendedorPresenter()
        {
            vendedor = new Vendedor();
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
                vendedor.CambiarDatos(nombre, apellido, codigo);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ObtenerDatosVendedor(out string nombre, out string apellido, out string codigo)
        {
            nombre = vendedor.Nombre;
            apellido = vendedor.Apellido;
            codigo = vendedor.Codigo;
        }
    }
}
