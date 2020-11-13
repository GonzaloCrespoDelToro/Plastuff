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
    public partial class Mostrar_Clientes : Form
    {
        C2_Negocio.Clientes _Clientes = new C2_Negocio.Clientes();
       
        public Mostrar_Clientes()
        {
            InitializeComponent();
        }

        private void Mostrar_Clientes_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void Listar()
        {
            txtfilter.Clear();
            var clientes = _Clientes.ListarClientes();
            GridViewClientes.DataSource = (from c in clientes
                                           select new
                                           {
                                               Nombre = $"{c.Nombre} {c.Apellido}",
                                               Direccion = c.Direccion,
                                               DNI = c.DNI,
                                               FechaNacimiento = c.Fechanac.ToShortDateString(),
                                               Email = c.Mail,
                                               Contacto = c.Telefono
                                           }).ToList();

        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modelo.Cliente cliente = new Modelo.Cliente();
            if (GridViewClientes.SelectedCells.Count > 0 && GridViewClientes.SelectedCells.Count < 2)
            {
                int selectedrowindex = GridViewClientes.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = GridViewClientes.Rows[selectedrowindex];
                string DNI = Convert.ToString(selectedRow.Cells["DNI"].Value);
                cliente.DNI = DNI;
                cliente = _Clientes.TraerClientePorDNI(cliente);
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
