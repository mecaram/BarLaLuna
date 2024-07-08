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
    public partial class ProcesoPrincipal : Form
    {
        public List<Venta> listaVentas = new List<Venta>();
        public ProcesoPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Obtengo los valores que ingreso el usuario
            string producto = cboProducto.SelectedItem.ToString();
            int cantidad = Convert.ToInt32(nudCantidad.Value);
            decimal precio = Convert.ToDecimal(txtPrecioUnitario.Text);

            // Registro la Venta
            Venta venta = new Venta();
            venta.RegistrarVenta(producto, cantidad, precio);

            // Agrego la Venta a la Lista
            listaVentas.Add(venta);

            // Inicializo los controles
            cboProducto.SelectedItem = "Te";
            nudCantidad.Value = 1;
            txtPrecioUnitario.Text = "0";
            txtTotal.Text = "0";

            txtPrecioUnitario.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cboProducto.SelectedItem = "Te";
            nudCantidad.Value = 1;
            txtPrecioUnitario.Text = "0";
            txtTotal.Text = "0";

            txtPrecioUnitario.Focus();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            // Declaro un objeto del formulario ListadoDeVentas
            ListadoDeVentas formulario = new ListadoDeVentas();

            // Asigno a la propiedad listaVentas la lista de ventas
            formulario.listaVentas = listaVentas;
            // llamo al formulario en Modo Modal
            formulario.ShowDialog(this);
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            Estadisticas formulario = new Estadisticas();
            formulario.listaVentas = listaVentas;
            formulario.ShowDialog(this);
        }

        private void txtPrecioUnitario_Leave(object sender, EventArgs e)
        {

            decimal precio = 0;
            try
            {
                precio = Convert.ToDecimal(txtPrecioUnitario.Text);
            }
            catch
            {
                precio = 0;
            }

            int cantidad = Convert.ToInt32(nudCantidad.Value);
            decimal total = cantidad * precio;
            txtTotal.Text = Convert.ToString(total);
        }

        private void nudCantidad_Leave(object sender, EventArgs e)
        {
            decimal precio = 0;
            try
            {
                precio = Convert.ToDecimal(txtPrecioUnitario.Text);
            }
            catch
            {
                precio = 0;
            }

            int cantidad = Convert.ToInt32(nudCantidad.Value);
            decimal total = cantidad * precio;
            txtTotal.Text = Convert.ToString(total);
        }

        private void ProcesoPrincipal_Load(object sender, EventArgs e)
        {
            cboProducto.SelectedItem = "Te";
            nudCantidad.Value = 1;
            txtPrecioUnitario.Focus();
        }
    }
}
