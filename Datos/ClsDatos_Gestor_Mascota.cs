using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Datos
{
    public class ClsDatos_Gestor_Mascota
    {
        clsDatosConexion conex = new clsDatosConexion();

        public DataTable ListarMascotas(String sql)
        {
            clsDatosMetodosGlobales Depa = new clsDatosMetodosGlobales();
            DataTable DT = new DataTable();
            DT = Depa.bd_Consulta(sql);



            return DT;
        }
        public DataTable LlenarCMb(String sql)
        {

            clsDatosMetodosGlobales cmb = new clsDatosMetodosGlobales();
            return cmb.bd_Consulta(sql);
        }
    }
}
