using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plustuff_TC.Seguridad.Pantallas.Usuario
{
    public partial class Cambiar_Contraseña : Form
    {
        Servicios.SessionManager _Sesion = Servicios.SessionManager.Getinstance;
        C2_Negocio.Usuarios _Usuarios = new C2_Negocio.Usuarios();
        Modelo.Usuario Usuario = new Modelo.Usuario();

        public Cambiar_Contraseña()
        {
            InitializeComponent();
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            //Falta la verificacion de caracteres
            try
            {
                Usuario = _Sesion.Usuario;

                if (txtpass.Text != txtrepetpass.Text)
                {
                    lblerror.Visible = true;
                    lblerror.Text = "Las contraseñas no coinciden";
                    return;
                }

                Usuario.Pass = txtpass.Text;

                if (!_Usuarios.Modificar_Pass(Usuario))
                {
                    MessageBox.Show("Se profijo un error al modificar la contraseña", "Error de contraseña");
                    return;
                }

                MessageBox.Show("La contraseña se modifico con exito", "Contraseña");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error al modificar la contraseña","Error de contraseña");
            }
        }

        private void Cambiar_Contraseña_Load(object sender, EventArgs e)
        {
           
        }
    }
}
