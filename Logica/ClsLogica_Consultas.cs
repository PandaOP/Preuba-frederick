using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
    
   public  class ClsLogica_Consultas
    {
        public String Agregar_Consulta(int idveterinario, int idmascota, String cedulacliente, int idenfermedades, String estado, String Descripcion_Consulta, String peso, String temperatura, String fecha)
        {
            String respuesta;
            int i;
            ClsDatos_Consultas panda = new ClsDatos_Consultas();
            i = panda.Agregar_Consulta(idveterinario, idmascota, cedulacliente, idenfermedades, estado, Descripcion_Consulta, peso, temperatura, fecha);
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

        public DataTable cmbEnfermedades()
        {
            ClsDatos_Consultas x = new ClsDatos_Consultas();
            String sql = "SELECT id_enfermedad, descripcion FROM enfermedades;";

            return x.LlenarCMb(sql);
        }

        public DataTable cmbVeterinario()
        {
            ClsDatos_Consultas x = new ClsDatos_Consultas();
            String sql = "SELECT id_veterinario, CONCAT_WS(' ',nombre_personas,apellido_personas) AS Vete FROM personas, veterinarios WHERE veterinarios.cedula = personas.cedula;";

            return x.LlenarCMb(sql);
        }

        public DataTable cmbcliente()
        {
            ClsDatos_Consultas x = new ClsDatos_Consultas();
            String sql = "select cedula, CONCAT_WS(' ',nombre_personas,apellido_personas) as cliente FROM personas;";

            return x.LlenarCMb(sql);
        }

        public DataTable txtMascota()
        {
            ClsDatos_Persona x = new ClsDatos_Persona();
            String sql = "SELECT id_mascota, CONCAT_WS('-',nombre_mascota,nombre_personas,apellido_personas) AS nombre FROM personas,mascotas,propietarios WHERE mascotas.id_propietario=propietarios.id_propietario AND propietarios.cedula=personas.cedula";


            return x.LlenarCMb(sql);
        }


    }
}
