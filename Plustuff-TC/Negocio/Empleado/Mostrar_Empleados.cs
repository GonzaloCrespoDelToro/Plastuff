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

        public Mostrar_Empleados()
        {
            InitializeComponent();
        }

        private void Mostrar_Empleados_Load(object sender, EventArgs e)
        {
            var Empleados = _empleado.Listar_Empleados();
            this.GridViewEmpleados.DataSource = Empleados;
        }
    }
}
