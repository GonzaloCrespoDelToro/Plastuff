using System;
using System.Windows.Forms;

namespace Plustuff_TC.Negocio.Pantallas
{
    public partial class Modificar_Estado : Form
    {
        public Modelo.Pedidos _Pedido = new Modelo.Pedidos();
        C2_Negocio.Cotizaciones _Cotizaciones = new C2_Negocio.Cotizaciones();
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;

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
                int estado = _Cotizaciones.ModificarEstadoPedido(_Pedido);
                if (estado == 1)
                {
                    //Da de alta en bitacora
                    bitacora.Accion = "EnvioMailPedido";
                    bitacora.Descripcion = $"Se envio el mail del pedido N° {_Pedido.ID} ";
                    bitacora.FechaHora = DateTime.Now;
                    bitacora.U_id = Sesion.Usuario.id;
                    bitacora.Criticidad = 3;
                    _Bitacora.Alta(bitacora);
                }
                MessageBox.Show("El estado fue modificado con exito","Cambio Exitoso");
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Modificar_Estado_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Ruta = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + @"\Plaware Help.chm";
            Help.ShowHelp(this, Ruta, "MoficarEstado.htm");
        }
    }
}
