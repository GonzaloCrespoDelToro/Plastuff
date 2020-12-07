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
    public partial class Modificar_Filamento : Form
    {
        public Modelo.TipoFilamento TipoFilamento = new Modelo.TipoFilamento();
        C2_Negocio.Filamentos _Filamentos = new C2_Negocio.Filamentos();
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;
        public Modificar_Filamento()
        {
            InitializeComponent();
        }

        private void Modificar_Filamento_Load(object sender, EventArgs e)
        {
            try
            {
                txtmaterialselect.Text = TipoFilamento.Tipo;
                txtprecioselect.Text = TipoFilamento.Precio.ToString();

                txtmaterial.Text = TipoFilamento.Tipo;
                txtprecio.Text = TipoFilamento.Precio.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
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

                _Filamentos.Modificar_TipoFilamento(TipoFilamento);

                //Da de alta en bitacora
                bitacora.Accion = "ModificacionFilamento";
                bitacora.Descripcion = $"Se modifico la info del material {txtmaterial.Text}";
                bitacora.FechaHora = DateTime.Now;
                bitacora.U_id = Sesion.Usuario.id;
                bitacora.Criticidad = 3;
                _Bitacora.Alta(bitacora);

                MessageBox.Show("El material se modifico exitosamente", "Modificar Material", MessageBoxButtons.OK);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Modificar_Filamento_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Ruta = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + @"\Plaware Help.chm";
            Help.ShowHelp(this, Ruta, "ModificarFilamento.htm");
        }
    }
}
