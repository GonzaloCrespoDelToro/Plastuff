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
        public Modificar_Familia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "¿Seguro desea eliminar la Familia?", "Eliminar Familia", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

        }
    }
}
