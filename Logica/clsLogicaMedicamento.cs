using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
    public class clsLogicaMedicamento
    {
        public String AgregarMedicamento(String nombre_medicamento, String unidad_medida, String descripcion_medicamento)
        {

            String respuesta;
            int i;
            clsDatosMedicamento addDepartamento = new clsDatosMedicamento();
            i = addDepartamento.AgregarMedicamento(nombre_medicamento,unidad_medida,descripcion_medicamento);
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
        public DataTable ListarMedicamento(String x)
        {
            String sql = "SELECT * FROM medicamentos WHERE medicamentos.nombre_medicamento LIKE '%" + x + "%'";
            Datos.clsDatosDepartamento lista = new Datos.clsDatosDepartamento();
            DataTable DT = new DataTable();
            DT = lista.ListarDepartamentos(sql);

            return DT;
        }
    }
}
