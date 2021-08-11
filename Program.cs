﻿using System;
using System.Collections.Generic;
using Taller_POO.Cliente;
using Taller_POO.Productos;
namespace Desktop
{
    class Program
    {
        public static void programa()

        {
            Console.WriteLine("¿desea ingresar al sistema?");
            string pregunta = Console.ReadLine();

            if (pregunta.Equals("si", StringComparison.OrdinalIgnoreCase))
            {
                var ListaClientes = new List<Cliente>();
                ListaClientes.Add(new Cliente("1214512678", "Roberto", "calle 48 #34-36", "3421561278"));
                ListaClientes.Add(new Cliente("1214514167", "Alberto", "calle 52 #12-14", "3215435789"));
                ListaClientes.Add(new Cliente("1214556778", "Emmanuelo", "calle 78 20-22", "3421446758"));
                ListaClientes.Add(new Cliente("1214534757", "Pedrosky", "calle 24 #24-26", "3153456676"));
                ListaClientes.Add(new Cliente("1564788989", "Admin ", "calle 28 #26-28", "3645767879"));
                ListaClientes.Add(new Cliente("1564786799", "Julieta ", "calle 28 #30-32", "3645797879"));
                ListaClientes.Add(new Cliente("1564778989", "Nilo ", "calle 29 #44-46", "3645347879"));
                ListaClientes.Add(new Cliente("1564728989", "Anselmo", "calle 30 #26-28", "3644667879"));
                ListaClientes.Add(new Cliente("1564758989", "Aura", "calle 40 #46-48", "3645763779"));
                ListaClientes.Add(new Cliente("1564808980", "Pascuala ", "calle 20 #46-48", "3645744879"));

                var ListaProductos = new List<Producto>();
                ListaProductos.Add(new Producto("1215", "Arroz", 3000, 16));
                ListaProductos.Add(new Producto("1456", "Papa", 2000, 40));
                ListaProductos.Add(new Producto("1128", "Aguacate", 2000, 20));
                ListaProductos.Add(new Producto("1459", "Manzana", 1200, 20));
                ListaProductos.Add(new Producto("1486", "Limpido", 4000, 20));
                ListaProductos.Add(new Producto("1557", "Jabon", 3000, 30));
                ListaProductos.Add(new Producto("1647", "Pera", 1700, 10));
                ListaProductos.Add(new Producto("1888", "Avena", 3000, 15));
                ListaProductos.Add(new Producto("1657", "Mortadela", 5000, 15));
                ListaProductos.Add(new Producto("1688", "panela", 4000, 20));

                while (pregunta.Equals("si", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"-----------------nombre de la empresa-----------------");
                    Console.WriteLine("Digite a que modulo desea ingresar");
                    Console.WriteLine("1.Módulo de clientes");
                    Console.WriteLine("2.Módulo de productos");
                    Console.WriteLine("3.Módulo de venta");
                    Console.WriteLine("4.Módulo de reportes");
                    Console.WriteLine("5.Módulo de configuración");
                    int modulo = int.Parse(Console.ReadLine());
                    if (modulo == 1)
                    {
                        string preguntaModuloCliente = "si";
                        while (preguntaModuloCliente.Equals("si", StringComparison.OrdinalIgnoreCase))
                        {
                            ModuloCliente(ListaClientes);
                            Console.WriteLine("desea realizar otra operación en este modulo");
                            preguntaModuloCliente = Console.ReadLine();

                        }
                    }
                    else if (modulo == 2)
                    {
                        string preguntaModuloProducto = "si";
                        while (preguntaModuloProducto.Equals("si", StringComparison.OrdinalIgnoreCase))
                        {
                            moduloProductos(ListaProductos);
                            Console.WriteLine("desea realizar otra operación en este modulo");
                            preguntaModuloProducto = Console.ReadLine();

                        }

                    }
                    else if (modulo == 3)
                    {
                        string preguntaModuloVenta = "si";
                        while (preguntaModuloVenta.Equals("si", StringComparison.OrdinalIgnoreCase))
                        {
                            moduloVentas();
                            Console.WriteLine("desea realizar otra operación en este modulo");
                            preguntaModuloVenta = Console.ReadLine();

                        }

                    }
                    else if (modulo == 4)
                    {
                        string preguntaModuloReportes = "si";
                        while (preguntaModuloReportes.Equals("si", StringComparison.OrdinalIgnoreCase))
                        {
                            moduloReportes();
                            Console.WriteLine("desea realizar otra operación en este modulo");
                            preguntaModuloReportes = Console.ReadLine();

                        }

                    }

                    Console.WriteLine("¿desea ingresar al sistema?");
                    pregunta = Console.ReadLine();
                }

            }

            Console.WriteLine("fin del programa");


        }
        static void Main(string[] args)
        {
            try{
                programa();
            }   catch(Exception e){
                Console.WriteLine($"{e}");
                Console.WriteLine("Ejecute de nuevo el programa. <3costeños");
            }
        }

