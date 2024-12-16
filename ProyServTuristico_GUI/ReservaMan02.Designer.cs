namespace ProyServTuristico_GUI
{
    partial class ReservaMan02
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAgregarCliente = new Button();
            label4 = new Label();
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
            cboDepaTour = new ComboBox();
            label6 = new Label();
            dtpFecReserva = new DateTimePicker();
            label7 = new Label();
            groupBox1 = new GroupBox();
            rtbTarjetaDebito = new RadioButton();
            rtbTarjetaCredito = new RadioButton();
            rtbEfectivo = new RadioButton();
            btnGrabar = new Button();
            btnCancelar = new Button();
            cboAlojamientosDisponibles = new ComboBox();
            label8 = new Label();
            lblNoDisponible = new Label();
            txtTotal = new TextBox();
            label9 = new Label();
            label10 = new Label();
            cboCategoria = new ComboBox();
            txtCantidadNoches = new TextBox();
            label11 = new Label();
            lblTarifaNoche = new Label();
            lblNomCli = new Label();
            lblApeCli = new Label();
            label12 = new Label();
            lblDniCli = new Label();
            label14 = new Label();
            lblTelCli = new Label();
            label16 = new Label();
            lblSexoCli = new Label();
            label18 = new Label();
            lblEstadoCli = new Label();
            label13 = new Label();
            lblEmailCli = new Label();
            label19 = new Label();
            lblFecNacCli = new Label();
            txtCodCli = new TextBox();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgTourDis).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 10);
            label1.Name = "label1";
            label1.Size = new Size(71, 23);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 111);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 114);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 0;
            label3.Text = "Apellido: ";
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(845, 209);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(193, 29);
            btnAgregarCliente.TabIndex = 3;
            btnAgregarCliente.Text = "Agregar Nuevo Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(54, 364);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 0;
            label4.Text = "Tour:";
            // 
            // dtgTourDis
            // 
            dtgTourDis.AllowUserToAddRows = false;
            dtgTourDis.AllowUserToDeleteRows = false;
            dtgTourDis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTourDis.Columns.AddRange(new DataGridViewColumn[] { ID_Tour, Fec_Ini_Tour, Fec_Fin_Tour, ID_Ubicacion, Departamento, Provincia, Distrito, Est_Tour_Des });
            dtgTourDis.Location = new Point(53, 440);
            dtgTourDis.MultiSelect = false;
            dtgTourDis.Name = "dtgTourDis";
            dtgTourDis.ReadOnly = true;
            dtgTourDis.RowHeadersVisible = false;
            dtgTourDis.RowHeadersWidth = 51;
            dtgTourDis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgTourDis.Size = new Size(663, 188);
            dtgTourDis.TabIndex = 1;
            dtgTourDis.SelectionChanged += dtgTourDis_SelectionChanged;
            // 
            // ID_Tour
            // 
            ID_Tour.DataPropertyName = "ID_Tour";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ID_Tour.DefaultCellStyle = dataGridViewCellStyle1;
            ID_Tour.HeaderText = "CodTour";
            ID_Tour.MinimumWidth = 6;
            ID_Tour.Name = "ID_Tour";
            ID_Tour.ReadOnly = true;
            ID_Tour.Width = 125;
            // 
            // Fec_Ini_Tour
            // 
            Fec_Ini_Tour.DataPropertyName = "Fec_Ini_Tour";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            Fec_Ini_Tour.DefaultCellStyle = dataGridViewCellStyle2;
            Fec_Ini_Tour.HeaderText = "Fecha Inicio";
            Fec_Ini_Tour.MinimumWidth = 6;
            Fec_Ini_Tour.Name = "Fec_Ini_Tour";
            Fec_Ini_Tour.ReadOnly = true;
            Fec_Ini_Tour.Width = 125;
            // 
            // Fec_Fin_Tour
            // 
            Fec_Fin_Tour.DataPropertyName = "Fec_Fin_Tour";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            Fec_Fin_Tour.DefaultCellStyle = dataGridViewCellStyle3;
            Fec_Fin_Tour.HeaderText = "Fecha Fin";
            Fec_Fin_Tour.MinimumWidth = 6;
            Fec_Fin_Tour.Name = "Fec_Fin_Tour";
            Fec_Fin_Tour.ReadOnly = true;
            Fec_Fin_Tour.Width = 125;
            // 
            // ID_Ubicacion
            // 
            ID_Ubicacion.DataPropertyName = "ID_Ubicacion";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ID_Ubicacion.DefaultCellStyle = dataGridViewCellStyle4;
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
            label5.Location = new Point(53, 397);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 0;
            label5.Text = "Departamento: ";
            // 
            // cboDepaTour
            // 
            cboDepaTour.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepaTour.FormattingEnabled = true;
            cboDepaTour.Location = new Point(171, 393);
            cboDepaTour.Name = "cboDepaTour";
            cboDepaTour.Size = new Size(151, 28);
            cboDepaTour.TabIndex = 4;
            cboDepaTour.SelectedValueChanged += cboDepaTour_SelectedValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(40, 660);
            label6.Name = "label6";
            label6.Size = new Size(132, 23);
            label6.TabIndex = 0;
            label6.Text = "Fecha Reserva: ";
            // 
            // dtpFecReserva
            // 
            dtpFecReserva.Format = DateTimePickerFormat.Short;
            dtpFecReserva.Location = new Point(177, 660);
            dtpFecReserva.Name = "dtpFecReserva";
            dtpFecReserva.Size = new Size(122, 27);
            dtpFecReserva.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(387, 664);
            label7.Name = "label7";
            label7.Size = new Size(144, 23);
            label7.TabIndex = 0;
            label7.Text = "Monto Total(s/): ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rtbTarjetaDebito);
            groupBox1.Controls.Add(rtbTarjetaCredito);
            groupBox1.Controls.Add(rtbEfectivo);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(750, 523);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(277, 125);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Método de Pago: ";
            // 
            // rtbTarjetaDebito
            // 
            rtbTarjetaDebito.AutoSize = true;
            rtbTarjetaDebito.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbTarjetaDebito.Location = new Point(154, 36);
            rtbTarjetaDebito.Name = "rtbTarjetaDebito";
            rtbTarjetaDebito.Size = new Size(124, 24);
            rtbTarjetaDebito.TabIndex = 0;
            rtbTarjetaDebito.Text = "Tarjeta Débito";
            rtbTarjetaDebito.UseVisualStyleBackColor = true;
            // 
            // rtbTarjetaCredito
            // 
            rtbTarjetaCredito.AutoSize = true;
            rtbTarjetaCredito.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbTarjetaCredito.Location = new Point(17, 77);
            rtbTarjetaCredito.Name = "rtbTarjetaCredito";
            rtbTarjetaCredito.Size = new Size(127, 24);
            rtbTarjetaCredito.TabIndex = 0;
            rtbTarjetaCredito.Text = "Tarjeta Crédito";
            rtbTarjetaCredito.UseVisualStyleBackColor = true;
            // 
            // rtbEfectivo
            // 
            rtbEfectivo.AutoSize = true;
            rtbEfectivo.Checked = true;
            rtbEfectivo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbEfectivo.Location = new Point(17, 35);
            rtbEfectivo.Name = "rtbEfectivo";
            rtbEfectivo.Size = new Size(83, 24);
            rtbEfectivo.TabIndex = 0;
            rtbEfectivo.TabStop = true;
            rtbEfectivo.Text = "Efectivo";
            rtbEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(782, 693);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(94, 29);
            btnGrabar.TabIndex = 8;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(944, 693);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cboAlojamientosDisponibles
            // 
            cboAlojamientosDisponibles.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAlojamientosDisponibles.FormattingEnabled = true;
            cboAlojamientosDisponibles.Location = new Point(750, 443);
            cboAlojamientosDisponibles.Name = "cboAlojamientosDisponibles";
            cboAlojamientosDisponibles.Size = new Size(255, 28);
            cboAlojamientosDisponibles.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(750, 416);
            label8.Name = "label8";
            label8.Size = new Size(180, 23);
            label8.TabIndex = 0;
            label8.Text = "Estadías disponibles: ";
            // 
            // lblNoDisponible
            // 
            lblNoDisponible.AutoSize = true;
            lblNoDisponible.Location = new Point(750, 473);
            lblNoDisponible.Name = "lblNoDisponible";
            lblNoDisponible.Size = new Size(191, 20);
            lblNoDisponible.TabIndex = 9;
            lblNoDisponible.Text = "No hay Hoteles disponibles";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(537, 664);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(53, 267);
            label9.Name = "label9";
            label9.Size = new Size(221, 23);
            label9.TabIndex = 11;
            label9.Text = "Categoria de Alojamiento:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(546, 307);
            label10.Name = "label10";
            label10.Size = new Size(177, 23);
            label10.TabIndex = 12;
            label10.Text = "Cantidad de noches: ";
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(53, 307);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(151, 28);
            cboCategoria.TabIndex = 13;
            cboCategoria.SelectionChangeCommitted += cboCategoria_SelectionChangeCommitted;
            // 
            // txtCantidadNoches
            // 
            txtCantidadNoches.Location = new Point(737, 307);
            txtCantidadNoches.Margin = new Padding(3, 4, 3, 4);
            txtCantidadNoches.Name = "txtCantidadNoches";
            txtCantidadNoches.Size = new Size(60, 27);
            txtCantidadNoches.TabIndex = 14;
            txtCantidadNoches.TextChanged += txtCantidadNoches_TextChanged;
            txtCantidadNoches.KeyPress += txtCantidadNoches_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(234, 307);
            label11.Name = "label11";
            label11.Size = new Size(186, 23);
            label11.TabIndex = 15;
            label11.Text = "Tarifa por Noche (s/): ";
            // 
            // lblTarifaNoche
            // 
            lblTarifaNoche.BorderStyle = BorderStyle.FixedSingle;
            lblTarifaNoche.Location = new Point(419, 307);
            lblTarifaNoche.Name = "lblTarifaNoche";
            lblTarifaNoche.Size = new Size(68, 26);
            lblTarifaNoche.TabIndex = 19;
            lblTarifaNoche.TextAlign = ContentAlignment.MiddleCenter;
            lblTarifaNoche.TextChanged += lblTarifaNoche_TextChanged;
            // 
            // lblNomCli
            // 
            lblNomCli.BorderStyle = BorderStyle.FixedSingle;
            lblNomCli.Location = new Point(103, 109);
            lblNomCli.Name = "lblNomCli";
            lblNomCli.Size = new Size(125, 25);
            lblNomCli.TabIndex = 20;
            lblNomCli.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblApeCli
            // 
            lblApeCli.BorderStyle = BorderStyle.FixedSingle;
            lblApeCli.Location = new Point(374, 109);
            lblApeCli.Name = "lblApeCli";
            lblApeCli.Size = new Size(125, 25);
            lblApeCli.TabIndex = 20;
            lblApeCli.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(57, 165);
            label12.Name = "label12";
            label12.Size = new Size(42, 20);
            label12.TabIndex = 0;
            label12.Text = "DNI: ";
            // 
            // lblDniCli
            // 
            lblDniCli.BorderStyle = BorderStyle.FixedSingle;
            lblDniCli.Location = new Point(105, 160);
            lblDniCli.Name = "lblDniCli";
            lblDniCli.Size = new Size(125, 25);
            lblDniCli.TabIndex = 20;
            lblDniCli.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(296, 167);
            label14.Name = "label14";
            label14.Size = new Size(74, 20);
            label14.TabIndex = 0;
            label14.Text = "Telefono: ";
            // 
            // lblTelCli
            // 
            lblTelCli.BorderStyle = BorderStyle.FixedSingle;
            lblTelCli.Location = new Point(376, 165);
            lblTelCli.Name = "lblTelCli";
            lblTelCli.Size = new Size(125, 25);
            lblTelCli.TabIndex = 20;
            lblTelCli.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(305, 209);
            label16.Name = "label16";
            label16.Size = new Size(48, 20);
            label16.TabIndex = 0;
            label16.Text = "Sexo: ";
            // 
            // lblSexoCli
            // 
            lblSexoCli.BorderStyle = BorderStyle.FixedSingle;
            lblSexoCli.Location = new Point(374, 207);
            lblSexoCli.Name = "lblSexoCli";
            lblSexoCli.Size = new Size(125, 25);
            lblSexoCli.TabIndex = 20;
            lblSexoCli.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(47, 207);
            label18.Name = "label18";
            label18.Size = new Size(61, 20);
            label18.TabIndex = 0;
            label18.Text = "Estado: ";
            // 
            // lblEstadoCli
            // 
            lblEstadoCli.BorderStyle = BorderStyle.FixedSingle;
            lblEstadoCli.Location = new Point(105, 207);
            lblEstadoCli.Name = "lblEstadoCli";
            lblEstadoCli.Size = new Size(125, 25);
            lblEstadoCli.TabIndex = 20;
            lblEstadoCli.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(539, 114);
            label13.Name = "label13";
            label13.Size = new Size(53, 20);
            label13.TabIndex = 0;
            label13.Text = "Email: ";
            // 
            // lblEmailCli
            // 
            lblEmailCli.BorderStyle = BorderStyle.FixedSingle;
            lblEmailCli.Location = new Point(598, 109);
            lblEmailCli.Name = "lblEmailCli";
            lblEmailCli.Size = new Size(178, 25);
            lblEmailCli.TabIndex = 20;
            lblEmailCli.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(539, 170);
            label19.Name = "label19";
            label19.Size = new Size(156, 20);
            label19.TabIndex = 0;
            label19.Text = "Fecha de Nacimiento: ";
            // 
            // lblFecNacCli
            // 
            lblFecNacCli.BorderStyle = BorderStyle.FixedSingle;
            lblFecNacCli.Location = new Point(701, 165);
            lblFecNacCli.Name = "lblFecNacCli";
            lblFecNacCli.Size = new Size(125, 25);
            lblFecNacCli.TabIndex = 20;
            lblFecNacCli.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCodCli
            // 
            txtCodCli.Location = new Point(236, 46);
            txtCodCli.Name = "txtCodCli";
            txtCodCli.Size = new Size(125, 27);
            txtCodCli.TabIndex = 2;
            txtCodCli.TextChanged += txtCodCli_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(40, 49);
            label15.Name = "label15";
            label15.Size = new Size(190, 20);
            label15.TabIndex = 0;
            label15.Text = "Ingrese código del Cliente: ";
            // 
            // ReservaMan02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 751);
            Controls.Add(lblTelCli);
            Controls.Add(lblEmailCli);
            Controls.Add(lblEstadoCli);
            Controls.Add(lblFecNacCli);
            Controls.Add(lblDniCli);
            Controls.Add(lblApeCli);
            Controls.Add(lblSexoCli);
            Controls.Add(lblNomCli);
            Controls.Add(lblTarifaNoche);
            Controls.Add(label11);
            Controls.Add(txtCantidadNoches);
            Controls.Add(cboCategoria);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtTotal);
            Controls.Add(lblNoDisponible);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(groupBox1);
            Controls.Add(dtpFecReserva);
            Controls.Add(cboAlojamientosDisponibles);
            Controls.Add(cboDepaTour);
            Controls.Add(btnAgregarCliente);
            Controls.Add(txtCodCli);
            Controls.Add(label13);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(label15);
            Controls.Add(label3);
            Controls.Add(dtgTourDis);
            Controls.Add(label16);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReservaMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingresar Reserva";
            Load += ReservaMan02_Load;
            ((System.ComponentModel.ISupportInitialize)dtgTourDis).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAgregarCliente;
        private Label label4;
        private DataGridView dtgTourDis;
        private Label label5;
        private ComboBox cboDepaTour;
        private Label label6;
        private DateTimePicker dtpFecReserva;
        private Label label7;
        private GroupBox groupBox1;
        private RadioButton rtbTarjetaDebito;
        private RadioButton rtbTarjetaCredito;
        private RadioButton rtbEfectivo;
        private Button btnGrabar;
        private Button btnCancelar;
        private ComboBox cboAlojamientosDisponibles;
        private Label label8;
        private DataGridViewTextBoxColumn ID_Tour;
        private DataGridViewTextBoxColumn Fec_Ini_Tour;
        private DataGridViewTextBoxColumn Fec_Fin_Tour;
        private DataGridViewTextBoxColumn ID_Ubicacion;
        private DataGridViewTextBoxColumn Departamento;
        private DataGridViewTextBoxColumn Provincia;
        private DataGridViewTextBoxColumn Distrito;
        private DataGridViewTextBoxColumn Est_Tour_Des;
        private Label lblNoDisponible;
        private TextBox txtTotal;
        private Label label9;
        private Label label10;
        private ComboBox cboCategoria;
        private TextBox txtCantidadNoches;
        private Label label11;
        private Label lblTarifaNoche;
        private Label lblNomCli;
        private Label lblApeCli;
        private Label label12;
        private Label lblDniCli;
        private Label label14;
        private Label lblTelCli;
        private Label label16;
        private Label lblSexoCli;
        private Label label18;
        private Label lblEstadoCli;
        private Label label13;
        private Label lblEmailCli;
        private Label label19;
        private Label lblFecNacCli;
        private TextBox txtCodCli;
        private Label label15;
    }
}