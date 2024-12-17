namespace ProyServTuristico_GUI
{
    partial class ReservaMan01
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label1 = new Label();
            btnAgregar = new Button();
            btnActualizar = new Button();
            label2 = new Label();
            lblRegistros = new Label();
            dtgDatos = new DataGridView();
            ID_Reserva = new DataGridViewTextBoxColumn();
            Fec_Res = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Nom_Cli = new DataGridViewTextBoxColumn();
            Ape_Cli = new DataGridViewTextBoxColumn();
            Departamento = new DataGridViewTextBoxColumn();
            Provincia = new DataGridViewTextBoxColumn();
            Distrito = new DataGridViewTextBoxColumn();
            Fec_Ini_Tour = new DataGridViewTextBoxColumn();
            Fec_Fin_Tour = new DataGridViewTextBoxColumn();
            Est_Tour = new DataGridViewTextBoxColumn();
            txtNomCliFiltro = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cboDepaFiltro = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(203, 20);
            label1.TabIndex = 1;
            label1.Text = "Ingrese filtro de Reserva por: ";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(661, 457);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(95, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(784, 457);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(95, 29);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(907, 457);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Registros: ";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(981, 447);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(77, 42);
            lblRegistros.TabIndex = 1;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { ID_Reserva, Fec_Res, Estado, Nom_Cli, Ape_Cli, Departamento, Provincia, Distrito, Fec_Ini_Tour, Fec_Fin_Tour, Est_Tour });
            dtgDatos.Location = new Point(11, 79);
            dtgDatos.MultiSelect = false;
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.RowHeadersWidth = 51;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1055, 351);
            dtgDatos.TabIndex = 3;
            // 
            // ID_Reserva
            // 
            ID_Reserva.DataPropertyName = "ID_Reserva";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ID_Reserva.DefaultCellStyle = dataGridViewCellStyle1;
            ID_Reserva.HeaderText = "CodReserva";
            ID_Reserva.MinimumWidth = 6;
            ID_Reserva.Name = "ID_Reserva";
            ID_Reserva.ReadOnly = true;
            // 
            // Fec_Res
            // 
            Fec_Res.DataPropertyName = "Fec_Res";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            Fec_Res.DefaultCellStyle = dataGridViewCellStyle2;
            Fec_Res.HeaderText = "FechaReserva";
            Fec_Res.MinimumWidth = 6;
            Fec_Res.Name = "Fec_Res";
            Fec_Res.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "EstadoReserva";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // Nom_Cli
            // 
            Nom_Cli.DataPropertyName = "Nom_Cli";
            Nom_Cli.HeaderText = "NomCliente";
            Nom_Cli.MinimumWidth = 6;
            Nom_Cli.Name = "Nom_Cli";
            Nom_Cli.ReadOnly = true;
            // 
            // Ape_Cli
            // 
            Ape_Cli.DataPropertyName = "Ape_Cli";
            Ape_Cli.HeaderText = "ApeCliente";
            Ape_Cli.MinimumWidth = 6;
            Ape_Cli.Name = "Ape_Cli";
            Ape_Cli.ReadOnly = true;
            // 
            // Departamento
            // 
            Departamento.DataPropertyName = "Departamento";
            Departamento.HeaderText = "DepaDestino";
            Departamento.MinimumWidth = 6;
            Departamento.Name = "Departamento";
            Departamento.ReadOnly = true;
            // 
            // Provincia
            // 
            Provincia.DataPropertyName = "Provincia";
            Provincia.HeaderText = "ProvinDestino";
            Provincia.MinimumWidth = 6;
            Provincia.Name = "Provincia";
            Provincia.ReadOnly = true;
            // 
            // Distrito
            // 
            Distrito.DataPropertyName = "Distrito";
            Distrito.HeaderText = "DistriDestino";
            Distrito.MinimumWidth = 6;
            Distrito.Name = "Distrito";
            Distrito.ReadOnly = true;
            // 
            // Fec_Ini_Tour
            // 
            Fec_Ini_Tour.DataPropertyName = "Fec_Ini_Tour";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            Fec_Ini_Tour.DefaultCellStyle = dataGridViewCellStyle3;
            Fec_Ini_Tour.HeaderText = "InicioTour";
            Fec_Ini_Tour.MinimumWidth = 6;
            Fec_Ini_Tour.Name = "Fec_Ini_Tour";
            Fec_Ini_Tour.ReadOnly = true;
            // 
            // Fec_Fin_Tour
            // 
            Fec_Fin_Tour.DataPropertyName = "Fec_Fin_Tour";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "d";
            Fec_Fin_Tour.DefaultCellStyle = dataGridViewCellStyle4;
            Fec_Fin_Tour.HeaderText = "FinTour";
            Fec_Fin_Tour.MinimumWidth = 6;
            Fec_Fin_Tour.Name = "Fec_Fin_Tour";
            Fec_Fin_Tour.ReadOnly = true;
            // 
            // Est_Tour
            // 
            Est_Tour.DataPropertyName = "Est_Tour_Des";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Est_Tour.DefaultCellStyle = dataGridViewCellStyle5;
            Est_Tour.HeaderText = "EstadoTour";
            Est_Tour.MinimumWidth = 6;
            Est_Tour.Name = "Est_Tour";
            Est_Tour.ReadOnly = true;
            // 
            // txtNomCliFiltro
            // 
            txtNomCliFiltro.Location = new Point(251, 36);
            txtNomCliFiltro.Name = "txtNomCliFiltro";
            txtNomCliFiltro.Size = new Size(125, 27);
            txtNomCliFiltro.TabIndex = 4;
            txtNomCliFiltro.TextChanged += txtNomCliFiltro_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 43);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 1;
            label3.Text = "Nombre Cliente: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 43);
            label4.Name = "label4";
            label4.Size = new Size(168, 20);
            label4.TabIndex = 1;
            label4.Text = "Departamento Destino: ";
            // 
            // cboDepaFiltro
            // 
            cboDepaFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepaFiltro.FormattingEnabled = true;
            cboDepaFiltro.Location = new Point(603, 36);
            cboDepaFiltro.Name = "cboDepaFiltro";
            cboDepaFiltro.Size = new Size(151, 28);
            cboDepaFiltro.TabIndex = 5;
            cboDepaFiltro.SelectedValueChanged += cboDepaFiltro_SelectedValueChanged;
            // 
            // ReservaMan01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 509);
            Controls.Add(cboDepaFiltro);
            Controls.Add(txtNomCliFiltro);
            Controls.Add(dtgDatos);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReservaMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Reservas";
            Load += ReservaMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnAgregar;
        private Button btnActualizar;
        private Label label2;
        private Label lblRegistros;
        private DataGridView dtgDatos;
        private TextBox txtNomCliFiltro;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn ID_Reserva;
        private DataGridViewTextBoxColumn Fec_Res;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Nom_Cli;
        private DataGridViewTextBoxColumn Ape_Cli;
        private DataGridViewTextBoxColumn Departamento;
        private DataGridViewTextBoxColumn Provincia;
        private DataGridViewTextBoxColumn Distrito;
        private DataGridViewTextBoxColumn Fec_Ini_Tour;
        private DataGridViewTextBoxColumn Fec_Fin_Tour;
        private DataGridViewTextBoxColumn Est_Tour;
        private ComboBox cboDepaFiltro;
    }
}