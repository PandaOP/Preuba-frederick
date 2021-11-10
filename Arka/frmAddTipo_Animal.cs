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
    public partial class frmAddTipo_Animal : Form
    {
        public frmAddTipo_Animal()
        {
            InitializeComponent();
            cmbtipomascota();
        }
        clsLogicaTipo_Animal addTipoAnimal = new clsLogicaTipo_Animal();
        private void btnAgregarAnimal_Click(object sender, EventArgs e)
        {
            if (validartxtAnimal())
            {
                AgregarTipo_Animal();
                cmbtipomascota();
            }
            else
            {
                MessageBox.Show("No supero la validacion");
            }
        }
        clsLogicaTipo_Animal tipomascota = new clsLogicaTipo_Animal ();
        void cmbtipomascota()
        {

            cmbTipoanimal.DataSource = tipomascota.cmbTipoAnimal();
            cmbTipoanimal.DisplayMember = "descripcion";
            cmbTipoanimal.ValueMember = "id_tipo_animal";
        }
        void AgregarTipo_Animal()
        {
            //llamar al metodo de agregar en logica
            String resp;
           
            resp = addTipoAnimal.AgregarTipo_Animal(txtAgregarAnimal.Text);
            MessageBox.Show(resp);
        }

        void AgregarRaza()
        {
            String resp;
            int id_tipo_animal = Convert.ToInt32(cmbTipoanimal.SelectedValue); 
            resp = addTipoAnimal.AgregarRaza( id_tipo_animal,Txt_Raza.Text);
            MessageBox.Show(resp);
        }
        Boolean validartxtAnimal()
        {
            if (txtAgregarAnimal.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        Boolean validartxtRaza()
        {
            if (Txt_Raza.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        void loadTipo_Animal(String x)
        {
            clsLogicaTipo_Animal loadTipo_Animal = new clsLogicaTipo_Animal();
            dgvTipoAnimal.DataSource = loadTipo_Animal.ListarTipo_Animal(x);

        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                dgvTipoAnimal.Columns.Clear();
            }
            else
            {
                loadTipo_Animal(txtBuscar.Text);
            }
        }

        private void txtAgregarAnimal_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtAgregarAnimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!(char.IsSeparator(e.KeyChar))))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!(char.IsSeparator(e.KeyChar))))
            {
                e.Handled = true;
                return;
            }
        }

        private void Txt_Raza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!(char.IsSeparator(e.KeyChar))))
            {
                e.Handled = true;
                return;
            }
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            if (validartxtRaza())
            {
                AgregarRaza();
                Txt_Raza.Text = "";
            }
            else
            {
                MessageBox.Show("No supero la validacion");
            }
        }

    }
}
