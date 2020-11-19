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
    public partial class Nuevo_Filamento : Form
    {
        Modelo.TipoFilamento TipoFilamento = new Modelo.TipoFilamento();
        C2_Negocio.Filamentos _Filamentos = new C2_Negocio.Filamentos();
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;

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
    }
}
