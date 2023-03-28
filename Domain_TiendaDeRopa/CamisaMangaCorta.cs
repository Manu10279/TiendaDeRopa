using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_TiendaDeRopa
{
    public class CamisaMangaCorta : Camisa
    {
        private string calidad, tipo, cuello;
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
                return cuello;
            }
        }

        public CamisaMangaCorta(string calidad, string cuello)
        {
            this.calidad = calidad;
            this.cuello = cuello;
            tipo = "Camisa Manga Corta";
        }
    }
}
