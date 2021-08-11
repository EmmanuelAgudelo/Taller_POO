namespace Taller_POO.Productos
{
    public class Producto
    {
        public string Codigo;
        public string Nombre;
        public int Precio;
        public int Cantidad;

        public Producto(string codigo, string nombre, int precio, int cantidad)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Cantidad = cantidad;
        }
    }
}