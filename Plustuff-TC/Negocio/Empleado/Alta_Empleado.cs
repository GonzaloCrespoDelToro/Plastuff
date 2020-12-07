using C2_Negocio;
using Modelo;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Plustuff_TC.Negocio.Empleado
{
    public partial class Alta_Empleado : Form, IObserverIdioma
    {
        Modelo.Empleado empleado = new Modelo.Empleado();
        C2_Negocio.Empleado _empleado = new C2_Negocio.Empleado();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;

        public Alta_Empleado()
        {
            InitializeComponent();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            empleado.Nombre = txtnombre.Text;
            empleado.Apellido = txtapellido.Text;
            empleado.DNI = txtdni.Text;
            empleado.Direccion = txtdirecc.Text;
            empleado.Fechanac =Convert.ToDateTime(dtFecha.Text);
            empleado.Mail = txtmail.Text;
            empleado.Telefono = txtcontacto.Text;

            if (!empleado.Mail.Contains("@") && !empleado.Mail.Contains(".com"))
            {
                MessageBox.Show(this, "Mail invalido", "Alta de empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_empleado.Vacio(empleado))
            {
                MessageBox.Show(this, "Debe completar todos los campos", "Alta de empleado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _empleado.Alta_Empleado(empleado);

            //Da de alta en bitacora
            bitacora.Accion = "AltaEmpleado";
            bitacora.Descripcion = $"Se dio de alta al empleado {empleado.Nombre} {empleado.Apellido}";
            bitacora.FechaHora = DateTime.Now;
            bitacora.U_id = Sesion.Usuario.id;
            bitacora.Criticidad = 3;
            _Bitacora.Alta(bitacora);

            DialogResult dialogResult = MessageBox.Show(this, "El empleado se registro con exito", "Alta de empleado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Alta_Empleado_Load(object sender, EventArgs e)
        {
            this.Traducir();
            Servicios.ManagerIdioma.Suscribir(this);
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

        public void ActualizarIdioma(Idioma idioma)
        {
            this.Traducir();
        }

        private void Traducir()
        {
            Traductor traductor = new Traductor();
            Modelo.Formulario formulario = new Formulario();
            formulario.Nombre = "AltaEmp";
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

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if  (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
