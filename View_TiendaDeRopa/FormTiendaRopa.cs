using Domain_TiendaDeRopa;
using Presenter_TiendaDeRopa;
using System.Globalization;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using static View_TiendaDeRopa.FormConfigurarVendedor;

namespace View_TiendaDeRopa
{
    public partial class FormTiendaRopa : Form
    {
        //Atributos
        private FormConfigurarVendedor formConfigurarVendedor;
        private FormHistorialCotizacion formHistorialCotizacion;
        private TiendaRopaPresenter tiendaRopa;
        private VendedorPresenter vendedor;
        private string calidad = "", tipo = "", cuello = "";
        private int cantidad = 0;
        private float intentoFloat;

        //Excepciones
        public class FueraDeStockException : Exception
        {
            public FueraDeStockException() : base("Error: No hay suficiente stock de ") { }
        }

        public class ComaException : Exception
        {
            public ComaException() : base("Error: Los números decimales deben ser ingresados con coma") { }
        }

        public class EnteroException : Exception
        {
            public EnteroException() : base("Error: La cantidad solo puede ser un número entero") { }
        }

        //Form
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
            CambioPrenda();
            Disponibilidad();
        }

        private void timer_Tick(object sender, EventArgs e) //Marcando Errores Automáticamente
        {
            if (TBPrecio.Text != "" && float.TryParse(TBPrecio.Text, out intentoFloat) == false) //Precio Formato
            {
                TBPrecio.BackColor = Color.Crimson;
            }
            else if (TBPrecio.Text.Contains(".") == true)
            {
                TBPrecio.BackColor = Color.Crimson;
            }
            else
            {
                TBPrecio.BackColor = Color.White;
            }

            try //Stock Formato y Stock Insuficiente 
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
            CambioPrenda();
            Disponibilidad();
        }

        private void RBPantalon_CheckedChanged(object sender, EventArgs e)
        {
            RBComun.Enabled = true;
            RBChupin.Enabled = true;
            RBMangaCorta.Enabled = false;
            RBMangaLarga.Enabled = false;
            RBCuelloComun.Enabled = false;
            RBCuelloMao.Enabled = false;
            CambioPrenda();
            Disponibilidad();
        }

        private void RBMangaCorta_CheckedChanged(object sender, EventArgs e)
        {
            CambioPrenda();
            Disponibilidad();
        }

        private void RBMangaLarga_CheckedChanged(object sender, EventArgs e)
        {
            CambioPrenda();
            Disponibilidad();
        }

        private void RBCuelloComun_CheckedChanged(object sender, EventArgs e)
        {
            CambioPrenda();
            Disponibilidad();
        }

        private void RBCuelloMao_CheckedChanged(object sender, EventArgs e)
        {
            CambioPrenda();
            Disponibilidad();
        }

        private void RBComun_CheckedChanged(object sender, EventArgs e)
        {
            CambioPrenda();
            Disponibilidad();
        }

        private void RBChupin_CheckedChanged(object sender, EventArgs e)
        {
            CambioPrenda();
            Disponibilidad();
        }

        private void RBStandard_CheckedChanged(object sender, EventArgs e)
        {
            CambioPrenda();
            Disponibilidad();
        }

        private void RBPremium_CheckedChanged(object sender, EventArgs e)
        {
            CambioPrenda();
            Disponibilidad();
        }

        private void BCotizar_Click(object sender, EventArgs e)
        {
            if (vendedor.Codigo != "")
            {
                try
                {
                    foreach (char caracter in TBPrecio.Text)
                    {
                        if (TBPrecio.Text.Contains(".") == true) //El precio solo puede contener comas
                        {
                            throw new ComaException();
                        }
                    }
                    if (TBCantidad.Text.Contains(".") == true || TBCantidad.Text.Contains(",") == true) //La cantidad solo puede ser entera
                    {
                        throw new EnteroException();
                    }
                    if (vendedor.Cotizar(tipo, calidad, int.Parse(TBCantidad.Text), cantidad, double.Parse(TBPrecio.Text), cuello) == false) //La cantidad no puede ser mayor que el stock
                    {
                        throw new FueraDeStockException();
                    }
                    formHistorialCotizacion.EnviarCotizacion(vendedor.Cotizaciones);
                    LPrecioFinal.Text = "Última Cotización: $" + vendedor.Cotizaciones[vendedor.Cotizaciones.Count - 1].PrecioFinal.ToString(vendedor.Cotizaciones[vendedor.Cotizaciones.Count - 1].PrecioFinal % 1 == 0 ? "#,##0.00" : "#,##0.00");
                    LUltimaCotizacion.Text = $" {tipo} {calidad} {cuello} x{TBCantidad.Text}";
                }
                catch (FormatException)
                {
                    MessageBox.Show("Error: Se encontraron errores de formato", "Cotización");
                }
                catch (ComaException ex)
                {
                    MessageBox.Show(ex.Message, "Cotización");
                }
                catch (EnteroException ex)
                {
                    MessageBox.Show(ex.Message, "Cotización");
                }
                catch (FueraDeStockException ex)
                {
                    MessageBox.Show(ex.Message + $"{tipo} {calidad} {cuello}", "Cotización");
                }
            }
            else
            {
                MessageBox.Show("Error: Para realizar una cotización primero configure su usuario de Vendedor", "Cotización");
                LNombreVendedor.ForeColor = Color.Crimson;
                LCodigoVendedor.ForeColor = Color.Crimson;
            }
        }

        private void BConfigurarVendedor_Click(object sender, EventArgs e)
        {
            formConfigurarVendedor.ShowDialog();
            LNombreVendedor.Text = $"Nombre del Vendedor: {vendedor.Nombre} {vendedor.Apellido}";
            LCodigoVendedor.Text = $"Código del Vendedor: {vendedor.Codigo}";

            if (vendedor.Codigo != "")
            {
                LNombreVendedor.ForeColor = Color.Black;
                LCodigoVendedor.ForeColor = Color.Black;
            }
        }

        private void LLHistorialCotizacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formHistorialCotizacion.Show();
        }

        //Métodos
        private void CambioPrenda()
        {
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

            if (RBStandard.Checked)
            {
                calidad = "Standard";
            }
            else if (RBPremium.Checked)
            {
                calidad = "Premium";
            }
        }

        private void Disponibilidad()
        {
            cantidad = tiendaRopa.ObtenerPrenda(tipo, calidad, cuello);
            LStock.Text = $"Stock Disponible de {tipo} {calidad} {cuello}: {cantidad}";
        }
    }
}