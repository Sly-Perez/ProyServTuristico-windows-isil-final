using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************************/
namespace ProyServTuristico_BE
{
    public class CategoriaBE
    {
        public Int16 ID_Categoria {  get; set; }
        public String Des_Cat {  get; set; }
        public Decimal Tar_Por_Noc { get; set; }
        public String Caracteristicas {  get; set; }
        public String Usu_Reg {  get; set; }
        public DateTime Fec_Reg { get; set; }
        public String Usu_Ult_Mod { get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
        public String Estado {  get; set; }
    }
}

/*************************************************************/