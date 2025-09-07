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
    public partial class frmPlatillos : Form
    {
        public frmPlatillos()
        {
            InitializeComponent();
        }

        private void FormPlatillos_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
            ConfigurarColumnas();
        }

        private void ActualizarGrid()
        {
            dgvPlatillos.DataSource = null;
            dgvPlatillos.DataSource = new BindingList<Platillo>(Data.DBTemporal.Platillos);
        }

        private void ConfigurarColumnas()
        {
            dgvPlatillos.Columns["Id"].Visible = false;
            dgvPlatillos.Columns["CategoriaId"].Visible = false;
            dgvPlatillos.Columns["Nombre"].HeaderText = "Nombre del Platillo";
            dgvPlatillos.Columns["Precio"].HeaderText = "Precio";
            dgvPlatillos.Columns["CategoriaNombre"].HeaderText = "Categoría";
            dgvPlatillos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAgregarPlatillo_Click(object sender, EventArgs e)
        {
            frmDetallePlatillo formDetalle = new frmDetallePlatillo();
            if (formDetalle.ShowDialog() == DialogResult.OK) //solo actualiza si guardó
            {
                ActualizarGrid();
            }
        }

        private void btnEditarPlatillo_Click(object sender, EventArgs e)
        {
            if (dgvPlatillos.CurrentRow != null)
            {
                Platillo platilloSeleccionado = (Platillo)dgvPlatillos.CurrentRow.DataBoundItem;

                frmDetallePlatillo formDetalle = new frmDetallePlatillo(platilloSeleccionado);

                if (formDetalle.ShowDialog() == DialogResult.OK)
                {
                    ActualizarGrid();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un platillo para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarPlatillo_Click(object sender, EventArgs e)
        {
            if (dgvPlatillos.CurrentRow != null)
            {
                Platillo platilloSeleccionado = (Platillo)dgvPlatillos.CurrentRow.DataBoundItem;

                Data.DBTemporal.EliminarPlatillo(platilloSeleccionado.Id);
                ActualizarGrid();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un platillo para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}
