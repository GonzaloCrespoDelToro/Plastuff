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

namespace Plustuff_TC
{
    public partial class Menu_Principal : Form
    {

        Usuarios _usuario = new Usuarios();
        Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;


        public Menu_Principal()
        {
            InitializeComponent();
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
            nueva_Cotizacion.Show();
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

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

            LogIn.Login login = new LogIn.Login();
            login.Show();
            this.Hide();
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
            mostrar_Empleados.Show();
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn.Error_Base error_Base = new LogIn.Error_Base();
            error_Base.Show();
        }
    }
}
