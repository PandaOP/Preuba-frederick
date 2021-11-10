using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
    public class clsDatosTipo_Cirugia
    {
        clsDatosConexion conex = new clsDatosConexion();
        public int AgregarTipo_Cirugia(String tipo_cirugia)
        {
            MySqlCommand CM = new MySqlCommand();
            try
            {
                MySqlParameter x;
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AddTipo_Cirugia";

                CM.Parameters.AddWithValue("pTipo_Cirugia", tipo_cirugia);
                CM.Parameters["pTipo_Cirugia"].Direction = ParameterDirection.Input;

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
        public DataTable ListarTipos_Cirugia(String sql)
        {
            clsDatosMetodosGlobales Depa = new clsDatosMetodosGlobales();
            DataTable DT = new DataTable();
            DT = Depa.bd_Consulta(sql);



            return DT;
        }

    }
}
