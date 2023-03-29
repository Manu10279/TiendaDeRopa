using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_TiendaDeRopa
{
    public class Vendedor
    {
        private string nombre = "", apellido = "", codigo = "";

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public string Codigo { get => codigo; }

        public void CambiarDatos(string nombre, string apellido, string codigo) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.codigo = codigo;
        }
    }
}
