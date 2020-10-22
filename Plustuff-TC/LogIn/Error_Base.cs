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


        public Error_Base()
        {
            InitializeComponent();
        }

        private void Error_Base_Load(object sender, EventArgs e)
        {
            var Bitacora = _Bitacora.Listar_Bitacora();
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

        private void btnRecalcular_Click(object sender, EventArgs e)
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

            DialogResult dialogResult = MessageBox.Show(this, "Los digitos se recalcularon con exito", "Recalcular Digitos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                this.Refresh();
            }
        }
    }
}
