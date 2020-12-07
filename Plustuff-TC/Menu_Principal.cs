using C2_Negocio;
using Modelo;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Plustuff_TC
{
    public partial class Menu_Principal : Form, IObserverIdioma
    {

        Usuarios _usuario = new Usuarios();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;
        Modelo.Idioma _idioma = new Idioma();


        public Menu_Principal()
        {
            InitializeComponent();
        }
        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            this.Traducir();
            Servicios.ManagerIdioma.Suscribir(this);
        }

        public void ActualizarIdioma(Idioma idioma)
        {
            this.Traducir();
        }

        private void Traducir()
        {
            var idioma = Servicios.ManagerIdioma.GetInstance();
            Traductor traductor = new Traductor();
            Modelo.Formulario formulario = new Formulario();
            formulario.Nombre = "Menu";
            var traducciones = traductor.ObtenerTraducciones(Sesion.Usuario.Idioma, formulario);
            if (traducciones.Any(t => t.Etiqueta == this.Name))
            {
                this.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.Name).Descripcion;
            }
            foreach (ToolStripMenuItem item in this.menuStrip.Items)
            {
                if (traducciones.Any(t => t.Etiqueta == item.Name))
                {
                    item.Text = traducciones.FirstOrDefault(t => t.Etiqueta == item.Name).Descripcion;
                }

                TraducirControlesInternos(item, traducciones);
            }
        }
        private void TraducirControlesInternos(ToolStripMenuItem item, List<Traduccion> traducciones)
        {

            if (item is ToolStripMenuItem)
            {
                foreach (ToolStripMenuItem subItem in item.DropDownItems)
                {
                    if (traducciones.Any(t => t.Etiqueta == subItem.Name))
                    {
                        subItem.Text = traducciones.FirstOrDefault(t => t.Etiqueta == subItem.Name).Descripcion;
                    }

                    TraducirControlesInternos(subItem, traducciones);
                }
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seguridad.Pantallas.Usuario.Alta_Usuario alta_Usuario = new Seguridad.Pantallas.Usuario.Alta_Usuario();
            alta_Usuario.MdiParent = this;
            alta_Usuario.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negocio.Nueva_Cotizacion nueva_Cotizacion = new Negocio.Nueva_Cotizacion();
            nueva_Cotizacion.MdiParent = this;
            nueva_Cotizacion.Show();
        }

        public void CerrarSesion()
        {
            bitacora.Accion = "Logout";
            bitacora.Descripcion = $"Logout exitoso";
            bitacora.FechaHora = DateTime.Now;
            bitacora.U_id = Sesion.Usuario.id;
            bitacora.Criticidad = 3;
            _Bitacora.Alta(bitacora);

            _usuario.CerrarSesion();
        }

        private void Menu_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.CerrarSesion();

            Application.Exit();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CerrarSesion();

            //LogIn.Login login = new LogIn.Login();
            //login.Show();
            //this.Hide();
            this.Close();
            Application.Restart();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negocio.Empleado.Alta_Empleado alta_Empleado = new Negocio.Empleado.Alta_Empleado();
            alta_Empleado.MdiParent = this;
            alta_Empleado.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negocio.Empleado.Mostrar_Empleados mostrar_Empleados = new Negocio.Empleado.Mostrar_Empleados();
            mostrar_Empleados.MdiParent = this;
            mostrar_Empleados.Menu_Principal = this;
            mostrar_Empleados.Show();
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn.Error_Base error_Base = new LogIn.Error_Base();
            error_Base.MdiParent = this;
            error_Base.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seguridad.Pantallas.Usuario.Cambiar_Contraseña cambiar_Contraseña = new Seguridad.Pantallas.Usuario.Cambiar_Contraseña();
            cambiar_Contraseña.MdiParent = this;
            cambiar_Contraseña.Show();
        }

        private void MostrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seguridad.Pantallas.Usuario.Mostrar_Usuario mostrar_Usuario = new Seguridad.Pantallas.Usuario.Mostrar_Usuario();
            mostrar_Usuario.MdiParent = this;
            mostrar_Usuario.Menu_Principal = this;
            mostrar_Usuario.Show();
        }

        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seguridad.Backup backup = new Seguridad.Backup();
            backup.MdiParent = this;
            backup.Show();
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Negocio.Pantallas.Nuevo_Cliente nuevo_Cliente = new Negocio.Pantallas.Nuevo_Cliente();
            nuevo_Cliente.MdiParent = this;
            nuevo_Cliente.Show();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Negocio.Pantallas.Mostrar_Clientes mostrar_Clientes = new Negocio.Pantallas.Mostrar_Clientes();
            mostrar_Clientes.MdiParent = this;
            mostrar_Clientes.Menu_Principal = this;
            mostrar_Clientes.Show();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Negocio.Pantallas.Nuevo_Filamento nuevo_Filamento = new Negocio.Pantallas.Nuevo_Filamento();
            nuevo_Filamento.MdiParent = this;
            nuevo_Filamento.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negocio.Pantallas.Mostrar_Filamentos mostrar_Filamentos = new Negocio.Pantallas.Mostrar_Filamentos();
            mostrar_Filamentos.MdiParent = this;
            mostrar_Filamentos.Show();
        }

        private void gestionarCotizaionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negocio.Pantallas.Gestionar_Cotizaciones gestionar_Cotizaciones = new Negocio.Pantallas.Gestionar_Cotizaciones();
            gestionar_Cotizaciones.Menu_Principal = this;
            gestionar_Cotizaciones.MdiParent = this;
            gestionar_Cotizaciones.Show();
        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modelo.Idioma idioma = new Idioma();
            idioma.id = 1;
            idioma.idioma = "Español";
            Sesion.Usuario.Idioma = idioma;

            Servicios.ManagerIdioma.CambiarIdioma(idioma);
        }

        private void inglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modelo.Idioma idioma = new Idioma();
            idioma.id = 2;
            idioma.idioma = "Ingles";
            Sesion.Usuario.Idioma = idioma;

            Servicios.ManagerIdioma.CambiarIdioma(idioma);
        }

        private void gestionarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negocio.Pantallas.Gestionar_Pedidos gestionar_Pedidos = new Negocio.Pantallas.Gestionar_Pedidos();
            gestionar_Pedidos.MdiParent = this;
            gestionar_Pedidos.Menu_Principal = this;
            gestionar_Pedidos.Show();
        }

        private void Menu_Principal_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            try
            {
                string Ruta = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + @"\Plaware Help.chm";
                Help.ShowHelp(this, Ruta, "Bienvenido.htm");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void altaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Fam_Pat.Alta_Familia alta_Familia = new Fam_Pat.Alta_Familia();
            alta_Familia.MdiParent = this;
            alta_Familia.Show();
        }

        private void asignarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fam_Pat.Asignar_Pat_Fam asignar_Pat_Fam = new Fam_Pat.Asignar_Pat_Fam();
            asignar_Pat_Fam.MdiParent = this;
            asignar_Pat_Fam.Show();
        }

        private void asignarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fam_Pat.Asignar_Fam_Usu asignar_Fam_Usu = new Fam_Pat.Asignar_Fam_Usu();
            asignar_Fam_Usu.MdiParent = this;
            asignar_Fam_Usu.Show();
        }

        private void asignarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fam_Pat.Asignar_Pat_Usu asignar_Pat_Usu = new Fam_Pat.Asignar_Pat_Usu();
            asignar_Pat_Usu.MdiParent = this;
            asignar_Pat_Usu.Show();
        }

        private void GestionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fam_Pat.Gestionar_Familias gestionar_Familias = new Fam_Pat.Gestionar_Familias();
            gestionar_Familias.MdiParent = this;
            gestionar_Familias.Menu_Principal = this;
            gestionar_Familias.Show();
        }
    }
}
