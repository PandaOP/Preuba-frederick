using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
    class clsDatosMetodosGlobales
    {
        clsDatosConexion conex = new clsDatosConexion();
        //llenar tablas
        public DataTable bd_Consulta(String sql)
        {
            // MessageBox.Show(sql);
            DataTable DT = new DataTable();

            try
            {
                MySqlCommand CM = new MySqlCommand(sql, conex.conectar);
                MySqlDataAdapter DA = new MySqlDataAdapter(CM);
                DA.Fill(DT);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                // MessageBox.Show(e.ToString());

            }
            finally
            {
                conex.conectar.Close();
            }

            return DT;
        }


        
    }
}
