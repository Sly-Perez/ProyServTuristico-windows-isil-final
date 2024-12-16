namespace ProyServTuristico_GUI
{
    partial class MenuPrincipalForm
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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            agregarCategoriaToolStripMenuItem = new ToolStripMenuItem();
            mantenimientoCategoriaToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            agregarClienteToolStripMenuItem = new ToolStripMenuItem();
            mantenimientoClienteToolStripMenuItem = new ToolStripMenuItem();
            empleadoToolStripMenuItem = new ToolStripMenuItem();
            agregarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            mantenimientoEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            reservaToolStripMenuItem = new ToolStripMenuItem();
            agregarReservaToolStripMenuItem = new ToolStripMenuItem();
            mantenimientoReservaToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            Titutlo = new Label();
            lblUsuario = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriaToolStripMenuItem, clienteToolStripMenuItem, empleadoToolStripMenuItem, reservaToolStripMenuItem, salirToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarCategoriaToolStripMenuItem, mantenimientoCategoriaToolStripMenuItem });
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(127, 22);
            categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // agregarCategoriaToolStripMenuItem
            // 
            agregarCategoriaToolStripMenuItem.Name = "agregarCategoriaToolStripMenuItem";
            agregarCategoriaToolStripMenuItem.Size = new Size(210, 22);
            agregarCategoriaToolStripMenuItem.Text = "Agregar Categoria";
            agregarCategoriaToolStripMenuItem.Click += agregarCategoriaToolStripMenuItem_Click;
            // 
            // mantenimientoCategoriaToolStripMenuItem
            // 
            mantenimientoCategoriaToolStripMenuItem.Name = "mantenimientoCategoriaToolStripMenuItem";
            mantenimientoCategoriaToolStripMenuItem.Size = new Size(210, 22);
            mantenimientoCategoriaToolStripMenuItem.Text = "Mantenimiento Categoria";
            mantenimientoCategoriaToolStripMenuItem.Click += mantenimientoCategoriaToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarClienteToolStripMenuItem, mantenimientoClienteToolStripMenuItem });
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(127, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // agregarClienteToolStripMenuItem
            // 
            agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            agregarClienteToolStripMenuItem.Size = new Size(196, 22);
            agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            agregarClienteToolStripMenuItem.Click += agregarClienteToolStripMenuItem_Click;
            // 
            // mantenimientoClienteToolStripMenuItem
            // 
            mantenimientoClienteToolStripMenuItem.Name = "mantenimientoClienteToolStripMenuItem";
            mantenimientoClienteToolStripMenuItem.Size = new Size(196, 22);
            mantenimientoClienteToolStripMenuItem.Text = "Mantenimiento Cliente";
            mantenimientoClienteToolStripMenuItem.Click += mantenimientoClienteToolStripMenuItem_Click;
            // 
            // empleadoToolStripMenuItem
            // 
            empleadoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarEmpleadoToolStripMenuItem, mantenimientoEmpleadoToolStripMenuItem });
            empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            empleadoToolStripMenuItem.Size = new Size(127, 22);
            empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // agregarEmpleadoToolStripMenuItem
            // 
            agregarEmpleadoToolStripMenuItem.Name = "agregarEmpleadoToolStripMenuItem";
            agregarEmpleadoToolStripMenuItem.Size = new Size(212, 22);
            agregarEmpleadoToolStripMenuItem.Text = "Agregar Empleado";
            agregarEmpleadoToolStripMenuItem.Click += agregarEmpleadoToolStripMenuItem_Click;
            // 
            // mantenimientoEmpleadoToolStripMenuItem
            // 
            mantenimientoEmpleadoToolStripMenuItem.Name = "mantenimientoEmpleadoToolStripMenuItem";
            mantenimientoEmpleadoToolStripMenuItem.Size = new Size(212, 22);
            mantenimientoEmpleadoToolStripMenuItem.Text = "Mantenimiento Empleado";
            mantenimientoEmpleadoToolStripMenuItem.Click += mantenimientoEmpleadoToolStripMenuItem_Click;
            // 
            // reservaToolStripMenuItem
            // 
            reservaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarReservaToolStripMenuItem, mantenimientoReservaToolStripMenuItem });
            reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            reservaToolStripMenuItem.Size = new Size(127, 22);
            reservaToolStripMenuItem.Text = "Reserva";
            // 
            // agregarReservaToolStripMenuItem
            // 
            agregarReservaToolStripMenuItem.Name = "agregarReservaToolStripMenuItem";
            agregarReservaToolStripMenuItem.Size = new Size(199, 22);
            agregarReservaToolStripMenuItem.Text = "Agregar Reserva";
            agregarReservaToolStripMenuItem.Click += agregarReservaToolStripMenuItem_Click;
            // 
            // mantenimientoReservaToolStripMenuItem
            // 
            mantenimientoReservaToolStripMenuItem.Name = "mantenimientoReservaToolStripMenuItem";
            mantenimientoReservaToolStripMenuItem.Size = new Size(199, 22);
            mantenimientoReservaToolStripMenuItem.Text = "Mantenimiento Reserva";
            mantenimientoReservaToolStripMenuItem.Click += mantenimientoReservaToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(127, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // Titutlo
            // 
            Titutlo.AccessibleName = "";
            Titutlo.AutoSize = true;
            Titutlo.BackColor = Color.Transparent;
            Titutlo.CausesValidation = false;
            Titutlo.Font = new Font("Segoe UI", 20F);
            Titutlo.Location = new Point(251, 113);
            Titutlo.Name = "Titutlo";
            Titutlo.Size = new Size(276, 37);
            Titutlo.TabIndex = 1;
            Titutlo.Text = "Bienvenido al Sistema";
            Titutlo.Click += label1_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AccessibleName = "";
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(319, 161);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(78, 32);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "label1";
            // 
            // MenuPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Turismo_Montaña__nieve__amanecer;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblUsuario);
            Controls.Add(Titutlo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipalForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem agregarCategoriaToolStripMenuItem;
        private ToolStripMenuItem mantenimientoCategoriaToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem agregarClienteToolStripMenuItem;
        private ToolStripMenuItem mantenimientoClienteToolStripMenuItem;
        private ToolStripMenuItem empleadoToolStripMenuItem;
        private ToolStripMenuItem reservaToolStripMenuItem;
        private ToolStripMenuItem agregarEmpleadoToolStripMenuItem;
        private ToolStripMenuItem mantenimientoEmpleadoToolStripMenuItem;
        private ToolStripMenuItem agregarReservaToolStripMenuItem;
        private ToolStripMenuItem mantenimientoReservaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Label Titutlo;
        private Label lblUsuario;
    }
}