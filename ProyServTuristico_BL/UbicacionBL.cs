using ProyServTuristico_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyServTuristico_BL
{
    public class UbicacionBL
    {
        UbicacionADO objUbicacionADO = new UbicacionADO();

        public DataTable ListarUbicacion_Departamentos()
        {
            return objUbicacionADO.ListarUbicacion_Departamentos();
        }
    }
}
