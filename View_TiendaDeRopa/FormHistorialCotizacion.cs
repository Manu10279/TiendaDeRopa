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
        private List<Cotizacion> cotizaciones;

        public FormHistorialCotizacion()
        {
            InitializeComponent();
        }

        private void FormHistorialCotizacion_Load(object sender, EventArgs e)
        {
            CargarCotizaciones();
        }

        public void EnviarCotizacion(List<Cotizacion> cotizaciones)
        {
            this.cotizaciones = cotizaciones;
            CargarCotizaciones();
        }

        public void CargarCotizaciones()
        {
            if (cotizaciones != null)
            {
                for (int i = DGVCotizaciones.RowCount-1; i < cotizaciones.Count; i++)
                {
                    DGVCotizaciones.Rows.Add();
                    DGVCotizaciones.Rows[i].Cells[0].Value = cotizaciones[i].Id;
                    DGVCotizaciones.Rows[i].Cells[1].Value = cotizaciones[i].Fecha.ToString("dd/MM/yyyy HH:mm:ss");
                    DGVCotizaciones.Rows[i].Cells[2].Value = cotizaciones[i].Cantidad;
                    DGVCotizaciones.Rows[i].Cells[3].Value = cotizaciones[i].Codigo;
                    DGVCotizaciones.Rows[i].Cells[4].Value = cotizaciones[i].Prenda;
                    DGVCotizaciones.Rows[i].Cells[5].Value = "$" + cotizaciones[i].PrecioFinal.ToString("0.00");
                }
                Text = cotizaciones[0].Id.ToString();
            }
            
        }

        private void FormHistorialCotizacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Evita que se cierre el formulario, solo lo oculta
            e.Cancel = true;
            Hide();
        }
    }
}
