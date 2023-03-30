using Domain_TiendaDeRopa;
using Presenter_TiendaDeRopa;
using static System.Net.Mime.MediaTypeNames;

namespace View_TiendaDeRopa
{
    public partial class FormTiendaRopa : Form
    {
        FormConfigurarVendedor formConfigurarVendedor;
        FormHistorialCotizacion formHistorialCotizacion;
        TiendaRopaPresenter tiendaRopa;
        VendedorPresenter vendedor;

        private string calidad = "", tipo = "", cuello = "";
        private int cantidad, intentoInt;
        private float intentoFloat;

        public class FueraDeStock : Exception
        {
            public FueraDeStock(string mensaje) : base("Error: " + mensaje) { }
        }

        public FormTiendaRopa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tiendaRopa = new TiendaRopaPresenter();
            vendedor = new VendedorPresenter(tiendaRopa);
            formConfigurarVendedor = new FormConfigurarVendedor(vendedor);
            formHistorialCotizacion = new FormHistorialCotizacion();

            LNombreTienda.Text = "Nombre de la Tienda: " + tiendaRopa.Nombre;
            LDireccionTienda.Text = "Dirección de la Tienda: " + tiendaRopa.Direccion;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Declarando Datos del Vendedor Automáticamente
            LNombreVendedor.Text = $"Nombre del Vendedor: {vendedor.Nombre} {vendedor.Apellido}";
            LCodigoVendedor.Text = $"Código del Vendedor: {vendedor.Codigo}";

            //Declarando Tipo de Prenda Automáticamente
            if (RBComun.Checked && RBComun.Enabled)
            {
                tipo = "Pantalon Común";
                cuello = "";
            }
            else if (RBChupin.Checked && RBChupin.Enabled)
            {
                tipo = "Pantalon Chupin";
                cuello = "";
            }

            if (RBMangaCorta.Checked && RBMangaCorta.Enabled)
            {
                tipo = "Camisa Manga Corta";
            }
            else if (RBMangaLarga.Checked && RBMangaLarga.Enabled)
            {
                tipo = "Camisa Manga Larga";
            }

            if (RBCuelloComun.Checked && RBCuelloComun.Enabled)
            {
                cuello = "Cuello Común";
            }
            else if (RBCuelloMao.Checked && RBCuelloMao.Enabled)
            {
                cuello = "Cuello Mao";
            }

            //Declarando Calidad Automáticamente
            if (RBStandard.Checked)
            {
                calidad = "Standard";
            }
            else if (RBPremium.Checked)
            {
                calidad = "Premium";
            }

            //Mostrando Stock Atomáticamente
            Disponibilidad();

            //Marcando Errores Automáticamente
            if (TBPrecio.Text != "" && float.TryParse(TBPrecio.Text, out intentoFloat) == false) //Precio Formato
            {
                TBPrecio.BackColor = Color.Crimson;
            }
            else
            {
                TBPrecio.BackColor = Color.White;
            }

            try //Stock Insuficiente y Stock Formato
            {
                if (TBCantidad.Text != "" && int.Parse(TBCantidad.Text) > cantidad)
                {
                    TBCantidad.BackColor = Color.Crimson;
                }
                else
                {
                    TBCantidad.BackColor = Color.White;
                }
            }
            catch (FormatException)
            {
                TBCantidad.BackColor = Color.Crimson;
            }
        }

        private void RBCamisa_CheckedChanged(object sender, EventArgs e)
        {
            RBComun.Enabled = false;
            RBChupin.Enabled = false;
            RBMangaCorta.Enabled = true;
            RBMangaLarga.Enabled = true;
            RBCuelloComun.Enabled = true;
            RBCuelloMao.Enabled = true;
        }

        private void RBPantalon_CheckedChanged(object sender, EventArgs e)
        {
            RBComun.Enabled = true;
            RBChupin.Enabled = true;
            RBMangaCorta.Enabled = false;
            RBMangaLarga.Enabled = false;
            RBCuelloComun.Enabled = false;
            RBCuelloMao.Enabled = false;
        }

        private void Disponibilidad()
        {
            cantidad = tiendaRopa.ObtenerPrenda(tipo, calidad, cuello);
            LStock.Text = $"Unidaded de Stock Disponibles de {tipo} {calidad} {cuello}: {cantidad}";
        }

        private void BCotizar_Click(object sender, EventArgs e)
        {
            if (vendedor.Codigo != "")
            {
                try
                {
                    if (vendedor.Cotizar(tipo, calidad, int.Parse(TBCantidad.Text), cantidad, double.Parse(TBPrecio.Text), cuello) == false)
                    {
                        throw new FueraDeStock("No hay suficiente stock de ");
                    }
                    formHistorialCotizacion.EnviarCotizacion(vendedor.Cotizaciones);
                    LPrecioFinal.Text = "Última Cotización: $" + vendedor.Cotizaciones[vendedor.Cotizaciones.Count - 1].PrecioFinal.ToString("0.00");
                    LUltimaCotizacion.Text = $" {tipo} {calidad} {cuello} x{TBCantidad.Text}";
                }
                catch (FormatException)
                {
                    MessageBox.Show("Error: Se encontraron errores de formato", "Cotización");
                }
                catch (FueraDeStock ex)
                {
                    MessageBox.Show(ex.Message + $"{tipo} {calidad} {cuello}", "Cotización");
                }
            }
            else
            {
                MessageBox.Show("Error: Para realizar una cotización primero configure su usuario de Vendedor", "Cotización");
            }
        }

        private void BConfigurarVendedor_Click(object sender, EventArgs e)
        {
            formConfigurarVendedor.ShowDialog();
        }

        private void LLHistorialCotizacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formHistorialCotizacion.Show();
        }
    }
}