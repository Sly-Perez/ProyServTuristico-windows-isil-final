using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyServTuristico_BE;
/***********************************************************************************************************************************/
namespace ProyServTuristico_ADO
{
    public class CategoriaADO
    {
        ConexionADO miConexionADO = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();


        public DataTable ListarCategoria()
        {
            try
            {
                cnx.ConnectionString = miConexionADO.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarCategorias";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();

                ada.Fill(dts, "categorias");
                return dts.Tables["categorias"];
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

        public CategoriaBE ConsultarCategoria(Int16 idCategoria)
        {
            try
            {
                CategoriaBE objCategoriaBE = new CategoriaBE();

                cnx.ConnectionString = miConexionADO.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarCategoria";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@ID_Categoria", idCategoria);

                cnx.Open();
                SqlDataReader dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objCategoriaBE.ID_Categoria = Convert.ToInt16(dtr["ID_Categoria"]);
                    objCategoriaBE.Des_Cat = dtr["Des_Cat"].ToString();
                    objCategoriaBE.Tar_Por_Noc = Convert.ToDecimal(dtr["Tar_Por_Noc"]);
                    objCategoriaBE.Caracteristicas = dtr["Caracteristicas"].ToString();
                    objCategoriaBE.Usu_Reg = dtr["Usu_Reg"].ToString();
                    objCategoriaBE.Estado = dtr["Estado"].ToString();
                }
                dtr.Close();
                return objCategoriaBE;

            }
            catch(Exception ex)
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
    }
}
/*********************************************************************************************************************/
