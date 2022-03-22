using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
   public class ClsLogicaEdicionPersona
    {


        public string Editar_Persona(String Cedula, String nombre_persona, String apellido_persona, String direccicon, int numero_telefono, int id_tipo_telefono, int id_municipio)
        {
            String respuesta;
            int i;
            ClsDatosEdicionPersona panda = new ClsDatosEdicionPersona();
            i = panda.Editar_Persona(Cedula,nombre_persona,apellido_persona,direccicon,numero_telefono,id_tipo_telefono,id_municipio);
            if (i == 0)
            {
                respuesta = "A Ocurrido error";
            }
            else if (i == 13)
            {
                respuesta = "Valor editado";
            }
            else
            {
                respuesta = "Error no determinado";
            }

            return respuesta;


        }

        public string Editar_Usuario(String Cedula, String alias, String clave, int estado_usuario, int id_tipo_usuario)
        {
            String respuesta;
            int i;
            ClsDatosEdicionPersona panda = new ClsDatosEdicionPersona();
            i = panda.Editar_Usuario(Cedula, alias, clave, estado_usuario, id_tipo_usuario);
            if (i == 0)
            {
                respuesta = "A Ocurrido error";
            }
            else if (i == 13)
            {
                respuesta = "Valor editado";
            }
            else
            {
                respuesta = "Error no determinado";
            }

            return respuesta;


        }

    }
}
