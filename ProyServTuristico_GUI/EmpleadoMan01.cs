using ProyServTuristico_BL;
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
    public partial class EmpleadoMan01 : Form
    {
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        EmpleadoBL objEmpleadoBE = new EmpleadoBL();
        DataView dtv;

        public EmpleadoMan01()
        {
            InitializeComponent();
        }

        private void EmpleadoMan01_Load(object sender, EventArgs e)
        {
            CargarDatos(txtNomEmpFiltro.Text.Trim(), txtApeEmpFiltro.Text.Trim());

        }

        private void CargarDatos(String strNomEmpFiltro, String strApeEmpFiltro)
        {
            dtv = new DataView(objEmpleadoBL.ListarEmpleado());
            // Construimos  el objeto Dataview dtv  en base al DataTable devuelto por el metodo ListarProducto
            // Y lo filtramos de acuerdo al parametro strFiltro

            dtv.RowFilter = "Nom_Emp LIKE '%" + strNomEmpFiltro + "%' AND Ape_Emp LIKE '%" + strApeEmpFiltro + "%'";
            dtgEmpleado.DataSource = dtv;
            lblRegistros.Text = dtgEmpleado.Rows.Count.ToString();

        }

        private void txtNomEmpFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtNomEmpFiltro.Text.Trim(), txtApeEmpFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void txtDniEmpFiltro_TextChanged(object sender, EventArgs e)
        {

            try
            {

                CargarDatos(txtNomEmpFiltro.Text.Trim(), txtApeEmpFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoMan02 formEmpeladosMan02 = new EmpleadoMan02();
                formEmpeladosMan02.ShowDialog();
                CargarDatos(txtNomEmpFiltro.Text.Trim(), txtApeEmpFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgEmpleado.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, selecciona un empleado para actualizar.");
                    return;
                }


                string strID_Empleado = dtgEmpleado.CurrentRow.Cells[0].Value.ToString();




                Int16 idEmpleado;
                if (!Int16.TryParse(strID_Empleado, out idEmpleado))
                {
                    MessageBox.Show("El ID del empleado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                EmpleadoMan03 objMan03 = new EmpleadoMan03();
                objMan03.ID_Empleado = idEmpleado;


                if (objMan03.ShowDialog() == DialogResult.OK)
                {
                    CargarDatos(txtNomEmpFiltro.Text.Trim(), txtApeEmpFiltro.Text.Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dtgEmpleado.CurrentRow != null)
                {

                    string codigoEmpleado = dtgEmpleado.CurrentRow.Cells[0].Value.ToString();

                    DialogResult respuesta = MessageBox.Show(
                        "¿Está seguro de eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {

                        if (objEmpleadoBL.EliminarEmpleado(codigoEmpleado))
                        {

                            CargarDatos(txtNomEmpFiltro.Text.Trim(), txtApeEmpFiltro.Text.Trim());
                        }
                        else
                        {
                            throw new Exception("No se puede eliminar el registro");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un empleado para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EmpleadoMan01_FormClosing(object sender, FormClosingEventArgs e)
        {
            NavigationHelper.ReturnToMenuPrincipal(this);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            NavigationHelper.ReturnToMenuPrincipal(this);
        }
    }
}
