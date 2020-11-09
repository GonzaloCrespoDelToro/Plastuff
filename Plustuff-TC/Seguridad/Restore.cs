using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plustuff_TC.Seguridad
{
    public partial class Restore : Form
    {
        public Restore()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Bak files (*.bak) | *.bak";
            this.openFileDialog1.ShowDialog();
            this.txtruta.Text = openFileDialog1.FileName;
        }
    }
}
