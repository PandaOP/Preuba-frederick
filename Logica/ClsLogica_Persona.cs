using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
    public class ClsLogica_Persona
    {
        public String AgregarPersona(String cedula, String nombre, String apellido, String direccion, int numero_telefono, int id_tipo_telefono, int id_municipio)
        {

            String respuesta;
            int i;
            ClsDatos_Persona pepito = new ClsDatos_Persona();
            i = pepito.AgregarPersona(cedula,nombre,apellido,direccion,numero_telefono,id_tipo_telefono,id_tipo_telefono);
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



        public DataTable cmbMunicipios()
        {
            ClsDatos_Persona x = new ClsDatos_Persona();
            String sql = "SELECT  id_municipio, CONCAT_WS(', ', nombre_municipio, nombre_departamento) AS MUDE FROM departamentos, municipios WHERE municipios.id_departamento = departamentos.id_departamento";

            return x.LlenarCMb(sql);
        }

        public DataTable cmbTipo_telefono()
        {
            ClsDatos_Persona x = new ClsDatos_Persona();
            String sql = "SELECT id_tipo_telefono, descripcion FROM tipo_telefonos";

            return x.LlenarCMb(sql);
        }

        public DataTable txtPersona()
        {
            ClsDatos_Persona x = new ClsDatos_Persona();
            String sql = "SELECT cedula, CONCAT_WS(' ',nombre_personas,apellido_personas) AS nombre FROM personas";


            return x.LlenarCMb(sql);
        }

        public DataTable cmbpersonas() 
        {
            ClsDatos_Persona x = new ClsDatos_Persona();
            String sql = "SELECT cedula, CONCAT_WS(' ',nombre_personas,apellido_personas) AS nombre FROM personas";
            return x.LlenarCMb(sql);
        }

        public DataTable cmbtipo_usuario    ()
        {
            ClsDatos_Persona x = new ClsDatos_Persona();
            String sql = "SELECT id_tipo_usuario, descripcion_tipo_usuario FROM tipo_usuarios";

            return x.LlenarCMb(sql);
        }

        public String AgregarCliente(String Cedula)
        {
            int respt;
            ClsDatos_Persona ne = new ClsDatos_Persona();
            respt = ne.InsertarCliente(Cedula);

            return "";
        }

        public String AgregarfVeterinario(String Cedula)
        {
            int respt;
            ClsDatos_Persona ne = new ClsDatos_Persona();
            respt = ne.Insertarveterinario(Cedula);

            return "";
        }

        public int ValidarAlias(String Alias)
        {
            int  i;
            ClsDatos_Persona panda = new ClsDatos_Persona();
            i = panda.VerificarAlias(Alias);
           
            return i;

        }

    }
}
