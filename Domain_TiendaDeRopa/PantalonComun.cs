using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_TiendaDeRopa
{
    public class PantalonComun : Pantalon
    {
        private string calidad;
        private string tipo;
        public override string Calidad
        {
            get
            {
                return calidad;
            }
        }
        public override string Tipo 
        { 
            get 
            { 
                return tipo; 
            } 
        }
        public override string Cuello
        {
            get
            {
                return "";
            }
        }

        public PantalonComun(string calidad)
        {
            this.calidad = calidad;
            tipo = "Pantalon Común";
        }
    }
}
