using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyServTuristico_GUI
{
    public partial class CategoriaMan01 : Form
    {
        private string connectionString = "Server=.;Database=ProyectoTurismo;Integrated Security=True;";
        private DataTable dataTable;

        public CategoriaMan01()
        {
            InitializeComponent();
            CargarCategorias();
            txtBuscar.TextChanged += new EventHandler(txtBuscar_TextChanged);
            btnAgregar.Click += new EventHandler(btnAgregar_Click);
            btnActualizar.Click += new EventHandler(btnActualizar_Click);
            btnEliminar.Click += new EventHandler(btnEliminar_Click);
            btnCerrar.Click += new EventHandler(btnCerrar_Click);
        }

        private void CargarCategorias()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "EXEC usp_ListarCategorias";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvCategorias.DataSource = dataTable;
                    lblRegistros.Text = dataTable.Rows.Count.ToString();

                    dgvCategorias.Columns["ID_Categoria"].HeaderText = "ID de Categoría";
                    dgvCategorias.Columns["Des_Cat"].HeaderText = "Descripción de Categoría";
                    dgvCategorias.Columns["Tar_Por_Noc"].HeaderText = "Tarifa por Noche";
                    dgvCategorias.Columns["Caracteristicas"].HeaderText = "Características";
                    dgvCategorias.Columns["Foto"].HeaderText = "Fotografía";
                    dgvCategorias.Columns["Usu_Reg"].HeaderText = "Usuario de Registro";
                    dgvCategorias.Columns["Fec_Reg"].HeaderText = "Fecha de Registro";
                    dgvCategorias.Columns["Usu_ult_Mod"].HeaderText = "Último Usuario en Modificar";
                    dgvCategorias.Columns["Fec_ult_mod"].HeaderText = "Fecha de Última Modificación";
                    dgvCategorias.Columns["Estado"].HeaderText = "Estado";
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dataTable.DefaultView;
            dv.RowFilter = string.Format("Convert(ID_Categoria, 'System.String') LIKE '%{0}%' OR Des_Cat LIKE '%{0}%' OR Caracteristicas LIKE '%{0}%' OR Estado LIKE '%{0}%'", txtBuscar.Text);
            dgvCategorias.DataSource = dv.ToTable();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCategoria();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una categoría para actualizar.");
                return;
            }

            int categoriaId = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells["ID_Categoria"].Value);
            CategoriaMan03 frm = new CategoriaMan03(categoriaId);
            frm.ShowDialog();
            CargarCategorias();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una categoría para eliminar.");
                return;
            }

            int categoriaId = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells["ID_Categoria"].Value);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    string deleteAlojamientoQuery = "DELETE FROM Tb_Alojamiento WHERE ID_Categoria = @ID";
                    using (SqlCommand command = new SqlCommand(deleteAlojamientoQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@ID", categoriaId);
                        command.ExecuteNonQuery();
                    }

                    string deleteCategoriaQuery = "EXEC usp_EliminarCategoria @ID";
                    using (SqlCommand command = new SqlCommand(deleteCategoriaQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@ID", categoriaId);
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Categoría eliminada.");
                    CargarCategorias();
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error al eliminar la categoría: " + ex.Message);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            NavigationHelper.ReturnToMenuPrincipal(this);
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCategorias.Rows[e.RowIndex];
                txtBuscar.Text = row.Cells["Des_Cat"].Value.ToString();
            }
        }

        private void AgregarCategoria()
        {
            CategoriaMan02 frm = new CategoriaMan02();
            frm.ShowDialog();
            CargarCategorias();
        }
    }
}
