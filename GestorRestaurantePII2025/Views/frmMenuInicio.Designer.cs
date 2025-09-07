namespace GestorRestaurantePII2025
{
    partial class frmMenuInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTomarPedido = new Button();
            btnMantenimientoPlatillos = new Button();
            btnMantenimientoCategoria = new Button();
            lblMenuInicio = new Label();
            SuspendLayout();
            // 
            // btnTomarPedido
            // 
            btnTomarPedido.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnTomarPedido.Location = new Point(59, 72);
            btnTomarPedido.Name = "btnTomarPedido";
            btnTomarPedido.Size = new Size(256, 67);
            btnTomarPedido.TabIndex = 0;
            btnTomarPedido.Text = "Tomar Pedido";
            btnTomarPedido.UseVisualStyleBackColor = true;
            btnTomarPedido.Click += btnTomarPedido_Click;
            // 
            // btnMantenimientoPlatillos
            // 
            btnMantenimientoPlatillos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnMantenimientoPlatillos.Location = new Point(59, 145);
            btnMantenimientoPlatillos.Name = "btnMantenimientoPlatillos";
            btnMantenimientoPlatillos.Size = new Size(256, 67);
            btnMantenimientoPlatillos.TabIndex = 1;
            btnMantenimientoPlatillos.Text = "Mantenimiento de Platillos";
            btnMantenimientoPlatillos.UseVisualStyleBackColor = true;
            btnMantenimientoPlatillos.Click += btnMantenimientoPlatillos_Click;
            // 
            // btnMantenimientoCategoria
            // 
            btnMantenimientoCategoria.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnMantenimientoCategoria.Location = new Point(59, 218);
            btnMantenimientoCategoria.Name = "btnMantenimientoCategoria";
            btnMantenimientoCategoria.Size = new Size(256, 67);
            btnMantenimientoCategoria.TabIndex = 2;
            btnMantenimientoCategoria.Text = "Mantenimiento de Categorías";
            btnMantenimientoCategoria.UseVisualStyleBackColor = true;
            btnMantenimientoCategoria.Click += btnMantenimientoCategoria_Click;
            // 
            // lblMenuInicio
            // 
            lblMenuInicio.AutoSize = true;
            lblMenuInicio.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuInicio.Location = new Point(59, 9);
            lblMenuInicio.Name = "lblMenuInicio";
            lblMenuInicio.Size = new Size(269, 38);
            lblMenuInicio.TabIndex = 3;
            lblMenuInicio.Text = "Menú de Opciones:";
            // 
            // frmMenuInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 330);
            Controls.Add(lblMenuInicio);
            Controls.Add(btnMantenimientoCategoria);
            Controls.Add(btnMantenimientoPlatillos);
            Controls.Add(btnTomarPedido);
            Name = "frmMenuInicio";
            Text = "Gestor de Restaurante";
            Load += this.frmMenuInicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTomarPedido;
        private Button btnMantenimientoPlatillos;
        private Button btnMantenimientoCategoria;
        private Label lblMenuInicio;
    }
}
