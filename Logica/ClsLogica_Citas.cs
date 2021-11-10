using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
namespace Logica
{
   public class ClsLogica_Citas
    {
    public String AgregarCita(String cedula, int id_veterinario, String fecha, String hora_inicio, String hora_final, String Descripcion)
        {
            String respuesta;
            int i;
            ClsDatos_Citas panda = new ClsDatos_Citas();
            i = panda.AgregarCita(cedula, id_veterinario, fecha, hora_inicio, hora_final, Descripcion);
            if (i == 0)
            {
                respuesta = "A Ocurrido error";
            }
            else if (i == 7)
            {
                respuesta = "valor guardado";
            }
            else if (i == 13)
            {
                respuesta = "los Rango de hora ya estan ocupados";
            }
            else if (i== 12)
            {
                respuesta = "El Rango De Hora Inicio Ya Esta Ocupado";
            } 
            else
            {
                respuesta = "El Rango De Hora Final Ya Esta Ocupado";
            }

            return respuesta;


        }





       /* public DataTable cmbTipoAnimal()
        {
            ClsDatos_Citas x = new ClsDatos_Citas();
            String sql = "select id_tipo_animal, descripcion from  tipo_animales";

            return x.LlenarCMb(sql);
        }

        public DataTable cmbRaza(int Id_Tipo_Animal)
        {
            ClsDatos_Citas x = new ClsDatos_Citas();
            String sql = "SELECT id_raza,raza_descripcion FROM raza WHERE raza.id_tipo_Animal = '" + Id_Tipo_Animal + "'";

            return x.LlenarCMb(sql);
        }*/

        public DataTable cmbVeterinario()
        {
            ClsDatos_Consultas x = new ClsDatos_Consultas();
            String sql = "SELECT id_veterinario, CONCAT_WS(' ',nombre_personas,apellido_personas) AS Vete FROM personas, veterinarios WHERE veterinarios.cedula = personas.cedula;";

            return x.LlenarCMb(sql);
        }

        public DataTable cmbestdocita()
        {
            ClsDatos_Citas x = new ClsDatos_Citas();
            String sql = "select id_estado_cita, Descripcion_estado_cita from  estado_citas";

            return x.LlenarCMb(sql);
        }

        public DataTable Listarcita(String estadocita, String nombre_cliente)
        {
            String sql = "SELECT * FROM dgvcitas WHERE Descripcion_estado_cita = '"+estadocita+"' and clientes like '%"+nombre_cliente+"%'";
            ClsDatos_Citas lista = new ClsDatos_Citas();
            DataTable DT = new DataTable();
            DT = lista.ListarCitas(sql);

            return DT;
        }

        public String EliminarC(int id_Cita)
        {
            ClsDatos_Citas X = new ClsDatos_Citas();

            X.Eliminar_Cita(id_Cita);
            return "Se ha eliminado Correctamente";
        }


    }
}
