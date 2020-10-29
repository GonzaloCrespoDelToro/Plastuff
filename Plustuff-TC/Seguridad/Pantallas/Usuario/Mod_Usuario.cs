using C2_Negocio;
using Modelo;
using Servicios;
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
    public partial class Mod_Usuario : Form, IObserverIdioma
    {
        public Modelo.Usuario Usuario = new Modelo.Usuario();
        Usuarios _usuario = new Usuarios();
        Servicios.Encriptacion _Encriptacion = new Servicios.Encriptacion();
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;


        public Mod_Usuario()
        {
            InitializeComponent();
        }

        private void Mod_Usuario_Load(object sender, EventArgs e)
        {
            var idiomas = _usuario.Listar_Idiomas();
            cmbidioma.DataSource = idiomas;
            cmbidioma.DisplayMember = "idioma";
            cmbidioma.ValueMember = "id";

            txtselectusu.Text = Usuario.Nombre;
            txtnombre.Text = Usuario.Nombre;
            cmbidioma.Text = Usuario.Idioma.idioma;

            this.Traducir();
            Servicios.ManagerIdioma.Suscribir(this);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpass.Text != txtreppass.Text)
                {
                    lblerror.Visible = true;
                    lblerror.Text = "Las contraseñas no coinciden";
                    return;
                }

                Modelo.Usuario user = new Modelo.Usuario();
                user.id = Usuario.id;
                user.Nombre = txtnombre.Text.ToLower();
                if (string.IsNullOrEmpty(txtpass.Text))
                {
                    user.Pass = Usuario.Pass;
                }
                else
                {
                    user.Pass = _Encriptacion.Encriptar(txtpass.Text, 1);
                }
                user.Idioma = cmbidioma.SelectedItem as Modelo.Idioma;
                user.Empleado = Usuario.Empleado;

                if (!_usuario.Consistencia_Nombre(user)) //Consistencia de datos
                {
                    MessageBox.Show("Error de consistencia. Intente nuevamente", "Error");
                    return;
                }
                var checkUsu = _usuario.Check_Usu(user);
                if (txtselectusu.Text != txtnombre.Text)
                {
                    if (checkUsu)
                    {
                        MessageBox.Show("Ya existe un usuario con este nombre", "Error");
                        return;
                    }
                }

                var mod = _usuario.Modificar_Usuario(user);
                if (!mod)
                {
                    MessageBox.Show("No se pudo realizar la modificacion del usuario", "Error");
                    return;
                }

                //Da de alta en bitacora
                bitacora.Accion = "ModificacionUsuario";
                bitacora.Descripcion = $"Se modifico la informacion del usuario {txtnombre.Text.ToLower()}";
                bitacora.FechaHora = DateTime.Now;
                bitacora.U_id = Sesion.Usuario.id;
                bitacora.Criticidad = 2;
                _Bitacora.Alta(bitacora);

                MessageBox.Show("Modificacion de usuario exitosa", "Modificacion");
                this.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error al querer modificar el Usuario", "Error");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ActualizarIdioma(Idioma idioma)
        {
            this.Traducir();
        }

        private void Traducir()
        {
            Traductor traductor = new Traductor();
            Modelo.Formulario formulario = new Formulario();
            formulario.Nombre = "ModUsu";
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
    }
}
