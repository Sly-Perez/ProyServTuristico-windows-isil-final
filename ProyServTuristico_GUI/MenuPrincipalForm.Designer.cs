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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriaToolStripMenuItem, clienteToolStripMenuItem, empleadoToolStripMenuItem, reservaToolStripMenuItem, salirToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarCategoriaToolStripMenuItem, mantenimientoCategoriaToolStripMenuItem });
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(160, 26);
            categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // agregarCategoriaToolStripMenuItem
            // 
            agregarCategoriaToolStripMenuItem.Name = "agregarCategoriaToolStripMenuItem";
            agregarCategoriaToolStripMenuItem.Size = new Size(262, 26);
            agregarCategoriaToolStripMenuItem.Text = "Agregar Categoria";
            agregarCategoriaToolStripMenuItem.Click += agregarCategoriaToolStripMenuItem_Click;
            // 
            // mantenimientoCategoriaToolStripMenuItem
            // 
            mantenimientoCategoriaToolStripMenuItem.Name = "mantenimientoCategoriaToolStripMenuItem";
            mantenimientoCategoriaToolStripMenuItem.Size = new Size(262, 26);
            mantenimientoCategoriaToolStripMenuItem.Text = "Mantenimiento Categoria";
            mantenimientoCategoriaToolStripMenuItem.Click += mantenimientoCategoriaToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarClienteToolStripMenuItem, mantenimientoClienteToolStripMenuItem });
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(160, 26);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // agregarClienteToolStripMenuItem
            // 
            agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            agregarClienteToolStripMenuItem.Size = new Size(243, 26);
            agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            agregarClienteToolStripMenuItem.Click += agregarClienteToolStripMenuItem_Click;
            // 
            // mantenimientoClienteToolStripMenuItem
            // 
            mantenimientoClienteToolStripMenuItem.Name = "mantenimientoClienteToolStripMenuItem";
            mantenimientoClienteToolStripMenuItem.Size = new Size(243, 26);
            mantenimientoClienteToolStripMenuItem.Text = "Mantenimiento Cliente";
            mantenimientoClienteToolStripMenuItem.Click += mantenimientoClienteToolStripMenuItem_Click;
            // 
            // empleadoToolStripMenuItem
            // 
            empleadoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarEmpleadoToolStripMenuItem, mantenimientoEmpleadoToolStripMenuItem });
            empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            empleadoToolStripMenuItem.Size = new Size(160, 26);
            empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // agregarEmpleadoToolStripMenuItem
            // 
            agregarEmpleadoToolStripMenuItem.Name = "agregarEmpleadoToolStripMenuItem";
            agregarEmpleadoToolStripMenuItem.Size = new Size(265, 26);
            agregarEmpleadoToolStripMenuItem.Text = "Agregar Empleado";
            agregarEmpleadoToolStripMenuItem.Click += agregarEmpleadoToolStripMenuItem_Click;
            // 
            // mantenimientoEmpleadoToolStripMenuItem
            // 
            mantenimientoEmpleadoToolStripMenuItem.Name = "mantenimientoEmpleadoToolStripMenuItem";
            mantenimientoEmpleadoToolStripMenuItem.Size = new Size(265, 26);
            mantenimientoEmpleadoToolStripMenuItem.Text = "Mantenimiento Empleado";
            mantenimientoEmpleadoToolStripMenuItem.Click += mantenimientoEmpleadoToolStripMenuItem_Click;
            // 
            // reservaToolStripMenuItem
            // 
            reservaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarReservaToolStripMenuItem, mantenimientoReservaToolStripMenuItem });
            reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            reservaToolStripMenuItem.Size = new Size(160, 26);
            reservaToolStripMenuItem.Text = "Reserva";
            // 
            // agregarReservaToolStripMenuItem
            // 
            agregarReservaToolStripMenuItem.Name = "agregarReservaToolStripMenuItem";
            agregarReservaToolStripMenuItem.Size = new Size(248, 26);
            agregarReservaToolStripMenuItem.Text = "Agregar Reserva";
            agregarReservaToolStripMenuItem.Click += agregarReservaToolStripMenuItem_Click;
            // 
            // mantenimientoReservaToolStripMenuItem
            // 
            mantenimientoReservaToolStripMenuItem.Name = "mantenimientoReservaToolStripMenuItem";
            mantenimientoReservaToolStripMenuItem.Size = new Size(248, 26);
            mantenimientoReservaToolStripMenuItem.Text = "Mantenimiento Reserva";
            mantenimientoReservaToolStripMenuItem.Click += mantenimientoReservaToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(160, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // MenuPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Turismo_Montaña__nieve__amanecer;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
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
    }
}