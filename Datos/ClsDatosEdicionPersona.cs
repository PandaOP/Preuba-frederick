using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
    public class ClsDatosEdicionPersona
    {
        clsDatosConexion conex = new clsDatosConexion();
        public int Editar_Persona(String Cedula, String nombre_persona, String apellido_persona, String direccicon, int numero_telefono, int id_tipo_telefono, int id_municipio)
        {
            MySqlCommand CM = new MySqlCommand();
            try
            {
                MySqlParameter x;
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "Editar_Persona";

                CM.Parameters.AddWithValue("pCedula", Cedula);
                CM.Parameters["pCedula"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pNombre_Persona", nombre_persona);
                CM.Parameters["pNombre_Persona"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pApellido_persona", apellido_persona);
                CM.Parameters["pApellido_persona"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pDireccion", direccicon);
                CM.Parameters["pDireccion"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pNumero_Telefono", numero_telefono);
                CM.Parameters["pNumero_Telefono"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pId_tipo_telefono", id_tipo_telefono);
                CM.Parameters["pId_tipo_telefono"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pId_Municipio", id_municipio);
                CM.Parameters["pId_Municipio"].Direction = ParameterDirection.Input;


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
            finally
            {
                conex.conectar.Close();
            }


        }


        public int Editar_Usuario(String Cedula, String alias, String clave, int estado_usuario, int id_tipo_usuario)
        {
            MySqlCommand CM = new MySqlCommand();
            try
            {
                MySqlParameter x;
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "Editar_Usuario";

                CM.Parameters.AddWithValue("pCedula", Cedula);
                CM.Parameters["pCedula"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pAlias", alias);
                CM.Parameters["pAlias"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pClave", clave);
                CM.Parameters["pApellido_persona"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pId_estado_usuario", estado_usuario);
                CM.Parameters["pId_estado_usuario"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pId_tipo_usuario", id_tipo_usuario);
                CM.Parameters["pId_tipo_usuario"].Direction = ParameterDirection.Input;

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
            finally
            {
                conex.conectar.Close();
            }










        }
    }
}
