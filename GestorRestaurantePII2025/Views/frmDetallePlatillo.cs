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
    public partial class frmDetallePlatillo : Form
    {

        private Platillo platilloAEditar;

        public frmDetallePlatillo(Platillo platillo = null)
        {
            InitializeComponent();
            this.platilloAEditar = platillo;
        }
        private void FormDetallePlatillo_Load(object sender, EventArgs e)
        {
            cmbBoxCategoriaPlatillo.DataSource = DBTemporal.Categorias;
            cmbBoxCategoriaPlatillo.DisplayMember = "Nombre";
            cmbBoxCategoriaPlatillo.ValueMember = "Id";

            if (platilloAEditar != null) //es editar
            {
                this.Text = "Editar Platillo"; //Cambia el título del formulario
                txtBoxNombrePlatillo.Text = platilloAEditar.Nombre;
                nupPrecioPlatillo.Value = platilloAEditar.Precio;
                cmbBoxCategoriaPlatillo.SelectedValue = platilloAEditar.CategoriaId;
            }
            else //es agregar
            {
                this.Text = "Agregar Nuevo Platillo";
            }
        }

        private void btnGuardarPlatillo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxNombrePlatillo.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nupPrecioPlatillo.Value <= 0)
            {
                MessageBox.Show("El precio debe ser mayor que cero", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbBoxCategoriaPlatillo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una categoría.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = txtBoxNombrePlatillo.Text;
            decimal precio = nupPrecioPlatillo.Value;
            int categoriaId = (int)cmbBoxCategoriaPlatillo.SelectedValue;

            if (platilloAEditar != null) //edita
            {
                DBTemporal.EditarPlatillo(platilloAEditar.Id, nombre, precio, categoriaId);
            }
            else //agrega
            {
                DBTemporal.AgregarPlatillo(nombre, precio, categoriaId);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
