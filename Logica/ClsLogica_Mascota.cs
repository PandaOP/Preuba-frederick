using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
    public class ClsLogica_Mascota
    {
        public string agregarMascota(String nombre_mascota, int id_Raza, String fecha, String cedula_propietario, String Sexo)
        {
            String respuesta;
            int i;
            ClsDatos_Mascotas panda = new ClsDatos_Mascotas();
            i = panda.AgregarMascota(nombre_mascota, id_Raza, fecha, cedula_propietario, Sexo);
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

        public DataTable cmbTipoAnimal()
        {
            ClsDatos_Persona x = new ClsDatos_Persona();
            String sql = "select id_tipo_animal, descripcion from  tipo_animales";

            return x.LlenarCMb(sql);
        }

        public DataTable cmbRaza(int Id_Tipo_Animal)
        {
            ClsDatos_Persona x = new ClsDatos_Persona();
            String sql = "SELECT id_raza,raza_descripcion FROM raza WHERE raza.id_tipo_Animal = '" + Id_Tipo_Animal + "'";

            return x.LlenarCMb(sql);
        }

        public String nombrepersona(String sql)
        {
            String respuesta, i;
            ClsDatos_Mascotas panda = new ClsDatos_Mascotas();
            i = panda.nombrepersona(sql);
            if (i == "0")
            {
                respuesta = "A Ocurrido error";
            }
            else
            {
                respuesta = i;

            }
            return respuesta;

        }

        /* public DataTable G_Mascota()
         {
             ClsDatos_Mascotas x = new ClsDatos_Mascotas();
             String sql = "SELECT mascotas.id_tipo_animal, descripcion, COUNT(mascotas.id_tipo_animal) as cantidad FROM mascotas, tipo_animales WHERE mascotas id_tipo_animal=tipo_animales.id_tipo_animal GROUP BY id_tipo_animal ORDER BY count(3)";

             return x.Graficas_mascotas(sql);
         }*/





    }
}
