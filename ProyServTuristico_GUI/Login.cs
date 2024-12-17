using System;
using System.Windows.Forms;

namespace ProyServTuristico_GUI
{
    public partial class Login : Form
    {
        private LoginADO loginADO;

        public Login()
        {
            InitializeComponent();
            loginADO = new LoginADO();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string estadoUsuario;
            string nombreUsuario;

            try
            {
                bool esValido = loginADO.ValidarUsuario(usuario, contraseña, out estadoUsuario, out nombreUsuario);

                if (esValido)
                {

                    Session.NombreUsuario = nombreUsuario;

                    MenuPrincipalForm menuPrincipal = new MenuPrincipalForm();
                    menuPrincipal.Show();
                    this.Hide();
                }
                else if (!string.IsNullOrEmpty(estadoUsuario) && estadoUsuario.Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Usuario Inactivo.");
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnIngresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnIngresar.PerformClick();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
