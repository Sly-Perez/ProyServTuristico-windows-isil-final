namespace ProyServTuristico_GUI
{
    partial class ClientesMan02
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
            txtApe = new TextBox();
            label3 = new Label();
            txtFechaNac = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            txtTelefono = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            gboxGenero = new GroupBox();
            rtbMasculino = new RadioButton();
            rtbFemenino = new RadioButton();
            txtDni = new TextBox();
            btnCancelar = new Button();
            btnGrabar = new Button();
            label7 = new Label();
            label9 = new Label();
            dtRegistro = new DateTimePicker();
            gboxGenero.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 39);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(139, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(243, 27);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(415, 41);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            // 
            // txtApe
            // 
            txtApe.Location = new Point(486, 41);
            txtApe.Name = "txtApe";
            txtApe.Size = new Size(243, 27);
            txtApe.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 91);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 4;
            label3.Text = "Dni:";
            label3.Click += label3_Click;
            // 
            // txtFechaNac
            // 
            txtFechaNac.Format = DateTimePickerFormat.Short;
            txtFechaNac.Location = new Point(485, 91);
            txtFechaNac.Margin = new Padding(2, 3, 2, 3);
            txtFechaNac.Name = "txtFechaNac";
            txtFechaNac.Size = new Size(158, 27);
            txtFechaNac.TabIndex = 7;
            txtFechaNac.ValueChanged += txtFechaNac_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(335, 91);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(152, 20);
            label4.TabIndex = 6;
            label4.Text = "Fecha de Nacimiento:";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(493, 147);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 10;
            label5.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(565, 147);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "999 999 999";
            txtTelefono.Size = new Size(163, 27);
            txtTelefono.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 144);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 8;
            label6.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(139, 141);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(314, 27);
            txtEmail.TabIndex = 9;
            // 
            // gboxGenero
            // 
            gboxGenero.Controls.Add(rtbMasculino);
            gboxGenero.Controls.Add(rtbFemenino);
            gboxGenero.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gboxGenero.Location = new Point(87, 195);
            gboxGenero.Name = "gboxGenero";
            gboxGenero.Size = new Size(277, 75);
            gboxGenero.TabIndex = 12;
            gboxGenero.TabStop = false;
            gboxGenero.Text = "Genero:";
            // 
            // rtbMasculino
            // 
            rtbMasculino.AutoSize = true;
            rtbMasculino.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbMasculino.Location = new Point(154, 37);
            rtbMasculino.Name = "rtbMasculino";
            rtbMasculino.Size = new Size(100, 24);
            rtbMasculino.TabIndex = 0;
            rtbMasculino.Text = "Masculino:";
            rtbMasculino.UseVisualStyleBackColor = true;
            // 
            // rtbFemenino
            // 
            rtbFemenino.AutoSize = true;
            rtbFemenino.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbFemenino.Location = new Point(17, 36);
            rtbFemenino.Name = "rtbFemenino";
            rtbFemenino.Size = new Size(95, 24);
            rtbFemenino.TabIndex = 0;
            rtbFemenino.Text = "Femenino";
            rtbFemenino.UseVisualStyleBackColor = true;
            rtbFemenino.CheckedChanged += rtbEfectivo_CheckedChanged;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(139, 93);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ingresa 8 dígitos:";
            txtDni.Size = new Size(163, 27);
            txtDni.TabIndex = 5;
            txtDni.Validating += txtDni_Validating;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(643, 267);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 29);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(502, 267);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(95, 29);
            btnGrabar.TabIndex = 16;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click_1;
            btnGrabar.KeyPress += btnGrabar_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(87, 184);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 17;
            label7.Click += label7_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(438, 200);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(126, 20);
            label9.TabIndex = 19;
            label9.Text = "Fecha de registro:";
            // 
            // dtRegistro
            // 
            dtRegistro.Format = DateTimePickerFormat.Short;
            dtRegistro.Location = new Point(565, 195);
            dtRegistro.Margin = new Padding(2, 3, 2, 3);
            dtRegistro.Name = "dtRegistro";
            dtRegistro.Size = new Size(158, 27);
            dtRegistro.TabIndex = 20;
            // 
            // ClientesMan02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 347);
            Controls.Add(dtRegistro);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(txtDni);
            Controls.Add(gboxGenero);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtFechaNac);
            Controls.Add(label3);
            Controls.Add(txtApe);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "ClientesMan02";
            Text = "Ingresar :";
            FormClosing += ClientesMan02_FormClosing;
            Load += ClientesMan02_Load;
            gboxGenero.ResumeLayout(false);
            gboxGenero.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApe;
        private Label label3;
        private DateTimePicker txtFechaNac;
        private Label label4;
        private Label label5;
        private TextBox txtTelefono;
        private Label label6;
        private TextBox txtEmail;
        private GroupBox gboxGenero;
        private RadioButton rtbMasculino;
        private RadioButton rtbFemenino;
        private TextBox txtDni;
        private Button btnCancelar;
        private Button btnGrabar;
        private Label label7;
        private Label label9;
        private DateTimePicker dtRegistro;
    }
}