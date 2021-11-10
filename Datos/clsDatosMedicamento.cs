using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
   public class clsDatosMedicamento
    {
        clsDatosConexion conex = new clsDatosConexion();
        public int AgregarMedicamento(String nombre_medicamento,String unidad_medida, String descripcion_medicamento)
        {
            //recordar agregar txt con formatos para que no ocurra un error 

            MySqlCommand CM = new MySqlCommand();
            try
            {
                MySqlParameter x;
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AddMedicamento";

                CM.Parameters.AddWithValue("pNombre_Medicamento", nombre_medicamento);
                CM.Parameters["pNombre_Medicamento"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pUnidad_Medida", unidad_medida);
                CM.Parameters["pUnidad_Medida"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pDescripcion_medicamento", descripcion_medicamento);
                CM.Parameters["pDescripcion_medicamento"].Direction = ParameterDirection.Input;

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
        public DataTable ListarMedicamentos(String sql)
        {
            clsDatosMetodosGlobales Depa = new clsDatosMetodosGlobales();
            DataTable DT = new DataTable();
            DT = Depa.bd_Consulta(sql);



            return DT;
        }
    }
}
