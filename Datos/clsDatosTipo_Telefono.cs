using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
    public class clsDatosTipo_Telefono
    {
        clsDatosConexion conex = new clsDatosConexion();
        public int AddTipo_Telefono(String descripcion_telefono)
        {
            MySqlCommand CM = new MySqlCommand();
            try
            {
                MySqlParameter x;
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AddTipo_Telefono";

                CM.Parameters.AddWithValue("p_descripcion_telefono", descripcion_telefono);
                CM.Parameters["p_descripcion_telefono"].Direction = ParameterDirection.Input;

                x = CM.Parameters.AddWithValue("pMsj", "");
                CM.Parameters["pMsj"].Direction = ParameterDirection.Output;
                CM.ExecuteNonQuery();
                return Convert.ToInt32(x.Value.ToString());
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return 0;

            }
            finally { conex.conectar.Close(); }




        }

        public DataTable ListarTiposTelefono(String sql)
        {
            clsDatosMetodosGlobales tipotelefono = new clsDatosMetodosGlobales();

            DataTable DT = new DataTable();
            DT = tipotelefono.bd_Consulta(sql);
            return DT;
        }
    }
}
