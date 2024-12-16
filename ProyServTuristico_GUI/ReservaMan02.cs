using ProyServTuristico_BL;
using ProyServTuristico_BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Globalization;

namespace ProyServTuristico_GUI
{
    public partial class ReservaMan02 : Form
    {
        ReservaBE objReservaBE = new ReservaBE();
        ReservaBL objReservaBL = new ReservaBL();
        FacturaBE objFacturaBE = new FacturaBE();
        /************************************************/
        CategoriaBE objCategoriaBE = new CategoriaBE();
        ClienteBE objClienteBE = new ClienteBE();
        /***********************************************/

        /**********************************************/
        CategoriaBL objCategoriaBL = new CategoriaBL();
        /*************************************************/
        ClienteBL objCienteBL = new ClienteBL();
        UbicacionBL objUbicacionBL = new UbicacionBL();
        TourBL objTourBL = new TourBL();
        AlojamientoBL objAlojamientoBL = new AlojamientoBL();

        DataView dtv;
        public ReservaMan02()
        {
            InitializeComponent();
        }

        private void ReservaMan02_Load(object sender, EventArgs e)
        {
            try
            {
                dtgTourDis.AutoGenerateColumns = false;

                DataTable dt = objUbicacionBL.ListarUbicacion_Departamentos();
                DataRow dr;
                dr = dt.NewRow();
                dr["Departamento"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboDepaTour.DataSource = dt;
                cboDepaTour.ValueMember = "Departamento";
                cboDepaTour.DisplayMember = "Departamento";

                CargarDatosAlojamientos(-1);
                /*****************************************/
                DataTable dt3 = objCategoriaBL.ListarCategoria();
                DataRow dr3;
                dr3 = dt3.NewRow();
                dr3["Des_Cat"] = "--Seleccione--";
                dt3.Rows.InsertAt(dr3, 0);
                cboCategoria.DataSource = dt3;
                cboCategoria.ValueMember = "ID_Categoria";
                cboCategoria.DisplayMember = "Des_Cat";
                /****************************************/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        private void CargarDatosCli(Int16 codCli)
        {
            try
            {
                objClienteBE = objCienteBL.ConsultarCliente(codCli);

                if (objClienteBE != null)
                {
                    lblNomCli.Text = objClienteBE.Nom_Cli;
                    lblApeCli.Text = objClienteBE.Ape_Cli;
                    lblDniCli.Text = objClienteBE.Dni_Cli;
                    lblTelCli.Text = objClienteBE.Num_Tel;
                    lblEmailCli.Text = objClienteBE.Email_Cli;
                    lblSexoCli.Text = objClienteBE.Sex_Cli;
                    lblEstadoCli.Text = objClienteBE.Estado;
                    if (objClienteBE.Fec_Nac.Year > 1)
                    {
                        lblFecNacCli.Text = objClienteBE.Fec_Nac.ToString();
                    }
                    else
                    {
                        lblFecNacCli.Text = "";
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        private void CargarDatosTour(String strDepartamento)
        {
            try
            {
                dtv = new DataView(objTourBL.Listar_Tour_Disponibles());
                dtv.RowFilter = "Departamento like '%" + strDepartamento + "%'";
                dtgTourDis.DataSource = dtv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        private void CargarDatosAlojamientos(Int16 idUbicacion)
        {
            try
            {
                DataTable dt2 = objAlojamientoBL.ListarAlojamiento_IDUbicacion(idUbicacion);

                if (dt2.Rows.Count > 0)
                {
                    cboAlojamientosDisponibles.Enabled = true;
                    lblNoDisponible.Visible = false;
                }
                else
                {
                    cboAlojamientosDisponibles.Enabled = false;
                    lblNoDisponible.Visible = true;
                }

                cboAlojamientosDisponibles.DataSource = dt2;
                DataRow dr2;
                dr2 = dt2.NewRow();
                dr2["Nom_Alo"] = "--Seleccione--";
                dt2.Rows.InsertAt(dr2, 0);
                cboAlojamientosDisponibles.ValueMember = "ID_Alojamiento";
                cboAlojamientosDisponibles.DisplayMember = "Nom_Alo";
                cboAlojamientosDisponibles.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cboDepaTour_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatosTour(cboDepaTour.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void dtgTourDis_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgTourDis.CurrentRow.Cells[3].Value != null)
                {
                    CargarDatosAlojamientos(Convert.ToInt16(dtgTourDis.CurrentRow.Cells[3].Value));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                /*VALIDACIONES*/
                if (txtCodCli.Text.Trim() == string.Empty || lblNomCli.Text.Trim() == string.Empty)
                {
                    throw new Exception("Es obligatorio seleccionar un Cliente");
                }
                /***************************************/
                if (cboCategoria.SelectedIndex == 0)
                {
                    throw new Exception("Es obligatorio seleccionar una categoría de alojamiento");
                }
                if (txtCantidadNoches.Text.Trim() == string.Empty)
                {
                    throw new Exception("Es obligatorio indicar la cantidad de noches de estadía");
                }

                /*****************************************/
                if (dtgTourDis.SelectedRows.Count == 0)
                {
                    throw new Exception("Es obligatorio seleccionar un Tour");
                }
                if (cboAlojamientosDisponibles.SelectedIndex == 0)
                {
                    throw new Exception("Es obligatorio seleccionar un hotel de Alojamiento");
                }
                if (dtpFecReserva.Value.Date < DateTime.Today.Date)
                {
                    throw new Exception("La fecha de reserva no puede ser menor a la fecha actual");
                }
                if (txtTotal.Text.Trim() == string.Empty)
                {
                    throw new Exception("Es obligatorio ingresar un monto total");
                }

                /*RESERVA*/
                objReservaBE.Id_Cliente = Convert.ToInt16(txtCodCli.Text.Trim());
                objReservaBE.Id_Tour = Convert.ToInt16(dtgTourDis.CurrentRow.Cells[0].Value);
                objReservaBE.Fec_Res = dtpFecReserva.Value;
                //POR AHORA MANUAL HASTA QUE AGREGUEN EL CREDENCIALES Y LOGIN
                objReservaBE.Usu_Reg = "jleon";
                objReservaBE.Estado = "Confirmada";


                /*FACTURA*/
                objFacturaBE.Total = Convert.ToDecimal(txtTotal.Text);

                if (rtbEfectivo.Checked == true)
                {
                    objFacturaBE.Met_Pag = 1;
                }
                else
                {
                    if (rtbTarjetaCredito.Checked == true)
                    {
                        objFacturaBE.Met_Pag = 2;
                    }
                    else
                    {
                        objFacturaBE.Met_Pag = 3;
                    }
                }
                //POR AHORA MANUAL HASTA QUE AGREGUEN EL CREDENCIALES Y LOGIN
                objFacturaBE.Auditoria = "factura generada desde aplicación escritorio";

                if (objReservaBL.InsertarReservaYGenerarfacturar(objReservaBE, objFacturaBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se logró insertar reserva ni generar factura, contactarse con TI.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        /***************************************************
        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            WE HAVE CHANGED THE PROPERTY OF OUR txtTotal 
            ReadOnly = true;

        }
        ******************************************************/
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ClientesMan02 formClienteMan02 = new ClientesMan02();
                formClienteMan02.ShowDialog();
                CargarDatosCli(Convert.ToInt16(txtCodCli));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        /****************************************************/
        private void CargarTarifaPorNoche(Int16 idCategoria)
        {
            try
            {
                objCategoriaBE = objCategoriaBL.ConsultarCategoria(idCategoria);

                lblTarifaNoche.Text = objCategoriaBE.Tar_Por_Noc.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        /************************************************/

        /*************************************************/
        private void cboCategoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                CargarTarifaPorNoche(Convert.ToInt16(cboCategoria.SelectedValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        /***************************************************/

        /****************************************************/
        private void txtCantidadNoches_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }
        /*****************************************************/

        /************************************************/
        private void CalcularMontoTotal(Decimal tarifaPorNoche, Int16 cantidadNoches)
        {
            try
            {
                txtTotal.Text = (tarifaPorNoche * cantidadNoches).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        /************************************************/

        /***************************************************/
        private void txtCantidadNoches_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCantidadNoches.Text != string.Empty && Convert.ToDecimal(lblTarifaNoche.Text) > 0)
                {
                    CalcularMontoTotal(Convert.ToDecimal(lblTarifaNoche.Text), Convert.ToInt16(txtCantidadNoches.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        /*************************************************/
        /*************************************************/
        private void lblTarifaNoche_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCantidadNoches.Text != string.Empty && Convert.ToDecimal(lblTarifaNoche.Text) > 0)
                {
                    CalcularMontoTotal(Convert.ToDecimal(lblTarifaNoche.Text), Convert.ToInt16(txtCantidadNoches.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtCodCli_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCodCli.Text.Trim() != string.Empty)
                {
                    CargarDatosCli(Convert.ToInt16(txtCodCli.Text.Trim()));
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        /*************************************************/

    }
}
