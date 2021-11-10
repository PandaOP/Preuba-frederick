using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

 namespace Arka
{
    public partial class Vista : Form
    {
        public Vista()
        {
            InitializeComponent();
        }

        
         private void LlenarVisual(object x)
        {
           if (this.Panel_Ventana.Controls.Count >= 0)
           {
               
                Panel_Ventana.Visible = true;
                this.Panel_Ventana.Controls.Clear();
                Form Fob = x as Form;

                Fob.TopLevel = false;
                Fob.Dock = DockStyle.Fill;
                this.Panel_Ventana.Controls.Add(Fob);
                this.Panel_Ventana.Tag = Fob;
                Fob.Show();
            }
        }
        private void Btn_Agregar_Departamentos_Click(object sender, EventArgs e)
        {
            LlenarVisual(new frmAddDepartamento());
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            LlenarVisual(new frmAddMedicamento());
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            // LlenarVisual(new frmAddTipo_Cirugia());
            LlenarVisual(new FrmGestorMascotaPro());
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            LlenarVisual(new frmAddTipo_Animal());
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            LlenarVisual(new frmAddTipo_Telefono());
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Panel_Ventana.Visible = false;
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            
            this.Panel_Ventana.Visible = false;
        }
    }
}
