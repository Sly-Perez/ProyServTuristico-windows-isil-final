namespace ProyServTuristico_GUI
{
    partial class ClienteMan03
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
            label7 = new Label();
            btnCancelar = new Button();
            btnGrabar = new Button();
            txtDni = new TextBox();
            gboxGenero = new GroupBox();
            rtbMasculino = new RadioButton();
            rtbFemenino = new RadioButton();
            txtEmail = new TextBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtFechaNac = new DateTimePicker();
            label3 = new Label();
            txtApe = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            txtActivo = new CheckBox();
            dtRegistro = new DateTimePicker();
            label9 = new Label();
            gboxGenero.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 147);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 33;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(528, 203);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(83, 22);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(428, 203);
            btnGrabar.Margin = new Padding(3, 2, 3, 2);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(83, 22);
            btnGrabar.TabIndex = 32;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(88, 78);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(143, 23);
            txtDni.TabIndex = 23;
            // 
            // gboxGenero
            // 
            gboxGenero.Controls.Add(rtbMasculino);
            gboxGenero.Controls.Add(rtbFemenino);
            gboxGenero.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gboxGenero.Location = new Point(42, 188);
            gboxGenero.Margin = new Padding(3, 2, 3, 2);
            gboxGenero.Name = "gboxGenero";
            gboxGenero.Padding = new Padding(3, 2, 3, 2);
            gboxGenero.Size = new Size(242, 56);
            gboxGenero.TabIndex = 30;
            gboxGenero.TabStop = false;
            gboxGenero.Text = "Genero:";
            // 
            // rtbMasculino
            // 
            rtbMasculino.AutoSize = true;
            rtbMasculino.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbMasculino.Location = new Point(136, 28);
            rtbMasculino.Margin = new Padding(3, 2, 3, 2);
            rtbMasculino.Name = "rtbMasculino";
            rtbMasculino.Size = new Size(83, 19);
            rtbMasculino.TabIndex = 0;
            rtbMasculino.Text = "Masculino:";
            rtbMasculino.UseVisualStyleBackColor = true;
            // 
            // rtbFemenino
            // 
            rtbFemenino.AutoSize = true;
            rtbFemenino.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbFemenino.Location = new Point(16, 28);
            rtbFemenino.Margin = new Padding(3, 2, 3, 2);
            rtbFemenino.Name = "rtbFemenino";
            rtbFemenino.Size = new Size(78, 19);
            rtbFemenino.TabIndex = 0;
            rtbFemenino.Text = "Femenino";
            rtbFemenino.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(88, 114);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(275, 23);
            txtEmail.TabIndex = 27;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 116);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 26;
            label6.Text = "Email:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(460, 118);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "999 999 999";
            txtTelefono.Size = new Size(143, 23);
            txtTelefono.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(397, 118);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 28;
            label5.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 79);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 24;
            label4.Text = "Fecha de Nacimiento:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtFechaNac
            // 
            txtFechaNac.Format = DateTimePickerFormat.Short;
            txtFechaNac.Location = new Point(391, 77);
            txtFechaNac.Margin = new Padding(2, 2, 2, 2);
            txtFechaNac.Name = "txtFechaNac";
            txtFechaNac.Size = new Size(139, 23);
            txtFechaNac.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 76);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 22;
            label3.Text = "Dni:";
            // 
            // txtApe
            // 
            txtApe.Location = new Point(391, 38);
            txtApe.Margin = new Padding(3, 2, 3, 2);
            txtApe.Name = "txtApe";
            txtApe.Size = new Size(213, 23);
            txtApe.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 38);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 20;
            label2.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(88, 37);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(213, 23);
            txtNombre.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 37);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 18;
            label1.Text = "Nombre:";
            // 
            // txtActivo
            // 
            txtActivo.AutoSize = true;
            txtActivo.Checked = true;
            txtActivo.CheckState = CheckState.Checked;
            txtActivo.Location = new Point(92, 154);
            txtActivo.Margin = new Padding(2, 2, 2, 2);
            txtActivo.Name = "txtActivo";
            txtActivo.Size = new Size(60, 19);
            txtActivo.TabIndex = 34;
            txtActivo.Text = "Activo";
            txtActivo.UseVisualStyleBackColor = true;
            // 
            // dtRegistro
            // 
            dtRegistro.Format = DateTimePickerFormat.Short;
            dtRegistro.Location = new Point(469, 153);
            dtRegistro.Margin = new Padding(2, 2, 2, 2);
            dtRegistro.Name = "dtRegistro";
            dtRegistro.Size = new Size(139, 23);
            dtRegistro.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(358, 157);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(100, 15);
            label9.TabIndex = 35;
            label9.Text = "Fecha de registro:";
            // 
            // ClienteMan03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 278);
            Controls.Add(dtRegistro);
            Controls.Add(label9);
            Controls.Add(txtActivo);
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "ClienteMan03";
            Text = "ClienteMan03";
            FormClosing += ClienteMan03_FormClosing;
            Load += ClienteMan03_Load;
            gboxGenero.ResumeLayout(false);
            gboxGenero.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button btnCancelar;
        private Button btnGrabar;
        private TextBox txtDni;
        private GroupBox gboxGenero;
        private RadioButton rtbMasculino;
        private RadioButton rtbFemenino;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtTelefono;
        private Label label5;
        private Label label4;
        private DateTimePicker txtFechaNac;
        private Label label3;
        private TextBox txtApe;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private CheckBox txtActivo;
        private DateTimePicker dtRegistro;
        private Label label9;
    }
}