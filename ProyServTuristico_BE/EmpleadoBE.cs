using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyServTuristico_BE
{
    public class EmpleadoBE
    {
        public Int16 ID_Empleado {  get; set; }
        public String Nom_Emp { get; set; }
        public String Ape_Emp {  get; set; }
        public String Dni_Emp {  get; set; }
        public String Tel_Emp {  get; set; }
        public String Email_Emp {  get; set; }
        public String Rol_Emp { get; set; }
        public Int16 Supervisot_ID { get; set; }
        public String Usu_Reg {  get; set; }
        public DateTime Fec_Reg {  get; set; }
        public String Usu_Ult_Mod { get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
        public String Estado {  get; set; }
    }
}
