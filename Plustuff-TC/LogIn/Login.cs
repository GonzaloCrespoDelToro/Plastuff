using C2_Negocio;
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
        public Usuarios _Usuario = new Usuarios();

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
            lblerror.Visible = false;

            if (!string.IsNullOrEmpty(txtpass.Text) || !string.IsNullOrEmpty(txtusu.Text))
            {
                Modelo.Usuario usuario = new Modelo.Usuario();
                usuario.Nombre = txtusu.Text;
                usuario.Pass = txtpass.Text;
                if (!_Usuario.Consistencia_Nombre(usuario)) //Consistencia de datos
                {
                    lblerror.Visible = true;
                    lblerror.Text = "Error de consistencia. Intente nuevamente";
                }
                else
                {
                    if (!_Usuario.Check_Usu(usuario))
                    {
                        lblerror.Visible = true;
                        lblerror.Text = "El usuario ingresado no existe";
                    }
                    else
                    {
                        if (!_Usuario.Check_Bloq(usuario))
                        {
                            MessageBox.Show(this, "Tu usuario ha sido bloqueado" + Environment.NewLine + "Por favor contactarse con el Administrador",
                                                 "Usuario Bloqueado", MessageBoxButtons.OKCancel,
                                                 MessageBoxIcon.Warning,
                                                 MessageBoxDefaultButton.Button1, 0,
                                                 "mspaint.chm",
                                                 "mspaint.chm::/paint_brush.htm");
                        }
                    }
                }
            }
            else
            {
                lblerror.Visible = true;
                lblerror.Text = "Debe completar todos los campos.";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
