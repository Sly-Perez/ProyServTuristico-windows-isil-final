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
            try
            {
                cboCargo.SelectedIndex = 0;

                CargarDatosEmpleadosxRol(Convert.ToInt16(cboCargo.SelectedIndex));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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



                objEmpleadoBE.Dni_Emp = txtDni.Text.Trim();
                objEmpleadoBE.Nom_Emp = txtNombre.Text.Trim();
                objEmpleadoBE.Ape_Emp = txtApellidos.Text.Trim();
                objEmpleadoBE.Tel_Emp = txtTelefono.Text.Trim();
                objEmpleadoBE.Email_Emp = txtEmail.Text.Trim();
                objEmpleadoBE.Rol_Emp = cboCargo.Text.Trim();

                if(cboSupervisores.Visible == true)
                {
                    objEmpleadoBE.Supervisot_ID = Convert.ToInt16(cboSupervisores.SelectedValue);
                }
                else
                {
                    ;
                }
                objEmpleadoBE.Usu_Reg = "jleoncitocraft";

                if (chkActivo.Checked == true)
                    objEmpleadoBE.Estado = "Activo";
                else
                    objEmpleadoBE.Estado = "Inactivo";


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
            this.Close();
        }


        private void txtDni_Validating(object sender, CancelEventArgs e)
        {
            if (txtDni.Text.Trim().Length != 8)
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }

        private void cboCargo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatosEmpleadosxRol(Convert.ToInt16(cboCargo.SelectedIndex));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosEmpleadosxRol(Int16 indice)
        {
            try
            {
                String strRol;
                if (indice > 0)
                {
                    if (indice == 1)
                    {
                        strRol = "Gerente";
                    }
                    else
                    {
                        strRol = "Supervisor";
                    }

                    DataTable dt2 = objEmpleadoBL.listarEmpleadoxRol(strRol);

                    cboSupervisores.DataSource = dt2;
                    cboSupervisores.ValueMember = "ID_Empleado";
                    cboSupervisores.DisplayMember = "Nom_Emp";
                    

                    cboSupervisores.Visible = true;
                    label7.Visible = true;
                }
                else
                {
                    cboSupervisores.DataSource = null;
                    cboSupervisores.Visible = false;
                    label7.Visible = false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
