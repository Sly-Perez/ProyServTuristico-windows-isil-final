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
            dtRegistro.Location = new Point(568, 113);
            dtRegistro.Margin = new Padding(2);
            dtRegistro.Name = "dtRegistro";
            dtRegistro.Size = new Size(139, 23);
            dtRegistro.TabIndex = 54;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(457, 117);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(100, 15);
            label9.TabIndex = 53;
            label9.Text = "Fecha de registro:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(568, 182);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 41);
            btnCancelar.TabIndex = 50;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(443, 182);
            btnGrabar.Margin = new Padding(3, 2, 3, 2);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(82, 41);
            btnGrabar.TabIndex = 51;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click_1;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(69, 69);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(104, 23);
            txtDni.TabIndex = 42;
            // 
            // gboxEstado
            // 
            gboxEstado.Controls.Add(rtbInactivo);
            gboxEstado.Controls.Add(rtbActivo);
            gboxEstado.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gboxEstado.Location = new Point(86, 167);
            gboxEstado.Margin = new Padding(3, 2, 3, 2);
            gboxEstado.Name = "gboxEstado";
            gboxEstado.Padding = new Padding(3, 2, 3, 2);
            gboxEstado.Size = new Size(242, 56);
            gboxEstado.TabIndex = 49;
            gboxEstado.TabStop = false;
            gboxEstado.Text = "Estado:";
            // 
            // rtbInactivo
            // 
            rtbInactivo.AutoSize = true;
            rtbInactivo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbInactivo.Location = new Point(136, 28);
            rtbInactivo.Margin = new Padding(3, 2, 3, 2);
            rtbInactivo.Name = "rtbInactivo";
            rtbInactivo.Size = new Size(67, 19);
            rtbInactivo.TabIndex = 0;
            rtbInactivo.Text = "Inactivo";
            rtbInactivo.UseVisualStyleBackColor = true;
            // 
            // rtbActivo
            // 
            rtbActivo.AutoSize = true;
            rtbActivo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbActivo.Location = new Point(16, 28);
            rtbActivo.Margin = new Padding(3, 2, 3, 2);
            rtbActivo.Name = "rtbActivo";
            rtbActivo.Size = new Size(59, 19);
            rtbActivo.TabIndex = 0;
            rtbActivo.Text = "Activo";
            rtbActivo.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(471, 71);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(236, 23);
            txtEmail.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(425, 73);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 45;
            label6.Text = "Email:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(262, 69);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "999 999 999";
            txtTelefono.Size = new Size(143, 23);
            txtTelefono.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(197, 71);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 47;
            label5.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 71);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 41;
            label3.Text = "Dni:";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(402, 32);
            txtApellidos.Margin = new Padding(3, 2, 3, 2);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(305, 23);
            txtApellidos.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 32);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 39;
            label2.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(97, 29);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(172, 23);
            txtNombre.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 37;
            label1.Text = "Nombre:";
            // 
            // cboCargo
            // 
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargo.FormattingEnabled = true;
            cboCargo.Location = new Point(86, 112);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(256, 23);
            cboCargo.TabIndex = 56;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 115);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 55;
            label4.Text = "Cargo:";
            // 
            // EmpleadoMan03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 248);
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
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmpleadoMan03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar empleado";
            FormClosing += EmpleadoMan03_FormClosing;
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