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
    public partial class FrmCitas : Form
    {
        public FrmCitas()
        {
            InitializeComponent();
        }

        void cmbllenarpropietario()
        {
            ClsLogica_Persona x = new ClsLogica_Persona();
            cmbPropietarios.DataSource = x.cmbpersonas();
            cmbPropietarios.DisplayMember = "nombre";
            cmbPropietarios.ValueMember = "cedula";
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

            Txt_Nombre_Cliente.AutoCompleteCustomSource = buscar;
            Txt_Nombre_Cliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Txt_Nombre_Cliente.AutoCompleteSource = AutoCompleteSource.CustomSource;





        }

        private void cmbPropietarios_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Nombre_Cliente.Text != "")
            {
                Txt_Cedula.Text = Convert.ToString(cmbPropietarios.SelectedValue);
            }
            else if (cmbPropietarios.Text == "")
            {
                Txt_Cedula.Text = "";
            }
        }

        private void Txt_Nombre_Cliente_TextChanged(object sender, EventArgs e)
        {
            cmbPropietarios.Text = Txt_Nombre_Cliente.Text;
        }

        private void FrmCitas_Load(object sender, EventArgs e)
        {
            buscarPersona();
            cmbllenarpropietario();
            cmbveterinario();
            DTP_Hora_Inicio.Format = DateTimePickerFormat.Time;
            DTP_Hora_Final.Format = DateTimePickerFormat.Time;
       
        }


        
     public void addCita()
        {

            int id_ver = Convert.ToInt32(Cmb_Veterinario.SelectedValue);
            String Fecha_=Fecha.Value.ToString("yyyy/MM/dd");
            String HoraI = DTP_Hora_Inicio.Value.ToString("HH:mm:ss");
            String HoraF = DTP_Hora_Final.Value.ToString("HH:mm:ss");
            ClsLogica_Citas Add = new ClsLogica_Citas();
           String Resp= Add.AgregarCita(Txt_Cedula.Text, id_ver, Fecha_, HoraI, HoraF, Txt_Notas.Text);
            MessageBox.Show(Resp);

        }
 	void cmbveterinario()
        {
            ClsLogica_Citas x = new ClsLogica_Citas();
            Cmb_Veterinario.DataSource = x.cmbVeterinario();
            Cmb_Veterinario.DisplayMember = "Vete";
            Cmb_Veterinario.ValueMember = "id_veterinario";
        }

        private void Btn_Agregar_Cita_Click(object sender, EventArgs e)
        {
            addCita();
            
        }
    }
}
