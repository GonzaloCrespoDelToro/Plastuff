using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plustuff_TC.Negocio
{
    public partial class Nueva_Cotizacion : Form
    {
        public Nueva_Cotizacion()
        {
            InitializeComponent();
        }

        private void btn_archivo_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            this.txtruta.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtgramos.Text) || !string.IsNullOrEmpty(txttiempo.Text))
            {
                var tiempo = Convert.ToInt32(this.txttiempo.Text);
                var gramos = Convert.ToInt32(this.txtgramos.Text);
                int precioKilo = 1200;
                int precioImpresion = 100;

                var asd = ((gramos * precioKilo) / 1000);


                var Total = ((((gramos * precioKilo) / 1000) * 2) + ((tiempo * precioImpresion) / 60));

                this.lblTotal.Text = Total.ToString();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
