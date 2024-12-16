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
    public class ReservaADO
    {
        ConexionADO miConexionADO = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;


        public DataTable listarReserva()
        {
            try
            {
                cnx.ConnectionString = miConexionADO.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarReserva";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();

                ada.Fill(dts,"Reservas");
                return dts.Tables["Reservas"];
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
        public ReservaBE consultarReserva(Int16 idReserva)
        {
            try
            {
                ReservaBE objReservaBE = new ReservaBE();

                cnx.ConnectionString = miConexionADO.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarReserva";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vID_Reserva", idReserva);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows==true)
                {
                    dtr.Read();
                    objReservaBE.Id_Reserva = Convert.ToInt16(dtr["ID_Reserva"]);
                    objReservaBE.Id_Cliente = Convert.ToInt16(dtr["ID_Cliente"]);
                    objReservaBE.Id_Tour = Convert.ToInt16(dtr["ID_Tour"]);
                    objReservaBE.Fec_Res = Convert.ToDateTime(dtr["Fec_Res"]);
                    objReservaBE.Estado = dtr["Estado"].ToString();
                }
                dtr.Close();
                return objReservaBE;
            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }
            finally
            {
                if(cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
        public Boolean InsertarReservaYGenerarfacturar(ReservaBE objReservaBE, FacturaBE objFacturaBE)
        {
            try
            {
                cnx.ConnectionString = miConexionADO.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarReservaYEfectuarFactura";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@vID_Cliente", objReservaBE.Id_Cliente);
                cmd.Parameters.AddWithValue("@vID_Tour", objReservaBE.Id_Tour);
                cmd.Parameters.AddWithValue("@vFec_Res", objReservaBE.Fec_Res);
                cmd.Parameters.AddWithValue("@vUsu_Reg", objReservaBE.Usu_Reg);
                cmd.Parameters.AddWithValue("@vEstado", objReservaBE.Estado);
                cmd.Parameters.AddWithValue("@vTotal", objFacturaBE.Total);
                cmd.Parameters.AddWithValue("@vMet_Pag", objFacturaBE.Met_Pag);
                cmd.Parameters.AddWithValue("@vAuditoria", objFacturaBE.Auditoria);

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

        public Boolean ActualizarReserva(ReservaBE objReservaBE)
        {
            try
            {
                cnx.ConnectionString = miConexionADO.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarReserva";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@vID_Reserva", objReservaBE.Id_Reserva);
                cmd.Parameters.AddWithValue("@vID_Cliente", objReservaBE.Id_Cliente);
                cmd.Parameters.AddWithValue("@vID_Tour", objReservaBE.Id_Tour);
                cmd.Parameters.AddWithValue("@vFec_Res", objReservaBE.Fec_Res);
                cmd.Parameters.AddWithValue("@vEstado", objReservaBE.Estado);
                cmd.Parameters.AddWithValue("@vUsu_Ult_Mod", objReservaBE.Usu_Ult_Mod);

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


    }
}
