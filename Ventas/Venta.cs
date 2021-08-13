using System;
using System.Collections.Generic;
using Taller_POO.Cliente;
namespace Taller_POO.Ventas

{
    public class Venta
    {
        public string documento;

        public int numeroFactura;
        public DateTime fecha;
        public List<VentaDetalles> productos;

        public bool estado;

        public int ValorTotal;

        public Venta(string documento, List<VentaDetalles> productos, int ValorTotal)
        {
            var random = new Random().Next(0, 10000);
            this.documento = documento;
            this.numeroFactura = random;
            this.fecha = DateTime.Today;
            this.productos = productos;
            this.estado = true;
            this.ValorTotal = ValorTotal;
        }

    }
}