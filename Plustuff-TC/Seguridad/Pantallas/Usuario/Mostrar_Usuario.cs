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
    public partial class Mostrar_Usuario : Form, IObserverIdioma
    {
        C2_Negocio.Usuarios _Usuarios = new C2_Negocio.Usuarios();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;
        public Menu_Principal Menu_Principal;
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        private Encriptacion _encriptacion = new Encriptacion();
        bool PatenteValida = false;


        public Mostrar_Usuario()
        {
            InitializeComponent();
        }

        private void Mostrar_Usuario_Load(object sender, EventArgs e)
        {
            try
            {
                this.listar();

                this.ValidarPermisos();
                if (PatenteValida == false)
                {
                    MessageBox.Show("No tiene permiso para ingresar a este formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.BeginInvoke(new MethodInvoker(this.Close));
                    return;
                }

                this.Traducir();
                Servicios.ManagerIdioma.Suscribir(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al cargar el formulario", "Error");
                this.Close();
            }
        }

        public void ValidarPermisos()
        {
            try
            {
                foreach (var p in Sesion.Usuario.Permisos)
                {
                    if (p is Modelo.Familia)
                    {
                        Modelo.Familia familia = (Modelo.Familia)p;

                        foreach (Modelo.Patente patente in familia.Permisos)
                        {
                            this.ValidarPatente(patente);
                        }
                    }
                    else
                    {
                        Modelo.Patente patente = (Modelo.Patente)p;

                        this.ValidarPatente(patente);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ValidarPatente(Modelo.Patente patente)
        {
            switch (patente.Nombre)
            {
                case "MODIFICAR USUARIO":
                    this.btnModificar.Enabled = true;
                    PatenteValida = true;
                    break;
                case "BAJA USUARIO":
                    this.btnBorrar.Enabled = true;
                    PatenteValida = true;
                    break;
                case "DESBLOQUEAR USUARIO":
                    this.btndesbloquear.Enabled = true;
                    PatenteValida = true;
                    break;
            }
        }

        private void listar()
        {
            try
            {
                txtfilter.Clear();

                var Usuarios = _Usuarios.Listar_Usuarios();
                this.GridViewUsuarios.DataSource = (from u in Usuarios
                                                    select new
                                                    {
                                                        Usuario = u.Nombre,
                                                        Empleado = $"{u.Empleado.Nombre} {u.Empleado.Apellido}",
                                                        Bloqueado = u.bloqueado,
                                                        Idioma = u.Idioma.idioma
                                                    }).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede listar a los usuarios, puede que los datos esten corruptos.", "Error");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modelo.Usuario User = new Modelo.Usuario();
            if (GridViewUsuarios.SelectedCells.Count > 0 && GridViewUsuarios.SelectedCells.Count < 2)
            {
                int selectedrowindex = GridViewUsuarios.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = GridViewUsuarios.Rows[selectedrowindex];
                string Nombre = Convert.ToString(selectedRow.Cells["Usuario"].Value);
                User.Nombre = Nombre;
                User = _Usuarios.TraerUsuByNombre(User);

                Seguridad.Pantallas.Usuario.Mod_Usuario mod_Usuario = new Mod_Usuario();
                mod_Usuario.Usuario = User;
                mod_Usuario.MdiParent = Menu_Principal;
                mod_Usuario.Show();
                this.Close();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var Usuarios = _Usuarios.Listar_Usuarios();
                this.GridViewUsuarios.DataSource = (from u in Usuarios where (u.Nombre.ToLower().Contains(txtfilter.Text.ToLower()) || u.Empleado.Nombre.ToLower().Contains(txtfilter.Text.ToLower()) || u.Empleado.Apellido.ToLower().Contains(txtfilter.Text.ToLower()))
                                                    select new
                                                    {
                                                        Usuario = u.Nombre,
                                                        Empleado = $"{u.Empleado.Nombre} {u.Empleado.Apellido}",
                                                        Bloqueado = u.bloqueado,
                                                        Idioma = u.Idioma.idioma
                                                    }).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error al filtrar","Error");
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
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
            formulario.Nombre = "MostrarUsu";
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

        private void btnclean_Click(object sender, EventArgs e)
        {
            this.listar();
        }

        private void GridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btndesbloquear_Click(object sender, EventArgs e)
        {
            Modelo.Usuario User = new Modelo.Usuario();
            if (GridViewUsuarios.SelectedCells.Count > 0 && GridViewUsuarios.SelectedCells.Count < 2)
            {
                int selectedrowindex = GridViewUsuarios.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = GridViewUsuarios.Rows[selectedrowindex];
                string Nombre = Convert.ToString(selectedRow.Cells["Usuario"].Value);
                User.Nombre = Nombre;
                User = _Usuarios.TraerUsuByNombre(User);
                User.Nombre = _encriptacion.Encriptar(User.Nombre, 2);

                if (User.bloqueado != true)
                {
                    MessageBox.Show("El usuario ya se encuentra Desbloqueado","Usuario");
                    return;
                }
                User.bloqueado = false;
                var mod = _Usuarios.Modificar_Usuario(User);
                if (!mod)
                {
                    MessageBox.Show("No se pudo realizar la modificacion del usuario", "Error");
                    return;
                }
                
                //Da de alta en bitacora
                bitacora.Accion = "DesbloqueoUsuario";
                bitacora.Descripcion = $"Se desbloqueo el usuario {Nombre}";
                bitacora.FechaHora = DateTime.Now;
                bitacora.U_id = Sesion.Usuario.id;
                bitacora.Criticidad = 2;
                _Bitacora.Alta(bitacora);

                MessageBox.Show("Desbloqueo exitoso", "Modificacion");
                this.listar();

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.Usuario User = new Modelo.Usuario();

                if (GridViewUsuarios.SelectedCells.Count > 0 && GridViewUsuarios.SelectedCells.Count < 2)
                {
                    int selectedrowindex = GridViewUsuarios.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = GridViewUsuarios.Rows[selectedrowindex];
                    string Nombre = Convert.ToString(selectedRow.Cells["Usuario"].Value);
                    User.Nombre = Nombre;
                    User = _Usuarios.TraerUsuByNombre(User);

                    if (User.id == Sesion.Usuario.id)
                    {
                        MessageBox.Show("No se puede eliminar el usuario ya que es el mismo que esta logeado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DialogResult result = MessageBox.Show("¿Seguro desea elimiar el uaurio?", "Eliminacion de Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (!_Usuarios.Baja(User))
                        {
                            MessageBox.Show("No se puede eliminar al usuario ya que posee patentes que otros no tienen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        //Da de alta en bitacora
                        bitacora.Accion = "BajaUsuario";
                        bitacora.Descripcion = $"Se dio de baja al usuario {Nombre}";
                        bitacora.FechaHora = DateTime.Now;
                        bitacora.U_id = Sesion.Usuario.id;
                        bitacora.Criticidad = 2;
                        _Bitacora.Alta(bitacora);

                        MessageBox.Show("Baja exitosa", "Baja de usuario");
                        this.listar();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
