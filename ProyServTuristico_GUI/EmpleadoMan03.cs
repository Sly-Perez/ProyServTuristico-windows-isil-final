using ProyServTuristico_ADO;
using ProyServTuristico_BE;
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
    public partial class EmpleadoMan03 : Form
    {
        // Instancias...
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        EmpleadoBE objEmpleadoBE = new EmpleadoBE();

        public EmpleadoMan03()
        {
            InitializeComponent();
        }


        public Int16 ID_Empleado { get; set; }

        private void EmpleadoMan03_Load(object sender, EventArgs e)
        {
            try
            {

                objEmpleadoBE = objEmpleadoBL.ConsultarEmpleado(this.ID_Empleado);


                if (objEmpleadoBE != null)
                {

                    txtNombre.Text = objEmpleadoBE.Nom_Emp;
                    txtApellidos.Text = objEmpleadoBE.Ape_Emp;
                    txtDni.Text = objEmpleadoBE.Dni_Emp;
                    txtTelefono.Text = objEmpleadoBE.Tel_Emp;
                    txtEmail.Text = objEmpleadoBE.Email_Emp;
                    cboCargo.Text = objEmpleadoBE.Rol_Emp;


                    if (objEmpleadoBE.Estado == "Activo")
                        rtbActivo.Checked = true;
                    else
                        rtbInactivo.Checked = true;

                    if (objEmpleadoBE.Rol_Emp == "Gerente")
                        cboCargo.SelectedIndex = 0;
                    else if (objEmpleadoBE.Rol_Emp == "Supervisor")
                        cboCargo.SelectedIndex = 1;
                    else
                        cboCargo.SelectedIndex = 2;

                    CargarDatosEmpleadosxRol(Convert.ToInt16(cboCargo.SelectedIndex));
                    if (cboCargo.SelectedIndex == 0)
                    {
                        ;
                    }
                    else
                    {
                        cboSupervisores.SelectedValue = objEmpleadoBE.Supervisot_ID;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró al empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click_1(object sender, EventArgs e)
        {
            try
            {

                List<string> errores = new List<string>();

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                    errores.Add("Debe ingresar el nombre del empleado.");

                if (string.IsNullOrWhiteSpace(txtApellidos.Text))
                    errores.Add("Debe ingresar el apellido del empleado.");

                if (txtDni.Text.Trim().Length != 8)
                    errores.Add("El DNI debe tener 8 dígitos.");

                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                    errores.Add("Debe ingresar el email del empleado.");

                if (!rtbActivo.Checked && !rtbInactivo.Checked)
                    errores.Add("Debe seleccionar el estado.");

                if (Convert.ToInt16(cboSupervisores.SelectedValue) == this.ID_Empleado)
                {
                    throw new Exception("No puede asignar como supervisor del empleado actual al empleado actual");
                }



                objEmpleadoBE.ID_Empleado = this.ID_Empleado;
                objEmpleadoBE.Nom_Emp = txtNombre.Text.Trim();
                objEmpleadoBE.Ape_Emp = txtApellidos.Text.Trim();
                objEmpleadoBE.Dni_Emp = txtDni.Text.Trim();
                objEmpleadoBE.Tel_Emp = txtTelefono.Text.Trim();
                objEmpleadoBE.Email_Emp = txtEmail.Text.Trim();

                if (cboCargo.SelectedIndex == 0)
                    objEmpleadoBE.Rol_Emp = "Gerente";
                else if (cboCargo.SelectedIndex == 1)
                    objEmpleadoBE.Rol_Emp = "Supervisor";
                else
                    objEmpleadoBE.Rol_Emp = "Empleado";

                if (cboSupervisores.Visible == true)
                    objEmpleadoBE.Supervisot_ID = Convert.ToInt16(cboSupervisores.SelectedValue);
                else
                    objEmpleadoBE.Supervisot_ID = 0;

                //para el campo Estado

                if (rtbActivo.Checked)
                {
                    objEmpleadoBE.Estado = "Activo";
                }
                else if (rtbInactivo.Checked)
                {
                    objEmpleadoBE.Estado = "Inactivo";
                }
                else
                {
                    throw new Exception("Debe seleccionar el estado.");
                }


                //COMO AÚN NO ESTA ESTABLECIDO EL MO-->ESTA EN BRUTO 
                objEmpleadoBE.Usu_Ult_Mod = "Admin";


                if (objEmpleadoBL.ActualizarEmpleado(objEmpleadoBE))
                {
                    MessageBox.Show("Empleado actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    throw new Exception("No se pudo actualizar el empleado. Intenta nuevamente.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
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

        private void cboCargo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {

                CargarDatosEmpleadosxRol(Convert.ToInt16(cboCargo.SelectedIndex));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboSupervisores_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(cboSupervisores.SelectedValue) == this.ID_Empleado)
                {
                    throw new Exception("No puede asignar como supervisor del empleado actual al empleado actual");
                }
            }
            catch(Exception ex)
            {
                CargarDatosEmpleadosxRol(Convert.ToInt16(cboCargo.SelectedIndex));
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
