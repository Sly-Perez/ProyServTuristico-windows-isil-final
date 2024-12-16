using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyServTuristico_BE
{
    public class AlojamientoBE
    {
         public Int16 ID_Alojamiento {  get; set; }
        public String Nom_Alo {  get; set; }
        public Int16 ID_Ubicacion {  get; set; }
        public String Departamento {  get; set; }
        public String Provincia { get; set; }
        public String Distrito {  get; set; }
        public String Estado { get; set; }
    }
}
