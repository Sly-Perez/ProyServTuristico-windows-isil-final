using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace ProyServTuristico_GUI
{
    public partial class CategoriaMan02 : Form
    {
        private string connectionString = "Server=.;Database=ProyectoTurismo;Integrated Security=True;";
        private string fotoPath = string.Empty;

        public CategoriaMan02()
        {
            InitializeComponent();
            CargarEstados();
            btnFoto.Click += new EventHandler(btnFoto_Click);
            btnGrabar.Click += new EventHandler(btnGrabar_Click);
            txtTarifaPorNoche.KeyPress += new KeyPressEventHandler(txtTarifaPorNoche_KeyPress);
        }

        private void CargarEstados()
        {
            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");
            cmbEstado.SelectedIndex = 0;
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


        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Selecciona una imagen"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fotoPath = openFileDialog.FileName;
                MessageBox.Show("Imagen seleccionada: " + fotoPath);

                pictureBoxFoto.Image = Image.FromFile(fotoPath);
                pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(fotoPath) ||
                string.IsNullOrWhiteSpace(txtTarifaPorNoche.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.");
                return;
            }

            byte[] fotoBytes = File.ReadAllBytes(fotoPath);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "EXEC usp_InsertarCategoria @Descripcion, @TarifaPorNoche, @Caracteristicas, @Foto, @Usu_Reg, @Estado";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                        command.Parameters.AddWithValue("@TarifaPorNoche", decimal.Parse(txtTarifaPorNoche.Text));
                        command.Parameters.AddWithValue("@Caracteristicas", txtCaracteristicas.Text);
                        command.Parameters.AddWithValue("@Foto", fotoBytes);
                        command.Parameters.AddWithValue("@Usu_Reg", "Admin");
                        command.Parameters.AddWithValue("@Estado", cmbEstado.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Fec_Reg", DateTime.Today);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Categoría agregada con éxito.");
                        this.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al agregar la categoría: " + ex.Message);
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
    }
}
