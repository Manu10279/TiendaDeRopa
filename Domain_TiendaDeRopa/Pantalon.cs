using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_TiendaDeRopa
{
    public abstract class Pantalon : Prenda 
    {
        //Métodos
        public void DatosSolicitados(string calidad)
        {
            calidadPedida = calidad;
        }
    }
}