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

namespace Plustuff_TC.Seguridad
{
    public partial class Restore : Form, IObserverIdioma
    {
        Modelo.Backup _Restore = new Modelo.Backup();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Servicios.Backup _Backups = new Servicios.Backup();

        public Restore()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Bak files (*.bak) | *.bak";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtruta.Text = openFileDialog1.FileName;
                _Restore.Destino = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Restore_Load(object sender, EventArgs e)
        {
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
            formulario.Nombre = "Restore";
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

        private void Restore_FormClosing(object sender, FormClosingEventArgs e)
        {
            Servicios.ManagerIdioma.Desuscribir(this);
        }

        private void btnrestore_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_Restore.Destino))
            {
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea realizar el Restore?", "Restore", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _Backups.RealizarRestore(_Restore);

                    //Da de alta en bitacora
                    bitacora.Accion = "Restore";
                    bitacora.Descripcion = $"Se realizo un Restore";
                    bitacora.FechaHora = DateTime.Now;
                    bitacora.U_id = Sesion.Usuario.id;
                    bitacora.Criticidad = 1;
                    _Bitacora.Alta(bitacora);

                    MessageBox.Show("Restore realizado con exito", "Restore");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
