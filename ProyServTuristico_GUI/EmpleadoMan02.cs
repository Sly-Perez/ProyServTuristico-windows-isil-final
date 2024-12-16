using ProyServTuristico_ADO;
using ProyServTuristico_BE;
using ProyServTuristico_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyServTuristico_GUI
{
    public partial class EmpleadoMan02 : Form
    {
        // Instancias...
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        EmpleadoBE objEmpleadoBE = new EmpleadoBE();
        EmpleadoADO EmpleadoADO = new EmpleadoADO();

        public EmpleadoMan02()
        {
            InitializeComponent();
        }

        private void EmpleadoMan02_Load(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validamos los campos obligatorios
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                    throw new Exception("Debe ingresar el nombre del empleado.");

                if (string.IsNullOrWhiteSpace(txtApellidos.Text))
                    throw new Exception("Debe ingresar el apellido del empleado.");

                if (txtDni.Text.Trim().Length != 8)
                    throw new Exception("Debe ingresar el DNI del empleado.");

                if (string.IsNullOrWhiteSpace(txtTelefono.Text))
                    throw new Exception("Debe ingresar el telefono del empleado.");

                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                    throw new Exception("Debe ingresar el emial del empleado.");

                if (dtRegistro.Value == null || dtRegistro.Value > DateTime.Now)
                    throw new Exception("Ingrese una fecha de registro válida.");


                objEmpleadoBE.Dni_Emp = txtDni.Text.Trim();
                objEmpleadoBE.Nom_Emp = txtNombre.Text.Trim();
                objEmpleadoBE.Ape_Emp = txtApellidos.Text.Trim();
                objEmpleadoBE.Tel_Emp = txtTelefono.Text.Trim();
                objEmpleadoBE.Email_Emp = txtEmail.Text.Trim();
                objEmpleadoBE.Rol_Emp = cboCargo.Text.Trim();

                if (string.IsNullOrWhiteSpace(objEmpleadoBE.Email_Emp))
                {
                    throw new Exception("El email del empleado es obligatorio.");
                }

                objEmpleadoBE.Fec_Reg = dtRegistro.Value;

                if (objEmpleadoBL.InsertarEmpleado(objEmpleadoBE))
                {
                    MessageBox.Show("Empleado registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    throw new Exception("No se logró el registro. Contacte al área de TI.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            NavigationHelper.ReturnToMenuPrincipal(this);
        }


        private void txtDni_Validating(object sender, CancelEventArgs e)
        {
            if (txtDni.Text.Trim().Length != 8)
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
    }
}
