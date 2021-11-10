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
    public partial class FrmGestor_Citas : Form
    {
        public FrmGestor_Citas()
        {
            InitializeComponent();
            cmbestadocita();
        }
        public void LlenarVisualCitas(object x)
        {
            if (this.Panel_Citas.Controls.Count >= 0)
            {
                Panel_Citas.Visible = true;
                this.Panel_Citas.Controls.Clear();
                Form Fob = x as Form;

                Fob.TopLevel = false;
                Fob.Dock = DockStyle.Fill;
                this.Panel_Citas.Controls.Add(Fob);
                this.Panel_Citas.Tag = Fob;
                Fob.Show();
            }
        }

        
        private void Btn_Agregar_Cita_Click(object sender, EventArgs e)
        {
            Btn_regresar.Visible = true;
            LlenarVisualCitas(new FrmCitas());
        }

        ClsLogica_Citas citas = new ClsLogica_Citas();
        void cmbestadocita()
        {
            CMB_Tipo_Cita.DataSource = citas.cmbestdocita();
            CMB_Tipo_Cita.DisplayMember = "Descripcion_estado_cita"; 
            CMB_Tipo_Cita.ValueMember = "id_estado_cita";
        }

        void loadCitas(String Tipocita, String cliente)
        {
          
            DGVTablaCita.DataSource = citas.Listarcita(Tipocita, cliente);
            

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            String estadocita = Convert.ToString(CMB_Tipo_Cita.Text);
            loadCitas(estadocita,TxtNombre.Text);
        }

        private void CMB_Tipo_Cita_SelectedValueChanged(object sender, EventArgs e)
        {
            String estadocita = Convert.ToString(CMB_Tipo_Cita.Text);
            loadCitas(estadocita, TxtNombre.Text);
        }
        String valorCelda;
        private void DGVTablaCita_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            valorCelda = DGVTablaCita.Rows[e.RowIndex].Cells[0].Value.ToString();
            
        }

        private void Bnt_Editar_Mascota_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("ESTA SEGURO DE ELIMINAR ESTA CITA", "IMPORTANTE", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                ClsLogica_Citas fun = new ClsLogica_Citas();
                String resp = fun.EliminarC(Convert.ToInt32(valorCelda));
                MessageBox.Show(resp);
                String estadocita = Convert.ToString(CMB_Tipo_Cita.Text);
                loadCitas(estadocita, TxtNombre.Text);

            }
        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            Panel_Citas.Visible = false;
            Btn_regresar.Visible = false;
        }
    }
}
