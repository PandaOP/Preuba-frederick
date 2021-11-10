using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
    public class ClsLogicaEdicionMascota
    {
        public DataTable LlenadoMascota(String x)
        {
            String sql = "SELECT nombre_mascota, tipo_animales.descripcion as Tipo_Animal, raza.raza_descripcion, fecha_nacimiento, CONCAT_WS(' ', nombre_personas, apellido_personas) As nombre, estado_mascota.Descripcion_estado_mascota As estado,sexo from mascotas, tipo_animales, raza, propietarios, personas, estado_mascota WHERE mascotas.id_estado_mascota = estado_mascota.Id_estado_mascota AND mascotas.id_propietario = propietarios.id_propietario and propietarios.cedula = personas.cedula and mascotas.id_raza = raza.id_raza and raza.id_tipo_Animal = tipo_animales.id_tipo_animal and id_mascota = '" + x + "'";
            ClsDatosEdicionMascota lista = new ClsDatosEdicionMascota();
            DataTable DT = new DataTable();
            DT = lista.InformacionMascota(sql);

            return DT;
        }


        public DataTable cmbTipoAnimal()
        {
            ClsDatosEdicionMascota x = new ClsDatosEdicionMascota();
            String sql = "select id_tipo_animal, descripcion from  tipo_animales";

            return x.LlenarCMb(sql);
        }

        public DataTable cmbPropietario()
        {
            ClsDatosEdicionMascota x = new ClsDatosEdicionMascota();
            String sql = "SELECT id_propietario, CONCAT_WS(' ',nombre_personas,apellido_personas) AS Propietario FROM personas, propietarios WHERE propietarios.cedula = personas.cedula;";

            return x.LlenarCMb(sql);
        }
        public DataTable cmbRaza(int Id_Tipo_Animal)
        {
            ClsDatos_Persona x = new ClsDatos_Persona();
            String sql = "SELECT id_raza,raza_descripcion FROM raza WHERE raza.id_tipo_Animal = '" + Id_Tipo_Animal + "'";

            return x.LlenarCMb(sql);
        }

        public DataTable cmbEstado()
        {
            ClsDatos_Persona x = new ClsDatos_Persona();
            String sql = "SELECT * FROM estado_mascota";

            return x.LlenarCMb(sql);
        }


        public string Editar_Mascota(int id_mascota, String nombre_mascota, int Raza, String fecha, int id_propietario, int estado, String Sexo)
        {
            String respuesta;
            int i;
            ClsDatosEdicionMascota panda = new ClsDatosEdicionMascota();
            i = panda.Editar_Mascota(id_mascota, nombre_mascota, Raza, fecha, id_propietario, estado, Sexo);
            if (i == 0)
            {
                respuesta = "A Ocurrido error";
            }
            else if (i == 13)
            {
                respuesta = "Valor editado";
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

        public String EliminarM(int id_Mascota)
        {
            ClsDatosEdicionMascota X = new ClsDatosEdicionMascota();

            X.Eliminar_Mascota(id_Mascota);
            return "Se ha eliminado Correctamente";
        }

    }
}
