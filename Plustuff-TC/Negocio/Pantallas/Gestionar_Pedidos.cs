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
    public partial class Gestionar_Pedidos : Form, IObserverIdioma
    {
        C2_Negocio.Cotizaciones _Cotizaciones = new C2_Negocio.Cotizaciones();
        public Menu_Principal Menu_Principal = new Menu_Principal();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;

        bool PatenteValida = false;
        public Gestionar_Pedidos()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            var Pedidos = _Cotizaciones.ListarPedidos();
            GridViewPedidos.DataSource = (from p in Pedidos
                                          select new
                                          {
                                              ID = p.ID,
                                              NombreCliente = $"{p.Cotizacion.Cliente.Nombre} {p.Cotizacion.Cliente.Apellido}",
                                              DNI = p.Cotizacion.Cliente.DNI,
                                              Estado = p.Estados.Estado,
                                              PrecioFinal = p.Cotizacion.PrecioFinal,
                                              Fecha = p.Fecha
                                          }).ToList();
        }

        private void Gestionar_Pedidos_Load(object sender, EventArgs e)
        {
            this.Traducir();
            Servicios.ManagerIdioma.Suscribir(this);

            this.Listar();

            var estados = _Cotizaciones.ListarEstados();
            cbestados.DataSource = estados;
            cbestados.DisplayMember = "Estado";
            cbestados.ValueMember = "ID";

            ValidarPermisos();
            if (PatenteValida == false)
            {
                MessageBox.Show("No tiene permiso para ingresar a este formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(this.Close));
                return;
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
            formulario.Nombre = "GestionarPedidos";
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
                case "MODIFICAR PEDIDOS":
                    PatenteValida = true;
                    break;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            var Pedidos = _Cotizaciones.ListarPedidos();

            if (rbDNI.Checked == true && !string.IsNullOrEmpty(txtDNI.Text))
            {
                GridViewPedidos.DataSource = (from p in Pedidos
                                              where (p.Cotizacion.Cliente.DNI == txtDNI.Text)
                                              select new
                                              {
                                                  ID = p.ID,
                                                  NombreCliente = $"{p.Cotizacion.Cliente.Nombre} {p.Cotizacion.Cliente.Apellido}",
                                                  DNI = p.Cotizacion.Cliente.DNI,
                                                  Estado = p.Estados.Estado,
                                                  PrecioFinal = p.Cotizacion.PrecioFinal,
                                                  Fecha = p.Fecha
                                              }).ToList();
            }
            else if (rbEstado.Checked == true && !string.IsNullOrEmpty(cbestados.Text))
            {
                GridViewPedidos.DataSource = (from p in Pedidos
                                              where (p.Estados.Estado == cbestados.Text)
                                              select new
                                              {
                                                  ID = p.ID,
                                                  NombreCliente = $"{p.Cotizacion.Cliente.Nombre} {p.Cotizacion.Cliente.Apellido}",
                                                  DNI = p.Cotizacion.Cliente.DNI,
                                                  Estado = p.Estados.Estado,
                                                  PrecioFinal = p.Cotizacion.PrecioFinal,
                                                  Fecha = p.Fecha
                                              }).ToList();
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            this.Listar();
            txtDNI.Clear();
        }

        private void rbDNI_CheckedChanged(object sender, EventArgs e)
        {
            txtDNI.Enabled = true;
            cbestados.Enabled = false;
        }

        private void rbEstado_CheckedChanged(object sender, EventArgs e)
        {
            cbestados.Enabled = true;
            txtDNI.Enabled = false;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Modelo.Pedidos _pedido = new Modelo.Pedidos();
            if (GridViewPedidos.SelectedCells.Count > 0 && GridViewPedidos.SelectedCells.Count < 2)
            {
                int selectedrowindex = GridViewPedidos.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = GridViewPedidos.Rows[selectedrowindex];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                _pedido.ID = id;
                _pedido = _Cotizaciones.TraerPedidoPorID(_pedido);

                Modificar_Estado modificar_Estado = new Modificar_Estado();
                modificar_Estado._Pedido = _pedido;
                modificar_Estado.MdiParent = Menu_Principal;
                modificar_Estado.Show();
                this.Close();
            }
        }

        private void Gestionar_Pedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Servicios.ManagerIdioma.Desuscribir(this);
        }
    }
}
