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
        public override string Calidad { get; }
        public override string Tipo { get; }
    }
}