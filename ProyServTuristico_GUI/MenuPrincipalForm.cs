using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyServTuristico_GUI
{
    public partial class MenuPrincipalForm : Form
    {

        public MenuPrincipalForm()
        {
            InitializeComponent();
            lblUsuario.Text = $"{Session.NombreUsuario}";
        }

        public void UpdateUserName()
        {
            lblUsuario.Text = $"{Session.NombreUsuario}";
        }





        private void agregarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new CategoriaMan02());
        }

        private void mantenimientoCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new CategoriaMan01());
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new ClientesMan02());
        }

        private void mantenimientoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new ClienteMan01());
        }

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new EmpleadoMan02());
        }

        private void mantenimientoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new EmpleadoMan01());
        }

        private void agregarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new ReservaMan02());
        }

        private void mantenimientoReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new ReservaMan01());
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
