using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_TiendaDeRopa
{
    public class PantalonChupin : Pantalon
    {
        private string calidadHijo;
        private string tipoHijo;
        public override string Calidad
        {
            get
            {
                return calidadHijo;
            }
        }
        public override string Tipo
        {
            get
            {
                return tipoHijo;
            }
        }
        public override string Cuello
        {
            get
            {
                return "";
            }
        }

        public PantalonChupin(string calidad)
        {
            calidadHijo = calidad;
            tipoHijo = "Pantalon Chupin";
        }
    }
}
