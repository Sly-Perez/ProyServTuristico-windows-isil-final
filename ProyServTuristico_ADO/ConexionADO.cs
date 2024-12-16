using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyServTuristico_ADO
{
    public class ConexionADO
    {
        public string ObtenerCadenaCnx()
        {
            try
            {
                string strCnx = ConfigurationManager.ConnectionStrings["ServTuristico"]?.ConnectionString;

                if (string.IsNullOrWhiteSpace(strCnx))
                {
                    throw new InvalidOperationException("La cadena de conexión 'ServTuristico' no está configurada o es inválida.");
                }

                return strCnx;
            }
            catch (ConfigurationErrorsException ex)
            {
                // Manejo de errores específicos de configuración
                throw new InvalidOperationException("Error al acceder al archivo de configuración.", ex);
            }
        }
    }
}