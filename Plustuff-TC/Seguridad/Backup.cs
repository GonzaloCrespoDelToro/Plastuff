using System;
using System.Windows.Forms;

namespace Plustuff_TC.Seguridad
{
    public partial class Backup : Form
    {
        Servicios.Backup _Backup = new Servicios.Backup();
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;
        Modelo.Backup backup = new Modelo.Backup();

        public Backup()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtruta.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_Backup.Consistencia(txtnombre.Text) || !_Backup.Consistencia(txtruta.Text))
                {
                    MessageBox.Show("Error de consistencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtruta.Text))
                {
                    MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string ruta = $"{txtruta.Text}\\{txtnombre.Text}";

                backup.Destino = ruta;
                backup.NombreArchivo = txtnombre.Text;
                backup.FechaHora = DateTime.Now;

                _Backup.RealizarBackup(backup);

                //Da de alta en bitacora
                bitacora.Accion = "BackUp";
                bitacora.Descripcion = $"Se realizo un BackUp";
                bitacora.FechaHora = DateTime.Now;
                bitacora.U_id = Sesion.Usuario.id;
                bitacora.Criticidad = 3;
                _Bitacora.Alta(bitacora);

                MessageBox.Show("El Backup se genero correctamente");

                txtruta.Clear();
                txtnombre.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Backup_Load(object sender, EventArgs e)
        {
           string FechaHora = _Backup.TraerUltimoBack();
            if (string.IsNullOrEmpty(FechaHora))
            {
                lblfechahora.Text = "No hay Backups generados.";
            }
            lblfechahora.Text = FechaHora;
        }
    }
}
