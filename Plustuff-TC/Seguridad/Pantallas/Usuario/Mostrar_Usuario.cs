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

        public Mostrar_Usuario()
        {
            InitializeComponent();
        }

        private void Mostrar_Usuario_Load(object sender, EventArgs e)
        {
            try
            {
                this.listar();

                this.Traducir();
                Servicios.ManagerIdioma.Suscribir(this);
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error al cargar el formulario", "Error");
                this.Close();
            }
        }

        private void listar()
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
    }
}
