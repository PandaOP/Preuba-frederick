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
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        //Buscar mascota
        void buscarMascota()
        {
            ClsLogica_Consultas txtBuscar = new ClsLogica_Consultas();
            DataTable DT = new DataTable();

            DT = txtBuscar.txtMascota();
            AutoCompleteStringCollection buscar = new AutoCompleteStringCollection();
            foreach (DataRow row in DT.Rows)
            {
                buscar.Add(Convert.ToString(row["nombre"]));
            }

            Txt_Nombre_Animal.AutoCompleteCustomSource = buscar;
            Txt_Nombre_Animal.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Txt_Nombre_Animal.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }

        void buscarCliente()
        {
            ClsLogica_Consultas txtBuscar = new ClsLogica_Consultas();
            DataTable DT = new DataTable();

            DT = txtBuscar.cmbcliente();
            AutoCompleteStringCollection buscar = new AutoCompleteStringCollection();
            foreach (DataRow row in DT.Rows)
            {
                buscar.Add(Convert.ToString(row["cliente"]));
            }

            Txt_Cliente.AutoCompleteCustomSource = buscar;
            Txt_Cliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Txt_Cliente.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }

        //agregar Consulta
        void AgregarConsulta()
        {
            ClsLogica_Consultas consulta = new ClsLogica_Consultas();
            string resp;
            int idEnfermedad= Convert.ToInt32(Cmb_Enfermedades.SelectedValue);
            String cedula = Convert.ToString(cmbCliente.SelectedValue);
            string Nfecha = Fecha_Consulta.Value.ToString("yyyy/MM/dd");
            idEnfermedad = Convert.ToInt32(Cmb_Enfermedades.SelectedValue);
            int id_Veterinario = Convert.ToInt32(Cmb_Veterinario.SelectedValue);
            int id_mascota = Convert.ToInt32(Cmb_mascotas.SelectedValue);
            String estado = Convert.ToString(txtestado.SelectedValue);

            resp = consulta.Agregar_Consulta(id_Veterinario, id_mascota, cedula,idEnfermedad,estado,Txt_descripcion_consulta.Text,TxtPeso.Text,TxtTemperatura.Text, Nfecha);
           MessageBox.Show(resp);
        }
        void cmbefermedades()
        {
            ClsLogica_Consultas x = new ClsLogica_Consultas();
            Cmb_Enfermedades.DataSource = x.cmbEnfermedades();
            Cmb_Enfermedades.DisplayMember = "descripcion";
            Cmb_Enfermedades.ValueMember = "id_enfermedad";
        }

        void cmbveterinario()
        {
            ClsLogica_Consultas x = new ClsLogica_Consultas();
            Cmb_Veterinario.DataSource = x.cmbVeterinario();
            Cmb_Veterinario.DisplayMember = "Vete";
            Cmb_Veterinario.ValueMember = "id_veterinario";
        }
        void cmbllenarcliente()
        {
            ClsLogica_Consultas x = new ClsLogica_Consultas();
            cmbCliente.DataSource = x.cmbcliente();
            cmbCliente.DisplayMember = "cliente";
            cmbCliente.ValueMember = "cedula";

        }

        void cmbmascota()
        {
            ClsLogica_Consultas x = new ClsLogica_Consultas();
            Cmb_mascotas.DataSource = x.txtMascota();
            Cmb_mascotas.DisplayMember = "nombre";
            Cmb_mascotas.ValueMember = "id_mascota";

        }
        


       
        public Boolean verificar()
        {
            if (txtestado.Text != "" & TxtPeso.Text != "" & TxtTemperatura.Text != "" & Txt_descripcion_consulta.Text != "" )
            {
                return true;
            }
            else { return false; }
            
        
        }
        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            cmbllenarcliente();
            cmbveterinario();
            cmbefermedades();
            buscarMascota();
            cmbmascota();
            buscarCliente();
        }

        private void Btn_Agregar_Consulta_Click(object sender, EventArgs e)
        {
            if (verificar())
            {
                AgregarConsulta();
            }
            else 
            {
                MessageBox.Show("hay campos vacias ");
            }
        }

        private void Txt_Nombre_Animal_TextChanged(object sender, EventArgs e)
        {
            Cmb_mascotas.Text = Txt_Nombre_Animal.Text;
        }

        private void Txt_Cliente_TextChanged(object sender, EventArgs e)
        {
            cmbCliente.Text = Txt_Cliente.Text;
        }

        private void TxtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtTemperatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Txt_Nombre_Animal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }

        }

        private void Txt_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }

        }

        private void Txt_descripcion_consulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }

        }
    }
}
