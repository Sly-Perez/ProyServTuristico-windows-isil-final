namespace ProyServTuristico_GUI
{
    partial class CategoriaMan01
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
            label1 = new Label();
            btnAgregar = new Button();
            txtBuscar = new TextBox();
            label2 = new Label();
            dgvCategorias = new DataGridView();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnCerrar = new Button();
            label3 = new Label();
            lblRegistros = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(782, 613);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(249, 12);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(125, 27);
            txtBuscar.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 18);
            label2.Name = "label2";
            label2.Size = new Size(190, 20);
            label2.TabIndex = 8;
            label2.Text = "Ingrese filtro por categoria:";
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(27, 71);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(1188, 388);
            dgvCategorias.TabIndex = 9;
            dgvCategorias.CellContentClick += dgvCategorias_CellContentClick;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(899, 613);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(95, 29);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1032, 613);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(1151, 613);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1116, 552);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 13;
            label3.Text = "Registros: ";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(1210, 541);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(79, 42);
            lblRegistros.TabIndex = 14;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CategoriaMan01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 704);
            Controls.Add(lblRegistros);
            Controls.Add(label3);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(dgvCategorias);
            Controls.Add(label2);
            Controls.Add(txtBuscar);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Name = "CategoriaMan01";
            Text = "Mantenimiento de Categoria";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnAgregar;
        private TextBox txtBuscar;
        private Label label2;
        private DataGridView dgvCategorias;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnCerrar;
        private Label label3;
        private Label lblRegistros;
    }
}