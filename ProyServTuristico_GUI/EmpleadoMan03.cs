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
                    dtRegistro.Value = objEmpleadoBE.Fec_Reg;


                    if (objEmpleadoBE.Estado == "Activo")
                        txtActivo.Checked = true;
                    else
                        txtActivo.Checked = false;
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



                objEmpleadoBE.Nom_Emp = txtNombre.Text.Trim();
                objEmpleadoBE.Ape_Emp = txtApellidos.Text.Trim();
                objEmpleadoBE.Dni_Emp = txtDni.Text.Trim();
                objEmpleadoBE.Email_Emp = txtEmail.Text.Trim();
                objEmpleadoBE.Tel_Emp = txtTelefono.Text.Trim();
                objEmpleadoBE.Rol_Emp = cboCargo.Text.Trim();
                objEmpleadoBE.Fec_Reg = dtRegistro.Value;

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
            NavigationHelper.ReturnToMenuPrincipal(this);
        }

        private void EmpleadoMan03_FormClosing(object sender, FormClosingEventArgs e)
        {
            NavigationHelper.ReturnToMenuPrincipal(this);
        }
    }
}
