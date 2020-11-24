using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plustuff_TC.Fam_Pat
{
    public partial class Alta_Familia : Form
    {
        C2_Negocio.Familias _Familias = new C2_Negocio.Familias();
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;

        public Alta_Familia()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtdescrip.Text))
                {
                    MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Modelo.Familia familia = new Modelo.Familia
                {
                    Familia = true,
                    Descripcion = txtdescrip.Text,
                    Nombre = txtnombre.Text.ToUpper()
                };

                if (!_Familias.Consistencia(familia))
                {
                    MessageBox.Show("Ya existe una Familia con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _Familias.Alta(familia);

                //Da de alta en bitacora
                bitacora.Accion = "AltaFamilia";
                bitacora.Descripcion = $"Se dio de alta a la familia {txtnombre.Text}";
                bitacora.FechaHora = DateTime.Now;
                bitacora.U_id = Sesion.Usuario.id;
                bitacora.Criticidad = 3;
                _Bitacora.Alta(bitacora);

                MessageBox.Show("Alta de Familia exitosa", "Alta de Familia");
                txtdescrip.Clear();
                txtnombre.Clear();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
