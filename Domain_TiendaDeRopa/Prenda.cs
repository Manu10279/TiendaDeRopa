using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_TiendaDeRopa
{
    public abstract class Prenda
    {
        public abstract string Calidad { get; }
        public abstract string Tipo { get; }
        public int Cantidad { get; set; }
    }
}
