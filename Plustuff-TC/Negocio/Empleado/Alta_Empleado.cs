using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plustuff_TC.Negocio.Empleado
{
    public partial class Alta_Empleado : Form
    {
        public Alta_Empleado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "¿Seguro que desea inhabilitar el Empleado?", "Baja de empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
