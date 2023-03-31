using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_TiendaDeRopa
{
    public class Camisa : Prenda
    {
        //Atributos
        protected string cuelloPedido = "";

        //Métodos
        public void DatosSolicitados(string calidad, string cuello)
        {
            calidadPedida = calidad;
            cuelloPedido = cuello;
        }
    }
}
