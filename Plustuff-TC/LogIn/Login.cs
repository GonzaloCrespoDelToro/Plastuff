using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plustuff_TC.LogIn
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                MessageBox.Show(this, "Tu usuario ha sido bloqueado" + Environment.NewLine + "Por favor contactarse con el Administrador",
                                   "Usuario Bloqueado", MessageBoxButtons.OKCancel,
                                   MessageBoxIcon.Warning,
                                   MessageBoxDefaultButton.Button1, 0,
                                   "mspaint.chm",
                                   "mspaint.chm::/paint_brush.htm");
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
