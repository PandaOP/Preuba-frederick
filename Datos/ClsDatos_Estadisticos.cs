using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Datos
{
    public class ClsDatos_Estadisticos
    {

        clsDatosConexion conex = new clsDatosConexion();

        public int Verificar()
        {
            clsDatosMetodosGlobales Actualizar = new clsDatosMetodosGlobales();

            String i = "UPDATE citas SET id_estado_cita=2 WHERE fecha_cita <= CURTIME();";
            DataTable tabla = new DataTable();
            tabla = Actualizar.bd_Consulta(i);

            return 13;
        }
    }
}
