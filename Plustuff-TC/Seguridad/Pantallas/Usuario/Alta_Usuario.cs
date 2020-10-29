using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using C2_Negocio;
using Modelo;
using Servicios;

namespace Plustuff_TC.Seguridad.Pantallas.Usuario
{
    public partial class Alta_Usuario : Form, IObserverIdioma
    {
        Usuarios _usuario = new Usuarios();
        C2_Negocio.Empleado _empleado = new C2_Negocio.Empleado();
        Modelo.Usuario Usuario = new Modelo.Usuario();
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;

        public Alta_Usuario()
        {
            InitializeComponent();
        }

        private void Alta_Usuario_Load(object sender, EventArgs e)
        {
            try
            {
                var empleados = _empleado.Listar_Empleados_Usuarios();

                cmbEmpleado.DataSource = empleados;
                cmbEmpleado.DisplayMember = "Nombre";
                cmbEmpleado.ValueMember = "ID";

                var idiomas = _usuario.Listar_Idiomas();
                cmbidioma.DataSource = idiomas;
                cmbidioma.DisplayMember = "idioma";
                cmbidioma.ValueMember = "id";

                this.Traducir();
                Servicios.ManagerIdioma.Suscribir(this);
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error al cargar el formulario");
            }
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtnombreU.Text) || string.IsNullOrEmpty(cmbEmpleado.Text) || string.IsNullOrEmpty(cmbidioma.Text))
                {
                    MessageBox.Show("Complete todos los campos", "Error");
                    return;
                }

                var idiomaselect = cmbidioma.SelectedItem as Modelo.Idioma;
                var selectemp = cmbEmpleado.SelectedItem as Modelo.Empleado;

                Usuario.Nombre = txtnombreU.Text.ToLower();
                Usuario.Idioma = idiomaselect;
                Usuario.Empleado = selectemp;

                if (!_usuario.Consistencia_Nombre(Usuario)) //Consistencia de datos
                {
                    MessageBox.Show("Error de consistencia. Intente nuevamente", "Error");
                    return;
                }

                if (!_usuario.Check_Usu(Usuario))
                {
                    var alta = _usuario.Alta_Usuario(Usuario);
                    if (!alta)
                    {
                        MessageBox.Show("No se pudo realizar el alta del usuario", "Error");
                        return;
                    }

                    //Da de alta en bitacora
                    bitacora.Accion = "AltaUsuario";
                    bitacora.Descripcion = $"Se dio de alta al usuario {txtnombreU.Text.ToLower()}";
                    bitacora.FechaHora = DateTime.Now;
                    bitacora.U_id = Sesion.Usuario.id;
                    bitacora.Criticidad = 3;
                    _Bitacora.Alta(bitacora);

                    MessageBox.Show("Alta de usuario exitosa","Alta de usuario");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ya existe un usuario con este nombre", "Error");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Se Produjo un error inesperado", "Error");
            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
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
            formulario.Nombre = "Altausu";
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

        private void Alta_Usuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Servicios.ManagerIdioma.Desuscribir(this);
        }
    }
}
