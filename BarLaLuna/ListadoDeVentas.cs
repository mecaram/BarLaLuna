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
    public partial class ListadoDeVentas : Form
    {
        public List<Venta> listaVentas = new List<Venta>();
        public ListadoDeVentas()
        {
            InitializeComponent();
        }

        private void ListadoDeVentas_Load(object sender, EventArgs e)
        {
            dgvListado.AutoGenerateColumns = false;
            dgvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvListado.Columns.Clear();
            dgvListado.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "FechaVenta", DataPropertyName = "FechaVenta", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            dgvListado.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Producto", DataPropertyName = "Producto", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            dgvListado.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cantidad", DataPropertyName = "Cantidad", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            dgvListado.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "PrecioUnitario", DataPropertyName = "PrecioUnitario", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            dgvListado.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Total", DataPropertyName = "Total", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });

            foreach(Venta ventas in listaVentas)
            {
                dgvListado.Rows.Add(ventas.FechaVenta, ventas.Producto, ventas.Cantidad, ventas.PrecioUnitario, ventas.Total);
            }
            dgvListado.Refresh();  // Actualiza la grilla
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close(); // Cierra el formulario
        }
    }
}
