using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyServTuristico_ADO;

namespace ProyServTuristico_BL
{
    public class TourBL
    {
        TourADO objTourADO = new TourADO();
        
        public DataTable Listar_Tour_Disponibles()
        {
            return objTourADO.Listar_Tour_Disponibles();
        }
    }
}
