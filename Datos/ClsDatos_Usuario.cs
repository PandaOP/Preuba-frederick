using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
    public class ClsDatos_Usuario
    {
        clsDatosConexion conex = new clsDatosConexion();
        public int AgregarUsuario(String cedula, String alias, String clave, int id_tipo_usuario)
        {
            MySqlCommand CM = new MySqlCommand();
            try
            {
                MySqlParameter x;
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "Add_Usuario";

                CM.Parameters.AddWithValue("Pcedula", cedula);
                CM.Parameters["Pcedula"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Palias", alias);
                CM.Parameters["Palias"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pclave", clave);
                CM.Parameters["Pclave"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pid_tipo_usuario", id_tipo_usuario);
                CM.Parameters["Pid_tipo_usuario"].Direction = ParameterDirection.Input;

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

        public int LoguearUsuario(String alias, String clave)
        {
            MySqlCommand CM = new MySqlCommand();
            try
            {
                MySqlParameter x;
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "Loguear_usuario";

                CM.Parameters.AddWithValue("Palias", alias);
                CM.Parameters["Palias"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pclave", clave);
                CM.Parameters["Pclave"].Direction = ParameterDirection.Input;

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

        public String CapturarCedula(String alias, String clave)
        {
            MySqlCommand CM = new MySqlCommand();
            try
            {
                MySqlParameter x;
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "capturar_cedula";

                CM.Parameters.AddWithValue("Palias", alias);
                CM.Parameters["Palias"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pclave", clave);
                CM.Parameters["Pclave"].Direction = ParameterDirection.Input;

                x = CM.Parameters.AddWithValue("pMsj", "");
                CM.Parameters["pMsj"].Direction = ParameterDirection.Output;
                CM.ExecuteNonQuery();
                return x.Value.ToString();

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return "error";
            }
            finally { conex.conectar.Close(); }
        }
    }
}
