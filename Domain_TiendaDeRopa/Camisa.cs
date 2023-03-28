using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_TiendaDeRopa
{
    public class Camisa : Prenda
    {
        public override string Calidad { get; }
        public override string Tipo { get; }
        public override string Cuello { get; }
    }
}
