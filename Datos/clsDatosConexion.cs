using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Datos
{
   public class clsDatosConexion
    {
            //clase de coneccion a la base de datos
            static String host = "127.0.0.1";
            static String usuario = "root";
            static String Clave = "root";
            static String BaseDatos = "arka";

        //crear conexion 
        public MySqlConnection conectar = new MySqlConnection("datasource=" + host + ";username=" + usuario + ";password=" + Clave + ";database=" + BaseDatos);
    }
}
