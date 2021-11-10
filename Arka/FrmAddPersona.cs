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
using System.Data;

namespace Arka
{
    public partial class FrmEditarMascota : Form 
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        void Cmb_Tipo_Usuario()
        {
            ClsLogica_Persona Cmb = new ClsLogica_Persona();
            CmbUsuario.DataSource = Cmb.cmbtipo_usuario();
            CmbUsuario.ValueMember = "id_tipo_usuario";
            CmbUsuario.DisplayMember = "descripcion_tipo_usuario";
        }

        void buscarMUDE()
        {
            ClsLogica_Persona cmbBuscar = new ClsLogica_Persona();
            DataTable DT = new DataTable();

            DT = cmbBuscar.cmbMunicipios();
            cmb_Municipio_Dep.DataSource = cmbBuscar.cmbMunicipios();
            cmb_Municipio_Dep.ValueMember = "id_municipio";
            cmb_Municipio_Dep.DisplayMember = "MUDE";
            AutoCompleteStringCollection buscar = new AutoCompleteStringCollection();
            foreach (DataRow row in DT.Rows)
            {
                buscar.Add(Convert.ToString(row["MUDE"]));
            }

            cmb_Municipio_Dep.AutoCompleteCustomSource = buscar;
            cmb_Municipio_Dep.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_Municipio_Dep.AutoCompleteSource = AutoCompleteSource.CustomSource;



        }
        int valor;
        public void tiporegistro(int dato)
        {
             valor = dato;

            if (valor!=3)
            {
                MessageBox.Show("Usted viene del login");
                CmbUsuario.Visible = false;
                lblTipo_usuario.Visible = false;
            }
        }

        void llenar_Tipo_telefono()
        {
            ClsLogica_Persona b = new ClsLogica_Persona();

            cmb_Tipo_telefono.DataSource = b.cmbTipo_telefono();
            cmb_Tipo_telefono.ValueMember = "id_tipo_telefono";
            cmb_Tipo_telefono.DisplayMember = "descripcion";


        }

        public FrmEditarMascota(int dato)
        {
            valor = dato;
            InitializeComponent();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {

            this.Close();
         
        }

        private void FrmAddPersona_Load(object sender, EventArgs e)
        {
            buscarMUDE();
            llenar_Tipo_telefono();
            Cmb_Tipo_Usuario();
        }

        public int  Agregar_Persona() 
        {
            int I=2;
            ClsLogica_Persona persona = new ClsLogica_Persona();
            if (persona.ValidarAlias(TxtUsuario.Text)!=0)
            {
                MessageBox.Show("El Usuario Ya Existe");
                I = 1;
                return I;
            }
            else
            {
                String resp, name;
                int tipo_Telefono, id_municipio, numero_telefono;
                tipo_Telefono = Convert.ToInt32(cmb_Tipo_telefono.SelectedValue);
                id_municipio = Convert.ToInt32(cmb_Municipio_Dep.SelectedValue);
                numero_telefono = Convert.ToInt32(Txt_Telefono.Text);

                ClsLogica_Usuario usuario = new ClsLogica_Usuario();

                if (valor == 1 || valor == 2)
                {
                    resp = persona.AgregarPersona(Txt_Cedula.Text, Txt_nombre.Text, Txt_Apellido.Text, txt_direccion.Text, numero_telefono, tipo_Telefono, id_municipio);
                       
                    if (resp == "Valor guardado")
                    {
                        name = usuario.AgregarUsuario(Txt_Cedula.Text, TxtUsuario.Text, Txtpass.Text, 1);
                        resp =persona.AgregarCliente(Txt_Cedula.Text);
                        MessageBox.Show(resp);
                        I = 0;
                    }
                    else
                    { 
                        resp = "La cedula ya existe";
                        MessageBox.Show(resp);
                    }

                    



                }
                else if (valor == 3 )
                {
                    int tu = Convert.ToInt32(CmbUsuario.SelectedValue);
                    resp = persona.AgregarPersona(Txt_Cedula.Text, Txt_nombre.Text, Txt_Apellido.Text, txt_direccion.Text, numero_telefono, tipo_Telefono, id_municipio);
                  
                    if (resp == "Valor guardado")
                    {
                        name = usuario.AgregarUsuario(Txt_Cedula.Text, TxtUsuario.Text, Txtpass.Text, tu);
                        resp = persona.AgregarCliente(Txt_Cedula.Text);
                        MessageBox.Show(resp);
                        I = 0;
                    }
                    else
                    {
                        resp = "La cedula ya existe";
                        MessageBox.Show(resp);
                    }

                }

                return I;



            }




        }

        Boolean validartxt()
        {
            

            if (Txt_Cedula.Text != "" & Txt_nombre.Text != "" & Txt_Apellido.Text != "" & txt_direccion.Text != "" & Txt_Telefono.Text != "" & Txtpass.Text == Txtpassrepit.Text)
            {
                return true;
            }
            else 
            {
                return false;
            }
        
        
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            if (validartxt())
            {
                if (Agregar_Persona()==0)
                {
                    this.Close();
                } 
                //MessageBox.Show("Guardado Correctamente");
                
            }
            else
            {
                MessageBox.Show("No se pudo Guardar \n" + "Hay campos vacios \n"+"o las contraseñas no coinciden");
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void Txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!Char.IsSeparator(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }

        }

        private void Txt_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!Char.IsSeparator(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }

        }

        private void Txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            
        }

        private void Txtpassrepit_TextChanged(object sender, EventArgs e)
        {
            if (Txtpassrepit.Text == "")
            {
                lblconfirmacion.Visible = false;
            }
            else if (Txtpassrepit.Text == Txtpass.Text)
            {
                lblconfirmacion.Visible = false;
            }
            else
            {
                lblconfirmacion.Visible = true;
            }
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            ClsLogica_Persona usu = new ClsLogica_Persona();
            
            if (usu.ValidarAlias(TxtUsuario.Text)!=0)
            {
                lblUsuario.Visible = true;
            }
            else
            {
                lblUsuario.Visible = false;
            
            }
        }
    }
}
