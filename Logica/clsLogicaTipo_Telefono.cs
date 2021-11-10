using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
   public class clsLogicaTipo_Telefono
    {
        public String AgregarTipoTelefono(String descripcion_telefono)
        {

            String respuesta;
            int i;
            clsDatosTipo_Telefono addTipoTelefono = new clsDatosTipo_Telefono();
            i = addTipoTelefono.AddTipo_Telefono(descripcion_telefono);
            if (i == 0)
            {
                respuesta = "A Ocurrido error";
            }
            else if (i == 13)
            {
                respuesta = "EL valor ya existe";
            }
            else if (i == 7)
            {
                respuesta = "Valor guardado";
            }
            else
            {
                respuesta = "Error no determinado";
            }

            return respuesta;


        }

         public DataTable ListarTipoTelefono(String x)
        {
            String sql = "SELECT * FROM tipo_telefonos WHERE tipo_telefonos.descripcion like '%" + x + "%'";
            Datos.clsDatosTipo_Telefono lista = new Datos.clsDatosTipo_Telefono();
            DataTable DT = new DataTable();
            DT = lista.ListarTiposTelefono(sql);

            return DT;
        }
    }
}
