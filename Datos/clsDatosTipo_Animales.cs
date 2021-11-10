using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Datos
{
    public class clsDatosTipo_Animales
    {
        clsDatosConexion conex = new clsDatosConexion();
        public int AgregarTipo_Amimales(String tipo_animal)
        {
            MySqlCommand CM = new MySqlCommand();
            try
            {
                MySqlParameter x;
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AddTipo_Animal";

                CM.Parameters.AddWithValue("pTipo_Animal", tipo_animal);
                CM.Parameters["pTipo_Animal"].Direction = ParameterDirection.Input;

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

        public int AddRaza(int id_tipo_animal, String Descripcion_Raza)
        {
            MySqlCommand CM = new MySqlCommand();
            try
            {
                MySqlParameter x;
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "Add_Raza";

                CM.Parameters.AddWithValue("pid_tipo_animal", id_tipo_animal);
                CM.Parameters["pid_tipo_animal"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pdescripcion_rasa", Descripcion_Raza    );
                CM.Parameters["pdescripcion_rasa"].Direction = ParameterDirection.Input;

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
        public DataTable ListarTipos_animales(String sql)
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
