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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region "variables"

        int diasPlazo = 0;
        int requerimientoN = 0;





        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            string Rpta = "";
            

            prop_requerimiento oAr = new prop_requerimiento();
            oAr.n_req = requerimientoN;
            oAr.descripcion = txt_descripcion.Text.Trim();
            oAr.tipo_requerimiento = cb_requerimiento.Text.Trim();
            oAr.usuario_req = cb_usuario_req.Text.Trim();
            oAr.prioridad = Convert.ToInt32( cb_prioridad.Text);
            oAr.dias_plazo=diasPlazo;


            data_requerimiento Datos = new data_requerimiento();
            Rpta = Datos.Guardar_ar( oAr);

            if (Rpta.Equals("OK"))
            {

                MessageBox.Show("Los datos se han guardado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
