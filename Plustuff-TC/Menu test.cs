using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plustuff_TC
{
    public partial class Menu_test : Form
    {
        public Menu_test()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            LogIn.Login login = new LogIn.Login();
            login.Show();
        }

        private void Inicio_sistema_Click(object sender, EventArgs e)
        {
            LogIn.Inicio_Sistema inicio_Sistema = new LogIn.Inicio_Sistema();
            inicio_Sistema.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Negocio.Nueva_Cotizacion nueva_Cotizacion = new Negocio.Nueva_Cotizacion();
            nueva_Cotizacion.Show();
        }

        private void BackUp_Click(object sender, EventArgs e)
        {
            Seguridad.Backup backup = new Seguridad.Backup();
            backup.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Fam_Pat.Asignar_Pat_Fam asignar_Pat_Fam = new Fam_Pat.Asignar_Pat_Fam();
            //asignar_Pat_Fam.Show();

            //Fam_Pat.Asignar_Fam_Usu asignar_Pat_Fam = new Fam_Pat.Asignar_Fam_Usu();
            //asignar_Pat_Fam.Show();

            //Fam_Pat.Asignar_Pat_Usu asignar_Fam_Usu = new Fam_Pat.Asignar_Pat_Usu();
            //asignar_Fam_Usu.Show();

            LogIn.Error_Base error_Base = new LogIn.Error_Base();
            error_Base.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Negocio.Pantallas.Nuevo_Cliente nuevo_Cliente = new Negocio.Pantallas.Nuevo_Cliente();
            nuevo_Cliente.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Negocio.Pantallas.Gestionar_Cotizaciones gestionar_Cotizaciones = new Negocio.Pantallas.Gestionar_Cotizaciones();
            gestionar_Cotizaciones.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Negocio.Pantallas.Nuevo_Filamento nuevo_Filamento = new Negocio.Pantallas.Nuevo_Filamento();
            nuevo_Filamento.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Negocio.Pantallas.Modificar_Filamento modificar_Filamento = new Negocio.Pantallas.Modificar_Filamento();
            modificar_Filamento.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Negocio.Pantallas.Modificar_Cotizacion modificar_Cotizacion = new Negocio.Pantallas.Modificar_Cotizacion();
            modificar_Cotizacion.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Seguridad.Pantallas.Usuario.Alta_Usuario alta_Usuario = new Seguridad.Pantallas.Usuario.Alta_Usuario();
            alta_Usuario.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Seguridad.Pantallas.Usuario.Mod_Usuario alta_Usuario = new Seguridad.Pantallas.Usuario.Mod_Usuario();
            alta_Usuario.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this, "¿Seguro que desea inhabilitar el usuario?", "Baja de usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            Seguridad.Pantallas.Usuario.Desbloquear_Usuario alta_Usuario = new Seguridad.Pantallas.Usuario.Desbloquear_Usuario();
            alta_Usuario.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Fam_Pat.Alta_Familia alta_Familia = new Fam_Pat.Alta_Familia();
            alta_Familia.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Fam_Pat.Modificar_Familia alta_Familia = new Fam_Pat.Modificar_Familia();
            alta_Familia.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Negocio.Empleado.Alta_Empleado alta_Empleado = new Negocio.Empleado.Alta_Empleado();
            alta_Empleado.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Negocio.Empleado.Modificar_Empleado modificar_Empleado = new Negocio.Empleado.Modificar_Empleado();
            modificar_Empleado.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Seguridad.Pantallas.Usuario.Cambiar_Contraseña cambiar_Contraseña = new Seguridad.Pantallas.Usuario.Cambiar_Contraseña();
            cambiar_Contraseña.Show();

        }
    }
}
