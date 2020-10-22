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
    public partial class Mostrar_Empleados : Form
    {
        Modelo.Empleado empleado = new Modelo.Empleado();
        C2_Negocio.Empleado _empleado = new C2_Negocio.Empleado();
        Menu_Principal Menu_Principal = new Menu_Principal();

        public Mostrar_Empleados()
        {
            InitializeComponent();
        }

        private void Mostrar_Empleados_Load(object sender, EventArgs e)
        {
            var Empleados = _empleado.Listar_Empleados();
            this.GridViewEmpleados.DataSource = Empleados.Where(x => x.ID != 1).ToArray();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtfilter.Text))
            {
                var Empleados = _empleado.Listar_Empleados();
                this.GridViewEmpleados.DataSource = Empleados.Where(x => x.Apellido.ToLower().Contains(txtfilter.Text.ToLower()) ||
                x.Nombre.ToLower().Contains(txtfilter.Text.ToLower()) || x.Direccion.ToLower().Contains(txtfilter.Text.ToLower()) || x.DNI.ToLower().Contains(txtfilter.Text.ToLower())
                || x.Mail.ToLower().Contains(txtfilter.Text.ToLower())).Where(x => x.ID != 1).ToArray();
            }
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            txtfilter.Clear();
            var Empleados = _empleado.Listar_Empleados();
            this.GridViewEmpleados.DataSource = Empleados.Where(x => x.ID != 1).ToArray();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modelo.Empleado SelectEmp = (Modelo.Empleado)GridViewEmpleados.CurrentRow.DataBoundItem;
            Negocio.Empleado.Modificar_Empleado modificar_Empleado = new Modificar_Empleado();
            modificar_Empleado.SelectEmpleado = SelectEmp;
            modificar_Empleado.Show();
            this.Hide();
        }
    }
}
