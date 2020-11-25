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

namespace Plustuff_TC.LogIn
{
    public partial class Error_Base : Form, IObserverIdioma
    {

        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Servicios.Verificadores _Verificadores = new Servicios.Verificadores();
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;
        List<Modelo.Bitacora> Bitacora;
        bool PatenteValida = false;

        public Error_Base()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            Bitacora = _Bitacora.Listar_Bitacora();
            dgvBitacora.DataSource = (from b in Bitacora
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

            this.Traducir();
            Servicios.ManagerIdioma.Suscribir(this);

            ValidarPermisos();
            if (this.PatenteValida == false)
            {
                MessageBox.Show("No tiene permiso para ingresar a este formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(this.Close));
                return;
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

        private void ValidarPatente(Patente patente)
        {
            switch (patente.Nombre)
            {
                case "CONSULTAR BITÁCORA":
                    this.PatenteValida = true;
                    break;
                case "RECALCULAR DÍGITOS VERIFICADORES":
                    this.btnRecalcular.Enabled = true;
                    break;
                case "REALIZAR RESTORE":
                    this.btnrestore.Enabled = true;
                    break;
            }
        }

        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(this, "¿Desea recalcular los digitos?", "Recalcular Digitos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
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

        

        private void button2_Click(object sender, EventArgs e)
        {
            Seguridad.Restore restore = new Seguridad.Restore();
            restore.Show();
        }

        public void ActualizarIdioma(Idioma idioma)
        {
            this.Traducir();
        }

        private void Traducir()
        {
            Traductor traductor = new Traductor();
            Modelo.Formulario formulario = new Formulario();
            formulario.Nombre = "Bitacora";
            List<Traduccion> traducciones;
            if (Sesion != null)
            {
                traducciones = traductor.ObtenerTraducciones(Sesion.Usuario.Idioma, formulario);
            }
            else
            {
                Modelo.Idioma IdiomaDefault = new Idioma();
                IdiomaDefault.id = 1;
                IdiomaDefault.idioma = "Español";
                traducciones = traductor.ObtenerTraducciones(IdiomaDefault, formulario);
            }
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

        private void Error_Base_FormClosing(object sender, FormClosingEventArgs e)
        {
            Servicios.ManagerIdioma.Desuscribir(this);
            if (this.MdiParent == null)
            {
                Environment.Exit(0);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
