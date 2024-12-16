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

    public class ReservaBL
    {
        ReservaADO objReservaADO = new ReservaADO();

        public DataTable ListarReserva()
        {
            return objReservaADO.listarReserva();
        }
        public ReservaBE ConsultarReserva(Int16 idReserva)
        {
            return objReservaADO.consultarReserva(idReserva);
        }
        public Boolean InsertarReservaYGenerarfacturar(ReservaBE objReservaBE, FacturaBE objFacturaBE)
        {
            return objReservaADO.InsertarReservaYGenerarfacturar(objReservaBE, objFacturaBE);
        }
        public Boolean ActualizarReserva(ReservaBE objReservaBE)
        {
            return objReservaADO.ActualizarReserva(objReservaBE);
        }
    }
}
