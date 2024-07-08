using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BarLaLuna
{
    public class Venta
    {
        public DateTime FechaVenta;
        public string Producto = "";
        public int Cantidad = 0;
        public decimal PrecioUnitario = 0;
        public decimal Total = 0;

        public void RegistrarVenta(string producto, int cantidad, decimal precioUnitario)
        {
            FechaVenta = DateTime.Now;
            Producto = producto;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Total = cantidad * precioUnitario;
        }
    }
}
