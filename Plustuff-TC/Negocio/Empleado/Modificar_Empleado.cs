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

namespace Plustuff_TC.Negocio.Empleado
{
    public partial class Modificar_Empleado : Form, IObserverIdioma
    {
        public Modelo.Empleado SelectEmpleado = new Modelo.Empleado();
        C2_Negocio.Empleado _empleado = new C2_Negocio.Empleado();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;


        public Modificar_Empleado()
        {
            InitializeComponent();
        }

        private void Modificar_Empleado_Load(object sender, EventArgs e)
        {
            txtnombreselect.Text = SelectEmpleado.Nombre + " " +SelectEmpleado.Apellido;
            txtdniselect.Text = SelectEmpleado.DNI;

            txtnombre.Text = SelectEmpleado.Nombre;
            txtapellido.Text = SelectEmpleado.Apellido;
            txtdni.Text = SelectEmpleado.DNI;
            dtFecha.Text = SelectEmpleado.Fechanac.ToShortDateString();
            txtdirecc.Text = SelectEmpleado.Direccion;
            txtemail.Text = SelectEmpleado.Mail;
            txtcontacto.Text = SelectEmpleado.Telefono;

            this.Traducir();
            Servicios.ManagerIdioma.Suscribir(this);
        }

        public void ActualizarIdioma(Idioma idioma)
        {
            this.Traducir();
        }

        private void Traducir()
        {
            Traductor traductor = new Traductor();
            Modelo.Formulario formulario = new Formulario();
            formulario.Nombre = "ModEmp";
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

        private void Confirmar_Click(object sender, EventArgs e)
        {
            SelectEmpleado.Nombre = txtnombre.Text;
            SelectEmpleado.Apellido = txtapellido.Text;
            SelectEmpleado.DNI = txtdni.Text;
            SelectEmpleado.Direccion = txtdirecc.Text;
            SelectEmpleado.Fechanac = Convert.ToDateTime(dtFecha.Text);
            SelectEmpleado.Mail = txtemail.Text;
            SelectEmpleado.Telefono = txtcontacto.Text;

            if (_empleado.Vacio(SelectEmpleado))
            {
                MessageBox.Show(this, "Debe completar todos los campos", "Alta de empleado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _empleado.Modificar_Empleado(SelectEmpleado);

            //Da de alta en bitacora
            bitacora.Accion = "ModificacionEmpleado";
            bitacora.Descripcion = $"Se modifico la informacion del empleado {SelectEmpleado.Nombre} {SelectEmpleado.Apellido}";
            bitacora.FechaHora = DateTime.Now;
            bitacora.U_id = Sesion.Usuario.id;
            bitacora.Criticidad = 3;
            _Bitacora.Alta(bitacora);

            DialogResult dialogResult = MessageBox.Show(this, "El empleado se modifico con exito", "Modificacion de empleado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Modificar_Empleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            Servicios.ManagerIdioma.Desuscribir(this);
        }

        private void txtcontacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
