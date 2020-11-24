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
    public partial class Modificar_Cotizacion : Form
    {
        public Modelo.Cotizacion cotizacion = new Modelo.Cotizacion();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;
        Modelo.TipoFilamento _TipoFilamento = new Modelo.TipoFilamento();
        Modelo.Bitacora bitacora = new Modelo.Bitacora();

        C2_Negocio.Cotizaciones _Cotizaciones = new C2_Negocio.Cotizaciones();
        C2_Negocio.Clientes _Clientes = new C2_Negocio.Clientes();
        C2_Negocio.Filamentos _Filamentos = new C2_Negocio.Filamentos();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();


        public Modificar_Cotizacion()
        {
            InitializeComponent();
        }

        private void Modificar_Cotizacion_Load(object sender, EventArgs e)
        {
            cotizacion = _Cotizaciones.TraerCotizacionPorID(cotizacion);
            txtid.Text = cotizacion.ID.ToString();
            txtdetalleselect.Text = cotizacion.Detalle;

            txtdetalle.Text = cotizacion.Detalle;
            lbltotal.Text = cotizacion.PrecioFinal.ToString(); ;
            txtruta.Text = cotizacion.Ruta;
            cotizacion.Empleado = Sesion.Usuario.Empleado;

            var clientes = _Clientes.ListarClientes().Where(c => c.Baja.Equals(false)).ToArray();

            cbxclientes.DataSource = clientes;
            cbxclientes.DisplayMember = "NombreCompleto";
            cbxclientes.ValueMember = "ID";

            var tipoFilamentos = _Filamentos.ListarTipoFilamento();
            cbxfilamento.DataSource = tipoFilamentos;
            cbxfilamento.DisplayMember = "Tipo";
            cbxfilamento.ValueMember = "ID";
        }

        private void pbruta_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtruta.Text = openFileDialog1.FileName;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            txtruta.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
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

                this.lbltotal.Text = cotizacion.PrecioFinal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                cotizacion.Ruta = txtruta.Text;
                cotizacion.Detalle = txtdetalle.Text;

                _Cotizaciones.ModificarCotizacion(cotizacion);

                //Da de alta en bitacora
                bitacora.Accion = "ModificarCotizacion";
                bitacora.Descripcion = $"Se modifico la cotizacion del cliente {cotizacion.Cliente.Nombre} {cotizacion.Cliente.Apellido}";
                bitacora.FechaHora = DateTime.Now;
                bitacora.U_id = Sesion.Usuario.id;
                bitacora.Criticidad = 3;
                _Bitacora.Alta(bitacora);

                MessageBox.Show("La cotizacion de Modifico correctamente", "Modificar Cotizacion");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txttiempo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtgramos_KeyPress(object sender, KeyPressEventArgs e)
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
