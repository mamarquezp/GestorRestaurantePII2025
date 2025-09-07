using GestorRestaurantePII2025.Views;

namespace GestorRestaurantePII2025
{
    public partial class frmMenuInicio : Form
    {
        public frmMenuInicio()
        {
            InitializeComponent();
        }
        private void frmMenuInicio_Load(object sender, EventArgs e)
        {
            Data.DBTemporal.CargarDatosIniciales();
        }
        private void btnTomarPedido_Click(object sender, EventArgs e)
        {
            frmOrdenes formOrdenes = new frmOrdenes();
            formOrdenes.FormClosed += (s, args) => this.Show();
            formOrdenes.Show();
            this.Hide();
        }

        private void btnMantenimientoPlatillos_Click(object sender, EventArgs e)
        {
            frmPlatillos formPlatillos = new frmPlatillos();
            formPlatillos.FormClosed += (s, args) => this.Show();
            formPlatillos.Show();
            this.Hide();
        }

        private void btnMantenimientoCategoria_Click(object sender, EventArgs e)
        {
            FrmCategorias formCategorias = new FrmCategorias();
            formCategorias.FormClosed += (s, args) => this.Show();
            formCategorias.Show();
            this.Hide();
        }
    }
}
