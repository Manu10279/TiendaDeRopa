using Domain_TiendaDeRopa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View_TiendaDeRopa
{
    public partial class FormHistorialCotizacion : Form
    {
        //Atributos
        private List<Cotizacion> cotizaciones;

        //Form
        public FormHistorialCotizacion()
        {
            InitializeComponent();
        }

        private void FormHistorialCotizacion_Load(object sender, EventArgs e)
        {
            CargarCotizaciones();
        }

        private void FormHistorialCotizacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Evita que se cierre el formulario, solo lo oculta
            e.Cancel = true;
            Hide();
        }

        //Métodos
        public void CargarCotizaciones()
        {
            if (cotizaciones != null)
            {
                for (int i = DGVCotizaciones.RowCount - 1; i < cotizaciones.Count; i++)
                {
                    DGVCotizaciones.Rows.Add();
                    DGVCotizaciones.Rows[i].Cells[0].Value = cotizaciones[i].Id;
                    DGVCotizaciones.Rows[i].Cells[1].Value = cotizaciones[i].Codigo;
                    DGVCotizaciones.Rows[i].Cells[2].Value = cotizaciones[i].Prenda;
                    DGVCotizaciones.Rows[i].Cells[3].Value = cotizaciones[i].Cantidad;
                    DGVCotizaciones.Rows[i].Cells[4].Value = "$" + cotizaciones[i].PrecioFinal.ToString(cotizaciones[i].PrecioFinal % 1 == 0 ? "#,##0.00" : "#,##0.00");
                    DGVCotizaciones.Rows[i].Cells[5].Value = cotizaciones[i].Fecha.ToString("dd/MM/yyyy HH:mm:ss");
                }
            }
        }

        public void EnviarCotizacion(List<Cotizacion> cotizaciones)
        {
            this.cotizaciones = cotizaciones;
            CargarCotizaciones();
        }
    }
}
