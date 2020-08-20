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
    public partial class Asignar_Fam_Usu : Form
    {
        public Asignar_Fam_Usu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "¿Seguro desea desasignar la familia asignada?",
                                  "Desasignar", MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Warning);
        }
    }
}
