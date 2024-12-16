using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyServTuristico_GUI
{
    public partial class CategoriaMan03 : Form
    {
        private string connectionString = "Server=.;Database=ProyectoTurismo;Integrated Security=True;";
        private int categoriaId;

        public CategoriaMan03(int id)
        {
            InitializeComponent();
            categoriaId = id;
            CargarComboEstado();
            CargarCategoria();
            btnGrabar.Click += btnActualizar_Click;
            btnCancelar.Click += btnCancelar_Click;
            btnFoto.Click += btnCargarFoto_Click;
            txtTarifaPorNoche.KeyPress += new KeyPressEventHandler(txtTarifaPorNoche_KeyPress);
        }

        private void CargarComboEstado()
        {
            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");
        }

        private void CargarCategoria()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Tb_Categoria WHERE ID_Categoria = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", categoriaId);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        txtDescripcion.Text = reader["Des_Cat"].ToString();
                        txtTarifaPorNoche.Text = reader["Tar_Por_Noc"].ToString();
                        txtCaracteristicas.Text = reader["Caracteristicas"].ToString();

                        string estado = reader["Estado"].ToString();
                        if (estado == "Activo")
                        {
                            cmbEstado.SelectedIndex = 0;
                        }
                        else if (estado == "Inactivo")
                        {
                            cmbEstado.SelectedIndex = 1;
                        }

                        byte[] fotoBytes = reader["Foto"] as byte[];
                        if (fotoBytes != null && fotoBytes.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(fotoBytes))
                            {
                                pictureBoxFoto.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            pictureBoxFoto.Image = null;
                        }
                    }
                }
            }
        }
        private void txtTarifaPorNoche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && txtTarifaPorNoche.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtTarifaPorNoche.Text) || cmbEstado.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            byte[] fotoBytes = null;
            if (pictureBoxFoto.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBoxFoto.Image.Save(ms, pictureBoxFoto.Image.RawFormat);
                    fotoBytes = ms.ToArray();
                }
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "EXEC usp_ActualizarCategoria @ID, @Descripcion, @Tarifa, @Caracteristicas, @Foto, @Usu_Ult_Mod, @Estado";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", categoriaId);
                        command.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                        command.Parameters.AddWithValue("@Tarifa", Convert.ToDecimal(txtTarifaPorNoche.Text));
                        command.Parameters.AddWithValue("@Caracteristicas", txtCaracteristicas.Text);
                        command.Parameters.AddWithValue("@Estado", cmbEstado.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Usu_Ult_Mod", "");
                        command.Parameters.AddWithValue("@Usu_Reg", "Admin");

                        if (fotoBytes != null)
                        {
                            command.Parameters.Add("@Foto", SqlDbType.Image).Value = fotoBytes;
                        }
                        else
                        {
                            command.Parameters.Add("@Foto", SqlDbType.Image).Value = DBNull.Value;
                        }

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Categoría actualizada correctamente.");
                        this.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al actualizar la categoría: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(ofd.FileName);
                pictureBoxFoto.Tag = ofd.FileName;
            }
        }
    }
}
