using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using Logica;
namespace Arka
{




    public partial class Principal_Arka : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

            [DllImport("user32.DLL", EntryPoint = "SendMessage")]
            private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        int PoderPandil;
        public String Pcedula;
        public void usuario(string usuario, string cedula)
        {

            PoderPandil = Convert.ToInt32(usuario);
            Pcedula = cedula;
        }
        public Principal_Arka()
        {
          InitializeComponent();
   
        }

        

        //llenado de Panel Opciones
        public void LlenarVisual(object x)
        {
           if (this.Panel_visual.Controls.Count >= 0)
           {

                this.Panel_visual.Controls.Clear();
                Form Fob = x as Form;

                Fob.TopLevel = false;
                Fob.Dock = DockStyle.Fill;
                this.Panel_visual.Controls.Add(Fob);
                this.Panel_visual.Tag = Fob;
                Fob.Show();
            }
        }



        //Boton Cerrar
        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Desea salir", "IMPORTANTE", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                //Application.Exit();
                this.Close();
            }
            
            
        }

        private void Btn_ocultar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Menu
       

    

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            
        }



       public void Btn_Registrar_animal_Click(object sender, EventArgs e)
        {
            
            LlenarVisual(new FrmMascotas(PoderPandil, Pcedula));
            
        }



 

        private void Principal_Arka_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString(PoderPandil));
            // MessageBox.Show(Pcedula);
            timer1.Enabled = true;
            LlenarVisual(new FrmInicio());
            if (PoderPandil == 2)
            {
               
                

            }
            else if (PoderPandil == 1)
            {
               
            }
        }

        private void Bnt_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Btn_Animales_Click(object sender, EventArgs e)
        {
            LlenarVisual(new FrmGestorMascotaPro());
            FrmGestorMascotaPro Pandisimo = new FrmGestorMascotaPro();
            Pandisimo.Poder(Pcedula);
        }

        private void Btn_Inicio_Click(object sender, EventArgs e)
        {
            LlenarVisual(new FrmInicio());
        }

        private void Btn_Citas_Click(object sender, EventArgs e)
        {
            LlenarVisual(new FrmGestor_Citas());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ClsLogica_Estadisticos UP = new ClsLogica_Estadisticos();
            UP.BD_Actualziar();
        }
    }
}
