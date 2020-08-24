using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C2_Negocio;

namespace Plustuff_TC.Seguridad.Pantallas.Usuario
{
    public partial class Alta_Usuario : Form
    {
        public Usuarios usuario;

        public Alta_Usuario()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            var usu = new Usuarios();
            usu.Verificar_Usuario(txtnombreU.Text);
        }
    }
}
