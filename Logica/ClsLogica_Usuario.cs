using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Windows;

namespace Logica
{
    public class ClsLogica_Usuario
    {
        ClsDatos_Usuario pepito = new ClsDatos_Usuario();
        public String AgregarUsuario(String cedula, String alias, String clave, int id_tipo_usuario)
        {

            String respuesta;
            int i;
            
            i = pepito.AgregarUsuario(cedula, alias, clave, id_tipo_usuario);
            if (i == 7)
            {
                respuesta = "Se A guardado correctamente";
            }
            else if (i == 1)
            {
                respuesta = "nombre de usuario ya registrado ";
            }
            else if (i == 2)
            {
                respuesta = "la cedula ya existe";
            }
            else
            {
                respuesta = "Error no determinado";
            }

            return respuesta;


        }

        public String Loguear_Usuario(String alias, String clave)
        {
            String respuesta;
            int i;

            i = pepito.LoguearUsuario(alias, clave);
            if (i == 5)
            {
                respuesta = "Usuario O Contraseña Incorrecta";
            }
            else
            {
                respuesta = Convert.ToString(i); ;
            }

            return respuesta;
        }

        public String capturarcedula(String alias, String clave)
        {
            return pepito.CapturarCedula(alias, clave);


        }

        public String Cambiar_Estado_usuario(String Cedu)
        {
            ClsDatos_Usuario X = new ClsDatos_Usuario();
            
            X.EStado_Usuario(Cedu);
            return "Ok";
        }
        public String Cambiar_Estado_Finalizado(String Cedu)
        {
            ClsDatos_Usuario X = new ClsDatos_Usuario();

            X.EStado_Finalizado(Cedu);
            return "Ok";
        }

        public int ValidarEstado(String Alias)
        {
            int i;
            ClsDatos_Usuario panda = new ClsDatos_Usuario();
            i = panda.VerificarUsuario(Alias);

            return i;

        }
    }

    
}
