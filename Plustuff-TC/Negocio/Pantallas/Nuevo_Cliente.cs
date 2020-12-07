using Modelo;
using Servicios;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Plustuff_TC.Negocio.Pantallas
{
    public partial class Nuevo_Cliente : Form, IObserverIdioma
    {
        Modelo.Cliente cliente = new Modelo.Cliente();
        C2_Negocio.Clientes _Clientes = new C2_Negocio.Clientes();
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;
        bool PatenteValida = false;

        public Nuevo_Cliente()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            cliente.Nombre = txtnombre.Text;
            cliente.Apellido = txtapellido.Text;
            cliente.DNI = txtdni.Text;
            cliente.Direccion = txtdireccion.Text;
            cliente.Fechanac = Convert.ToDateTime(dtFecha.Text);
            cliente.Mail = txtemail.Text;
            cliente.Telefono = txtcontacto.Text;
            cliente.Baja = false;

            if (!_Clientes.Validacion(cliente))
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_Clientes.ValidarMail(cliente))
            {
                MessageBox.Show("Mail invalido, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Clientes.Consistencia(cliente))
            {
                MessageBox.Show("Ya existe un Cliente con este DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Clientes.Alta_Cliente(cliente);

            //Da de alta en bitacora
            bitacora.Accion = "AltaCliente";
            bitacora.Descripcion = $"Se dio de alta al cliente {txtnombre.Text} {txtapellido.Text}";
            bitacora.FechaHora = DateTime.Now;
            bitacora.U_id = Sesion.Usuario.id;
            bitacora.Criticidad = 3;
            _Bitacora.Alta(bitacora);

            MessageBox.Show("Alta de cliente exitosa", "Alta de cliente");
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

        private void Nuevo_Cliente_Load(object sender, EventArgs e)
        {
            this.Traducir();
            Servicios.ManagerIdioma.Suscribir(this);
            ValidarPermisos();
            if (PatenteValida == false)
            {
                MessageBox.Show("No tiene permiso para ingresar a este formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(this.Close));
                return;
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
                case "ALTA CLIENTE":
                    PatenteValida = true;
                    break;
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

        private void Nuevo_Cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Servicios.ManagerIdioma.Desuscribir(this);
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar))
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

        private void Nuevo_Cliente_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Ruta = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + @"\Plaware Help.chm";
            Help.ShowHelp(this, Ruta, "AltaCliente.htm");
        }
    }
}
