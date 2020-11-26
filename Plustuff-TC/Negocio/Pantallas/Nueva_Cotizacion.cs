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

namespace Plustuff_TC.Negocio
{
    public partial class Nueva_Cotizacion : Form, IObserverIdioma
    {
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;

        Modelo.Cotizacion _Cotizacion = new Modelo.Cotizacion();
        Modelo.TipoFilamento _TipoFilamento = new Modelo.TipoFilamento();
        Modelo.Bitacora bitacora = new Modelo.Bitacora();

        C2_Negocio.Clientes _Clientes = new C2_Negocio.Clientes();
        C2_Negocio.Filamentos _Filamentos = new C2_Negocio.Filamentos();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        C2_Negocio.Cotizaciones _Cotizaciones = new C2_Negocio.Cotizaciones();
        bool PatenteValida = false;

        public Nueva_Cotizacion()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.Cotizacion cotizacion = new Modelo.Cotizacion();

                cotizacion.Ruta = txtruta.Text;
                cotizacion.Detalle = txtdetalle.Text;
                cotizacion.Tiempo = string.IsNullOrEmpty(txttiempo.Text) ? 0 : int.Parse(txttiempo.Text);
                cotizacion.Gramos = string.IsNullOrEmpty(txtgramos.Text) ? 0 : double.Parse(txtgramos.Text);
                cotizacion.Empleado = Sesion.Usuario.Empleado;
                

                if (!_Cotizaciones.Validacion(cotizacion))
                {
                    MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _TipoFilamento = cbxfilamento.SelectedItem as Modelo.TipoFilamento;

                cotizacion = _Cotizaciones.CalcularCotizacion(cotizacion, _TipoFilamento);

                this.lblTotal.Text = cotizacion.PrecioFinal.ToString();

                _Cotizacion = cotizacion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            txttiempo.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtruta.Text = openFileDialog1.FileName;
            }
        }

        private void Nueva_Cotizacion_Load(object sender, EventArgs e)
        {
            var clientes = _Clientes.ListarClientes().Where(c => c.Baja.Equals(false)).ToArray();
            cbClientes.DataSource = clientes;
            cbClientes.DisplayMember = "NombreCompleto";
            cbClientes.ValueMember = "ID";

            var tipoFilamentos = _Filamentos.ListarTipoFilamento();
            cbxfilamento.DataSource = tipoFilamentos;
            cbxfilamento.DisplayMember = "Tipo";
            cbxfilamento.ValueMember = "ID";

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
                case "GENERAR COTIZACIÓN":
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
            formulario.Nombre = "NuevaCotizacion";
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

        private void lblTotal_TextChanged(object sender, EventArgs e)
        {
            if (lblTotal.Text != "0")
            {
                btnaceptar.Enabled = true;
                btnguardar.Enabled = true;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                _Cotizacion.Cliente = cbClientes.SelectedItem as Modelo.Cliente;
                _Cotizaciones.Alta(_Cotizacion);

                //Da de alta en bitacora
                bitacora.Accion = "AltaCotizacion";
                bitacora.Descripcion = $"Se guardo la cotizacion del cliente {_Cotizacion.Cliente.Nombre} {_Cotizacion.Cliente.Apellido}";
                bitacora.FechaHora = DateTime.Now;
                bitacora.U_id = Sesion.Usuario.id;
                bitacora.Criticidad = 3;
                _Bitacora.Alta(bitacora);

                MessageBox.Show("Guardado de cotizacion exitosa", "Alta de Cotizacion");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            try
            {
                _Cotizaciones.Alta(_Cotizacion);

                _Cotizaciones.TraerCotizacionPorRuta(_Cotizacion); //Busca el ID de la cotizacion

                _Cotizaciones.AceptarCotizacion(_Cotizacion);

                //Da de alta en bitacora
                bitacora.Accion = "AceptarCotizacion";
                bitacora.Descripcion = $"El cliente {_Cotizacion.Cliente.Nombre} {_Cotizacion.Cliente.Apellido} acepto la cotizacion N° {_Cotizacion.ID}";
                bitacora.FechaHora = DateTime.Now;
                bitacora.U_id = Sesion.Usuario.id;
                bitacora.Criticidad = 3;
                _Bitacora.Alta(bitacora);

                MessageBox.Show("La cotizacion ha sido aceptada", "Cotizacion");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Nueva_Cotizacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Servicios.ManagerIdioma.Desuscribir(this);
        }
    }
}
