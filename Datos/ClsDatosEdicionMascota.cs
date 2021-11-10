using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
    public class ClsDatosEdicionMascota
    {
        clsDatosConexion conex = new clsDatosConexion();
        //llenar tablas

        public DataTable LlenarCMb(String sql)
        {

            clsDatosMetodosGlobales cmb = new clsDatosMetodosGlobales();
            return cmb.bd_Consulta(sql);
        }
        public DataTable InformacionMascota(String sql)
        {
            clsDatosMetodosGlobales Depa = new clsDatosMetodosGlobales();
            DataTable DT = new DataTable();
            DT = Depa.bd_Consulta(sql);
            return DT;
        }

        public int Editar_Mascota(int id_mascota, String nombre_mascota, int Raza, String fecha, int id_propietario, int Estado, String Sexo)
        {
            MySqlCommand CM = new MySqlCommand();
            try
            {
                MySqlParameter x;
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "Editar_Mascota";

                CM.Parameters.AddWithValue("pId_mascota", id_mascota);
                CM.Parameters["pId_mascota"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pNombre_Mascota", nombre_mascota);
                CM.Parameters["pNombre_Mascota"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pId_Raza", Raza);
                CM.Parameters["pId_Raza"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pFecha_Nacimiento", fecha);
                CM.Parameters["pFecha_Nacimiento"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pId_Propietario", id_propietario);
                CM.Parameters["pId_Propietario"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pEstado", Estado);
                CM.Parameters["pEstado"].Direction = ParameterDirection.Input;

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

        public int Eliminar_Mascota(int id_mascota)
        {
            clsDatosMetodosGlobales eliminar = new clsDatosMetodosGlobales();

            String i = "DELETE FROM mascotas WHERE id_mascota =" + id_mascota + ";";
            DataTable tabla = new DataTable();
            tabla = eliminar.bd_Consulta(i);

            return 13;
        }
    }
}
