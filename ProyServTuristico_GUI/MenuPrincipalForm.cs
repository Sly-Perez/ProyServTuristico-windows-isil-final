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
            
        }





        private void agregarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriaMan02 frmCategoria02 = new CategoriaMan02();
            frmCategoria02.MdiParent = this;
            frmCategoria02.Show();
        }

        private void mantenimientoCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriaMan01 frmcategoria01 = new CategoriaMan01();
            frmcategoria01.MdiParent = this;
            frmcategoria01.Show();
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesMan02 frmCliente02 = new ClientesMan02();
            frmCliente02.MdiParent = this;
            frmCliente02.Show();
        }

        private void mantenimientoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteMan01 frmCliente01 = new ClienteMan01();
            frmCliente01.MdiParent = this;
            frmCliente01.Show();
        }

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadoMan02 frmEmpleado02 = new EmpleadoMan02();
            frmEmpleado02.MdiParent = this;
            frmEmpleado02.Show();
        }

        private void mantenimientoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadoMan01 frmEmpleado01 = new EmpleadoMan01();
            frmEmpleado01.MdiParent = this;
            frmEmpleado01.Show();
        }

        private void agregarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservaMan02 frmReserva02 = new ReservaMan02();
            frmReserva02.MdiParent = this;
            frmReserva02.Show();
        }

        private void mantenimientoReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservaMan01 frmReserva01 = new ReservaMan01();
            frmReserva01.MdiParent = this;
            frmReserva01.Show();
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
