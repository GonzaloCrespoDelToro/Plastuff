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
    public partial class Datos_Conexion : Form
    {
        Verificadores _Verificador = new Verificadores();

        public Datos_Conexion()
        {
            InitializeComponent();
        }

        private void Datos_Conexion_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBDD.Text) || string.IsNullOrEmpty(txtServidor.Text))
            {
                MessageBox.Show("Por Favor complete todos los campos", "Redim Software", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimpiarTxt();
            }
            else
            {
                string[] Datos = { txtServidor.Text, txtBDD.Text };
                if (_Verificador.Datos_Conexion(Datos))
                {
                    try
                    {
                        Application.Restart();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        private void LimpiarTxt()
        {
            txtBDD.Clear();
            txtServidor.Clear();
        }
    }
}
