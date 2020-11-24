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

namespace Plustuff_TC.Negocio.Pantallas
{
    public partial class Mostrar_Clientes : Form, IObserverIdioma
    {
        C2_Negocio.Clientes _Clientes = new C2_Negocio.Clientes();
        public Menu_Principal Menu_Principal = new Menu_Principal();

        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;

        public Mostrar_Clientes()
        {
            InitializeComponent();
        }

        private void Mostrar_Clientes_Load(object sender, EventArgs e)
        {
            this.Listar();

            this.Traducir();
            Servicios.ManagerIdioma.Suscribir(this);
        }
        public void ActualizarIdioma(Idioma idioma)
        {
            this.Traducir();
        }

        private void Traducir()
        {
            Traductor traductor = new Traductor();
            Modelo.Formulario formulario = new Formulario();
            formulario.Nombre = "MostrarCliente";
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
                                               Contacto = c.Telefono,
                                               Baja = c.Baja
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

                Pantallas.Modificar_Cliente modificar_Cliente = new Modificar_Cliente(cliente);
                modificar_Cliente.MdiParent = Menu_Principal;
                modificar_Cliente.Show();
                this.Close();
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Modelo.Cliente cliente = new Modelo.Cliente();
            if (GridViewClientes.SelectedCells.Count > 0 && GridViewClientes.SelectedCells.Count < 2)
            {
                int selectedrowindex = GridViewClientes.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = GridViewClientes.Rows[selectedrowindex];
                string DNI = Convert.ToString(selectedRow.Cells["DNI"].Value);
                cliente.DNI = DNI;
                cliente = _Clientes.TraerClientePorDNI(cliente); //Me traigo el cliente

                string NombreCompleto = $"{cliente.Nombre} {cliente.Apellido}";

                if (cliente.Baja != false)
                {
                    MessageBox.Show("El cliente seleccionado ya esta dado de Baja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                _Clientes.Baja_Logica(cliente);

                //Da de alta en bitacora
                bitacora.Accion = "BajaCliente";
                bitacora.Descripcion = $"Se dio de baja al cliente {NombreCompleto}";
                bitacora.FechaHora = DateTime.Now;
                bitacora.U_id = Sesion.Usuario.id;
                bitacora.Criticidad = 2;
                _Bitacora.Alta(bitacora);

                MessageBox.Show("El cliente seleccionado se dio de Baja exitosamente", "Baja Cliente", MessageBoxButtons.OK);

                this.Listar();
            }
        }

        private void Mostrar_Clientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Servicios.ManagerIdioma.Desuscribir(this);
        }
    }
}
