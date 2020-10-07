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
        Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Verificadores _Verificador = new Verificadores();
        LogIn.Login login = new Login();
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        public string Error_DVH = null;
        public string Error_DVV = null;

        public Inicio_Sistema()
        {
            InitializeComponent();
        }

        private void Inicio_Sistema_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Refresh();
            lblproc.Text = "Verificando integridad del archivo config...";
            this.Refresh();
            System.Threading.Thread.Sleep(400);
            _Verificador.Verificar_TXT(); //Verifica la integridad del txt
            lblproc.Text = "Intentando conectar a la base de datos..";
            this.Refresh();
            System.Threading.Thread.Sleep(300);
            if (_Verificador.Armar_Conexion() != true) //Verifica si se puede conectar a la base
            {
                LogIn.Datos_Conexion datos_Conexion = new Datos_Conexion();
                datos_Conexion.Show();
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                return;
            }
            lblproc.Text = "Verificando digitos horizontales de la base de datos..";
            this.Refresh();
            System.Threading.Thread.Sleep(500);
            string ErrorDVH = _Verificador.Verificar_DVH(); //Verificacion de DVH
            if (!string.IsNullOrEmpty(ErrorDVH))
            {
                Error_DVH = ErrorDVH;
                bitacora.Accion = "ErrorDVH";
                bitacora.Descripcion = ErrorDVH;
                bitacora.FechaHora = DateTime.Now;
                bitacora.U_id = 1;
                bitacora.Criticidad = 1;
                _Bitacora.Alta(bitacora);
            }
            lblproc.Text = "Verificando digitos verticales de la base de datos..";
            this.Refresh();
            System.Threading.Thread.Sleep(500);
            string ErrorDVV = _Verificador.Verificar_DVV(); //Verificacion de DVV
            if (!string.IsNullOrEmpty(ErrorDVV))
            {
                Error_DVV = ErrorDVV;
                bitacora.Accion = "ErrorDVV";
                bitacora.Descripcion = ErrorDVV;
                bitacora.FechaHora = DateTime.Now;
                bitacora.U_id = 1;
                bitacora.Criticidad = 1;
                _Bitacora.Alta(bitacora);
            }
            //Esconde el form de Inicio de sistema
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            login.Error_DVH = Error_DVH;
            login.Error_DVV = Error_DVV;
            login.Show();
        }
    }
}
