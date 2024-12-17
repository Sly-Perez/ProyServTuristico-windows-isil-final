namespace ProyServTuristico_GUI
{
    partial class EmpleadoMan03
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
            dtRegistro = new DateTimePicker();
            label9 = new Label();
            btnCancelar = new Button();
            btnGrabar = new Button();
            txtDni = new TextBox();
            gboxEstado = new GroupBox();
            rtbInactivo = new RadioButton();
            rtbActivo = new RadioButton();
            txtEmail = new TextBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            label3 = new Label();
            txtApellidos = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            cboCargo = new ComboBox();
            label4 = new Label();
            gboxEstado.SuspendLayout();
            SuspendLayout();
            // 
            // dtRegistro
            // 
            dtRegistro.Format = DateTimePickerFormat.Short;
            dtRegistro.Location = new Point(649, 151);
            dtRegistro.Margin = new Padding(2, 3, 2, 3);
            dtRegistro.Name = "dtRegistro";
            dtRegistro.Size = new Size(158, 27);
            dtRegistro.TabIndex = 54;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(522, 156);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(126, 20);
            label9.TabIndex = 53;
            label9.Text = "Fecha de registro:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(649, 243);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 55);
            btnCancelar.TabIndex = 50;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(506, 243);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(94, 55);
            btnGrabar.TabIndex = 51;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click_1;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(79, 92);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(118, 27);
            txtDni.TabIndex = 42;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // gboxEstado
            // 
            gboxEstado.Controls.Add(rtbInactivo);
            gboxEstado.Controls.Add(rtbActivo);
            gboxEstado.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gboxEstado.Location = new Point(98, 223);
            gboxEstado.Name = "gboxEstado";
            gboxEstado.Size = new Size(277, 75);
            gboxEstado.TabIndex = 49;
            gboxEstado.TabStop = false;
            gboxEstado.Text = "Estado:";
            // 
            // rtbInactivo
            // 
            rtbInactivo.AutoSize = true;
            rtbInactivo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbInactivo.Location = new Point(155, 37);
            rtbInactivo.Name = "rtbInactivo";
            rtbInactivo.Size = new Size(82, 24);
            rtbInactivo.TabIndex = 0;
            rtbInactivo.Text = "Inactivo";
            rtbInactivo.UseVisualStyleBackColor = true;
            // 
            // rtbActivo
            // 
            rtbActivo.AutoSize = true;
            rtbActivo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbActivo.Location = new Point(18, 37);
            rtbActivo.Name = "rtbActivo";
            rtbActivo.Size = new Size(72, 24);
            rtbActivo.TabIndex = 0;
            rtbActivo.Text = "Activo";
            rtbActivo.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(538, 95);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(269, 27);
            txtEmail.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(486, 97);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 45;
            label6.Text = "Email:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(299, 92);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "999 999 999";
            txtTelefono.Size = new Size(163, 27);
            txtTelefono.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(225, 95);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 47;
            label5.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 95);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 41;
            label3.Text = "Dni:";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(459, 43);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(348, 27);
            txtApellidos.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(385, 43);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 39;
            label2.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(111, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(196, 27);
            txtNombre.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 40);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 37;
            label1.Text = "Nombre:";
            // 
            // cboCargo
            // 
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargo.FormattingEnabled = true;
            cboCargo.Location = new Point(98, 149);
            cboCargo.Margin = new Padding(3, 4, 3, 4);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(292, 28);
            cboCargo.TabIndex = 56;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 153);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 55;
            label4.Text = "Cargo:";
            // 
            // EmpleadoMan03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 331);
            Controls.Add(cboCargo);
            Controls.Add(label4);
            Controls.Add(dtRegistro);
            Controls.Add(label9);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(txtDni);
            Controls.Add(gboxEstado);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtApellidos);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmpleadoMan03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar empleado";
            Load += EmpleadoMan03_Load;
            gboxEstado.ResumeLayout(false);
            gboxEstado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtRegistro;
        private Label label9;
        private CheckBox txtActivo;
        private Button btnCancelar;
        private Button btnGrabar;
        private TextBox txtDni;
        private GroupBox gboxEstado;
        private RadioButton rtbInactivo;
        private RadioButton rtbActivo;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtTelefono;
        private Label label5;
        private Label label4;
        private DateTimePicker txtFechaNac;
        private Label label3;
        private TextBox txtApellidos;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private ComboBox cboCargo;
    }
}