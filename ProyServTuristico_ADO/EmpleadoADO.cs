﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyServTuristico_BE;

namespace ProyServTuristico_ADO
{
    public class EmpleadoADO
    {
        ConexionADO miConexionADO = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable listarEmpleado()
        {
            try
            {
                cnx.ConnectionString = miConexionADO.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarEmpleado";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();

                ada.Fill(dts, "Empleados");
                return dts.Tables["Empleados"];
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

        public EmpleadoBE ConsultarEmpleado(Int16 idEmp)
        {
            try
            {
                EmpleadoBE objEmpleadoBE = new EmpleadoBE();

                cnx.ConnectionString = miConexionADO.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vID_Emp", idEmp);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objEmpleadoBE.ID_Empleado = Convert.ToInt16(dtr["ID_Empleado"]);
                    objEmpleadoBE.Nom_Emp = dtr["Nom_Emp"].ToString();
                    objEmpleadoBE.Ape_Emp = dtr["Ape_Emp"].ToString();
                    objEmpleadoBE.Dni_Emp = dtr["Dni_Emp"].ToString();
                    objEmpleadoBE.Tel_Emp = dtr["Tel_Emp"].ToString();
                    objEmpleadoBE.Email_Emp = dtr["Email_Emp"].ToString();
                    objEmpleadoBE.Rol_Emp = dtr["Rol_Emp"].ToString();
                    objEmpleadoBE.Estado = dtr["Estado"].ToString();
                }
                dtr.Close();
                return objEmpleadoBE;
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
        public Boolean InsertarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            try
            {
                cnx.ConnectionString = miConexionADO.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarEmpleado";
                cmd.Parameters.Clear();

                
                cmd.Parameters.AddWithValue("@vNom_Emp", objEmpleadoBE.Nom_Emp);
                cmd.Parameters.AddWithValue("@vApe_Emp", objEmpleadoBE.Ape_Emp);
                cmd.Parameters.AddWithValue("@vDni_Emp", objEmpleadoBE.Dni_Emp);
                cmd.Parameters.AddWithValue("@vTel_Emp", objEmpleadoBE.Tel_Emp);
                cmd.Parameters.AddWithValue("@vRol_Emp", objEmpleadoBE.Rol_Emp);
                cmd.Parameters.AddWithValue("@vEstado", objEmpleadoBE.Estado);


                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar empleado: " + ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
        //actualizar
        public Boolean ActualizarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            try
            {
                cnx.ConnectionString = miConexionADO.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarEmpleado";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@vNom_Emp", objEmpleadoBE.Nom_Emp);
                cmd.Parameters.AddWithValue("@vApe_Emp", objEmpleadoBE.Ape_Emp);
                cmd.Parameters.AddWithValue("@vDni_Emp", objEmpleadoBE.Dni_Emp);
                cmd.Parameters.AddWithValue("@vTel_Emp", objEmpleadoBE.Tel_Emp);
                cmd.Parameters.AddWithValue("@vRol_Emp", objEmpleadoBE.Rol_Emp);
                cmd.Parameters.AddWithValue("@vEstado", objEmpleadoBE.Estado);


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
        public Boolean EliminarEmpleado(String strCodigo)
        {


            try
            {
                //Codifique
                cnx.ConnectionString = miConexionADO.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Empleado", strCodigo);
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

