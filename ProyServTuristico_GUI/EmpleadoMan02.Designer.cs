namespace ProyServTuristico_GUI
{
    partial class EmpleadoMan02
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
            txtNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cboCargo = new ComboBox();
            chkActivo = new CheckBox();
            btnGrabar = new Button();
            btnCancelar = new Button();
            txtApellidos = new TextBox();
            txtDni = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            label6 = new Label();
            dtRegistro = new DateTimePicker();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 52);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(115, 49);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(265, 27);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(407, 52);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 102);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 4;
            label3.Text = "DNI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 102);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 6;
            label4.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 154);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 8;
            label5.Text = "Cargo:";
            // 
            // cboCargo
            // 
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargo.FormattingEnabled = true;
            cboCargo.Items.AddRange(new object[] { "Gerente", "Supervisor", "Empleado" });
            cboCargo.Location = new Point(100, 151);
            cboCargo.Margin = new Padding(3, 4, 3, 4);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(292, 28);
            cboCargo.TabIndex = 9;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(71, 232);
            chkActivo.Margin = new Padding(3, 4, 3, 4);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(73, 24);
            chkActivo.TabIndex = 13;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(427, 232);
            btnGrabar.Margin = new Padding(3, 4, 3, 4);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(118, 40);
            btnGrabar.TabIndex = 14;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(585, 232);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(118, 40);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(488, 49);
            txtApellidos.Margin = new Padding(3, 4, 3, 4);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(265, 27);
            txtApellidos.TabIndex = 3;
            txtApellidos.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(86, 99);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ingresa 8 dígitos";
            txtDni.Size = new Size(125, 27);
            txtDni.TabIndex = 5;
            txtDni.TextAlign = HorizontalAlignment.Right;
            txtDni.Validating += txtDni_Validating;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(316, 99);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(118, 27);
            txtTelefono.TabIndex = 7;
            txtTelefono.TextAlign = HorizontalAlignment.Right;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(524, 99);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 27);
            txtEmail.TabIndex = 17;
            txtEmail.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(469, 102);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 16;
            label6.Text = "Email:";
            // 
            // dtRegistro
            // 
            dtRegistro.Format = DateTimePickerFormat.Short;
            dtRegistro.Location = new Point(595, 152);
            dtRegistro.Margin = new Padding(2);
            dtRegistro.Name = "dtRegistro";
            dtRegistro.Size = new Size(158, 27);
            dtRegistro.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(468, 157);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(126, 20);
            label9.TabIndex = 21;
            label9.Text = "Fecha de registro:";
            // 
            // EmpleadoMan02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 321);
            Controls.Add(dtRegistro);
            Controls.Add(label9);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(txtDni);
            Controls.Add(txtApellidos);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(chkActivo);
            Controls.Add(cboCargo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmpleadoMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Empleado";
            Load += EmpleadoMan02_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cboCargo;
        private CheckBox chkActivo;
        private Button btnGrabar;
        private Button btnCancelar;
        private TextBox txtApellidos;
        private TextBox txtDni;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private Label label6;
        private DateTimePicker dtRegistro;
        private Label label9;
    }
}