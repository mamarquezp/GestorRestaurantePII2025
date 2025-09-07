using GestorRestaurantePII2025.Data;
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
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void ActualizarGrid()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = new BindingList<Categoria>(DBTemporal.Categorias);
            dgvCategorias.Columns["Id"].Visible = false; //para no mostrar el ID
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre de la nueva categoría:", "Agregar Categoría", "");
            if (!string.IsNullOrWhiteSpace(nombre))
            {
                if (DBTemporal.Categorias.Exists(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Esa categoría ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DBTemporal.AgregarCategoria(nombre);
                ActualizarGrid();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                int idSeleccionado = (int)dgvCategorias.CurrentRow.Cells["Id"].Value;
                Categoria categoriaActual = DBTemporal.Categorias.Find(c => c.Id == idSeleccionado);

                string nuevoNombre = Microsoft.VisualBasic.Interaction.InputBox("Modifique el nombre de la categoría:", "Editar Categoría", categoriaActual.Nombre);

                if (!string.IsNullOrWhiteSpace(nuevoNombre) && !nuevoNombre.Equals(categoriaActual.Nombre))
                {
                    DBTemporal.EditarCategoria(idSeleccionado, nuevoNombre);
                    ActualizarGrid();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                int idSeleccionado = (int)dgvCategorias.CurrentRow.Cells["Id"].Value;
                string nombreCategoria = dgvCategorias.CurrentRow.Cells["Nombre"].Value.ToString();

                if (DBTemporal.Platillos.Exists(p => p.CategoriaId == idSeleccionado))
                {
                    MessageBox.Show("No se puede eliminar la categoría porque tiene platillos asociados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DBTemporal.EliminarCategoria(idSeleccionado);
                ActualizarGrid();
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
