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
    public partial class frmAddTipo_Cirugia : Form
    {
        public frmAddTipo_Cirugia()
        {
            InitializeComponent();
        }
        void AgregarTipo_Cirugia()
        {
            //llamar al metodo de agregar en logica
            String resp;
            ClsLogicaTipo_Cirugia addTipocirugia = new ClsLogicaTipo_Cirugia();
            resp = addTipocirugia.AgregarTipo_Cirugia(txtAgregarCirugia.Text);
            MessageBox.Show(resp);
        }
        Boolean validartxtCiria()
        {
            if (txtAgregarCirugia.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        void LoadTipo_Cirugia(String x)
        {
            ClsLogicaTipo_Cirugia loadTipo_cirugia = new ClsLogicaTipo_Cirugia();
            dgvTipoCiguia.DataSource = loadTipo_cirugia.ListarTipo_Cirugia(x);
        }
        private void btnAgregarCirugia_Click(object sender, EventArgs e)
        {
            if (validartxtCiria())
            {
                AgregarTipo_Cirugia();
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
                dgvTipoCiguia.Columns.Clear();
            }
            else
            {
                LoadTipo_Cirugia(txtBuscar.Text);
            }
        }

        private void txtAgregarCirugia_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