        public static void ModuloCliente(List<Cliente> ListaClientes)


        {
            int accion;
            Console.WriteLine("¿Qué acción desea realizar?");
            Console.WriteLine("1. Agregar Cliente");
            Console.WriteLine("2. Buscar cliente");
            Console.WriteLine("3. Editar Cliente");
            Console.WriteLine("4. Eliminar Cliente");
            accion = int.Parse(Console.ReadLine());
            if (accion == 1)
            {

                var ClienteServices = new ClienteServices();
                ClienteServices.AgregarCliente(ListaClientes);

            }

            else if (accion == 2)
            {

                var ClienteServices = new ClienteServices();
                ClienteServices.BuscarCliente(ListaClientes);


            }
            else if (accion == 3)
            {

                var ClienteServices = new ClienteServices();
                ClienteServices.EditarCliente(ListaClientes);

            }
            else if (accion == 4)
            {
                var ClienteServices = new ClienteServices();
                ClienteServices.EliminarCliente(ListaClientes);

            }





        }
        public static void moduloProductos(List<Producto> ListaProductos)
        {
            int accion;
            Console.WriteLine("¿Qué acción desea realizar?");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Buscar producto");
            Console.WriteLine("3. Editar producto");
            Console.WriteLine("4. Eliminar producto");
            accion = int.Parse(Console.ReadLine());
            if (accion == 1)
            {
                var ProductService = new ProductoServices();
                ProductService.AddProduct(ListaProductos);
                foreach (var producto in ListaProductos)
                {
                    Console.WriteLine($"Código del producto: {producto.codigo}\nNombre del producto: {producto.nombre}\nprecio del producto: {producto.precio}\ncantidad disponible: {producto.cantidad}");
                }
            }
            else if (accion == 2)
            {
                var ProductService = new ProductoServices();
                ProductService.BuscarProducto(ListaProductos);
                foreach (var producto in ListaProductos)
                {
                    Console.WriteLine($"Código del producto: {producto.codigo}\nNombre del producto: {producto.nombre}\nprecio del producto: {producto.precio}\ncantidad disponible: {producto.cantidad}");
                }
            }
            else if (accion == 3)
            {
                var ProductService = new ProductoServices();
                ProductService.EditarProducto(ListaProductos);
                foreach (var producto in ListaProductos)
                {
                    Console.WriteLine($"Código del producto: {producto.codigo}\nNombre del producto: {producto.nombre}\nprecio del producto: {producto.precio}\ncantidad disponible: {producto.cantidad}");
                }
            }
            else if (accion == 4)
            {
                var ProductService = new ProductoServices();
                ProductService.EliminarProducto(ListaProductos);
                foreach (var producto in ListaProductos)
                {
                    Console.WriteLine($"Código del producto: {producto.codigo}\nNombre del producto: {producto.nombre}\nprecio del producto: {producto.precio}\ncantidad disponible: {producto.cantidad}");
                }
            }
        }
        public static void moduloVentas()
        {

        }
        public static void moduloReportes()
        {

        }
        public static void moduloConfiguracion()
        {
            
        }
    }
}
