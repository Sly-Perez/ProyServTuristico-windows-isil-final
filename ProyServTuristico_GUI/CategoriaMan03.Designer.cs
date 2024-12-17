namespace ProyServTuristico_GUI
{
    partial class CategoriaMan03
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
            pictureBoxFoto = new PictureBox();
            txtDescripcion = new TextBox();
            cmbEstado = new ComboBox();
            btnFoto = new Button();
            txtCaracteristicas = new TextBox();
            label8 = new Label();
            btnCancelar = new Button();
            btnGrabar = new Button();
            txtTarifaPorNoche = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxFoto
            // 
            pictureBoxFoto.Location = new Point(394, 175);
            pictureBoxFoto.Name = "pictureBoxFoto";
            pictureBoxFoto.Size = new Size(219, 110);
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFoto.TabIndex = 65;
            pictureBoxFoto.TabStop = false;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(146, 68);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(125, 27);
            txtDescripcion.TabIndex = 64;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(145, 175);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(151, 28);
            cmbEstado.TabIndex = 63;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(423, 129);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(147, 29);
            btnFoto.TabIndex = 62;
            btnFoto.Text = "Agregar Foto";
            btnFoto.UseVisualStyleBackColor = true;
            // 
            // txtCaracteristicas
            // 
            txtCaracteristicas.Location = new Point(467, 65);
            txtCaracteristicas.Multiline = true;
            txtCaracteristicas.Name = "txtCaracteristicas";
            txtCaracteristicas.Size = new Size(213, 58);
            txtCaracteristicas.TabIndex = 61;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(83, 175);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 60;
            label8.Text = "Estado:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(586, 309);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 58;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(467, 309);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(94, 29);
            btnGrabar.TabIndex = 59;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            // 
            // txtTarifaPorNoche
            // 
            txtTarifaPorNoche.Location = new Point(145, 118);
            txtTarifaPorNoche.Name = "txtTarifaPorNoche";
            txtTarifaPorNoche.Size = new Size(163, 27);
            txtTarifaPorNoche.TabIndex = 55;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(364, 133);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 57;
            label6.Text = "Foto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(355, 75);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 56;
            label4.Text = "Características:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 121);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 54;
            label3.Text = "Tarifa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 68);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 53;
            label2.Text = "Descripción:";
            // 
            // CategoriaMan03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 419);
            Controls.Add(pictureBoxFoto);
            Controls.Add(txtDescripcion);
            Controls.Add(cmbEstado);
            Controls.Add(btnFoto);
            Controls.Add(txtCaracteristicas);
            Controls.Add(label8);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(txtTarifaPorNoche);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "CategoriaMan03";
            Text = "Actualizar Categoria";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxFoto;
        private TextBox txtDescripcion;
        private ComboBox cmbEstado;
        private Button btnFoto;
        private TextBox txtCaracteristicas;
        private Label label8;
        private Button btnCancelar;
        private Button btnGrabar;
        private TextBox txtTarifaPorNoche;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}