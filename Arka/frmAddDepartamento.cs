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
    public partial class frmAddDepartamento : Form
    {
        public frmAddDepartamento()
        {
            InitializeComponent();
        }
        
        void AgregarDepartamento()
        {
            //llamar al metodo de agregar en logica
            String resp;
            clsLogicaDepartamento addDepartamento = new clsLogicaDepartamento();
            resp = addDepartamento.AgregarDepartamento(txtAgregarDepartamento.Text);
            MessageBox.Show(resp);
        }
        Boolean validartxtDepartamento()
        {
            if (txtAgregarDepartamento.Text != "")
            {
                
                return true;

            }
            else
            {
                return false;
            }

        }
        void loadDepartamento(String x)
        {
            clsLogicaDepartamento load = new clsLogicaDepartamento();
            dgvDepartamentos.DataSource = load.ListarDepartamentos(x);

        }
        private void btnAgregarDepartamento_Click(object sender, EventArgs e)
        {
            if (validartxtDepartamento())
            {
                AgregarDepartamento();
            }
            else
            {
                MessageBox.Show("No supero la validacion");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                dgvDepartamentos.Columns.Clear();
            }
            else
            {
                loadDepartamento(txtBuscar.Text);
            }
        }

        private void txtAgregarDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)  && (!(char.IsSeparator(e.KeyChar))))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!(char.IsSeparator(e.KeyChar))))
            {
                e.Handled = true;
                return;
            }

        }
    }
}
