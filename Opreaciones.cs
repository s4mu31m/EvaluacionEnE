using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Ene
{
    public partial class Opreaciones : Form
    {
        public Opreaciones()
        {
            InitializeComponent();
        }
         #region "Variables"
        int nCodigo_ar = 0;
        int nEstado_guarda = 0;

        #endregion

        #region "Métodos"

        private void Formato_ar()
        {
            dgv_articulos.Columns[0].Width = 80;
            dgv_articulos.Columns[0].HeaderText = "CODIGO";
            dgv_articulos.Columns[1].Width = 250;
            dgv_articulos.Columns[1].HeaderText = "ARTICULO";
            dgv_articulos.Columns[2].Width = 150;
            dgv_articulos.Columns[2].HeaderText = "MARCA";
            dgv_articulos.Columns[3].Width = 80;
            dgv_articulos.Columns[3].HeaderText = "MEDIDA";
            dgv_articulos.Columns[4].Width = 150;
            dgv_articulos.Columns[4].HeaderText = "CATEGORIA";
            dgv_articulos.Columns[5].Width = 150;
            dgv_articulos.Columns[5].HeaderText = "STOCK ACTUAL";
            dgv_articulos.Columns[6].Visible = false;
            dgv_articulos.Columns[7].Visible = false;
        }

        private void Listado_ar(string cTexto)
        {
            Data_requerimientos Datos = new Data_requerimientos();
            dgv_articulos.DataSource = Datos.Listado_ar(cTexto);
            this.Formato_ar();
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Listado_ar("%");
        }
        
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
