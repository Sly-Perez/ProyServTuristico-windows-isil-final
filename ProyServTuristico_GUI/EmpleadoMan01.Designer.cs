namespace ProyServTuristico_GUI
{
    partial class EmpleadoMan01
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnCerrar = new Button();
            label4 = new Label();
            lblRegistros = new Label();
            dtgEmpleado = new DataGridView();
            ID_Empleado = new DataGridViewTextBoxColumn();
            Nom_Emp = new DataGridViewTextBoxColumn();
            Ape_Emp = new DataGridViewTextBoxColumn();
            Dni_Emp = new DataGridViewTextBoxColumn();
            Tel_Emp = new DataGridViewTextBoxColumn();
            Email_Emp = new DataGridViewTextBoxColumn();
            Rol_Emp = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            txtApeEmpFiltro = new TextBox();
            txtNomEmpFiltro = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgEmpleado).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(427, 432);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(111, 43);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(577, 432);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(111, 43);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(725, 432);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(111, 43);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(870, 432);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(111, 43);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 443);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 2;
            label4.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(175, 439);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(96, 29);
            lblRegistros.TabIndex = 2;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtgEmpleado
            // 
            dtgEmpleado.AllowUserToAddRows = false;
            dtgEmpleado.AllowUserToDeleteRows = false;
            dtgEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEmpleado.Columns.AddRange(new DataGridViewColumn[] { ID_Empleado, Nom_Emp, Ape_Emp, Dni_Emp, Tel_Emp, Email_Emp, Rol_Emp, Estado });
            dtgEmpleado.Location = new Point(27, 85);
            dtgEmpleado.MultiSelect = false;
            dtgEmpleado.Name = "dtgEmpleado";
            dtgEmpleado.ReadOnly = true;
            dtgEmpleado.RowHeadersVisible = false;
            dtgEmpleado.RowHeadersWidth = 51;
            dtgEmpleado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgEmpleado.Size = new Size(1003, 315);
            dtgEmpleado.TabIndex = 4;
            // 
            // ID_Empleado
            // 
            ID_Empleado.DataPropertyName = "ID_Empleado";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ID_Empleado.DefaultCellStyle = dataGridViewCellStyle1;
            ID_Empleado.HeaderText = "ID Empleados";
            ID_Empleado.MinimumWidth = 6;
            ID_Empleado.Name = "ID_Empleado";
            ID_Empleado.ReadOnly = true;
            ID_Empleado.Width = 125;
            // 
            // Nom_Emp
            // 
            Nom_Emp.DataPropertyName = "Nom_Emp";
            Nom_Emp.HeaderText = "Nombre";
            Nom_Emp.MinimumWidth = 6;
            Nom_Emp.Name = "Nom_Emp";
            Nom_Emp.ReadOnly = true;
            Nom_Emp.Width = 125;
            // 
            // Ape_Emp
            // 
            Ape_Emp.DataPropertyName = "Ape_Emp";
            Ape_Emp.HeaderText = "Apellido";
            Ape_Emp.MinimumWidth = 6;
            Ape_Emp.Name = "Ape_Emp";
            Ape_Emp.ReadOnly = true;
            Ape_Emp.Width = 125;
            // 
            // Dni_Emp
            // 
            Dni_Emp.DataPropertyName = "Dni_Emp";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dni_Emp.DefaultCellStyle = dataGridViewCellStyle2;
            Dni_Emp.HeaderText = "DNI";
            Dni_Emp.MinimumWidth = 6;
            Dni_Emp.Name = "Dni_Emp";
            Dni_Emp.ReadOnly = true;
            Dni_Emp.Width = 125;
            // 
            // Tel_Emp
            // 
            Tel_Emp.DataPropertyName = "Tel_Emp";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Tel_Emp.DefaultCellStyle = dataGridViewCellStyle3;
            Tel_Emp.HeaderText = "Telefono";
            Tel_Emp.MinimumWidth = 6;
            Tel_Emp.Name = "Tel_Emp";
            Tel_Emp.ReadOnly = true;
            Tel_Emp.Width = 125;
            // 
            // Email_Emp
            // 
            Email_Emp.DataPropertyName = "Email_Emp";
            Email_Emp.HeaderText = "Correo";
            Email_Emp.MinimumWidth = 6;
            Email_Emp.Name = "Email_Emp";
            Email_Emp.ReadOnly = true;
            Email_Emp.Width = 125;
            // 
            // Rol_Emp
            // 
            Rol_Emp.DataPropertyName = "Rol_Emp";
            Rol_Emp.HeaderText = "Cargo";
            Rol_Emp.MinimumWidth = 6;
            Rol_Emp.Name = "Rol_Emp";
            Rol_Emp.ReadOnly = true;
            Rol_Emp.Width = 125;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 125;
            // 
            // txtApeEmpFiltro
            // 
            txtApeEmpFiltro.Location = new Point(694, 29);
            txtApeEmpFiltro.Name = "txtApeEmpFiltro";
            txtApeEmpFiltro.Size = new Size(125, 27);
            txtApeEmpFiltro.TabIndex = 15;
            // 
            // txtNomEmpFiltro
            // 
            txtNomEmpFiltro.Location = new Point(447, 29);
            txtNomEmpFiltro.Name = "txtNomEmpFiltro";
            txtNomEmpFiltro.Size = new Size(125, 27);
            txtNomEmpFiltro.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(613, 33);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 11;
            label3.Text = "Apellidos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(374, 33);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 12;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 33);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 13;
            label1.Text = "Filtro de Empleado por: ";
            // 
            // EmpleadoMan01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 523);
            Controls.Add(txtApeEmpFiltro);
            Controls.Add(txtNomEmpFiltro);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtgEmpleado);
            Controls.Add(lblRegistros);
            Controls.Add(label4);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmpleadoMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Empleado";
            Load += EmpleadoMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgEmpleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnCerrar;
        private Label label4;
        private Label lblRegistros;
        private DataGridView dtgEmpleado;
        private TextBox txtApeEmpFiltro;
        private TextBox txtNomEmpFiltro;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn ID_Empleado;
        private DataGridViewTextBoxColumn Nom_Emp;
        private DataGridViewTextBoxColumn Ape_Emp;
        private DataGridViewTextBoxColumn Dni_Emp;
        private DataGridViewTextBoxColumn Tel_Emp;
        private DataGridViewTextBoxColumn Email_Emp;
        private DataGridViewTextBoxColumn Rol_Emp;
        private DataGridViewTextBoxColumn Estado;
    }
}