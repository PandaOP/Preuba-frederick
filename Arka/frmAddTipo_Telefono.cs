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
    public partial class frmAddTipo_Telefono : Form
    {
        public frmAddTipo_Telefono()
        {
            InitializeComponent();
        }
        void AgregarTipoTelefono()
        {
            //llamar al metodo de agregar en logica
            String resp;
            clsLogicaTipo_Telefono addTipoTelefono = new clsLogicaTipo_Telefono();
            resp = addTipoTelefono.AgregarTipoTelefono(txtAgregarTelefono.Text);
            MessageBox.Show(resp);
        }

        Boolean validartxtTipoTelefono()
        {
            //codigo para validar la entrada de texto 
            if (txtAgregarTelefono.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        void loadTipoTelefono(String x)
        {
            clsLogicaTipo_Telefono load = new clsLogicaTipo_Telefono();
            dgvTiposTelefonos.DataSource = load.ListarTipoTelefono(x);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //boton clic agregar tipo camion
            if (validartxtTipoTelefono())
            {
                AgregarTipoTelefono();
            }
            else
            {
                MessageBox.Show("No supero la validacion");
            }

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text == "")
            {
                dgvTiposTelefonos.Columns.Clear();
            }
            else
            {
                loadTipoTelefono(txtbuscar.Text);
            }
        }

        private void txtAgregarTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)&& (!(char.IsSeparator(e.KeyChar))))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)&& (!(char.IsSeparator(e.KeyChar))))
            {
                e.Handled = true;
                return;
            }
        }

        
    }
}
