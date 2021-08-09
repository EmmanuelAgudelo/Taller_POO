using System;
using System.Collections.Generic;
using System.Linq;

namespace Taller_POO.Productos
{
    public class ProductoServices
    {
        public void AddProduct(List<Producto> ListaProductos)
        {
            Console.WriteLine("digite el codigo del producto");
            string codigo = Console.ReadLine();
            Console.WriteLine("digite el nombre del producto");
            string nombre = Console.ReadLine();
            Console.WriteLine("digite el precio del producto");
            int precio = int.Parse(Console.ReadLine());
            Console.WriteLine("digite la cantidad del producto");
            int cantidad = int.Parse(Console.ReadLine());

            var producto = new Producto(codigo, nombre, precio, cantidad);
            ListaProductos.Add(producto);
            Console.WriteLine("Producto añadido satisfactoriamente");

        }
        public void BuscarProducto(List<Producto> listaProductos)
        {
            Console.WriteLine("digite el codigo del producto");
            string codigo = Console.ReadLine();

            var producto = listaProductos.Where(p => p.codigo == codigo).FirstOrDefault();

            Console.WriteLine("información del producto \n");
            Console.WriteLine($"Código del producto: {producto.codigo}\nNombre del producto: {producto.nombre}\nprecio del producto: {producto.precio}\ncantidad disponible: {producto.cantidad}");

        }
        public void EditarProducto(List<Producto> listaProductos)
        {
            Console.WriteLine("digite el codigo del producto");
            string codigo = Console.ReadLine();

            var producto = listaProductos.Where(p => p.codigo == codigo).FirstOrDefault();

            Console.WriteLine("información del producto \n");
            Console.WriteLine($"Código del producto: {producto.codigo}\nNombre del producto: {producto.nombre}\nprecio del producto: {producto.precio}\ncantidad disponible: {producto.cantidad}");
            Console.WriteLine("digite el nombre del producto");
            string nombre = Console.ReadLine();
            Console.WriteLine("digite el precio del producto");
            int precio = int.Parse(Console.ReadLine());
            Console.WriteLine("digite la cantidad del producto");
            int cantidad = int.Parse(Console.ReadLine());

            producto.nombre = nombre;
            producto.precio = precio;
            producto.cantidad = cantidad;

            Console.WriteLine("producto editado satisfactoriamente");
        }

        public void EliminarProducto(List<Producto> listaProductos)
        {
            Console.WriteLine("digite el codigo del producto");
            string codigo = Console.ReadLine();

            var producto = listaProductos.Where(p => p.codigo == codigo).FirstOrDefault();
            Console.WriteLine("información del producto \n");
            Console.WriteLine($"Código del producto: {producto.codigo}\nNombre del producto: {producto.nombre}\nprecio del producto: {producto.precio}\ncantidad disponible: {producto.cantidad}");
            listaProductos.Remove(producto);

            Console.WriteLine("producto eliminado satisfactoriamente");

        }
    }
}