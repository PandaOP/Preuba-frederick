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
namespace Arka
{
    public partial class FrmGestorMascotaPro : Form
    {
        public FrmGestorMascotaPro()
        {
            InitializeComponent();
        }
        
        public String Pandausuario, valorCelda;
        public void Poder( string cedula)
        {


            Pandausuario = cedula;
        }
        public void LlenarVisualM(object x)
        {
            if (this.Panel_Mascota.Controls.Count >= 0)
            {
                Panel_Mascota.Visible = true;
                this.Panel_Mascota.Controls.Clear();
                Form Fob = x as Form;

                Fob.TopLevel = false;
                Fob.Dock = DockStyle.Fill;
                this.Panel_Mascota.Controls.Add(Fob);
                this.Panel_Mascota.Tag = Fob;
                Fob.Show();
            }
        }
        void loadGestormascota(String TipoAnimal, String cedula, String mascota)
        {
            ClsLogica_Gestor_Mascota load = new ClsLogica_Gestor_Mascota();
            DGVTablaMascota.DataSource = load.ListarGertorMascota(TipoAnimal, cedula, mascota);
            DGVTablaMascota.Columns[0].Visible = false;


        }
        void cmbtipomascota()
        {
            ClsLogica_Gestor_Mascota tipomascota = new ClsLogica_Gestor_Mascota();
            CMB_TipoAnimal.DataSource = tipomascota.cmbTipoAnimal();
            CMB_TipoAnimal.DisplayMember = "descripcion";
            CMB_TipoAnimal.ValueMember = "id_tipo_animal";


        }

        private void FrmGestorMascotaPro_Load(object sender, EventArgs e)
        {
           

            cmbtipomascota();
            loadGestormascota("", "", "");
        }

        private void TxtNombre_Mascota_TextChanged(object sender, EventArgs e)
        {
            String a = Convert.ToString(CMB_TipoAnimal.Text);

            loadGestormascota(a, Txtcedula.Text, TxtNombre.Text);
        }

        private void CMB_TipoAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            String a = Convert.ToString(CMB_TipoAnimal.Text);

            loadGestormascota(a, Txtcedula.Text, TxtNombre.Text);
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            String a = Convert.ToString(CMB_TipoAnimal.Text);

            loadGestormascota(a, Txtcedula.Text, TxtNombre.Text);
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            
            Cls_metodos_Ventanas Editar = new Cls_metodos_Ventanas();
            // Editar.EditarM();

            // MessageBox.Show(valorCelda);
        }

        private void DGVTablaMascota_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            valorCelda = DGVTablaMascota.Rows[e.RowIndex].Cells[0].Value.ToString();


            Btn_regresar.Visible = true;
            LlenarVisualM(new FrmEdicionMascota(Convert.ToInt32(valorCelda)));
            // selecciona el valor de la selda al que se le da doble clik
            //string valorCelda = DGVTablaMascota.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

        }

        private void Btn_Agregar_Mascota_Click(object sender, EventArgs e)
        {

            Btn_regresar.Visible = true;
            LlenarVisualM(new FrmMascotas(3, Pandausuario));
        }

        private void Bnt_Editar_Mascota_Click(object sender, EventArgs e)
        {
            if (valorCelda != null)
            {
                Btn_regresar.Visible = true;

                LlenarVisualM(new FrmEdicionMascota(Convert.ToInt32(valorCelda)));
            } else
            {

                MessageBox.Show("SELECCIONE UNA MASCOTA");

            }

           
        }

        private void DGVTablaMascota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            valorCelda = DGVTablaMascota.Rows[e.RowIndex].Cells[0].Value.ToString();
            Lbl_Id_Mascota.Text = valorCelda;
        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            Panel_Mascota.Visible = false;
            Btn_regresar.Visible = false;
            valorCelda = null;
        }

  
    }
}
