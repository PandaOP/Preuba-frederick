using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
namespace Logica
{
    public class ClsLogica_Estadisticos
    {
         public String BD_Actualziar()
        {
            ClsDatos_Estadisticos X = new ClsDatos_Estadisticos();

            X.Verificar();
            return "ok";
        }
    }
}
