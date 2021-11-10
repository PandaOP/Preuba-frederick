using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
namespace Arka
{
    public partial class FrmEdicionMascota : Form
    {
        int idM=0;
        ClsLogicaEdicionMascota DTE = new ClsLogicaEdicionMascota();
       
        public FrmEdicionMascota(int id_mascosta)
        {
             idM = id_mascosta;
            //MessageBox.Show(Convert.ToString( id_mascosta));
            InitializeComponent();
            cmbtipomascota();
            cmb_Raza(1);
            cmbpropietarios();
            cmbEstado();

                       
        }

        private void FrmEdicionMascota_Load(object sender, EventArgs e)
        {
            lbl_Id.Text = (Convert.ToString(idM));
            llenarArray();
        }
        //Creacion de datos

        void cmbtipomascota()
        {
            Cmb_tipo_animal.DataSource = DTE.cmbTipoAnimal();
            Cmb_tipo_animal.DisplayMember = "descripcion";
            Cmb_tipo_animal.ValueMember = "id_tipo_animal";
        }
     
        void cmbpropietarios()
        {
            CmbPropietario.DataSource = DTE.cmbPropietario();
            CmbPropietario.DisplayMember = "Propietario";
            CmbPropietario.ValueMember = "id_propietario";
        }
        void cmb_Raza(int x)
        {

            CmbRaza.DataSource = DTE.cmbRaza(x);
            CmbRaza.DisplayMember = "raza_descripcion";
            CmbRaza.ValueMember = "id_raza";
        }

        void cmbEstado()
        {

            CmbEstado_mascota.DataSource = DTE.cmbEstado();
            CmbEstado_mascota.DisplayMember = "Descripcion_estado_mascota";
            CmbEstado_mascota.ValueMember = "Id_estado_mascota";
        }


        void llenarArray()
        {
            ClsLogicaEdicionMascota DTE = new ClsLogicaEdicionMascota();
            Solucion.DataSource = DTE.LlenadoMascota(Convert.ToString(idM));




            Txt_Nombre_Mascota.Text = Convert.ToString(Solucion.Rows[0].Cells[0].Value);

            Cmb_tipo_animal.Text = Convert.ToString(Solucion.Rows[0].Cells[1].Value);
          
            string   x = Convert.ToString(Solucion.Rows[0].Cells[1].Value);
           // MessageBox.Show(x);
            CmbRaza.Text = Convert.ToString(Solucion.Rows[0].Cells[2].Value);
            //TxtEdad.Text = Convert.ToString(Solucion.Rows[0].Cells[3].Value);
            DTP_edad.Text = Convert.ToString(Solucion.Rows[0].Cells[3].Value);
            CmbPropietario.Text = Convert.ToString(Solucion.Rows[0].Cells[4].Value);
            CmbEstado_mascota.Text = Convert.ToString(Solucion.Rows[0].Cells[5].Value);
            CmbSexo.Text = Convert.ToString(Solucion.Rows[0].Cells[6].Value);


        }

        Boolean validartxt()
        {


            if (Txt_Nombre_Mascota.Text != "" & DTP_edad.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }


        }





        void EditarMascota()
        {
            ClsLogicaEdicionMascota mascota = new ClsLogicaEdicionMascota();
            string resp;
            int idtipoanimal, idPropietario, idMascota, idRaza, idestado;
            string Nfecha = DTP_edad.Value.ToString("yyyy/MM/dd");
            String estado = CmbEstado_mascota.Text;
            idtipoanimal = Convert.ToInt32(Cmb_tipo_animal.SelectedValue);
            idPropietario = Convert.ToInt32(CmbPropietario.SelectedValue);
            idRaza = Convert.ToInt32(CmbRaza.SelectedValue);
            idestado = Convert.ToInt32(CmbEstado_mascota.SelectedValue);

            String sexo = CmbSexo.Text;
            idMascota = Convert.ToInt32(lbl_Id.Text);
            //MessageBox.Show(idPropietario.ToString(), estado);
            resp = mascota.Editar_Mascota(idMascota, Txt_Nombre_Mascota.Text, idRaza, Nfecha, idPropietario, idestado, sexo);
            // resp = mascota.Editar_Mascota(idMascota, Txt_Nombre_Mascota.Text ,idtipoanimal,TxtRasa.Text,Nfecha,idPropietario, estado,sexo);
            MessageBox.Show(resp);



        }

        private void CmbTipo_Animal_SelectedValueChanged(object sender, EventArgs e)
        {
            String hola = Convert.ToString(Cmb_tipo_animal.SelectedValue);
            if (hola == "System.Data.DataRowView")
            {
                //no pasa nada
            }
            else
            {
                int gg = Convert.ToInt32(Cmb_tipo_animal.SelectedValue);
                cmb_Raza(gg);

            }
        }

        private void Btn_Editar_Click_1(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Desea Editar Esta Mascota", "IMPORTANTE", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Txt_Nombre_Mascota.ReadOnly = false;
                Cmb_tipo_animal.Enabled = true;
                CmbRaza.Enabled = true;
                DTP_edad.Enabled = true;
                CmbPropietario.Enabled = true;
                CmbEstado_mascota.Enabled = true;
                CmbSexo.Enabled = true;
                btn_guardar.Enabled = true;
                btn_guardar.Visible = true;
                cmbtipomascota();
                cmbpropietarios();
                cmbEstado();


            }

        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Desea Guardar los cambios", "IMPORTANTE", MessageBoxButtons.YesNo);


            if (validartxt())
            {
                if (resultado == DialogResult.Yes)
                {
                    Txt_Nombre_Mascota.ReadOnly = true;
                    Cmb_tipo_animal.Enabled = false;
                    CmbRaza.Enabled = false;
                    DTP_edad.Enabled = false;
                    CmbPropietario.Enabled = false;
                    CmbEstado_mascota.Enabled = false;
                    CmbSexo.Enabled = false;
                    btn_guardar.Visible = false;
                    EditarMascota();
                    

                }

            }
            else
            {
                MessageBox.Show("Hay campos Vacios");
            }
        }

        private void Btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("ESTA SEGURO DE ELIMINAR ESTA MASCOTA", "IMPORTANTE", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                ClsLogicaEdicionMascota fun = new ClsLogicaEdicionMascota();
                String resp = fun.EliminarM(idM);
                MessageBox.Show(resp);
                this.Close();
            }
        }
    }
    }

