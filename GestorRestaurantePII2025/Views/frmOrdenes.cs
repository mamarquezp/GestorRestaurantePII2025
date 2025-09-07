using GestorRestaurantePII2025.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorRestaurantePII2025.Views
{
    public partial class frmOrdenes : Form
    {
        private BindingList<DetalleOrden> pedidoActual = new BindingList<DetalleOrden>();
        public frmOrdenes()
        {
            InitializeComponent();
        }
        private void frmOrdenes_Load(object sender, EventArgs e)
        {
            dgvPedidoActual.DataSource = pedidoActual;
            ConfigurarGridPedido();

            cmbBoxCategoriaOrden.DataSource = Data.DBTemporal.Categorias;
            if (cmbBoxCategoriaOrden.Items.Count > 0)
            {
                cmbBoxCategoriaOrden.SelectedIndex = 0;
                CargarPlatillosPorCategoria();
            }
            CalcularTotal();
        }

        private void cmbBoxCategoriaOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPlatillosPorCategoria();
        }

        private void CargarPlatillosPorCategoria()
        {
            if (cmbBoxCategoriaOrden.SelectedItem is Categoria categoriaSeleccionada)
            {
                List<Platillo> platillosFiltrados = Data.DBTemporal.Platillos
                    .Where(p => p.CategoriaId == categoriaSeleccionada.Id).ToList();

                lstBoxPlatillosOrden.DataSource = platillosFiltrados;
                lstBoxPlatillosOrden.DisplayMember = "Nombre";
            }
        }

        private void btnAgregarAPedido_Click(object sender, EventArgs e)
        {
            if (lstBoxPlatillosOrden.SelectedItem is Platillo platilloSeleccionado && nudCantidadPlatos.Value > 0)
            {
                DetalleOrden itemExistente = pedidoActual.FirstOrDefault(item => item.PlatilloId == platilloSeleccionado.Id);

                if (itemExistente != null)
                {
                    itemExistente.Cantidad += (int)nudCantidadPlatos.Value; //para no duplicar el mismo plato
                }
                else
                {
                    var nuevoItem = new DetalleOrden
                    {
                        PlatilloId = platilloSeleccionado.Id,
                        NombrePlatillo = platilloSeleccionado.Nombre,
                        PrecioUnitario = platilloSeleccionado.Precio,
                        Cantidad = (int)nudCantidadPlatos.Value
                    };
                    pedidoActual.Add(nuevoItem);
                }

                dgvPedidoActual.Refresh();
                CalcularTotal();
                nudCantidadPlatos.Value = 1;
            }
            else
            {
                MessageBox.Show("Seleccione un platillo y una cantidad mayor a cero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnQuitarDelPedido_Click(object sender, EventArgs e)
        {
            if (dgvPedidoActual.CurrentRow != null)
            {
                DetalleOrden itemAEliminar = (DetalleOrden)dgvPedidoActual.CurrentRow.DataBoundItem;
                pedidoActual.Remove(itemAEliminar);
                CalcularTotal(); //ajuste al eliminar
            }
        }

        private void btnModificarCantidad_Click(object sender, EventArgs e)
        {
            if (dgvPedidoActual.CurrentRow != null)
            {
                DetalleOrden itemAModificar = (DetalleOrden)dgvPedidoActual.CurrentRow.DataBoundItem;
                string nuevaCantidadStr = Microsoft.VisualBasic.Interaction.InputBox(
                    $"Ingrese la nueva cantidad para '{itemAModificar.NombrePlatillo}':",
                    "Modificar Cantidad",
                    itemAModificar.Cantidad.ToString());

                if (int.TryParse(nuevaCantidadStr, out int nuevaCantidad) && nuevaCantidad > 0)
                {
                    itemAModificar.Cantidad = nuevaCantidad;
                    dgvPedidoActual.Refresh();
                    CalcularTotal();
                }
                else if (!string.IsNullOrEmpty(nuevaCantidadStr)) //para evitar error si cancela
                {
                    MessageBox.Show("Por favor ingrese un número entero y mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CalcularTotal()
        {
            decimal total = pedidoActual.Sum(item => item.Subtotal);
            lblTotalMonto.Text = $"{total:C}";
        }

        private void ConfigurarGridPedido()
        {
            dgvPedidoActual.Columns["PlatilloId"].Visible = false;
            dgvPedidoActual.Columns["NombrePlatillo"].HeaderText = "Platillo";
            dgvPedidoActual.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvPedidoActual.Columns["PrecioUnitario"].HeaderText = "Precio";
            dgvPedidoActual.Columns["Subtotal"].HeaderText = "Subtotal";
            dgvPedidoActual.Columns["PrecioUnitario"].DefaultCellStyle.Format = "c";
            dgvPedidoActual.Columns["Subtotal"].DefaultCellStyle.Format = "c";
            dgvPedidoActual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
