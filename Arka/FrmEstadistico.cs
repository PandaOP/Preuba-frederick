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
    public partial class FrmEstadistico : Form
    {
        public FrmEstadistico()
        {
            InitializeComponent();
        }

        ArrayList especie = new ArrayList();
        ArrayList cont = new ArrayList();
        void grafica()
        {

            clsDatosConexion conex = new clsDatosConexion();
            MySqlCommand CM = new MySqlCommand("ME", conex.conectar);
            CM.CommandType = CommandType.StoredProcedure;
            conex.conectar.Open();
            MySqlDataReader dr = CM.ExecuteReader();

            while (dr.Read())
            {
                especie.Add(dr.GetString(2));
                cont.Add(dr.GetInt32(4));

            }
            Ch_ET.Series[0].Points.DataBindXY(especie, cont);
            Ch_ET.Update();
            dr.Close();
            conex.conectar.Close();
        }

        private void FrmEstadistico_Load(object sender, EventArgs e)
        {
            grafica();
        }
    }
}
