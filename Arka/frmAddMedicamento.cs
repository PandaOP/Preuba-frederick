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
    public partial class frmAddMedicamento : Form
    {
        public frmAddMedicamento()
        {
            InitializeComponent();
        }

        void AgregarMedicina()
        {
            //llamar al metodo de agregar en logica
            String unidad;
            unidad = txtuUidades.Text + cbbunidadmedida.Text;
            String resp;
            clsLogicaMedicamento addTipoTelefono = new clsLogicaMedicamento();
            resp = addTipoTelefono.AgregarMedicamento(txtNombreMedicamento.Text,unidad,txtDescripcipcionMedicamento.Text);
            MessageBox.Show(resp);
            }


        Boolean validartxtTipoTelefono()
        {
            //agreagar validacion para la combobox
            //codigo para validar la entrada de texto 
            if (txtNombreMedicamento.Text != "" & txtuUidades.Text !="" & txtNombreMedicamento.Text !="")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        void loadMedicamento(String x)
        {
            clsLogicaMedicamento load = new clsLogicaMedicamento();
            dgvMedicamento.DataSource = load.ListarMedicamento(x);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validartxtTipoTelefono())
            {
                AgregarMedicina();
            }
            else
            {
                MessageBox.Show("No supero la validacion");
            }
        }

        private void txtuUidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

            if (txtbuscar.Text == "")
            {
                dgvMedicamento.Columns.Clear();
            }
            else
            {
                loadMedicamento(txtbuscar.Text);
            }
        }

        private void txtNombreMedicamento_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtDescripcipcionMedicamento_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!Char.IsSeparator(e.KeyChar))) 
            {
                e.Handled = true;
                return;
            }

        } 

        private void txtNombreMedicamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)&& (!(char.IsSeparator(e.KeyChar))) )
            {
                e.Handled = true;
                return;
            }
        }

        private void txtDescripcipcionMedicamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)&& (!(char.IsSeparator(e.KeyChar)))) 
            {
                e.Handled = true;
                return;
            }
        }
    }
}
