using Modelo;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plustuff_TC.Seguridad.Pantallas.Usuario
{
    public partial class Cambiar_Contraseña : Form, IObserverIdioma
    {
        Servicios.SessionManager _Sesion = Servicios.SessionManager.Getinstance;
        C2_Negocio.Usuarios _Usuarios = new C2_Negocio.Usuarios();
        Modelo.Usuario Usuario = new Modelo.Usuario();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;


        public Cambiar_Contraseña()
        {
            InitializeComponent();
        }

        public void ActualizarIdioma(Idioma idioma)
        {
            this.Traducir();
        }

        private void Traducir()
        {
            Traductor traductor = new Traductor();
            Modelo.Formulario formulario = new Formulario();
            formulario.Nombre = "CambiarPass";
            var traducciones = traductor.ObtenerTraducciones(Sesion.Usuario.Idioma, formulario);
            if (traducciones.Any(t => t.Etiqueta == this.Name))
            {
                this.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.Name).Descripcion;
            }
            foreach (Control item in this.Controls)
            {
                if (traducciones.Any(t => t.Etiqueta == item.Name))
                {
                    item.Text = traducciones.FirstOrDefault(t => t.Etiqueta == item.Name).Descripcion;
                }

                TraducirControlesInternos(item, traducciones);
            }
        }

        private void TraducirControlesInternos(Control item, List<Traduccion> traducciones)
        {
            if (item is GroupBox)
            {
                foreach (Control subItem in item.Controls)
                {
                    if (traducciones.Any(t => t.Etiqueta == subItem.Name))
                    {
                        subItem.Text = traducciones.FirstOrDefault(t => t.Etiqueta == subItem.Name).Descripcion;
                    }

                    TraducirControlesInternos(subItem, traducciones);
                }
            }
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

                var input = txtpass.Text;

                var hasNumber = new Regex(@"[0-9]+");
                var hasUpperChar = new Regex(@"[A-Z]+");
                var hasMinimum8Chars = new Regex(@".{8,}");

                var isValidated = hasNumber.IsMatch(input) && hasUpperChar.IsMatch(input) && hasMinimum8Chars.IsMatch(input);

                if (!isValidated)
                {
                    MessageBox.Show(this, "La contraseña no respeta la pantilla", "Error Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!_Usuarios.Modificar_Pass(Usuario))
                {
                    MessageBox.Show("Se produjo un error al modificar la contraseña", "Error de contraseña");
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
            this.Traducir();
            Servicios.ManagerIdioma.Suscribir(this);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cambiar_Contraseña_FormClosing(object sender, FormClosingEventArgs e)
        {
            Servicios.ManagerIdioma.Desuscribir(this);
        }
    }
}
