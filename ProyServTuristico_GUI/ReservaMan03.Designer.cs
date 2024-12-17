namespace ProyServTuristico_GUI
{
    partial class ReservaMan03
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            btnAgregarCliente = new Button();
            txtApeCliFiltro = new TextBox();
            txtNomCliFiltro = new TextBox();
            label3 = new Label();
            dtgClientesReg = new DataGridView();
            ID_Cliente = new DataGridViewTextBoxColumn();
            Nom_Cli = new DataGridViewTextBoxColumn();
            Ape_Cli = new DataGridViewTextBoxColumn();
            Dni_Cli = new DataGridViewTextBoxColumn();
            Num_Tel = new DataGridViewTextBoxColumn();
            Email_Cli = new DataGridViewTextBoxColumn();
            Sex_Cli = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label1 = new Label();
            lblNoDisponible = new Label();
            cboAlojamientosDisponibles = new ComboBox();
            cboDepaTour = new ComboBox();
            dtgTourDis = new DataGridView();
            ID_Tour = new DataGridViewTextBoxColumn();
            Fec_Ini_Tour = new DataGridViewTextBoxColumn();
            Fec_Fin_Tour = new DataGridViewTextBoxColumn();
            ID_Ubicacion = new DataGridViewTextBoxColumn();
            Departamento = new DataGridViewTextBoxColumn();
            Provincia = new DataGridViewTextBoxColumn();
            Distrito = new DataGridViewTextBoxColumn();
            Est_Tour_Des = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label8 = new Label();
            label4 = new Label();
            label6 = new Label();
            lblCodReserva = new Label();
            dtpFecReserva = new DateTimePicker();
            label7 = new Label();
            btnCancelar = new Button();
            btnActualizar = new Button();
            button1 = new Button();
            chkEstado = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dtgClientesReg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgTourDis).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(826, 260);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(193, 29);
            btnAgregarCliente.TabIndex = 8;
            btnAgregarCliente.Text = "Agregar Nuevo Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // txtApeCliFiltro
            // 
            txtApeCliFiltro.Location = new Point(289, 77);
            txtApeCliFiltro.Name = "txtApeCliFiltro";
            txtApeCliFiltro.Size = new Size(125, 27);
            txtApeCliFiltro.TabIndex = 6;
            txtApeCliFiltro.TextChanged += txtApeCliFiltro_TextChanged;
            // 
            // txtNomCliFiltro
            // 
            txtNomCliFiltro.Location = new Point(79, 77);
            txtNomCliFiltro.Name = "txtNomCliFiltro";
            txtNomCliFiltro.Size = new Size(125, 27);
            txtNomCliFiltro.TabIndex = 7;
            txtNomCliFiltro.TextChanged += txtNomCliFiltro_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 80);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 4;
            label3.Text = "Apellido: ";
            // 
            // dtgClientesReg
            // 
            dtgClientesReg.AllowUserToAddRows = false;
            dtgClientesReg.AllowUserToDeleteRows = false;
            dtgClientesReg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgClientesReg.Columns.AddRange(new DataGridViewColumn[] { ID_Cliente, Nom_Cli, Ape_Cli, Dni_Cli, Num_Tel, Email_Cli, Sex_Cli, Estado });
            dtgClientesReg.Location = new Point(13, 109);
            dtgClientesReg.MultiSelect = false;
            dtgClientesReg.Name = "dtgClientesReg";
            dtgClientesReg.ReadOnly = true;
            dtgClientesReg.RowHeadersVisible = false;
            dtgClientesReg.RowHeadersWidth = 51;
            dtgClientesReg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgClientesReg.Size = new Size(1006, 144);
            dtgClientesReg.TabIndex = 5;
            // 
            // ID_Cliente
            // 
            ID_Cliente.DataPropertyName = "ID_Cliente";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ID_Cliente.DefaultCellStyle = dataGridViewCellStyle1;
            ID_Cliente.HeaderText = "CodCliente";
            ID_Cliente.MinimumWidth = 6;
            ID_Cliente.Name = "ID_Cliente";
            ID_Cliente.ReadOnly = true;
            ID_Cliente.Width = 125;
            // 
            // Nom_Cli
            // 
            Nom_Cli.DataPropertyName = "Nom_Cli";
            Nom_Cli.HeaderText = "Nombre";
            Nom_Cli.MinimumWidth = 6;
            Nom_Cli.Name = "Nom_Cli";
            Nom_Cli.ReadOnly = true;
            Nom_Cli.Width = 125;
            // 
            // Ape_Cli
            // 
            Ape_Cli.DataPropertyName = "Ape_Cli";
            Ape_Cli.HeaderText = "Apellido";
            Ape_Cli.MinimumWidth = 6;
            Ape_Cli.Name = "Ape_Cli";
            Ape_Cli.ReadOnly = true;
            Ape_Cli.Width = 125;
            // 
            // Dni_Cli
            // 
            Dni_Cli.DataPropertyName = "Dni_Cli";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dni_Cli.DefaultCellStyle = dataGridViewCellStyle2;
            Dni_Cli.HeaderText = "DNI";
            Dni_Cli.MinimumWidth = 6;
            Dni_Cli.Name = "Dni_Cli";
            Dni_Cli.ReadOnly = true;
            Dni_Cli.Width = 125;
            // 
            // Num_Tel
            // 
            Num_Tel.DataPropertyName = "Num_Tel";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Num_Tel.DefaultCellStyle = dataGridViewCellStyle3;
            Num_Tel.HeaderText = "Telefono";
            Num_Tel.MinimumWidth = 6;
            Num_Tel.Name = "Num_Tel";
            Num_Tel.ReadOnly = true;
            Num_Tel.Width = 125;
            // 
            // Email_Cli
            // 
            Email_Cli.DataPropertyName = "Email_Cli";
            Email_Cli.HeaderText = "Correo";
            Email_Cli.MinimumWidth = 6;
            Email_Cli.Name = "Email_Cli";
            Email_Cli.ReadOnly = true;
            Email_Cli.Width = 125;
            // 
            // Sex_Cli
            // 
            Sex_Cli.DataPropertyName = "Sex_Cli";
            Sex_Cli.HeaderText = "Sexo";
            Sex_Cli.MinimumWidth = 6;
            Sex_Cli.Name = "Sex_Cli";
            Sex_Cli.ReadOnly = true;
            Sex_Cli.Width = 125;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 81);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 9;
            label2.Text = "Nombre: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 51);
            label1.Name = "label1";
            label1.Size = new Size(71, 23);
            label1.TabIndex = 10;
            label1.Text = "Cliente:";
            // 
            // lblNoDisponible
            // 
            lblNoDisponible.AutoSize = true;
            lblNoDisponible.Location = new Point(835, 391);
            lblNoDisponible.Name = "lblNoDisponible";
            lblNoDisponible.Size = new Size(191, 20);
            lblNoDisponible.TabIndex = 17;
            lblNoDisponible.Text = "No hay Hoteles disponibles";
            // 
            // cboAlojamientosDisponibles
            // 
            cboAlojamientosDisponibles.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAlojamientosDisponibles.FormattingEnabled = true;
            cboAlojamientosDisponibles.Location = new Point(846, 360);
            cboAlojamientosDisponibles.Name = "cboAlojamientosDisponibles";
            cboAlojamientosDisponibles.Size = new Size(180, 28);
            cboAlojamientosDisponibles.TabIndex = 15;
            // 
            // cboDepaTour
            // 
            cboDepaTour.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepaTour.FormattingEnabled = true;
            cboDepaTour.Location = new Point(131, 301);
            cboDepaTour.Name = "cboDepaTour";
            cboDepaTour.Size = new Size(151, 28);
            cboDepaTour.TabIndex = 16;
            cboDepaTour.SelectionChangeCommitted += cboDepaTour_SelectionChangeCommitted;
            // 
            // dtgTourDis
            // 
            dtgTourDis.AllowUserToAddRows = false;
            dtgTourDis.AllowUserToDeleteRows = false;
            dtgTourDis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTourDis.Columns.AddRange(new DataGridViewColumn[] { ID_Tour, Fec_Ini_Tour, Fec_Fin_Tour, ID_Ubicacion, Departamento, Provincia, Distrito, Est_Tour_Des });
            dtgTourDis.Location = new Point(11, 348);
            dtgTourDis.MultiSelect = false;
            dtgTourDis.Name = "dtgTourDis";
            dtgTourDis.ReadOnly = true;
            dtgTourDis.RowHeadersVisible = false;
            dtgTourDis.RowHeadersWidth = 51;
            dtgTourDis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgTourDis.Size = new Size(663, 188);
            dtgTourDis.TabIndex = 14;
            dtgTourDis.SelectionChanged += dtgTourDis_SelectionChanged;
            // 
            // ID_Tour
            // 
            ID_Tour.DataPropertyName = "ID_Tour";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ID_Tour.DefaultCellStyle = dataGridViewCellStyle4;
            ID_Tour.HeaderText = "CodTour";
            ID_Tour.MinimumWidth = 6;
            ID_Tour.Name = "ID_Tour";
            ID_Tour.ReadOnly = true;
            ID_Tour.Width = 125;
            // 
            // Fec_Ini_Tour
            // 
            Fec_Ini_Tour.DataPropertyName = "Fec_Ini_Tour";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "d";
            Fec_Ini_Tour.DefaultCellStyle = dataGridViewCellStyle5;
            Fec_Ini_Tour.HeaderText = "Fecha Inicio";
            Fec_Ini_Tour.MinimumWidth = 6;
            Fec_Ini_Tour.Name = "Fec_Ini_Tour";
            Fec_Ini_Tour.ReadOnly = true;
            Fec_Ini_Tour.Width = 125;
            // 
            // Fec_Fin_Tour
            // 
            Fec_Fin_Tour.DataPropertyName = "Fec_Fin_Tour";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "d";
            Fec_Fin_Tour.DefaultCellStyle = dataGridViewCellStyle6;
            Fec_Fin_Tour.HeaderText = "Fecha Fin";
            Fec_Fin_Tour.MinimumWidth = 6;
            Fec_Fin_Tour.Name = "Fec_Fin_Tour";
            Fec_Fin_Tour.ReadOnly = true;
            Fec_Fin_Tour.Width = 125;
            // 
            // ID_Ubicacion
            // 
            ID_Ubicacion.DataPropertyName = "ID_Ubicacion";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ID_Ubicacion.DefaultCellStyle = dataGridViewCellStyle7;
            ID_Ubicacion.HeaderText = "CodUbicacion";
            ID_Ubicacion.MinimumWidth = 6;
            ID_Ubicacion.Name = "ID_Ubicacion";
            ID_Ubicacion.ReadOnly = true;
            ID_Ubicacion.Width = 125;
            // 
            // Departamento
            // 
            Departamento.DataPropertyName = "Departamento";
            Departamento.HeaderText = "Departamento";
            Departamento.MinimumWidth = 6;
            Departamento.Name = "Departamento";
            Departamento.ReadOnly = true;
            Departamento.Width = 125;
            // 
            // Provincia
            // 
            Provincia.DataPropertyName = "Provincia";
            Provincia.HeaderText = "Provincia";
            Provincia.MinimumWidth = 6;
            Provincia.Name = "Provincia";
            Provincia.ReadOnly = true;
            Provincia.Width = 125;
            // 
            // Distrito
            // 
            Distrito.DataPropertyName = "Distrito";
            Distrito.HeaderText = "Distrito";
            Distrito.MinimumWidth = 6;
            Distrito.Name = "Distrito";
            Distrito.ReadOnly = true;
            Distrito.Width = 125;
            // 
            // Est_Tour_Des
            // 
            Est_Tour_Des.DataPropertyName = "Est_Tour_Des";
            Est_Tour_Des.HeaderText = "Estado Tour";
            Est_Tour_Des.MinimumWidth = 6;
            Est_Tour_Des.Name = "Est_Tour_Des";
            Est_Tour_Des.ReadOnly = true;
            Est_Tour_Des.Width = 125;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 305);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 11;
            label5.Text = "Departamento: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(713, 325);
            label8.Name = "label8";
            label8.Size = new Size(180, 23);
            label8.TabIndex = 12;
            label8.Text = "Estadías disponibles: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 272);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 13;
            label4.Text = "Tour:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 19);
            label6.Name = "label6";
            label6.Size = new Size(170, 23);
            label6.TabIndex = 10;
            label6.Text = "Código de Reserva: ";
            // 
            // lblCodReserva
            // 
            lblCodReserva.BorderStyle = BorderStyle.FixedSingle;
            lblCodReserva.Location = new Point(189, 20);
            lblCodReserva.Name = "lblCodReserva";
            lblCodReserva.Size = new Size(61, 25);
            lblCodReserva.TabIndex = 18;
            lblCodReserva.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpFecReserva
            // 
            dtpFecReserva.Format = DateTimePickerFormat.Short;
            dtpFecReserva.Location = new Point(846, 436);
            dtpFecReserva.Name = "dtpFecReserva";
            dtpFecReserva.Size = new Size(122, 27);
            dtpFecReserva.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(709, 436);
            label7.Name = "label7";
            label7.Size = new Size(132, 23);
            label7.TabIndex = 19;
            label7.Text = "Fecha Reserva: ";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(950, 565);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(789, 565);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 22;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(723, 360);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 23;
            button1.Text = "Cambiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(801, 499);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(72, 24);
            chkEstado.TabIndex = 24;
            chkEstado.Text = "Activa";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // ReservaMan03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 607);
            Controls.Add(chkEstado);
            Controls.Add(button1);
            Controls.Add(btnCancelar);
            Controls.Add(btnActualizar);
            Controls.Add(dtpFecReserva);
            Controls.Add(label7);
            Controls.Add(lblCodReserva);
            Controls.Add(lblNoDisponible);
            Controls.Add(cboAlojamientosDisponibles);
            Controls.Add(cboDepaTour);
            Controls.Add(dtgTourDis);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(btnAgregarCliente);
            Controls.Add(txtApeCliFiltro);
            Controls.Add(txtNomCliFiltro);
            Controls.Add(label3);
            Controls.Add(dtgClientesReg);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReservaMan03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualización de Reserva: ";
            Load += ReservaMan03_Load;
            ((System.ComponentModel.ISupportInitialize)dtgClientesReg).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgTourDis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarCliente;
        private TextBox txtApeCliFiltro;
        private TextBox txtNomCliFiltro;
        private Label label3;
        private DataGridView dtgClientesReg;
        private DataGridViewTextBoxColumn ID_Cliente;
        private DataGridViewTextBoxColumn Nom_Cli;
        private DataGridViewTextBoxColumn Ape_Cli;
        private DataGridViewTextBoxColumn Dni_Cli;
        private DataGridViewTextBoxColumn Num_Tel;
        private DataGridViewTextBoxColumn Email_Cli;
        private DataGridViewTextBoxColumn Sex_Cli;
        private DataGridViewTextBoxColumn Estado;
        private Label label2;
        private Label label1;
        private Label lblNoDisponible;
        private ComboBox cboAlojamientosDisponibles;
        private ComboBox cboDepaTour;
        private DataGridView dtgTourDis;
        private DataGridViewTextBoxColumn ID_Tour;
        private DataGridViewTextBoxColumn Fec_Ini_Tour;
        private DataGridViewTextBoxColumn Fec_Fin_Tour;
        private DataGridViewTextBoxColumn ID_Ubicacion;
        private DataGridViewTextBoxColumn Departamento;
        private DataGridViewTextBoxColumn Provincia;
        private DataGridViewTextBoxColumn Distrito;
        private DataGridViewTextBoxColumn Est_Tour_Des;
        private Label label5;
        private Label label8;
        private Label label4;
        private Label label6;
        private Label lblCodReserva;
        private DateTimePicker dtpFecReserva;
        private Label label7;
        private Button btnCancelar;
        private Button btnActualizar;
        private Button button1;
        private CheckBox chkEstado;
    }
}