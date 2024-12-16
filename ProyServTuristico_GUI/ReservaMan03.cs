using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyServTuristico_BE;
using ProyServTuristico_BL;

namespace ProyServTuristico_GUI
{
    public partial class ReservaMan03 : Form
    {
        ReservaBE objReservaBE = new ReservaBE();
        ReservaBL objReservaBL = new ReservaBL();
        ClienteBE objClienteBE = new ClienteBE();

        ClienteBL objClienteBL = new ClienteBL();
        UbicacionBL objUbicacionBL = new UbicacionBL();
        TourBL objTourBL = new TourBL();
        AlojamientoBL objAlojamientoBL = new AlojamientoBL();

        DataView dtv;
        public ReservaMan03()
        {
            InitializeComponent();
        }

        public Int16 codReserva { get; set; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            NavigationHelper.ReturnToMenuPrincipal(this);
        }

        private void ReservaMan03_Load(object sender, EventArgs e)
        {
            try
            {
                dtgClientesReg.AutoGenerateColumns = false;
                dtgTourDis.AutoGenerateColumns = false;
                lblCodReserva.Text = this.codReserva.ToString();


                objReservaBE = objReservaBL.ConsultarReserva(codReserva);
                objClienteBE = objClienteBL.ConsultarCliente(objReservaBE.Id_Cliente);
                //cargar datos del cliente
                txtNomCliFiltro.Text = objClienteBE.Nom_Cli;
                txtApeCliFiltro.Text = objClienteBE.Ape_Cli;

                CargarDatosCliId(objReservaBE.Id_Cliente);

                //cargar datos del tour
                CargarDatosTourId(objReservaBE.Id_Tour);

                DataTable dt = objUbicacionBL.ListarUbicacion_Departamentos();
                cboDepaTour.DataSource = dt;
                cboDepaTour.ValueMember = "Departamento";
                cboDepaTour.DisplayMember = "Departamento";
                cboDepaTour.SelectedValue = dtgTourDis.CurrentRow.Cells[4].Value;

                //cargar datos de alojamiento
                cboAlojamientosDisponibles.Visible = false;
                lblNoDisponible.Visible = false;
                CargarDatosAlojamientos(Convert.ToInt16(dtgTourDis.CurrentRow.Cells[3].Value));

                //cargar fecha de reserva
                dtpFecReserva.Value = objReservaBE.Fec_Res;

                //cargar estado de reserva
                if (objReservaBE.Estado == "Confirmada")
                {
                    chkEstado.Checked = true;
                }
                else
                {
                    chkEstado.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }


        private void CargarDatosCliId(Int16 idCli)
        {
            try
            {
                dtv = new DataView(objClienteBL.ListarCliente());
                dtv.RowFilter = "ID_Cliente = " + idCli;
                dtgClientesReg.DataSource = dtv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        private void CargarDatosCliNombrexApellido(String strNomFiltro, String strApeFiltro)
        {
            try
            {
                dtv = new DataView(objClienteBL.ListarCliente());
                dtv.RowFilter = "Nom_Cli like '%" + strNomFiltro + "%' and Ape_Cli like '%" + strApeFiltro + "%' ";
                dtgClientesReg.DataSource = dtv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        private void CargarDatosTourId(Int16 idTour)
        {
            try
            {
                dtv = new DataView(objTourBL.Listar_Tour_Disponibles());
                dtv.RowFilter = "ID_Tour = " + idTour;
                dtgTourDis.DataSource = dtv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void CargarDatosTourDepartamento(String strDepartamento)
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
                if (cboAlojamientosDisponibles.Visible == true)
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


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void txtNomCliFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatosCliNombrexApellido(txtNomCliFiltro.Text.Trim(), txtApeCliFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void txtApeCliFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatosCliNombrexApellido(txtNomCliFiltro.Text.Trim(), txtApeCliFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void cboDepaTour_SelectedValueChanged(object sender, EventArgs e)
        {
            /**/
        }

        private void cboDepaTour_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                CargarDatosTourDepartamento(cboDepaTour.SelectedValue.ToString());
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
                    cboAlojamientosDisponibles.Visible = true;
                    CargarDatosAlojamientos(Convert.ToInt16(dtgTourDis.CurrentRow.Cells[3].Value));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboAlojamientosDisponibles.Visible = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //validacion
                if (dtgClientesReg.SelectedRows.Count == 0)
                {
                    throw new Exception("Es obligatorio seleccionar un Cliente");
                }
                if (dtgTourDis.SelectedRows.Count == 0)
                {
                    throw new Exception("Es obligatorio seleccionar un Tour");
                }
                if (cboAlojamientosDisponibles.Visible == true)
                {
                    if (cboAlojamientosDisponibles.SelectedIndex == 0)
                    {
                        throw new Exception("Es obligatorio seleccionar un hotel de Alojamiento");
                    }
                }

                if (dtpFecReserva.Value.Date < DateTime.Today.Date)
                {
                    throw new Exception("La fecha de reserva no puede ser menor a la fecha actual");
                }

                objReservaBE.Id_Reserva = Convert.ToInt16(lblCodReserva.Text.Trim());
                objReservaBE.Id_Cliente = Convert.ToInt16(dtgClientesReg.CurrentRow.Cells[0].Value);
                objReservaBE.Id_Tour = Convert.ToInt16(dtgTourDis.CurrentRow.Cells[0].Value);
                objReservaBE.Fec_Res = dtpFecReserva.Value;
                if (chkEstado.Checked == true)
                {
                    objReservaBE.Estado = "Confirmada";
                }
                else
                {
                    objReservaBE.Estado = "Cancelada";
                }
                //POR AHORA MANUAL HASTA QUE AGREGUEN EL CREDENCIALES Y LOGIN
                objReservaBE.Usu_Ult_Mod = "jleoncitocraft777";

                if (objReservaBL.ActualizarReserva(objReservaBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se pudo actualizar la reserva. Contactarse con TI");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ClientesMan02 formClienteMan02 = new ClientesMan02();
                formClienteMan02.ShowDialog();
                CargarDatosCliNombrexApellido(txtNomCliFiltro.Text.Trim(), txtApeCliFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ReservaMan03_FormClosing(object sender, FormClosingEventArgs e)
        {
            NavigationHelper.ReturnToMenuPrincipal(this);
        }
    }
}
