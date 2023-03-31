namespace Domain_TiendaDeRopa
{
    public abstract class Prenda
    {
        //Atributos
        protected string calidad = "", calidadPedida = "";
        protected double precio = 0.00;

        //Propiedades
        public virtual string Calidad { get => calidad; }
        public virtual double Precio { get => precio; }
        public virtual int Cantidad { get; }
        
        //Métodos
        public void CambiarPrecio(double precio)
        {
            this.precio = precio;
        }
    }
}
