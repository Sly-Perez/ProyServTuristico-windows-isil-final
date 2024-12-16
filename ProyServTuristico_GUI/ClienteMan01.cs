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
    public partial class ClienteMan01 : Form
    {
        ClienteBL objClienteBL = new ClienteBL();
        ClienteBL objclienteBE = new ClienteBL();
        DataView dtv;
        public ClienteMan01()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClienteMan01_Load(object sender, EventArgs e)
        {

            CargarDato(txtNomCliFiltro.Text.Trim(), txtApeCliFiltro.Text.Trim());

        }

        private void CargarDato(String strNomCliFiltro, String strApeCliFiltro)
        {
            dtv = new DataView(objClienteBL.ListarCliente());

            // Aplicar filtros directamente
            dtv.RowFilter = "Nom_Cli LIKE '%" + strNomCliFiltro + "%' AND Ape_Cli LIKE '%" + strApeCliFiltro + "%'";

            dtgCliente.DataSource = dtv;
            lblRegistros.Text = dtgCliente.Rows.Count.ToString();
        }
        private void txtNomCliFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                CargarDato(txtNomCliFiltro.Text.Trim(), txtApeCliFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void txtDniCliFiltro_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
               
                CargarDato(txtNomCliFiltro.Text.Trim(), txtApeCliFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ClientesMan02 formClienteMan02 = new ClientesMan02();
                formClienteMan02.ShowDialog();
                CargarDato(txtNomCliFiltro.Text.Trim(), txtApeCliFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //error

        }

        private void button1_Click(object sender, EventArgs e)
            //actualizar
        {
            try
            {
                if (dtgCliente.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, selecciona un cliente para actualizar.");
                    return;
                }

                
                string strID_Cliente = dtgCliente.CurrentRow.Cells[0].Value.ToString();
               


                
                Int16 idCliente;
                if (!Int16.TryParse(strID_Cliente, out idCliente))
                {
                    MessageBox.Show("El ID del cliente no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                ClienteMan03 objMan03 = new ClienteMan03();
                objMan03.ID_Cliente = idCliente; 

                
                if (objMan03.ShowDialog() == DialogResult.OK)
                {
                    CargarDato(txtNomCliFiltro.Text.Trim(), txtApeCliFiltro.Text.Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {

                try
                {
                   
                    if (dtgCliente.CurrentRow != null)
                    {
                       
                        string codigoCliente = dtgCliente.CurrentRow.Cells[0].Value.ToString();

                        DialogResult respuesta = MessageBox.Show(
                            "¿Está seguro de eliminar el registro?",
                            "Confirmar",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            
                            if (objClienteBL.EliminarCliente(codigoCliente))
                            {
                            
                            CargarDato(txtNomCliFiltro.Text.Trim(), txtApeCliFiltro.Text.Trim());
                        }
                            else
                            {
                                throw new Exception("No se puede eliminar el registro porque está vinculado a otra tabla");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione un producto para eliminar.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


        }
    }



    

