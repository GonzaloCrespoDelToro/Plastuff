using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plustuff_TC.Fam_Pat
{
    public partial class Modificar_Familia : Form
    {
        public Modelo.Familia familia = new Modelo.Familia();
        public Modificar_Familia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Modificar_Familia_Load(object sender, EventArgs e)
        {
            txtnombreselec.Text = familia.Nombre;
            txtnombre.Text = familia.Nombre;
            txtdescrip.Text = familia.Descripcion;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
