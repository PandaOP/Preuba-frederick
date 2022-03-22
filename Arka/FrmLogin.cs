using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using Logica;
namespace Arka
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Desea salir", "IMPORTANTE", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Link_Registrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            FrmEditarMascota registro = new FrmEditarMascota(1);
            

            this.Hide();
             registro.tiporegistro(1);


            registro.ShowDialog();
            

            this.Show();
        }
        public Boolean verificar () 
        {
            if (TxtUsuario.Text != "" & TxtContrasena.Text != "")
            {
                return true;
            }
            else 
            {
                return false;
            }
            
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (verificar())
            {
                
                verificar_actualizar_estado();
                
            }
            else
            {
                MessageBox.Show("tiene vacio los campos");
            }
            
        }
        String resp, cedula;
        void Loguear()
        {
           
            ClsLogica_Usuario loguear = new ClsLogica_Usuario();
            resp = loguear.Loguear_Usuario(TxtUsuario.Text, TxtContrasena.Text);
            cedula = loguear.capturarcedula(TxtUsuario.Text, TxtContrasena.Text);
          
            loguear.Cambiar_Estado_usuario(cedula);

            if (resp == "Usuario O Contraseña Incorrecta")
            {
                MessageBox.Show(resp);

            }
            else
            {
                Principal_Arka principal = new Principal_Arka();
                principal.usuario(resp, cedula);
                this.Hide();
                MessageBox.Show("iniciando Sesión", "");
                principal.ShowDialog();

                this.Show();
            }

        }

        void verificar_actualizar_estado()
        {
            ClsLogica_Usuario Very = new ClsLogica_Usuario();
            cedula = Very.capturarcedula(TxtUsuario.Text, TxtContrasena.Text);
           int OK= Very.ValidarEstado(cedula);

            if (OK==1)
            {
                MessageBox.Show("El Usuario ya esta conectado");
            }
            else
            {
                Loguear();
            }
        }


    }
}
