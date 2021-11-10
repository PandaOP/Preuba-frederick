using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
namespace Logica
{
   public class clsLogicaTipo_Animal
    {
        public String AgregarTipo_Animal(String Tipo_Animal)
        {

            String respuesta;
            int i;
            clsDatosTipo_Animales addtipo_animal = new clsDatosTipo_Animales();
            i = addtipo_animal.AgregarTipo_Amimales(Tipo_Animal);
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

        public String AgregarRaza(int Id_Tipo_Animal, String Descripcion_Raza)
        {

            String respuesta;
            int i;
            clsDatosTipo_Animales addtipo_animal = new clsDatosTipo_Animales();
            i = addtipo_animal.AddRaza(Id_Tipo_Animal, Descripcion_Raza);
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
        public DataTable ListarTipo_Animal(String x)
        {
            String sql = "SELECT id_raza, tipo_animales.descripcion ,raza.raza_descripcion FROM tipo_animales, raza WHERE raza.id_tipo_Animal = tipo_animales.id_tipo_animal and tipo_animales.descripcion like '%"+x+"%'";
            Datos.clsDatosTipo_Animales lista = new Datos.clsDatosTipo_Animales();
            DataTable DT = new DataTable();
            DT = lista.ListarTipos_animales(sql);

            return DT;
        }
    }
}
