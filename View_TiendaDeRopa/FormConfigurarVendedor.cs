using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain_TiendaDeRopa;
using Presenter_TiendaDeRopa;

namespace View_TiendaDeRopa
{
    public partial class FormConfigurarVendedor : Form
    {
        public ConfigurarVendedorPresenter configurarVendedor;
        private int intentoInt;
        private string nombre = "", apellido = "", codigo = "";
        private float intentoFloat;

        public class NoString : Exception
        {
            public NoString(string mensaje) : base("Error: " + mensaje) { }
        }

        public FormConfigurarVendedor()
        {
            InitializeComponent();
        }

        private void FormConfigurarVendedor_Load(object sender, EventArgs e)
        {
            configurarVendedor = new ConfigurarVendedorPresenter();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (TBVendedorNombre.Text != "")
            {
                try
                {
                    foreach (char caracter in TBVendedorNombre.Text)
                    {
                        if (TBVendedorNombre.Text != "" && !Char.IsLetter(caracter) && !Char.IsWhiteSpace(caracter)) //Nombre Formato
                        {
                            throw new NoString("Escriba solo letras");
                        }
                        else
                        {
                            TBVendedorNombre.BackColor = Color.White;
                        }
                    }
                }
                catch (NoString)
                {
                    TBVendedorNombre.BackColor = Color.Crimson;
                }
            }
            else
            {
                TBVendedorNombre.BackColor = Color.White;
            }

            if (TBVendedorApellido.Text != "")
            {
                try
                {
                    foreach (char caracter in TBVendedorApellido.Text)
                    {
                        if (TBVendedorApellido.Text != "" && !Char.IsLetter(caracter) && !Char.IsWhiteSpace(caracter)) //Nombre Formato
                        {
                            throw new NoString("Escriba solo letras");
                        }
                        else
                        {
                            TBVendedorApellido.BackColor = Color.White;
                        }
                    }
                }
                catch (NoString)
                {
                    TBVendedorApellido.BackColor = Color.Crimson;
                }
            }
            else
            {
                TBVendedorApellido.BackColor = Color.White;
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TBVendedorNombre.Text != "" && TBVendedorApellido.Text != "")
                {
                    if (configurarVendedor.Utiles(TBVendedorNombre.Text, TBVendedorApellido.Text, codigo) == false)
                    {
                        throw new NoString("Escriba solo letras");
                    }
                    Text = "Guardado";
                }
                if (TBVendedorNombre.Text == "")
                {
                    throw new NoString("Ingrese un Nombre");
                }
                else if (TBVendedorApellido.Text == "")
                {
                    throw new NoString("Ingrese un Apellido");
                }
            }
            catch (NoString ex)
            {
                MessageBox.Show(ex.Message, "Configurar Vendedor");
            }
            configurarVendedor.ObtenerDatosVendedor(out nombre, out apellido, out codigo);
        }

        public void ObtenerDatos(out string nombre, out string apellido, out string codigo)
        {
            nombre = this.nombre;
            apellido = this.apellido;
            codigo = this.codigo;
        }
    }
}
