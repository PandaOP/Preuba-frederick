using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using System.Data;

namespace Logica
{
   public class clsLogicaDepartamento
    {
        public String AgregarDepartamento(String nombre_departamento)
        {

            String respuesta;
            int i;
            clsDatosDepartamento addDepartamento = new clsDatosDepartamento();
            i = addDepartamento.AgregarDepartamento(nombre_departamento);
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

        public DataTable ListarDepartamentos(String x)
        {
            String sql = "SELECT * FROM departamentos WHERE departamentos.nombre_departamento like '%" + x + "%'";
            Datos.clsDatosDepartamento lista = new Datos.clsDatosDepartamento();
            DataTable DT = new DataTable();
            DT = lista.ListarDepartamentos(sql);

            return DT;
        }
    }
}
