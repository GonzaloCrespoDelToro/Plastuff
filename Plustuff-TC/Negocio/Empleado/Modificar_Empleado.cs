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
    public partial class Modificar_Empleado : Form
    {
        public Modelo.Empleado SelectEmpleado = new Modelo.Empleado();
        C2_Negocio.Empleado _empleado = new C2_Negocio.Empleado();
        Bitacora _Bitacora = new C2_Negocio.Bitacora();
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
    }
}
