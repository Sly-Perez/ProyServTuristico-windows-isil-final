using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyServTuristico_ADO;
using ProyServTuristico_BE;

namespace ProyServTuristico_BL
{
    public class EmpleadoBL
    {
        EmpleadoADO objEmpleadoADO = new EmpleadoADO();

        public DataTable ListarEmpleado()
        {
            return objEmpleadoADO.listarEmpleado();
        }

        public EmpleadoBE ConsultarEmpleado(Int16 idEmp)
        {
            return objEmpleadoADO.ConsultarEmpleado(idEmp);
        }
       
        public Boolean InsertarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            return objEmpleadoADO.InsertarEmpleado(objEmpleadoBE);
        }

     
        public Boolean ActualizarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            return objEmpleadoADO.ActualizarEmpleado(objEmpleadoBE);
        }
        public Boolean EliminarEmpleado(String strCodigo)
        {
            return objEmpleadoADO.EliminarEmpleado(strCodigo);
        }


        public DataTable listarEmpleadoxRol(String strRol)
        {
            return objEmpleadoADO.listarEmpleadoxRol(strRol);
        }
    }
}
