using Acceso_Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plustuff_TC.Seguridad.Pantallas.Usuario
{
    public partial class Alta_Usuario : Form
    {
        public Alta_Usuario()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var accesosql = new AccesoSQL();
            accesosql.Armar_Conexion();
            //string datos = accesosql.Ejecutar_Query("ExecuteScalar", "Select C_nombre from Colores where id = 1");
            accesosql.Ejecutar_Query("ExecuteNonQuery", "INSERT INTO Colores VALUES('"+txtnombreU.Text+"')");
            //if (Convert.ToBoolean(accesosql.Ejecutar_Query("ExecuteNonQuery", "INSERT INTO Colores VALUES('sdfsdf')")) == true)
            //{

            //}
        }
    }
}
