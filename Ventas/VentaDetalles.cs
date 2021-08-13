namespace Taller_POO.Ventas
{
    public class VentaDetalles
    {
        public string nombre;
        public int precio;
        public int cantidad;

        public VentaDetalles(string nombre, int precio, int cantidad)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

    }
}