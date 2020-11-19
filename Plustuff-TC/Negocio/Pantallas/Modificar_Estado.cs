using System;
using System.Windows.Forms;

namespace Plustuff_TC.Negocio.Pantallas
{
    public partial class Modificar_Estado : Form
    {
        public Modelo.Pedidos _Pedido = new Modelo.Pedidos();
        C2_Negocio.Cotizaciones _Cotizaciones = new C2_Negocio.Cotizaciones();

        public Modificar_Estado()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modificar_Estado_Load(object sender, EventArgs e)
        {
            txtid.Text = _Pedido.ID.ToString();

            var estados = _Cotizaciones.ListarEstados();
            cbestados.DataSource = estados;
            cbestados.DisplayMember = "Estado";
            cbestados.ValueMember = "ID";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                _Pedido.Estados = cbestados.SelectedItem as Modelo.Estados;
                _Cotizaciones.ModificarEstadoPedido(_Pedido);
                MessageBox.Show("El estado fue modificado con exito","Cambio Exitoso");
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            

        }
    }
}
