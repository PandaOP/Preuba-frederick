using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
    public class ClsDatos_Persona
    {
        clsDatosConexion conex = new clsDatosConexion();
        public int AgregarPersona(String cedula, String nombre, String apellido, String direccion, int numero_telefono, int id_tipo_telefono, int id_municipio)
        {
            MySqlCommand CM = new MySqlCommand();
            try
            {
                MySqlParameter x;
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "Add_persona";

                CM.Parameters.AddWithValue("pCedula", cedula);
                CM.Parameters["pCedula"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pNombre", nombre);
                CM.Parameters["pNombre"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pApellido", apellido);
                CM.Parameters["pApellido"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pDireccion", direccion);
                CM.Parameters["pApellido"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pNumero_Telefono", numero_telefono);
                CM.Parameters["pNumero_Telefono"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pid_Tipo_Telefono", id_tipo_telefono);
                CM.Parameters["Pid_Tipo_Telefono"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pId_Municiopio", id_tipo_telefono);
                CM.Parameters["pId_Municiopio"].Direction = ParameterDirection.Input;

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


        public DataTable LlenarCMb(String sql)
        {
            
            clsDatosMetodosGlobales cmb = new clsDatosMetodosGlobales();
            return cmb.bd_Consulta(sql);
        }


        public int InsertarCliente(String cedula)
        {
            String i = "INSERT INTO clientes(cedula) VALUES('"+cedula+"')";

            clsDatosMetodosGlobales guar = new clsDatosMetodosGlobales();
            DataTable dt = new DataTable();
            dt = guar.bd_Consulta(i);

            return 0;
        }

        public int Insertarveterinario(String cedula)
        {
            String i = "INSERT INTO veterinarios(cedula,estado) VALUES ('"+cedula+"','Disponible')";

            clsDatosMetodosGlobales guar = new clsDatosMetodosGlobales();
            DataTable dt = new DataTable();
            dt = guar.bd_Consulta(i);

            return 0;
        }

        public int VerificarAlias(String Alias) 
        {
            String sql = "SELECT COUNT(*) FROM usuarios WHERE usuarios.alias = '"+Alias+"'";
            int Vali=1;
            String aver;
            try
            {
                conex.conectar.Open();
                MySqlCommand CM = new MySqlCommand(sql, conex.conectar);
                MySqlDataReader DR = CM.ExecuteReader();
                if (DR.Read())
                {
                    aver = DR["COUNT(*)"].ToString();
                    Vali = Convert.ToInt32(aver);
                }
                else { aver = "se salio del sentencia sql"; }




                return Vali;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                // MessageBox.Show(e.ToString());
                aver = "0";
                return 0;
            }
            finally
            {
                conex.conectar.Close();
            }

            
        }


    }
}
