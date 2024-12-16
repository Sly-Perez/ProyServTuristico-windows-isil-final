namespace ProyServTuristico_GUI
{
    partial class ClienteMan01
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
            dtgCliente = new DataGridView();
            ID_Cliente = new DataGridViewTextBoxColumn();
            Nom_Cli = new DataGridViewTextBoxColumn();
            Ape_Cli = new DataGridViewTextBoxColumn();
            Dni_Cli = new DataGridViewTextBoxColumn();
            Num_Tel = new DataGridViewTextBoxColumn();
            Email_Cli = new DataGridViewTextBoxColumn();
            Sex_Cli = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            txtNomCliFiltro = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtApeCliFiltro = new TextBox();
            lblRegistros = new Label();
            btnEliminar = new Button();
            btnAgregar = new Button();
            label2 = new Label();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgCliente).BeginInit();
            SuspendLayout();
            // 
            // dtgCliente
            // 
            dtgCliente.AllowUserToAddRows = false;
            dtgCliente.AllowUserToDeleteRows = false;
            dtgCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCliente.Columns.AddRange(new DataGridViewColumn[] { ID_Cliente, Nom_Cli, Ape_Cli, Dni_Cli, Num_Tel, Email_Cli, Sex_Cli, Estado });
            dtgCliente.Location = new Point(24, 111);
            dtgCliente.Margin = new Padding(4);
            dtgCliente.MultiSelect = false;
            dtgCliente.Name = "dtgCliente";
            dtgCliente.ReadOnly = true;
            dtgCliente.RowHeadersVisible = false;
            dtgCliente.RowHeadersWidth = 51;
            dtgCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCliente.Size = new Size(1312, 392);
            dtgCliente.TabIndex = 2;
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
            // txtNomCliFiltro
            // 
            txtNomCliFiltro.Location = new Point(313, 63);
            txtNomCliFiltro.Margin = new Padding(4);
            txtNomCliFiltro.Name = "txtNomCliFiltro";
            txtNomCliFiltro.Size = new Size(155, 31);
            txtNomCliFiltro.TabIndex = 9;
            txtNomCliFiltro.TextChanged += txtNomCliFiltro_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(528, 66);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 6;
            label4.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 72);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 7;
            label3.Text = "Nombre Cliente: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(237, 25);
            label1.TabIndex = 8;
            label1.Text = "Ingrese filtro de Cliente por: ";
            label1.Click += label1_Click;
            // 
            // txtApeCliFiltro
            // 
            txtApeCliFiltro.Location = new Point(618, 66);
            txtApeCliFiltro.Margin = new Padding(4);
            txtApeCliFiltro.Name = "txtApeCliFiltro";
            txtApeCliFiltro.Size = new Size(155, 31);
            txtApeCliFiltro.TabIndex = 10;
            txtApeCliFiltro.TextChanged += txtDniCliFiltro_TextChanged;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(1201, 561);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(119, 35);
            lblRegistros.TabIndex = 14;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(993, 561);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 53);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(619, 561);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(139, 53);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1201, 536);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 15;
            label2.Text = "Registros:";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(815, 561);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(139, 53);
            btnActualizar.TabIndex = 17;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += button1_Click;
            // 
            // ClienteMan01
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 636);
            Controls.Add(btnActualizar);
            Controls.Add(label2);
            Controls.Add(lblRegistros);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(txtApeCliFiltro);
            Controls.Add(txtNomCliFiltro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dtgCliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClienteMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento Clientes:";
            Load += ClienteMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgCliente;
        private DataGridViewTextBoxColumn ID_Cliente;
        private DataGridViewTextBoxColumn Nom_Cli;
        private DataGridViewTextBoxColumn Ape_Cli;
        private DataGridViewTextBoxColumn Dni_Cli;
        private DataGridViewTextBoxColumn Num_Tel;
        private DataGridViewTextBoxColumn Email_Cli;
        private DataGridViewTextBoxColumn Sex_Cli;
        private DataGridViewTextBoxColumn Estado;
        private TextBox txtNomCliFiltro;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtApeCliFiltro;
        private Label lblRegistros;
        private Button btnEliminar;
        private Button btnAgregar;
        private Label label2;
        private Button btnActualizar;
    }
}