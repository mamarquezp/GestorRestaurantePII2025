namespace GestorRestaurantePII2025.Views
{
    partial class frmOrdenes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlDatosOrden = new Panel();
            nudCantidadPlatos = new NumericUpDown();
            lblCantidadOrden = new Label();
            btnAgregarAPedido = new Button();
            lstBoxPlatillosOrden = new ListBox();
            lblPlatilloOrden = new Label();
            cmbBoxCategoriaOrden = new ComboBox();
            lblCategoriaOrden = new Label();
            label1 = new Label();
            dgvPedidoActual = new DataGridView();
            btnModificarCantidad = new Button();
            btnQuitarDelPedido = new Button();
            lblTotalTitulo = new Label();
            lblTotalMonto = new Label();
            pnlDatosOrden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadPlatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidoActual).BeginInit();
            SuspendLayout();
            // 
            // pnlDatosOrden
            // 
            pnlDatosOrden.BackColor = SystemColors.ControlLight;
            pnlDatosOrden.Controls.Add(nudCantidadPlatos);
            pnlDatosOrden.Controls.Add(lblCantidadOrden);
            pnlDatosOrden.Controls.Add(btnAgregarAPedido);
            pnlDatosOrden.Controls.Add(lstBoxPlatillosOrden);
            pnlDatosOrden.Controls.Add(lblPlatilloOrden);
            pnlDatosOrden.Controls.Add(cmbBoxCategoriaOrden);
            pnlDatosOrden.Controls.Add(lblCategoriaOrden);
            pnlDatosOrden.Location = new Point(12, 12);
            pnlDatosOrden.Name = "pnlDatosOrden";
            pnlDatosOrden.Size = new Size(292, 484);
            pnlDatosOrden.TabIndex = 0;
            // 
            // nudCantidadPlatos
            // 
            nudCantidadPlatos.Location = new Point(136, 385);
            nudCantidadPlatos.Name = "nudCantidadPlatos";
            nudCantidadPlatos.Size = new Size(150, 27);
            nudCantidadPlatos.TabIndex = 6;
            // 
            // lblCantidadOrden
            // 
            lblCantidadOrden.AutoSize = true;
            lblCantidadOrden.Location = new Point(0, 387);
            lblCantidadOrden.Name = "lblCantidadOrden";
            lblCantidadOrden.Size = new Size(130, 20);
            lblCantidadOrden.TabIndex = 5;
            lblCantidadOrden.Text = "Cantidad a añadir:";
            // 
            // btnAgregarAPedido
            // 
            btnAgregarAPedido.Location = new Point(3, 418);
            btnAgregarAPedido.Name = "btnAgregarAPedido";
            btnAgregarAPedido.Size = new Size(286, 63);
            btnAgregarAPedido.TabIndex = 4;
            btnAgregarAPedido.Text = "Añadir a Pedido ===>";
            btnAgregarAPedido.UseVisualStyleBackColor = true;
            btnAgregarAPedido.Click += btnAgregarAPedido_Click;
            // 
            // lstBoxPlatillosOrden
            // 
            lstBoxPlatillosOrden.FormattingEnabled = true;
            lstBoxPlatillosOrden.Location = new Point(56, 86);
            lstBoxPlatillosOrden.Name = "lstBoxPlatillosOrden";
            lstBoxPlatillosOrden.Size = new Size(233, 284);
            lstBoxPlatillosOrden.TabIndex = 3;
            // 
            // lblPlatilloOrden
            // 
            lblPlatilloOrden.AutoSize = true;
            lblPlatilloOrden.Location = new Point(3, 64);
            lblPlatilloOrden.Name = "lblPlatilloOrden";
            lblPlatilloOrden.Size = new Size(146, 20);
            lblPlatilloOrden.TabIndex = 2;
            lblPlatilloOrden.Text = "Platillos Disponibles:";
            // 
            // cmbBoxCategoriaOrden
            // 
            cmbBoxCategoriaOrden.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxCategoriaOrden.FormattingEnabled = true;
            cmbBoxCategoriaOrden.Location = new Point(56, 33);
            cmbBoxCategoriaOrden.Name = "cmbBoxCategoriaOrden";
            cmbBoxCategoriaOrden.Size = new Size(233, 28);
            cmbBoxCategoriaOrden.TabIndex = 1;
            cmbBoxCategoriaOrden.SelectedIndexChanged += cmbBoxCategoriaOrden_SelectedIndexChanged;
            // 
            // lblCategoriaOrden
            // 
            lblCategoriaOrden.AutoSize = true;
            lblCategoriaOrden.Location = new Point(3, 10);
            lblCategoriaOrden.Name = "lblCategoriaOrden";
            lblCategoriaOrden.Size = new Size(77, 20);
            lblCategoriaOrden.TabIndex = 0;
            lblCategoriaOrden.Text = "Categoria:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(469, 9);
            label1.Name = "label1";
            label1.Size = new Size(285, 54);
            label1.TabIndex = 1;
            label1.Text = "Pedido Actual";
            // 
            // dgvPedidoActual
            // 
            dgvPedidoActual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidoActual.Location = new Point(310, 66);
            dgvPedidoActual.Name = "dgvPedidoActual";
            dgvPedidoActual.RowHeadersWidth = 51;
            dgvPedidoActual.Size = new Size(610, 385);
            dgvPedidoActual.TabIndex = 2;
            // 
            // btnModificarCantidad
            // 
            btnModificarCantidad.Location = new Point(310, 457);
            btnModificarCantidad.Name = "btnModificarCantidad";
            btnModificarCantidad.Size = new Size(153, 39);
            btnModificarCantidad.TabIndex = 3;
            btnModificarCantidad.Text = "Modificar Cantidad";
            btnModificarCantidad.UseVisualStyleBackColor = true;
            btnModificarCantidad.Click += btnModificarCantidad_Click;
            // 
            // btnQuitarDelPedido
            // 
            btnQuitarDelPedido.Location = new Point(469, 457);
            btnQuitarDelPedido.Name = "btnQuitarDelPedido";
            btnQuitarDelPedido.Size = new Size(153, 39);
            btnQuitarDelPedido.TabIndex = 4;
            btnQuitarDelPedido.Text = "Quitar del Pedido";
            btnQuitarDelPedido.UseVisualStyleBackColor = true;
            btnQuitarDelPedido.Click += btnQuitarDelPedido_Click;
            // 
            // lblTotalTitulo
            // 
            lblTotalTitulo.AutoSize = true;
            lblTotalTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotalTitulo.Location = new Point(779, 459);
            lblTotalTitulo.Name = "lblTotalTitulo";
            lblTotalTitulo.Size = new Size(89, 37);
            lblTotalTitulo.TabIndex = 5;
            lblTotalTitulo.Text = "Total:";
            // 
            // lblTotalMonto
            // 
            lblTotalMonto.AutoSize = true;
            lblTotalMonto.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalMonto.Location = new Point(830, 496);
            lblTotalMonto.Name = "lblTotalMonto";
            lblTotalMonto.Size = new Size(88, 32);
            lblTotalMonto.TabIndex = 6;
            lblTotalMonto.Text = "Q 0.00";
            // 
            // frmOrdenes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 561);
            Controls.Add(lblTotalMonto);
            Controls.Add(lblTotalTitulo);
            Controls.Add(btnQuitarDelPedido);
            Controls.Add(btnModificarCantidad);
            Controls.Add(dgvPedidoActual);
            Controls.Add(label1);
            Controls.Add(pnlDatosOrden);
            Name = "frmOrdenes";
            Text = "Gestion de Órdenes";
            Load += frmOrdenes_Load;
            pnlDatosOrden.ResumeLayout(false);
            pnlDatosOrden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadPlatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidoActual).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlDatosOrden;
        private ComboBox cmbBoxCategoriaOrden;
        private Label lblCategoriaOrden;
        private Button btnAgregarAPedido;
        private ListBox lstBoxPlatillosOrden;
        private Label lblPlatilloOrden;
        private Label label1;
        private DataGridView dgvPedidoActual;
        private Button btnModificarCantidad;
        private Button btnQuitarDelPedido;
        private Label lblTotalTitulo;
        private Label lblTotalMonto;
        private Label lblCantidadOrden;
        private NumericUpDown nudCantidadPlatos;
    }
}