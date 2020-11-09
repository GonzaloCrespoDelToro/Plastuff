using System;
using System.Windows.Forms;

namespace Plustuff_TC.Negocio.Pantallas
{
    public partial class Nuevo_Cliente : Form
    {
        Modelo.Cliente cliente = new Modelo.Cliente();
        C2_Negocio.Clientes _Clientes = new C2_Negocio.Clientes();

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
        }
    }
}
