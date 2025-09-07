namespace GestorRestaurantePII2025.Views
{
    partial class frmDetallePlatillo
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
            lblNombrePlatillo = new Label();
            txtBoxNombrePlatillo = new TextBox();
            nupPrecioPlatillo = new NumericUpDown();
            lblPrecioPlatillo = new Label();
            cmbBoxCategoriaPlatillo = new ComboBox();
            lblCategoriaPlatillo = new Label();
            btnGuardarPlatillo = new Button();
            btnCancelarPlatillo = new Button();
            ((System.ComponentModel.ISupportInitialize)nupPrecioPlatillo).BeginInit();
            SuspendLayout();
            // 
            // lblNombrePlatillo
            // 
            lblNombrePlatillo.AutoSize = true;
            lblNombrePlatillo.Location = new Point(12, 9);
            lblNombrePlatillo.Name = "lblNombrePlatillo";
            lblNombrePlatillo.Size = new Size(117, 20);
            lblNombrePlatillo.TabIndex = 0;
            lblNombrePlatillo.Text = "Nombre Platillo:";
            // 
            // txtBoxNombrePlatillo
            // 
            txtBoxNombrePlatillo.Location = new Point(145, 12);
            txtBoxNombrePlatillo.Name = "txtBoxNombrePlatillo";
            txtBoxNombrePlatillo.PlaceholderText = "Ingrese el nombre del Platillo";
            txtBoxNombrePlatillo.Size = new Size(296, 27);
            txtBoxNombrePlatillo.TabIndex = 1;
            // 
            // nupPrecioPlatillo
            // 
            nupPrecioPlatillo.DecimalPlaces = 2;
            nupPrecioPlatillo.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nupPrecioPlatillo.Location = new Point(145, 45);
            nupPrecioPlatillo.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nupPrecioPlatillo.Name = "nupPrecioPlatillo";
            nupPrecioPlatillo.Size = new Size(150, 27);
            nupPrecioPlatillo.TabIndex = 2;
            // 
            // lblPrecioPlatillo
            // 
            lblPrecioPlatillo.AutoSize = true;
            lblPrecioPlatillo.Location = new Point(12, 45);
            lblPrecioPlatillo.Name = "lblPrecioPlatillo";
            lblPrecioPlatillo.Size = new Size(103, 20);
            lblPrecioPlatillo.TabIndex = 3;
            lblPrecioPlatillo.Text = "Precio Platillo:";
            // 
            // cmbBoxCategoriaPlatillo
            // 
            cmbBoxCategoriaPlatillo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxCategoriaPlatillo.FormattingEnabled = true;
            cmbBoxCategoriaPlatillo.Location = new Point(145, 78);
            cmbBoxCategoriaPlatillo.Name = "cmbBoxCategoriaPlatillo";
            cmbBoxCategoriaPlatillo.Size = new Size(296, 28);
            cmbBoxCategoriaPlatillo.TabIndex = 4;
            // 
            // lblCategoriaPlatillo
            // 
            lblCategoriaPlatillo.AutoSize = true;
            lblCategoriaPlatillo.Location = new Point(12, 78);
            lblCategoriaPlatillo.Name = "lblCategoriaPlatillo";
            lblCategoriaPlatillo.Size = new Size(127, 20);
            lblCategoriaPlatillo.TabIndex = 5;
            lblCategoriaPlatillo.Text = "Categoría Platillo:";
            // 
            // btnGuardarPlatillo
            // 
            btnGuardarPlatillo.Location = new Point(173, 141);
            btnGuardarPlatillo.Name = "btnGuardarPlatillo";
            btnGuardarPlatillo.Size = new Size(122, 45);
            btnGuardarPlatillo.TabIndex = 6;
            btnGuardarPlatillo.Text = "Guardar";
            btnGuardarPlatillo.UseVisualStyleBackColor = true;
            btnGuardarPlatillo.Click += btnGuardarPlatillo_Click;
            // 
            // btnCancelarPlatillo
            // 
            btnCancelarPlatillo.Location = new Point(319, 141);
            btnCancelarPlatillo.Name = "btnCancelarPlatillo";
            btnCancelarPlatillo.Size = new Size(122, 45);
            btnCancelarPlatillo.TabIndex = 7;
            btnCancelarPlatillo.Text = "Cancelar";
            btnCancelarPlatillo.UseVisualStyleBackColor = true;
            // 
            // frmDetallePlatillo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 206);
            Controls.Add(btnCancelarPlatillo);
            Controls.Add(btnGuardarPlatillo);
            Controls.Add(lblCategoriaPlatillo);
            Controls.Add(cmbBoxCategoriaPlatillo);
            Controls.Add(lblPrecioPlatillo);
            Controls.Add(nupPrecioPlatillo);
            Controls.Add(txtBoxNombrePlatillo);
            Controls.Add(lblNombrePlatillo);
            Name = "frmDetallePlatillo";
            Text = "Detalle del Platillo";
            Load += frmDetallePlatillo_Load;
            ((System.ComponentModel.ISupportInitialize)nupPrecioPlatillo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombrePlatillo;
        private TextBox txtBoxNombrePlatillo;
        private NumericUpDown nupPrecioPlatillo;
        private Label lblPrecioPlatillo;
        private ComboBox cmbBoxCategoriaPlatillo;
        private Label lblCategoriaPlatillo;
        private Button btnGuardarPlatillo;
        private Button btnCancelarPlatillo;
    }
}