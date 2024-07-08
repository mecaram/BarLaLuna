using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarLaLuna
{
    public partial class Estadisticas : Form
    {
        public List<Venta> listaVentas = new List<Venta>();

        public Estadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            // Suma de Totales x Venta
            decimal suma = 0; // Inicializo la variable suma
            foreach (Venta v in listaVentas)
                suma += v.Total;

            txtTotalVentas.Text = suma.ToString("$##.##");

            // Ticket Promedio x Venta
            int cantTickets = listaVentas.Count; // Obtengo la cantidad de registros de la lista
            decimal ticketPromedio = suma / cantTickets; // Calculo la division de la suma por la cantidad de tickets
            txtTicketPromedio.Text = ticketPromedio.ToString("$##.##");

            // Calcular el Precio Maximo por Producto
            // Declaro e inicializo las variables
            decimal precioMaximoTe = 0, precioMaximoCafe = 0, precioMaximoChocolatada = 0;

            // Calcular el Precio Minimo por Producto
            // Declaro e inicializo las variables
            decimal precioMinimoTe = 0, precioMinimoCafe = 0, precioMinimoChocolatada = 0;

            // Recorro las Lista de Ventas
            foreach (Venta v in listaVentas)
            {
                // Pregunto si el producto correcto y ademas si el Precio Unitario es Mayor que el Maximo
                if (v.Producto == "Te" && v.PrecioUnitario > precioMaximoTe)
                    precioMaximoTe = v.PrecioUnitario;

                if (v.Producto == "Cafe" && v.PrecioUnitario > precioMaximoCafe)
                    precioMaximoCafe = v.PrecioUnitario;

                if (v.Producto == "Chocolatada" && v.PrecioUnitario > precioMaximoChocolatada)
                    precioMaximoChocolatada = v.PrecioUnitario;

                // Pregunto si el producto correcto y ademas si el Precio Unitario es Menor que el Minimo
                if (v.Producto == "Te" && v.PrecioUnitario < precioMinimoTe)
                    precioMinimoTe = v.PrecioUnitario;

                if (v.Producto == "Cafe" && v.PrecioUnitario < precioMinimoCafe)
                    precioMinimoCafe = v.PrecioUnitario;

                if (v.Producto == "Chocolatada" && v.PrecioUnitario < precioMinimoChocolatada)
                    precioMinimoChocolatada = v.PrecioUnitario;
            }

            txtPrecioMaximoTe.Text = precioMaximoTe.ToString("$##.##");
            txtPrecioMaximoCafe.Text = precioMaximoCafe.ToString("$##.##");
            txtPrecioMaximoChocolatada.Text = precioMaximoChocolatada.ToString("$##.##");

            txtPrecioMinimoTe.Text = precioMinimoTe.ToString("$##.##");
            txtPrecioMinimoCafe.Text = precioMinimoCafe.ToString("$##.##");
            txtPrecioMinimoChocolatada.Text = precioMinimoChocolatada.ToString("$##.##");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
