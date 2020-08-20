using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plustuff_TC.Negocio.Pantallas
{
    public partial class Gestionar_Cotizaciones : Form
    {
        public Gestionar_Cotizaciones()
        {
            InitializeComponent();
        }

        private void Cotizaciones_Enter(object sender, EventArgs e)
        {

        }

        private void Gestionar_Cotizaciones_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }

        private void DNI_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            textBox1.Enabled = false;
        }
    }
}
