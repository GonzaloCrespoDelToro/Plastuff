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

namespace Plustuff_TC.Negocio.Pantallas
{
    public partial class Modificar_Cliente : Form, IObserverIdioma
    {
        public Modelo.Cliente _Cliente;
        C2_Negocio.Clientes _Clientes = new C2_Negocio.Clientes();

        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;

        public Modificar_Cliente(Modelo.Cliente cliente)
        {
            this._Cliente = cliente;
            InitializeComponent();
        }

        private void Modificar_Cliente_Load(object sender, EventArgs e)
        {
            this.txtselectclient.Text = $"{_Cliente.Nombre} {_Cliente.Apellido}";

            this.txtnombre.Text = _Cliente.Nombre;
            this.txtapellido.Text = _Cliente.Apellido;
            this.txtdireccion.Text = _Cliente.Direccion;
            this.dtFecha.Text = _Cliente.Fechanac.ToShortDateString();
            this.txtemail.Text = _Cliente.Mail;
            this.txtcontacto.Text = _Cliente.Telefono;
            this.txtdni.Text = _Cliente.DNI;
            if (!_Cliente.Baja)
            {
                this.cbxbaja.Hide();
                this.lblbaja.Hide();
            }
            this.cbxbaja.Checked = _Cliente.Baja;

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
            formulario.Nombre = "AltaCliente";
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Modelo.Cliente SelectCliente = new Modelo.Cliente();
            SelectCliente = _Cliente;

            _Cliente.Nombre = txtnombre.Text;
            _Cliente.Apellido = txtapellido.Text;
            _Cliente.Direccion = txtdireccion.Text;
            _Cliente.DNI = txtdni.Text;
            _Cliente.Fechanac = Convert.ToDateTime(dtFecha.Text);
            _Cliente.Mail = txtemail.Text;
            _Cliente.Telefono = txtcontacto.Text;
            _Cliente.Baja = this.cbxbaja.Checked;

            if (!_Clientes.Validacion(_Cliente))
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (SelectCliente.DNI != _Cliente.DNI)
            {
                if (_Clientes.Consistencia(_Cliente))
                {
                    MessageBox.Show("Ya existe un Cliente con este DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            _Clientes.Modificar_Cliente(_Cliente);

            //Da de alta en bitacora
            bitacora.Accion = "ModificacionCliente";
            bitacora.Descripcion = $"Se modifico informacion del cliente {txtnombre.Text} {txtapellido.Text}";
            bitacora.FechaHora = DateTime.Now;
            bitacora.U_id = Sesion.Usuario.id;
            bitacora.Criticidad = 3;
            _Bitacora.Alta(bitacora);

            MessageBox.Show("El cliente se modifico con exito", "Modificacion de cliente");
            this.Close();

        }

        private void Modificar_Cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Servicios.ManagerIdioma.Desuscribir(this);
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

        private void txtcontacto_TextChanged(object sender, EventArgs e)
        {

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
