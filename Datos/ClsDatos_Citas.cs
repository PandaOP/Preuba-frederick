using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
  public     class ClsDatos_Citas
    {
         clsDatosConexion conex = new clsDatosConexion();
          public int AgregarCita(String Cedula,  int id_veterinario, String fecha, String hora_inicio, String hora_final,String Descripcion)
        {
            MySqlCommand CM = new MySqlCommand();
            try
            {
                MySqlParameter x;
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "Add_Cita";

                CM.Parameters.AddWithValue("pCedula", Cedula);
                CM.Parameters["pCedula"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pId_veterinario", id_veterinario);
                CM.Parameters["pId_veterinario"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pFecha_cita", fecha);
                CM.Parameters["pFecha_cita"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pHora_inicio", hora_inicio);
                CM.Parameters["pHora_inicio"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pHora_final", hora_final);
                CM.Parameters["pHora_final"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pDecripcion", Descripcion);
                CM.Parameters["pDecripcion"].Direction = ParameterDirection.Input;

              
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

        public DataTable ListarCitas(String sql)
        {
            clsDatosMetodosGlobales Depa = new clsDatosMetodosGlobales();
            DataTable DT = new DataTable();
            DT = Depa.bd_Consulta(sql);



            return DT;
        }

        public int Eliminar_Cita(int id_cita)
        {
            clsDatosMetodosGlobales eliminar = new clsDatosMetodosGlobales();

            String i = "DELETE FROM citas WHERE id_cita = '"+id_cita +"';";
            DataTable tabla = new DataTable();
            tabla = eliminar.bd_Consulta(i);

            return 13;
        }

    }
}
