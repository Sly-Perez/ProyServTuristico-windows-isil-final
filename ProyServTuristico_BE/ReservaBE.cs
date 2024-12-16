using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyServTuristico_BE
{
    public class ReservaBE
    {
        public Int16 Id_Reserva{ get; set; }
        public Int16 Id_Cliente{ get; set; }
        public Int16 Id_Tour { get; set; }
        public DateTime Fec_Res {  get; set; } //fecha reserva
        public String Usu_Reg {  get; set; }
        public DateTime Fec_Reg {  get; set; }
        public String Usu_Ult_Mod {  get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
        public String Estado {  get; set; }

    }
}
