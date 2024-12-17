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
    public partial class ClientesMan02 : Form

    {

        ClienteBL objClienteBL = new ClienteBL();
        ClienteBE objClienteBE = new ClienteBE();
        ClienteADO clienteADO = new ClienteADO();

        DataView dtv;
        public ClientesMan02()
        {
            InitializeComponent();
        }

        private void ClientesMan02_Load(object sender, EventArgs e)
        {
            //
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtFechaNac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rtbEfectivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtDni_Validating(object sender, CancelEventArgs e)
        {
            if (txtDni.Text.Trim().Length != 8)
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {


        }

        private void label7_Click(object sender, EventArgs e)
        {
            //error

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click_1(object sender, EventArgs e)
        {

            try
            {
                // Validamos los campos obligatorios
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                    throw new Exception("El nombre del cliente es obligatorio.");

                if (string.IsNullOrWhiteSpace(txtApe.Text))
                    throw new Exception("El apellido del cliente es obligatorio.");

                if (txtDni.Text.Trim().Length != 8)
                    throw new Exception("El DNI debe tener exactamente 8 dígitos.");

                if (txtFechaNac.Value == null || txtFechaNac.Value > DateTime.Now)
                    throw new Exception("Ingrese una fecha de nacimiento válida.");

                if (dtRegistro.Value == null || dtRegistro.Value > DateTime.Now)
                    throw new Exception("Ingrese una fecha de registro válida.");


                objClienteBE.Dni_Cli = txtDni.Text.Trim();
                objClienteBE.Nom_Cli = txtNombre.Text.Trim();
                objClienteBE.Ape_Cli = txtApe.Text.Trim();
                objClienteBE.Fec_Nac = txtFechaNac.Value;
                objClienteBE.Num_Tel = txtTelefono.Text.Trim();
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


                objClienteBE.Email_Cli = txtEmail.Text.Trim();
                if (string.IsNullOrWhiteSpace(objClienteBE.Email_Cli))
                {
                    throw new Exception("El email del cliente es obligatorio.");
                }

                objClienteBE.Fec_Reg = dtRegistro.Value;
                objClienteBE.Usu_Reg = "Admin";

                if (objClienteBL.InsertarCliente(objClienteBE))
                {
                    MessageBox.Show("Cliente registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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






        private void btnGrabar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //error

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }
    }
}



