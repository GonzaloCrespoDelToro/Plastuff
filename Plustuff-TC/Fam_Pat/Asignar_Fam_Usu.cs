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
        C2_Negocio.Usuarios _Usuarios = new C2_Negocio.Usuarios();
        Modelo.Usuario Usuario;
        public Asignar_Fam_Usu()
        {
            InitializeComponent();
        }

        private void Asignar_Fam_Usu_Load(object sender, EventArgs e)
        {
            cmbusuarios.DataSource = _Usuarios.Listar_Usuarios();
            this.cmbusuarios.DisplayMember = "Nombre";
            this.cmbusuarios.ValueMember = "id";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbusuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Usuario = cmbusuarios.SelectedItem as Modelo.Usuario;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
