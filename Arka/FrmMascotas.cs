using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using System.Collections;
using MySql.Data.MySqlClient;
using Datos;
using System.Windows.Forms.DataVisualization.Charting;

namespace Arka
{
    public partial class FrmMascotas : Form
    {
        // public override void Refresh();
        int poder1;
        String cedula1;
        public FrmMascotas(int poder, string cedula)
        {
            InitializeComponent();
            poder1 = poder;
            cedula1 = cedula;
            if (poder == 1)
            {



                TxtCedula.Text = cedula;
                TxtPropietario.Text = tipomascota.nombrepersona(cedula1);
                TxtCedula.ReadOnly = true;
                TxtPropietario.ReadOnly = true;
                Btn_Persona.Visible = false;


            }
            else if (poder == 2)
            {
                Btn_Persona.Visible = false;
            }
            ////grafica();


        }
        ClsLogica_Mascota tipomascota = new ClsLogica_Mascota();

        public void cedulaMascota(string cedula)
        {
            Principal_Arka m = new Principal_Arka();

        }
        void cmbllenarpropietario()
        {
            ClsLogica_Persona x = new ClsLogica_Persona();
            cmbPropietarios.DataSource = x.cmbpersonas();
            cmbPropietarios.DisplayMember = "nombre";
            cmbPropietarios.ValueMember = "cedula";
        }
        void cmbtipomascota()
        {

            cmb_Tipo_Animal.DataSource = tipomascota.cmbTipoAnimal();
            cmb_Tipo_Animal.DisplayMember = "descripcion";
            cmb_Tipo_Animal.ValueMember = "id_tipo_animal";
        }
        void cmbRaza(int x)
        {

            Cmb_Raza.DataSource = tipomascota.cmbRaza(x);
            Cmb_Raza.DisplayMember = "raza_descripcion";
            Cmb_Raza.ValueMember = "id_raza";
        }



        void buscarPersona()
        {
            ClsLogica_Persona txtBuscar = new ClsLogica_Persona();
            DataTable DT = new DataTable();

            DT = txtBuscar.txtPersona();
            AutoCompleteStringCollection buscar = new AutoCompleteStringCollection();
            foreach (DataRow row in DT.Rows)
            {
                buscar.Add(Convert.ToString(row["nombre"]));
            }

            TxtPropietario.AutoCompleteCustomSource = buscar;
            TxtPropietario.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TxtPropietario.AutoCompleteSource = AutoCompleteSource.CustomSource;





        }

        private void Btn_Persona_Click(object sender, EventArgs e)
        {


            Cls_metodos_Ventanas persona = new Cls_metodos_Ventanas();

            persona.persona(poder1);




        }

        private void FrmMascotas_Load(object sender, EventArgs e)
        {

            buscarPersona();
            cmbllenarpropietario();
            cmbtipomascota();



        }

        private void TxtPropietario_TextChanged(object sender, EventArgs e)
        {
            if (poder1 != 1)
            {
                cmbPropietarios.Text = TxtPropietario.Text;

            }
            else
            {

            }


        }

        private void cmbPropietarios_TextChanged(object sender, EventArgs e)
        {
            if (poder1 != 1)
            {
                if (TxtPropietario.Text != "")
                {
                    TxtCedula.Text = Convert.ToString(cmbPropietarios.SelectedValue);
                }
                else if (cmbPropietarios.Text == "")
                {
                    TxtCedula.Text = "";
                }
            }


        }

        void AgregarMascota()
        {
            ClsLogica_Mascota mascota = new ClsLogica_Mascota();
            string resp;
            int idtipoanimal;
            string Nfecha = Fecha.Value.ToString("yyyy/MM/dd");
            int Raza = Convert.ToInt32(Cmb_Raza.SelectedValue);
            String sexo = CMB_Sexo.Text;


            resp = mascota.agregarMascota(Txt_Nombre_mascota.Text, Raza, Nfecha, TxtCedula.Text, sexo);
            MessageBox.Show(resp);
        }

        public Boolean txtValidar()
        {

            if (Txt_Nombre_mascota.Text != "" & TxtCedula.Text != "" & TxtPropietario.Text != "")
            {
                return true;
            }
            else { return false; }

        }


       /* void grafica()
        {

            ArrayList especie = new ArrayList();
            ArrayList cont = new ArrayList();
            clsDatosConexion conex = new clsDatosConexion();
            MySqlCommand CM = new MySqlCommand("Mostrar_mascota", conex.conectar);
            CM.CommandType = CommandType.StoredProcedure;
            conex.conectar.Open();
            MySqlDataReader dr = CM.ExecuteReader();

            while (dr.Read())
            {
                especie.Add(dr.GetString(1));
                cont.Add(dr.GetInt32(2));

            }
            Ch_Mascotas.Series[0].Points.DataBindXY(especie, cont);
            Ch_Mascotas.Update();
            dr.Close();
            dr.Dispose();
            conex.conectar.Close();
        }*/

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {

            if (txtValidar())
            {
                AgregarMascota();
                // grafica();

                

            }
            else
            {
                MessageBox.Show("No se pudo Guardar \n" + "Hay campos vacios");
            }
        }

        private void Txt_Nombre_mascota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }

        }

        private void TxtRaza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!Char.IsSeparator(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }

        }

        private void TxtPropietario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            /// cmbPropietarios.Text = tipomascota.nombrepersona(TxtCedula.Text);
            // MessageBox.Show(tipomascota.nombrepersona(TxtCedula.Text));

        }

        private void TxtPropietario_Leave(object sender, EventArgs e)
        {
            if (poder1 != 1)
            {
                cmbPropietarios.Text = TxtPropietario.Text;

            }
            else
            {

            }
        }

        private void cmb_Tipo_Animal_SelectedValueChanged(object sender, EventArgs e)
        {
            String hola = Convert.ToString(cmb_Tipo_Animal.SelectedValue);
            if (hola == "System.Data.DataRowView")
            {
                //no pasa nada
            }
            else
            {
                int gg = Convert.ToInt32(cmb_Tipo_Animal.SelectedValue);
                cmbRaza(gg);

            }

        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            FrmGestorMascotaPro Regre = Owner as FrmGestorMascotaPro;
            Regre.LlenarVisualM(new FrmGestorMascotaPro());
        }
    }
}

