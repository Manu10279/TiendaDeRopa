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
        //Atributos
        private VendedorPresenter vendedor;

        //Excepciones
        public class NoString : Exception
        {
            public NoString(string mensaje) : base("Error: " + mensaje) { }
        }

        //Form
        public FormConfigurarVendedor(VendedorPresenter configurarVendedor)
        {
            InitializeComponent();
            this.vendedor = configurarVendedor;
        }

        private void FormConfigurarVendedor_Load(object sender, EventArgs e)
        {
            TBVendedorNombre.Text = vendedor.Nombre;
            TBVendedorApellido.Text = vendedor.Apellido;
            LVendedorCodigo.Text = "Código: " + vendedor.Codigo;
            BGuardar.Text = "Guardar";
        }

        private void timer_Tick(object sender, EventArgs e) //Marcando Errores Automáticamente
        {
            if (TBVendedorNombre.Text != "")
            {
                try
                {
                    foreach (char caracter in TBVendedorNombre.Text)
                    {
                        if (!Char.IsLetter(caracter) && !Char.IsWhiteSpace(caracter)) //Nombre Formato
                        {
                            throw new NoString("");
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
                        if (!Char.IsLetter(caracter) && !Char.IsWhiteSpace(caracter)) //Nombre Formato
                        {
                            throw new NoString("");
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
                    if (vendedor.Utiles(TBVendedorNombre.Text, TBVendedorApellido.Text) == false)
                    {
                        throw new NoString("Escriba solo letras");
                    }
                    BGuardar.Text = "Guardado";
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
            LVendedorCodigo.Text = "Código: " + vendedor.Codigo;
        }
    }
}
