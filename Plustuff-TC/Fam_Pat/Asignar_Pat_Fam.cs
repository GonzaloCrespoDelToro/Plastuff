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
    public partial class Asignar_Pat_Fam : Form
    {
        public Asignar_Pat_Fam()
        {
            InitializeComponent();
        }

        private void Asignar_Pat_Fam_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "¿Seguro desea desasignar las patentes deseleccionadas?",
                                  "Desasignar", MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Warning);
        }
    }
}
