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
    public partial class Nuevo_Filamento : Form, IObserverIdioma
    {
        Modelo.TipoFilamento TipoFilamento = new Modelo.TipoFilamento();
        C2_Negocio.Filamentos _Filamentos = new C2_Negocio.Filamentos();
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;
        bool PatenteValida = false;

        public Nuevo_Filamento()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            TipoFilamento.Tipo = txtmaterial.Text;
            if (!string.IsNullOrEmpty(txtprecio.Text))
            {
                TipoFilamento.Precio = Convert.ToDouble(txtprecio.Text);
            }
            else
            {
                TipoFilamento.Precio = 0;
            }

            if (!_Filamentos.Validacion(TipoFilamento))
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Filamentos.Alta_TipoFilamento(TipoFilamento);

            //Da de alta en bitacora
            bitacora.Accion = "AltaMaterial";
            bitacora.Descripcion = $"Se dio de alta el material {txtmaterial.Text}";
            bitacora.FechaHora = DateTime.Now;
            bitacora.U_id = Sesion.Usuario.id;
            bitacora.Criticidad = 3;
            _Bitacora.Alta(bitacora);

            MessageBox.Show("El material se dio de alta exitosamente", "Alta Material",MessageBoxButtons.OK);
            this.Close();

        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Nuevo_Filamento_Load(object sender, EventArgs e)
        {
            this.Traducir();
            Servicios.ManagerIdioma.Suscribir(this);

            ValidarPermisos();
            if (PatenteValida == false)
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

        private void ValidarPatente(Modelo.Patente patente)
        {
            switch (patente.Nombre)
            {
                case "ALTA FILAMENTO":
                    PatenteValida = true;
                    break;
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
            formulario.Nombre = "AltaFilamento";
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

        private void Nuevo_Filamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            Servicios.ManagerIdioma.Desuscribir(this);
        }

        private void Nuevo_Filamento_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Ruta = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + @"\Plaware Help.chm";
            Help.ShowHelp(this, Ruta, "NuevoFilamento.htm");
        }
    }
}
