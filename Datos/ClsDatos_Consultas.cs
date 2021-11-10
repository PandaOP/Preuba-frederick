using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
    public class ClsDatos_Consultas
    {
        clsDatosConexion conex = new clsDatosConexion();

        public int Agregar_Consulta(int idveterinario, int idmascota, String cedulacliente,  int idenfermedades, String estado, String Descripcion_Consulta, String peso, String temperatura, String fecha)
        {
            MySqlCommand CM = new MySqlCommand();
            try
            {
                MySqlParameter x;
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "Add_Consulta";

                CM.Parameters.AddWithValue("pId_veterinario",  idveterinario);
                CM.Parameters["pId_veterinario"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pId_mascota",  idmascota);
                CM.Parameters["pId_mascota"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pCedula_Cliente", cedulacliente);
                CM.Parameters["pCedula_Cliente"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pId_enfermedad", idenfermedades);
                CM.Parameters["pId_enfermedad"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pEstado", estado);
                CM.Parameters["pEstado"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pDescripcion_Consulta", Descripcion_Consulta);
                CM.Parameters["pDescripcion_Consulta"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pPeso", peso);
                CM.Parameters["pPeso"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pTemperatura", temperatura);
                CM.Parameters["pTemperatura"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pFecha_Consulta", fecha);
                CM.Parameters["pFecha_Consulta"].Direction = ParameterDirection.Input;

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

        public int Agregar_consultaMedicamento(int idmedicamento, int idveterinario, int idmascota, String fecha)
        {
            MySqlCommand CM = new MySqlCommand();
            try
            {
                MySqlParameter x;
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "Add_Consulta_Medicamento";

                CM.Parameters.AddWithValue("pId_medicamento", idmedicamento);
                CM.Parameters["pId_medicamento"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pId_veterinario", idveterinario);
                CM.Parameters["pId_veterinario"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pId_mascota", idmascota);
                CM.Parameters["pId_mascota"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pFecha_Consulta", fecha);
                CM.Parameters["pFecha_Consulta"].Direction = ParameterDirection.Input;

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

        public DataTable ListaPaquete(String condicion)
        {
            clsDatosMetodosGlobales dgv = new clsDatosMetodosGlobales();
            String sql = "Select * From dgvmostrarconsulta where nombre_mascota LIKE '%" + condicion + "%'";
            return dgv.bd_Consulta(sql);
        }

    }
}
