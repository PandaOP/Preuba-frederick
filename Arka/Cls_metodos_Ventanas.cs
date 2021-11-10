using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Arka
{
    class Cls_metodos_Ventanas
    {
        public void persona(int dato)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmEditarMascota);
            if (frm != null)
            {

                frm.BringToFront();

            }
            else
            {
                frm = new FrmEditarMascota(dato);
                
                frm.ShowDialog();
                
            }


        }
        public void EditarM(int id_mascota)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmEdicionMascota);
            if (frm != null)
            {

                frm.BringToFront();

            }
            else
            {
                frm = new FrmEdicionMascota(id_mascota);

                frm.ShowDialog();

            }

            


        }



    }
}
