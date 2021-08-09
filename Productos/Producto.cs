namespace Taller_POO.Productos
{
    public class Producto
    {
        public string codigo;
        public string nombre;
        public int precio;
        public int cantidad;

        public Producto(string codigo, string nombre, int precio, int cantidad)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }
    }
}