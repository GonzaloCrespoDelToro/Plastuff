using System;
using System.Windows.Forms;
using System.Linq;

namespace Plustuff_TC.Negocio.Pantallas
{
    public partial class Gestionar_Cotizaciones : Form
    {
        public Menu_Principal Menu_Principal = new Menu_Principal();

        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;

        Modelo.Cotizacion _Cotizacion = new Modelo.Cotizacion();
        Modelo.TipoFilamento _TipoFilamento = new Modelo.TipoFilamento();
        Modelo.Bitacora bitacora = new Modelo.Bitacora();

        C2_Negocio.Clientes _Clientes = new C2_Negocio.Clientes();
        C2_Negocio.Filamentos _Filamentos = new C2_Negocio.Filamentos();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        C2_Negocio.Cotizaciones _Cotizaciones = new C2_Negocio.Cotizaciones();

        public Gestionar_Cotizaciones()
        {
            InitializeComponent();
        }

        private void Cotizaciones_Enter(object sender, EventArgs e)
        {

        }

        private void listar()
        {
            var cotizaciones = _Cotizaciones.ListarCotizaciones();
            this.GridViewCotizaciones.DataSource = (from c in cotizaciones
                                                    select new
                                                    {
                                                        ID = c.ID,
                                                        NombreCliente = $"{c.Cliente.Nombre} {c.Cliente.Apellido}",
                                                        DNICliente = c.Cliente.DNI,
                                                        PrecioFinal = c.PrecioFinal,
                                                        Fecha = c.Fecha
                                                    }).ToList();
        }

        private void Gestionar_Cotizaciones_Load(object sender, EventArgs e)
        {
            try
            {
                this.listar();

                txtDNI.Enabled = false;
                txtCotizacion.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DNI_CheckedChanged(object sender, EventArgs e)
        {
            txtDNI.Enabled = true;
            txtCotizacion.Enabled = false;
            txtCotizacion.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtCotizacion.Enabled = true;
            txtDNI.Enabled = false;
            txtDNI.Clear();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.Cotizacion cotizacion = new Modelo.Cotizacion();
                if (GridViewCotizaciones.SelectedCells.Count > 0 && GridViewCotizaciones.SelectedCells.Count < 2)
                {
                    int selectedrowindex = GridViewCotizaciones.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = GridViewCotizaciones.Rows[selectedrowindex];
                    int ID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                    cotizacion.ID = ID;

                    _Cotizaciones.AceptarCotizacion(cotizacion);

                    //Da de alta en bitacora
                    bitacora.Accion = "AceptarCotizacion";
                    bitacora.Descripcion = $"Se acepto la cotizacion N° {cotizacion.ID}";
                    bitacora.FechaHora = DateTime.Now;
                    bitacora.U_id = Sesion.Usuario.id;
                    bitacora.Criticidad = 3;
                    _Bitacora.Alta(bitacora);

                    MessageBox.Show($"La cotizacion N° {cotizacion.ID} fue aceptada", "Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            var cotizaciones = _Cotizaciones.ListarCotizaciones();
            if (rbDNI.Checked == true && !string.IsNullOrEmpty(txtDNI.Text))
            {
                this.GridViewCotizaciones.DataSource = (from c in cotizaciones
                                                        where (c.Cliente.DNI == txtDNI.Text)
                                                        select new
                                                        {
                                                            ID = c.ID,
                                                            NombreCliente = $"{c.Cliente.Nombre} {c.Cliente.Apellido}",
                                                            DNICliente = c.Cliente.DNI,
                                                            PrecioFinal = c.PrecioFinal,
                                                            Fecha = c.Fecha
                                                        }).ToList();
            }
            else if (rbCotiID.Checked == true && !string.IsNullOrEmpty(txtCotizacion.Text))
            {
                this.GridViewCotizaciones.DataSource = (from c in cotizaciones
                                                        where (c.ID == Convert.ToInt32(txtCotizacion.Text))
                                                        select new
                                                        {
                                                            ID = c.ID,
                                                            NombreCliente = $"{c.Cliente.Nombre} {c.Cliente.Apellido}",
                                                            DNICliente = c.Cliente.DNI,
                                                            PrecioFinal = c.PrecioFinal,
                                                            Fecha = c.Fecha
                                                        }).ToList();
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCotizacion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            this.listar();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.Cotizacion cotizacion = new Modelo.Cotizacion();
                if (GridViewCotizaciones.SelectedCells.Count > 0 && GridViewCotizaciones.SelectedCells.Count < 2)
                {
                    int selectedrowindex = GridViewCotizaciones.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = GridViewCotizaciones.Rows[selectedrowindex];
                    int ID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                    cotizacion.ID = ID;

                    Modificar_Cotizacion modificar_Cotizacion = new Modificar_Cotizacion();
                    modificar_Cotizacion.cotizacion = cotizacion;
                    modificar_Cotizacion.MdiParent = Menu_Principal;
                    modificar_Cotizacion.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
