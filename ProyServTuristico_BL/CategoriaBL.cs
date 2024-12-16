using ProyServTuristico_ADO;
using ProyServTuristico_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyServTuristico_ADO;
using ProyServTuristico_BE;
/*************************************************************/
namespace ProyServTuristico_BL
{
    public class CategoriaBL
    {
        CategoriaADO objCategoriaADO = new CategoriaADO();

        public DataTable ListarCategoria()
        {
            return objCategoriaADO.ListarCategoria();
        }

        public CategoriaBE ConsultarCategoria(Int16 idCategoria)
        {
            return objCategoriaADO.ConsultarCategoria(idCategoria);
        }
    }
}
/**************************************************************/