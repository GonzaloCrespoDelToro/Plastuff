using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plustuff_TC.LogIn
{
    public partial class Error_Base : Form
    {

        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Servicios.Verificadores _Verificadores = new Servicios.Verificadores();
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;
        List<Modelo.Bitacora> Bitacora;


        public Error_Base()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            Bitacora = _Bitacora.Listar_Bitacora();
            dgvBitacora.DataSource = (from b in Bitacora
                                      orderby b.FechaHora descending
                                      select new
                                      {
                                          Accion = b.Accion,
                                          Descripcion = b.Descripcion,
                                          Criticidad = b.CriticidadNombre,
                                          FechayHora = b.FechaHora,
                                          Usuario = b.Usuario
                                      }).ToArray();
        }

        private void Error_Base_Load(object sender, EventArgs e)
        {
            this.Listar();
            
            BloquearFiltros();

            var criticidad = _Bitacora.TraerCriticidades();
            cmbCriticidad.DataSource = criticidad;
            cmbCriticidad.DisplayMember = "Nombre";
            cmbCriticidad.ValueMember = "ID";
        }

        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(this, "¿Desea reclacular los digitos?", "Recalcular Digitos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                if (!_Verificadores.Recalcular_TodosDVV())
                {
                    MessageBox.Show(this, "No se pudo recalcular los digitos", "Recalcular Digitos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bitacora.Accion = "RecalculoDigitos";
                bitacora.Descripcion = "Se recalcularon todos los digitos";
                bitacora.FechaHora = DateTime.Now;
                bitacora.U_id = Sesion.Usuario.id;
                bitacora.Criticidad = 1;
                _Bitacora.Alta(bitacora);
            }
            this.Listar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rbFecha.Checked == true)
            {
                DateTime desde = Convert.ToDateTime(dtFechaDesde.Text);
                DateTime hasta = Convert.ToDateTime(dtFechaHasta.Text);
                dgvBitacora.DataSource = (from b in Bitacora
                                          orderby b.FechaHora descending
                                          where (b.FechaHora > desde && b.FechaHora < hasta)
                                          select new
                                          {
                                              Accion = b.Accion,
                                              Descripcion = b.Descripcion,
                                              Criticidad = b.CriticidadNombre,
                                              FechayHora = b.FechaHora,
                                              Usuario = b.Usuario
                                          }).ToArray();
            }
            else if (rbCriticidad.Checked == true)
            {
                var Criticidad = cmbCriticidad.Text;
                dgvBitacora.DataSource = (from b in Bitacora
                                          orderby b.FechaHora descending
                                          where (b.CriticidadNombre == Criticidad)
                                          select new
                                          {
                                              Accion = b.Accion,
                                              Descripcion = b.Descripcion,
                                              Criticidad = b.CriticidadNombre,
                                              FechayHora = b.FechaHora,
                                              Usuario = b.Usuario
                                          }).ToArray();
            }
            else if (rbtexto.Checked == true)
            {
                string texto = txttexto.Text;
                dgvBitacora.DataSource = (from b in Bitacora
                                          orderby b.FechaHora descending
                                          where (b.CriticidadNombre.ToLower().Contains(Text.ToLower())|| b.Descripcion.ToLower().Contains(texto.ToLower())
                                          || b.Accion.ToLower().Contains(Text.ToLower()) || b.Usuario.ToLower().Contains(texto.ToLower()))
                                          select new
                                          {
                                              Accion = b.Accion,
                                              Descripcion = b.Descripcion,
                                              Criticidad = b.CriticidadNombre,
                                              FechayHora = b.FechaHora,
                                              Usuario = b.Usuario
                                          }).ToArray();
            }
            

        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void BloquearFiltros()
        {
            lbldesde.Enabled = false;
            lblhasta.Enabled = false;
            dtFechaDesde.Enabled = false;
            dtFechaHasta.Enabled = false;
            cmbCriticidad.Enabled = false;
            txttexto.Enabled = false;
        }

        private void rbCriticidad_CheckedChanged(object sender, EventArgs e)
        {
            BloquearFiltros();
            cmbCriticidad.Enabled = true;
        }

        private void rbFecha_CheckedChanged(object sender, EventArgs e)
        {
            BloquearFiltros();
            lbldesde.Enabled = true;
            lblhasta.Enabled = true;
            dtFechaDesde.Enabled = true;
            dtFechaHasta.Enabled = true;
        }

        private void rbtexto_CheckedChanged(object sender, EventArgs e)
        {
            BloquearFiltros();
            txttexto.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
