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
    public partial class ClienteMan03 : Form
    {
        ClienteBL objClienteBL = new ClienteBL();
        ClienteBE objClienteBE = new ClienteBE();

        public ClienteMan03()
        {

            InitializeComponent();
        }
        public Int16 ID_Cliente { get; set; }
        private void ClienteMan03_Load(object sender, EventArgs e)
        {
            try
            {

                objClienteBE = objClienteBL.ConsultarCliente(this.ID_Cliente);


                if (objClienteBE != null)
                {

                    txtNombre.Text = objClienteBE.Nom_Cli;
                    txtApe.Text = objClienteBE.Ape_Cli;
                    txtDni.Text = objClienteBE.Dni_Cli;
                    txtTelefono.Text = objClienteBE.Num_Tel;
                    txtEmail.Text = objClienteBE.Email_Cli;
                    txtFechaNac.Value = objClienteBE.Fec_Nac;
                    dtRegistro.Value = objClienteBE.Fec_Reg;


                    if (objClienteBE.Sex_Cli == "Femenino")
                        rtbFemenino.Checked = true;
                    else if (objClienteBE.Sex_Cli == "Masculino")
                        rtbMasculino.Checked = true;

                    if (objClienteBE.Estado == "Activo")
                        txtActivo.Checked = true;
                    else
                        txtActivo.Checked = false;
                }
                else
                {
                    MessageBox.Show("No se encontró al cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //cancelar
            this.Close();

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {

                List<string> errores = new List<string>();

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                    errores.Add("El nombre es obligatorio.");

                if (string.IsNullOrWhiteSpace(txtApe.Text))
                    errores.Add("El apellido es obligatorio.");

                if (txtDni.Text.Trim().Length != 8)
                    errores.Add("El DNI debe tener 8 dígitos.");

                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                    errores.Add("El email es obligatorio.");

                if (!rtbFemenino.Checked && !rtbMasculino.Checked)
                    errores.Add("Debe seleccionar un género.");



                objClienteBE.Nom_Cli = txtNombre.Text.Trim();
                objClienteBE.Ape_Cli = txtApe.Text.Trim();
                objClienteBE.Dni_Cli = txtDni.Text.Trim();
                objClienteBE.Email_Cli = txtEmail.Text.Trim();
                objClienteBE.Num_Tel = txtTelefono.Text.Trim();
                objClienteBE.Fec_Nac = txtFechaNac.Value;
                objClienteBE.Fec_Reg = dtRegistro.Value;

                //para el campo Estado
                if (txtActivo.Checked)
                {
                    objClienteBE.Estado = "Activo";
                }
                else
                {
                    objClienteBE.Estado = "Inactivo";
                }

                //para el rb-->--___---
                if (rtbFemenino.Checked)
                {
                    objClienteBE.Sex_Cli = "Femenino";
                }
                else if (rtbMasculino.Checked)
                {
                    objClienteBE.Sex_Cli = "Masculino";
                }
                else
                {
                    throw new Exception("Debe seleccionar un género.");
                }


                //COMO AÚN NO ESTA ESTABLECIDO EL MO-->ESTA EN BRUTO 
                objClienteBE.Usu_Ult_Mod = "Admin";


                if (objClienteBL.ActualizarCliente(objClienteBE))
                {
                    MessageBox.Show("Cliente actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    throw new Exception("No se pudo actualizar el cliente. Intenta nuevamente.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            //error
        }

        private void ClienteMan03_FormClosing(object sender, FormClosingEventArgs e)
        {
            NavigationHelper.ReturnToMenuPrincipal(this);
        }
    }
}
    