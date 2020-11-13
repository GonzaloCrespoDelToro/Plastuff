using System;
using System.Windows.Forms;

namespace Plustuff_TC.Negocio.Pantallas
{
    public partial class Nuevo_Cliente : Form
    {
        Modelo.Cliente cliente = new Modelo.Cliente();
        C2_Negocio.Clientes _Clientes = new C2_Negocio.Clientes();
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;

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

            if (!_Clientes.Validacion(cliente))
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            bitacora.Descripcion = $"Se dio de alta al cliente {txtnombre.Text.ToLower()}";
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
    }
}
