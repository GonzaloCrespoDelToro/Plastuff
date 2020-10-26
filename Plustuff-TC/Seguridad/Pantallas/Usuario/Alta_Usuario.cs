using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C2_Negocio;

namespace Plustuff_TC.Seguridad.Pantallas.Usuario
{
    public partial class Alta_Usuario : Form
    {
        Usuarios _usuario = new Usuarios();
        Empleado _empleado = new Empleado();
        Modelo.Usuario Usuario = new Modelo.Usuario();


        public Alta_Usuario()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

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
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error al cargar el formulario");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
