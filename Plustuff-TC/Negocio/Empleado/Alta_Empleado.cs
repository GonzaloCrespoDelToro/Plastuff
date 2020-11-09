using C2_Negocio;
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
    public partial class Alta_Empleado : Form
    {
        Modelo.Empleado empleado = new Modelo.Empleado();
        C2_Negocio.Empleado _empleado = new C2_Negocio.Empleado();
        Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;

        public Alta_Empleado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
