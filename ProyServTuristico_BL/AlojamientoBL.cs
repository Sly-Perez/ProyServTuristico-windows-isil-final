using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*usando*/
using System.Data;
using ProyServTuristico_ADO;

namespace ProyServTuristico_BL
{
    public class AlojamientoBL
    {
        AlojamientoADO objAlojamientoADO = new AlojamientoADO();

        public DataTable ListarAlojamiento_IDUbicacion(Int16 idUbicacion)
        {
            return objAlojamientoADO.ListarAlojamiento_IDUbicacion(idUbicacion);
        }
    }
}
