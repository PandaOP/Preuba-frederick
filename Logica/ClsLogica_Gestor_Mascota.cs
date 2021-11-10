using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
namespace Logica
{
    public class ClsLogica_Gestor_Mascota
    {
        public DataTable ListarGertorMascota(String tipoanimal, String cedula, String nombremascota)
        {
            String sql = "SELECT * FROM dgvmascota WHERE Tipo_Animal like '%" + tipoanimal + "%' and cedula LIKE '%" + cedula + "%' and nombre_mascota LIKE'%" + nombremascota + "%'";
            Datos.ClsDatos_Gestor_Mascota lista = new Datos.ClsDatos_Gestor_Mascota();
            DataTable DT = new DataTable();
            DT = lista.ListarMascotas(sql);

            return DT;
        }
        public DataTable cmbTipoAnimal()
        {
            ClsDatos_Persona x = new ClsDatos_Persona();
            String sql = "select id_tipo_animal, descripcion from  tipo_animales";

            return x.LlenarCMb(sql);
        }
    }
}
