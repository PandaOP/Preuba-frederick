using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class ClsLogicaTipo_Cirugia
    {
        public String AgregarTipo_Cirugia(String Tipo_cirugia)
        {

            String respuesta;
            int i;
            clsDatosTipo_Cirugia addtipo_cirugia = new clsDatosTipo_Cirugia();
            i = addtipo_cirugia.AgregarTipo_Cirugia(Tipo_cirugia);
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
        public DataTable ListarTipo_Cirugia(String x)
        {
            String sql = "SELECT * FROM tipo_cirugias WHERE tipo_cirugias.descripcion LIKE  '%" + x + "%'";
            Datos.clsDatosTipo_Cirugia lista = new Datos.clsDatosTipo_Cirugia();
            DataTable DT = new DataTable();
            DT = lista.ListarTipos_Cirugia (sql);

            return DT;
        }
    }
}
