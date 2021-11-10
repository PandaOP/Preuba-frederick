using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
   public class clsDatosDepartamento
    {
        clsDatosConexion conex = new clsDatosConexion();
        public int AgregarDepartamento(String nombre_departamento)
        {
            MySqlCommand CM = new MySqlCommand();
            try
            {
                MySqlParameter x;
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AddDepartamento";

                CM.Parameters.AddWithValue("pNombre_Departamento", nombre_departamento);
                CM.Parameters["pNombre_Departamento"].Direction = ParameterDirection.Input;

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
        public DataTable ListarDepartamentos(String sql)
        {
            clsDatosMetodosGlobales Depa = new clsDatosMetodosGlobales();
            DataTable DT = new DataTable();
            DT = Depa.bd_Consulta(sql);



            return DT;
        }
    }
}
