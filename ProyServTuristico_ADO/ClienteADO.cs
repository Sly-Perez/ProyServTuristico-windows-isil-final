using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyServTuristico_BE;

namespace ProyServTuristico_ADO
{
    public class ClienteADO
    {
        ConexionADO miConexionADO = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable listarCliente()
        {
            try
            {
                cnx.ConnectionString = miConexionADO.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarClientes";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();

                ada.Fill(dts, "Clientes");
                return dts.Tables["Clientes"];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public ClienteBE ConsultarCliente(Int16 idCli)
        {
            try
            {
                ClienteBE objClienteBE = new ClienteBE();

                cnx.ConnectionString = miConexionADO.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vID_Cli", idCli);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objClienteBE.ID_Cliente = Convert.ToInt16(dtr["ID_Cliente"]);
                    objClienteBE.Nom_Cli = dtr["Nom_Cli"].ToString();
                    objClienteBE.Ape_Cli = dtr["Ape_Cli"].ToString();
                    objClienteBE.Dni_Cli = dtr["Dni_Cli"].ToString();
                    objClienteBE.Num_Tel = dtr["Num_Tel"].ToString();
                    objClienteBE.Email_Cli = dtr["Email_Cli"].ToString();
                    objClienteBE.Fec_Nac = Convert.ToDateTime(dtr["Fec_Nac"]);
                    objClienteBE.Sex_Cli = dtr["Sex_Cli"].ToString();
                    objClienteBE.Fec_Reg = Convert.ToDateTime(dtr["Fec_Reg"]);
                    objClienteBE.Estado = dtr["Estado"].ToString();
                }
                dtr.Close();
                return objClienteBE;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
        public Boolean InsertarCliente(ClienteBE objClienteBE)
        {
            try
            {
                cnx.ConnectionString = miConexionADO.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarCliente";
                cmd.Parameters.Clear();

                
                cmd.Parameters.AddWithValue("@vNom_Cli", objClienteBE.Nom_Cli);
                cmd.Parameters.AddWithValue("@vApe_Cli", objClienteBE.Ape_Cli);
                cmd.Parameters.AddWithValue("@vDni_Cli", objClienteBE.Dni_Cli);
                cmd.Parameters.AddWithValue("@vNum_Tel", objClienteBE.Num_Tel);
                cmd.Parameters.AddWithValue("@vFec_Nac", objClienteBE.Fec_Nac);
                cmd.Parameters.AddWithValue("@vSex_Cli", objClienteBE.Sex_Cli);
                cmd.Parameters.AddWithValue("@vUsu_Reg", objClienteBE.Usu_Reg);
                cmd.Parameters.AddWithValue("@vEstado", objClienteBE.Estado);
                cmd.Parameters.AddWithValue("@vEmail_Cli", objClienteBE.Email_Cli);


                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar cliente: " + ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
        //actualizar y eliminar
        public Boolean ActualizarCliente(ClienteBE objClienteBE)
        {
            try
            {
                cnx.ConnectionString = miConexionADO.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarCliente";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@vID_Cli", objClienteBE.ID_Cliente);
                cmd.Parameters.AddWithValue("@vNom_Cli", objClienteBE.Nom_Cli);
                cmd.Parameters.AddWithValue("@vApe_Cli", objClienteBE.Ape_Cli);
                cmd.Parameters.AddWithValue("@vDni_Cli", objClienteBE.Dni_Cli);
                cmd.Parameters.AddWithValue("@vEmail_Cli", objClienteBE.Email_Cli);
                cmd.Parameters.AddWithValue("@vNum_Tel", objClienteBE.Num_Tel);
                cmd.Parameters.AddWithValue("@vFec_Nac", objClienteBE.Fec_Nac);
                cmd.Parameters.AddWithValue("@vSex_Cli", objClienteBE.Sex_Cli);
                cmd.Parameters.AddWithValue("@vUsu_Ult_Mod", objClienteBE.Usu_Ult_Mod);
                cmd.Parameters.AddWithValue("@vEstado", objClienteBE.Estado);
                



                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();


                }
            }
        }
        //eliminar
        public Boolean EliminarCliente(String strCodigo)
        {


            try
            {
                //Codifique
                cnx.ConnectionString = miConexionADO.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Cliente", strCodigo);
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SqlException x)
            {
                //throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }


        }
    }
}


