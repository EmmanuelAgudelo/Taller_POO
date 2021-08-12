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
            //Validación Productos
            var verfProductos = ListaProductos.Any(p => p.Codigo == codigo);
            while(verfProductos){
                    Console.WriteLine("El producto ya existe, por favor digite el nuevo código del producto:");
                    codigo = Console.ReadLine();
                    verfProductos = ListaProductos.Any(c => c.Codigo == codigo);
            }

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
            //Validación Productos
            var verfProducto = listaProductos.Any(p => p.Codigo == codigo);
            if (verfProducto){
            var producto = listaProductos.Where(p => p.Codigo == codigo).FirstOrDefault();
            Console.WriteLine("información del producto \n");
            Console.WriteLine($"Código del producto: {producto.Codigo}\nNombre del producto: {producto.Nombre}\nprecio del producto: {producto.Precio}\ncantidad disponible: {producto.Cantidad}");
            }else{
                while(!verfProducto){
                    Console.WriteLine("El producto NO ha sido encontrado, digite de nuevo");
                    codigo = Console.ReadLine();
                    verfProducto = listaProductos.Any(p => p.Codigo == codigo);
                    
                    if (verfProducto){
                        var producto = listaProductos.Where(p => p.Codigo == codigo).FirstOrDefault();
                        Console.WriteLine("información del producto \n");
                        Console.WriteLine($"Código del producto: {producto.Codigo}\nNombre del producto: {producto.Nombre}\nprecio del producto: {producto.Precio}\ncantidad disponible: {producto.Cantidad}");
                     }

                }

        } 
    }
    public void EditarProducto(List<Producto> listaProductos){
            Console.WriteLine("digite el codigo del producto");
            string codigo = Console.ReadLine();
            //Validación Productos
            var verfProductos = listaProductos.Any(p => p.Codigo == codigo);
            while(!verfProductos){
                    Console.WriteLine("El producto NO existe, por favor digite el nuevo código del producto:");
                    codigo = Console.ReadLine();
                    verfProductos = listaProductos.Any(c => c.Codigo == codigo);
            }

            var producto = listaProductos.Where(p => p.Codigo == codigo).FirstOrDefault();
            Console.WriteLine("información del producto \n");
            Console.WriteLine($"Código del producto: {producto.Codigo}\nNombre del producto: {producto.Nombre}\nprecio del producto: {producto.Precio}\ncantidad disponible: {producto.Cantidad}");
            Console.WriteLine("digite el nombre del producto");
            string nombre = Console.ReadLine();
            Console.WriteLine("digite el precio del producto");
            int precio = int.Parse(Console.ReadLine());
            Console.WriteLine("digite la cantidad del producto");
            int cantidad = int.Parse(Console.ReadLine());

            producto.Nombre = nombre;
            producto.Precio = precio;
            producto.Cantidad = cantidad;

            Console.WriteLine("producto editado satisfactoriamente");
        }

        public void EliminarProducto(List<Producto> listaProductos){
            Console.WriteLine("digite el codigo del producto");
            string codigo = Console.ReadLine();
            //Validación Productos
            var verfProductos = listaProductos.Any(p => p.Codigo == codigo);
            while(!verfProductos){
                    Console.WriteLine("El producto NO existe, por favor digite el nuevo código del producto:");
                    codigo = Console.ReadLine();
                    verfProductos = listaProductos.Any(c => c.Codigo == codigo);
            }
            var producto = listaProductos.Where(p => p.Codigo == codigo).FirstOrDefault();
            Console.WriteLine("información del producto \n");
            Console.WriteLine($"Código del producto: {producto.Codigo}\nNombre del producto: {producto.Nombre}\nprecio del producto: {producto.Precio}\ncantidad disponible: {producto.Cantidad}");
            listaProductos.Remove(producto);

            Console.WriteLine("producto eliminado satisfactoriamente");

        }
    }
}