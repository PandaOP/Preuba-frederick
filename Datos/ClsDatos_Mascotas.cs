using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Datos
{
    public class ClsDatos_Mascotas
    {
        //kevin puto xd
        clsDatosConexion conex = new clsDatosConexion();
        public int AgregarMascota(String nombre_mascota, int id_raza, String fecha, String cedula_propietario, String Sexo)
        {
            MySqlCommand CM = new MySqlCommand();
            try
            {
                MySqlParameter x;
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "Add_Mascota";


                CM.Parameters.AddWithValue("pNombre_mascota", nombre_mascota);
                CM.Parameters["pNombre_mascota"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pidRaza", id_raza);
                CM.Parameters["pidRaza"].Direction = ParameterDirection.Input;


                CM.Parameters.AddWithValue("pFecha", fecha);
                CM.Parameters["pFecha"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pCedula_propietario", cedula_propietario);
                CM.Parameters["pCedula_propietario"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pSexo", Sexo);
                CM.Parameters["pSexo"].Direction = ParameterDirection.Input;

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

        public String nombrepersona(String sql)
        {
            String sql1 = "SELECT CONCAT_WS(' ', nombre_personas, apellido_personas) as nombre FROM personas WHERE personas.cedula = '" + sql + "'";
            String aver;
            try
            {
                conex.conectar.Open();
                MySqlCommand CM = new MySqlCommand(sql1, conex.conectar);
                MySqlDataReader DR = CM.ExecuteReader();
                if (DR.Read())
                {
                    aver = DR["nombre"].ToString();
                }
                else { aver = "se salio del sentencia sql"; }




                return aver;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                // MessageBox.Show(e.ToString());
                aver = "0";
                return aver;
            }
            finally
            {
                conex.conectar.Close();
            }



        }



    }



}

