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
        public string Error_DVV = null;
        public List<string>Error_DVH = null;
        public bool Admin = false;
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        Bitacora _Bitacora = new C2_Negocio.Bitacora();


        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblerror.Visible = false;

            if (!string.IsNullOrEmpty(txtpass.Text) || !string.IsNullOrEmpty(txtusu.Text))
            {
                Modelo.Usuario usuario = new Modelo.Usuario();
                usuario.Nombre = txtusu.Text.ToLower();
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
                        int Verificar = _Usuario.Verificar_Usu_Pass(usuario);

                        if (Verificar != 1)
                        {
                            if(Verificar != 2)
                            {
                                lblerror.Visible = true;
                                lblerror.Text = "La contraseña es incorrecta";
                                return;
                            }

                            MessageBox.Show(this, "Tu usuario ha sido bloqueado" + Environment.NewLine + "Por favor contactarse con el Administrador",
                                                 "Usuario Bloqueado", MessageBoxButtons.OKCancel,
                                                 MessageBoxIcon.Warning,
                                                 MessageBoxDefaultButton.Button1, 0,
                                                 "mspaint.chm",
                                                 "mspaint.chm::/paint_brush.htm");
                            return;
                        }

                       Modelo.Usuario User = _Usuario.GetUserByName(usuario);

                        if (Error_DVH.Count != 0 || !string.IsNullOrEmpty(Error_DVV))
                        {
                            //Verificar si es administrador
                            if (User.Permisos.Any(p => p.Nombre == "ADMIN"))
                            {
                                this.Hide();
                                Error_Base error_Base = new Error_Base();
                                error_Base.Show();
                                return;
                            }
                            else
                            {
                                lblerror.Visible = true;
                                lblerror.Text = "Solo el Administrador puede ingresar";
                                return;
                            }
                        }

                        this.Hide();

                        bitacora.Accion = "Login";
                        bitacora.Descripcion = $"Login exitoso";
                        bitacora.FechaHora = DateTime.Now;
                        bitacora.U_id = User.id;
                        bitacora.Criticidad = 3;
                        _Bitacora.Alta(bitacora);

                        Menu_Principal menu_Principal = new Menu_Principal();
                        menu_Principal.Show();
                    }   
                }
            }
            else
            {
                lblerror.Visible = true;
                lblerror.Text = "Debe completar todos los campos.";
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Error_DVH.Count != 0 || !string.IsNullOrEmpty(Error_DVV))
            {
                lblerror.Text = "Hay error en digitos, solo puede ingresar un administrador.";
                lblerror.Visible = true;
                Admin = true;
            }
        }
    }
}
