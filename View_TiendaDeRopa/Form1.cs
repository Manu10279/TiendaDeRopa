using Presenter_TiendaDeRopa;

namespace View_TiendaDeRopa
{
    public partial class Form1 : Form
    {
        TiendaRopaPresenter tiendaRopa;
        VendedorPresenter vendedorRopa;
        private string tipo, calidad;
        private int cantidad;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tiendaRopa = new TiendaRopaPresenter();
            vendedorRopa = new VendedorPresenter();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (RBComun.Checked && RBComun.Enabled)
            {
                tipo = "Pantalon Común";
            }
            else if (RBChupin.Checked && RBChupin.Enabled)
            {
                tipo = "Pantalon Chupin";
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
                tipo += " Cuello Común";
            }
            else if (RBCuelloMao.Checked && RBCuelloMao.Enabled)
            {
                tipo += " Cuello Mao";
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

        private void BDisponibilidad_Click(object sender, EventArgs e)
        {
            tiendaRopa.ObtenerPantalon(tipo, calidad, out cantidad);
            LStock.Text = $"Unidaded de Stock Disponibles de {tipo} {calidad}: {cantidad}";
        }

        private void BCotizar_Click(object sender, EventArgs e)
        {
            LPrecioFinal.Text = "$" + vendedorRopa.Cotizar(tipo, calidad, int.Parse(TBCantidad.Text), cantidad, double.Parse(TBPrecio.Text)).ToString("0.00");
        }
    }
}