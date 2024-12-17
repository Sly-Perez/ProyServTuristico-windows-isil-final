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
using System.Resources;
namespace ProyServTuristico_GUI
{
    public partial class ReservaMan01 : Form
    {
        ReservaBL objReservaBL = new ReservaBL();
        UbicacionBL objUbicacionBL = new UbicacionBL();
        DataView dtv;
        public ReservaMan01()
        {
            InitializeComponent();
        }

        private void ReservaMan01_Load(object sender, EventArgs e)
        {
            dtgDatos.AutoGenerateColumns = false;

            DataTable dt = objUbicacionBL.ListarUbicacion_Departamentos();
            cboDepaFiltro.DataSource = dt;
            DataRow dr;
            dr = dt.NewRow();
            dr["Departamento"] = "Todos";
            dt.Rows.InsertAt(dr, 0);
            cboDepaFiltro.ValueMember = "Departamento";
            cboDepaFiltro.DisplayMember = "Departamento";
            cboDepaFiltro.SelectedIndex = 0;
            CargarDatos(txtNomCliFiltro.Text.Trim(), cboDepaFiltro.SelectedValue.ToString());
        }
        private void CargarDatos(String strNomFiltro, String strDepaFiltro)
        {
            dtv = new DataView(objReservaBL.ListarReserva());
            if (strDepaFiltro == "Todos")
            {
                dtv.RowFilter = "Nom_Cli like '%" + strNomFiltro + "%' ";
            }
            else
            {
                dtv.RowFilter = "Nom_Cli like '%" + strNomFiltro + "%' and Departamento like '%" + strDepaFiltro + "%' ";
            }
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();
        }


        private void txtNomCliFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtNomCliFiltro.Text.Trim(), cboDepaFiltro.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ReservaMan02 formReservaMan02 = new ReservaMan02();
                formReservaMan02.ShowDialog();

                CargarDatos(txtNomCliFiltro.Text.Trim(), cboDepaFiltro.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((dtgDatos.CurrentRow != null && dtgDatos.CurrentRow.Cells[10].Value != null && dtgDatos.CurrentRow.Cells[10].Value.ToString() == "Finalizado"))
                {
                    throw new Exception("El Tour ya ha finalizado. No se puede editar");
                }
                else
                {
                    ReservaMan03 formReserva03 = new ReservaMan03();
                    formReserva03.codReserva = Convert.ToInt16(dtgDatos.CurrentRow.Cells[0].Value);
                    formReserva03.ShowDialog();
                }

                CargarDatos(txtNomCliFiltro.Text.Trim(), cboDepaFiltro.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
        }

        private void cboDepaFiltro_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtNomCliFiltro.Text.Trim(), cboDepaFiltro.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

    }
}
