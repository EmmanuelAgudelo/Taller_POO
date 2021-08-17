using System;
using System.Collections.Generic;
using System.Linq;
using Taller_POO.Cliente;
namespace Taller_POO.Ventas
{
    public class VentasServices
    {
        public void addFactura(List<Cliente.Cliente> ListaClientes, List<Productos.Producto> ListaProductos, List<Venta> ListaVentas)
        {
            Console.WriteLine("digite la cedula del cliente");
            string cedula = Console.ReadLine();

            var verificarCliente = ListaClientes.Any(c => c.Documento == cedula);

            int valorTotal = 0;
            var ListadoProductosFactura = new List<VentaDetalles>();
            if (!verificarCliente)
            {
                while (!verificarCliente)
                {
                    Console.WriteLine("No existe digite la cedula del cliente");
                    cedula = Console.ReadLine();
                    verificarCliente = ListaClientes.Any(c => c.Documento == cedula);
                }
            }
            var Cliente = ListaClientes.Where(c => c.Documento == cedula).FirstOrDefault();
            string pregunta = "si";
            while (pregunta.Equals("si", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("digite el codigo del producto");
                string codigo = Console.ReadLine();
                var verificarProducto = ListaProductos.Any(p => p.Codigo == codigo);
                if (!verificarProducto)
                {
                    while (!verificarProducto)
                    {
                        Console.WriteLine("No existe ese producto,digite el codigo del producto");
                        codigo = Console.ReadLine();
                        verificarProducto = ListaProductos.Any(p => p.Codigo == codigo);
                    }
                }
                var producto = ListaProductos.Where(p => p.Codigo == codigo).FirstOrDefault();
                Console.WriteLine($"digite la cantidad que desea agregar de {producto.Nombre}: ");
                int cantidad = int.Parse(Console.ReadLine());
                int valorProducto = producto.Precio * cantidad;
                valorTotal += valorProducto;
                var ProductoDetalle = new VentaDetalles(producto.Nombre, producto.Precio, cantidad);
                ListadoProductosFactura.Add(ProductoDetalle);
                Console.WriteLine("desea agregar otro producto?");
                pregunta = Console.ReadLine();

            }


            var Factura = new Venta(Cliente.Documento,
             ListadoProductosFactura, valorTotal);

            ListaVentas.Add(Factura);

        }

        public void BuscarFactura(List<Venta> ListaVentas)
        {
            Console.WriteLine("Digite el numero de la factura");
            int numeroFactura = int.Parse(Console.ReadLine());

            var verificarNumeroFactura = ListaVentas.Any(v => v.numeroFactura == numeroFactura);
            if (verificarNumeroFactura)
            {
                var Factura = ListaVentas.Where(f => f.numeroFactura == numeroFactura).FirstOrDefault();
                if (Factura.estado)
                {
                    Console.WriteLine($"numero factura: {Factura.numeroFactura}\nCedula cliente: {Factura.documento}\nValor total: {Factura.ValorTotal}");

                    foreach (var producto in Factura.productos)
                    {
                        Console.WriteLine($"Nombre: {producto.nombre}........{producto.precio}x{producto.cantidad}");
                    }
                }
                else { System.Console.WriteLine("La factura ha sido deshabilitada"); }

            }
            else
            {
                Console.WriteLine($"No se encontraron facturas con este identificador: {numeroFactura}");
            }


        }

        public void DeshabilitarFactura(List<Venta> ListaVentas)
        {
            Console.WriteLine("Digite el numero de la factura");
            int numeroFactura = int.Parse(Console.ReadLine());

            var verificarNumeroFactura = ListaVentas.Any(v => v.numeroFactura == numeroFactura);
            if (verificarNumeroFactura)
            {
                var Factura = ListaVentas.Where(f => f.numeroFactura == numeroFactura).FirstOrDefault();
                Factura.estado = false;
                System.Console.WriteLine("La factura ha sido deshabilitada correctamente\n");
            }
            else
            {
                Console.WriteLine($"No se encontraron facturas con este identificador: {numeroFactura}");
            }
        }
    }
}