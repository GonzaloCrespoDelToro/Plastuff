using C2_Negocio;
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
    public partial class Inicio_Sistema : Form
    {
        Bitacora _Bitacora = new Bitacora();
        Verificadores _Verificador = new Verificadores();

        public Inicio_Sistema()
        {
            InitializeComponent();
        }


        private void Inicio_Sistema_Load(object sender, EventArgs e)
        {
            lblproc.Text = "Verificando integridad del archivo config...";
            this.Refresh();
            System.Threading.Thread.Sleep(400);
            _Verificador.Verificar_TXT();
            lblproc.Text = "Intentando conectar a la base de datos..";
            this.Refresh();
            System.Threading.Thread.Sleep(300);
            if(_Verificador.Armar_Conexion() != true)
            {

            }
            LogIn.Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
