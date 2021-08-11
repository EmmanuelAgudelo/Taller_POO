using System;
using System.Collections.Generic;
using System.Linq;

namespace Taller_POO.Cliente

{
    public class ClienteServices
    {
        public void AgregarCliente(List<Cliente> ListaClientes)
        {
            Console.WriteLine("digite el documento del cliente");
            string documento = Console.ReadLine();
            Console.WriteLine("digite el nombre del cliente");
            string nombre = Console.ReadLine();
            Console.WriteLine("digite el direccion del cliente");
            string direccion = Console.ReadLine();
            Console.WriteLine("digite el telefono del cliente");
            string telefono = Console.ReadLine();

            var cliente = new Cliente(documento, nombre, direccion, telefono);
            ListaClientes.Add(cliente);
            Console.WriteLine("cliente agregado satisfactoriamente");

        }
        public void BuscarCliente(List<Cliente> ListaClientes)
        {
            Console.WriteLine("digite la cédula del cliente");
            string documento = Console.ReadLine();

            //var consulta = (from cliente in ListaClientes where cliente.documento.Equals(documento) select cliente).FirstOrDefault();
            var cliente = ListaClientes.Where(c => c.Documento == documento).FirstOrDefault();
            Console.WriteLine("datos del cliente consultado\n");
            Console.WriteLine($"documento: {cliente.Documento}\nnombre: {cliente.Nombre}\ndireccion: {cliente.Direccion}\ntelefono: {cliente.Telefono} \n");

        }
        public void EditarCliente(List<Cliente> ListaClientes)
        {
            Console.WriteLine("digite la cédula del cliente");
            string documento = Console.ReadLine();

            //var consulta = (from cliente in ListaClientes where cliente.documento.Equals(documento) select cliente).FirstOrDefault();
            var cliente = ListaClientes.Where(c => c.Documento == documento).FirstOrDefault();
            Console.WriteLine("datos del cliente \n");
            Console.WriteLine($"documento: {cliente.Documento}\nnombre: {cliente.Nombre}\ndireccion: {cliente.Direccion}\ntelefono: {cliente.Telefono} \n");
            Console.WriteLine("digite el nombre del cliente:");
            string nombre = Console.ReadLine();
            Console.WriteLine("digite la dirección del cliente:");
            string direccion = Console.ReadLine();
            Console.WriteLine("digite el telefono del cliente:");
            string telefono = Console.ReadLine();
            cliente.Nombre = nombre;
            cliente.Direccion = direccion;
            cliente.Telefono = telefono;
            Console.WriteLine("datos del cliente \n");
            Console.WriteLine($"documento: {cliente.Documento}\nnombre: {cliente.Nombre}\ndireccion: {cliente.Direccion}\ntelefono: {cliente.Telefono} \n");
            Console.WriteLine("cliente editado satisfactoriamente");
        }

        public void EliminarCliente(List<Cliente> ListaClientes)
        {
            Console.WriteLine("digite la cédula del cliente");
            string documento = Console.ReadLine();

            //var consulta = (from cliente in ListaClientes where cliente.documento.Equals(documento) select cliente).FirstOrDefault();
            var cliente = ListaClientes.Where(c => c.Documento == documento).FirstOrDefault();
            Console.WriteLine("datos del cliente \n");
            Console.WriteLine($"documento: {cliente.Documento}\nnombre: {cliente.Nombre}\ndireccion: {cliente.Direccion}\ntelefono: {cliente.Telefono} \n");
            ListaClientes.Remove(cliente);
            Console.WriteLine("cliente eliminado satisfactoriamente");
        }
    }
}