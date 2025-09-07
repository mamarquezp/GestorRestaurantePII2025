namespace GestorRestaurantePII2025.Views
{
    partial class frmPlatillos
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
            btnAgregarPlatillo = new Button();
            btnEditarPlatillo = new Button();
            btnEliminarPlatillo = new Button();
            dgvPlatillos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPlatillos).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarPlatillo
            // 
            btnAgregarPlatillo.Location = new Point(12, 12);
            btnAgregarPlatillo.Name = "btnAgregarPlatillo";
            btnAgregarPlatillo.Size = new Size(148, 53);
            btnAgregarPlatillo.TabIndex = 0;
            btnAgregarPlatillo.Text = "Agregar";
            btnAgregarPlatillo.UseVisualStyleBackColor = true;
            btnAgregarPlatillo.Click += btnAgregarPlatillo_Click;
            // 
            // btnEditarPlatillo
            // 
            btnEditarPlatillo.Location = new Point(314, 12);
            btnEditarPlatillo.Name = "btnEditarPlatillo";
            btnEditarPlatillo.Size = new Size(148, 53);
            btnEditarPlatillo.TabIndex = 1;
            btnEditarPlatillo.Text = "Editar";
            btnEditarPlatillo.UseVisualStyleBackColor = true;
            btnEditarPlatillo.Click += btnEditarPlatillo_Click;
            // 
            // btnEliminarPlatillo
            // 
            btnEliminarPlatillo.Location = new Point(640, 12);
            btnEliminarPlatillo.Name = "btnEliminarPlatillo";
            btnEliminarPlatillo.Size = new Size(148, 53);
            btnEliminarPlatillo.TabIndex = 2;
            btnEliminarPlatillo.Text = "Eliminar";
            btnEliminarPlatillo.UseVisualStyleBackColor = true;
            btnEliminarPlatillo.Click += btnEliminarPlatillo_Click;
            // 
            // dgvPlatillos
            // 
            dgvPlatillos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlatillos.Location = new Point(12, 80);
            dgvPlatillos.Name = "dgvPlatillos";
            dgvPlatillos.RowHeadersWidth = 51;
            dgvPlatillos.Size = new Size(779, 362);
            dgvPlatillos.TabIndex = 3;
            // 
            // frmPlatillos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPlatillos);
            Controls.Add(btnEliminarPlatillo);
            Controls.Add(btnEditarPlatillo);
            Controls.Add(btnAgregarPlatillo);
            Name = "frmPlatillos";
            Text = "Mantenimiento de Patillos";
            ((System.ComponentModel.ISupportInitialize)dgvPlatillos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregarPlatillo;
        private Button btnEditarPlatillo;
        private Button btnEliminarPlatillo;
        private DataGridView dgvPlatillos;
    }
}