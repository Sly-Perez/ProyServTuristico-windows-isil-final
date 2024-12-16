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
    public class ClienteBL
    {
        ClienteADO objClienteADO = new ClienteADO();

        public DataTable ListarCliente()
        {
            return objClienteADO.listarCliente();
        }

        public ClienteBE ConsultarCliente(Int16 idCli)
        {
            return objClienteADO.ConsultarCliente(idCli);
        }
       
        public Boolean InsertarCliente(ClienteBE objClienteBE)
        {
            return objClienteADO.InsertarCliente(objClienteBE);
        }

     
        public Boolean ActualizarCliente(ClienteBE objClienteBE)
        {
            return objClienteADO.ActualizarCliente(objClienteBE);
        }
        public Boolean EliminarCliente(String strCodigo)
        {
            return objClienteADO.EliminarCliente(strCodigo);
        }



    }
}
