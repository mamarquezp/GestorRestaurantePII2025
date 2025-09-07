namespace GestorRestaurantePII2025.Views
{
    partial class FrmCategorias
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
            btnAgregarCategoria = new Button();
            btnEditarCategoria = new Button();
            btnEliminarCategoria = new Button();
            dgvCategorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.Location = new Point(12, 12);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(148, 53);
            btnAgregarCategoria.TabIndex = 0;
            btnAgregarCategoria.Text = "Agregar";
            btnAgregarCategoria.UseVisualStyleBackColor = true;
            btnAgregarCategoria.Click += btnAgregar_Click;
            // 
            // btnEditarCategoria
            // 
            btnEditarCategoria.Location = new Point(314, 12);
            btnEditarCategoria.Name = "btnEditarCategoria";
            btnEditarCategoria.Size = new Size(148, 53);
            btnEditarCategoria.TabIndex = 1;
            btnEditarCategoria.Text = "Editar";
            btnEditarCategoria.UseVisualStyleBackColor = true;
            btnEditarCategoria.Click += btnEditar_Click;
            // 
            // btnEliminarCategoria
            // 
            btnEliminarCategoria.Location = new Point(640, 12);
            btnEliminarCategoria.Name = "btnEliminarCategoria";
            btnEliminarCategoria.Size = new Size(148, 53);
            btnEliminarCategoria.TabIndex = 2;
            btnEliminarCategoria.Text = "Eliminar";
            btnEliminarCategoria.UseVisualStyleBackColor = true;
            btnEliminarCategoria.Click += btnEliminar_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(12, 80);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(779, 362);
            dgvCategorias.TabIndex = 3;
            dgvCategorias.CellContentClick += dgvCategorias_CellContentClick;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCategorias);
            Controls.Add(btnEliminarCategoria);
            Controls.Add(btnEditarCategoria);
            Controls.Add(btnAgregarCategoria);
            Name = "frmCategorias";
            Text = "Mantenimiento de Categorias";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregarCategoria;
        private Button btnEditarCategoria;
        private Button btnEliminarCategoria;
        private DataGridView dgvCategorias;
    }
}