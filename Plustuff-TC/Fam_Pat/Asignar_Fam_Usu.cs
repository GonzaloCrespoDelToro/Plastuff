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
    public partial class Asignar_Fam_Usu : Form
    {
        C2_Negocio.Usuarios _Usuarios = new C2_Negocio.Usuarios();
        C2_Negocio.Familias _Familias = new C2_Negocio.Familias();
        List<Modelo.Familia> familias;
        Modelo.Usuario Usuario;
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;
        bool PatenteValida = false;

        public Asignar_Fam_Usu()
        {
            InitializeComponent();
        }

        private void Asignar_Fam_Usu_Load(object sender, EventArgs e)
        {
            this.TraerUsuarios();

            ValidarPermisos();
            if (this.PatenteValida == false)
            {
                MessageBox.Show("No tiene permiso para ingresar a este formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(this.Close));
                return;
            }
        }

        public void ValidarPermisos()
        {
            try
            {
                foreach (var p in Sesion.Usuario.Permisos)
                {
                    if (p is Modelo.Familia)
                    {
                        Modelo.Familia familia = (Modelo.Familia)p;

                        foreach (Modelo.Patente patente in familia.Permisos)
                        {
                            this.ValidarPatente(patente);
                        }
                    }
                    else
                    {
                        Modelo.Patente patente = (Modelo.Patente)p;

                        this.ValidarPatente(patente);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ValidarPatente(Modelo.Patente patente)
        {
            switch (patente.Nombre)
            {
                case "ASIGNACIÓN USUARIO-FAMILIA":
                    this.btnasignar.Enabled = true;
                    this.PatenteValida = true;
                    break;
                case "QUITAR FAMILIA-USUARIO":
                    this.btndesasignar.Enabled = true;
                    break;
            }
        }

        private void TraerUsuarios()
        {
            cmbusuarios.DataSource = _Usuarios.Listar_Usuarios();
            this.cmbusuarios.DisplayMember = "Nombre";
            this.cmbusuarios.ValueMember = "id";
        }


        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbusuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Usuario = cmbusuarios.SelectedItem as Modelo.Usuario;

                this.lvpatentes.Items.Clear();
                this.lvpatentesAsignadas.Items.Clear();

                this.lvpatentesAsignadas.Items.AddRange
                            (
                                (
                                    from f in Usuario.Permisos
                                    where f.Familia == true
                                    select new ListViewItem(f.Nombre)
                                ).ToArray()
                            );


                familias = _Familias.ListarFamilias();

                this.lvpatentes.Items.Clear();
                this.lvpatentes.Items.AddRange
                        (
                            (
                                from f in familias
                                select new ListViewItem(f.Nombre)
                            ).ToArray()
                        );
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnasignar_Click(object sender, EventArgs e)
        {
            if (lvpatentes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una familia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = lvpatentes.SelectedItems[0].Text;
            Modelo.Familia Fam = familias.FirstOrDefault(f => f.Familia && f.Nombre == nombre) as Modelo.Familia;

            var asignar = _Familias.Asignar(Usuario, Fam);

            if (!asignar)
            {
                MessageBox.Show("El Usuario ya tiene esta Familia asignada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Da de alta en bitacora
            bitacora.Accion = "AsignacionFamilia";
            bitacora.Descripcion = $"La Familia: {Fam.Nombre} se asigno al Usuario: {Usuario.Nombre}";
            bitacora.FechaHora = DateTime.Now;
            bitacora.U_id = Sesion.Usuario.id;
            bitacora.Criticidad = 3;
            _Bitacora.Alta(bitacora);

            this.lvpatentesAsignadas.Items.Add(Fam.Nombre);

            MessageBox.Show("La Familia se asigno correctamente", "Asignar Familia");
        }

        private void btndesasignar_Click(object sender, EventArgs e)
        {
            if (lvpatentesAsignadas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una familia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = lvpatentesAsignadas.SelectedItems[0].Text;
            Modelo.Familia Fam = familias.FirstOrDefault(f => f.Familia && f.Nombre == nombre) as Modelo.Familia;

            var desasignar = _Familias.Desasignar(Usuario, Fam);

            if (!desasignar)
            {
                MessageBox.Show("La familia no puede ser Desasignada ya que no pueden quedar zonas de nadie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Da de alta en bitacora
            bitacora.Accion = "DesasignacionFamilia";
            bitacora.Descripcion = $"La Familia: {Fam.Nombre} se Desasignó del Usuario: {Usuario.Nombre}";
            bitacora.FechaHora = DateTime.Now;
            bitacora.U_id = Sesion.Usuario.id;
            bitacora.Criticidad = 3;
            _Bitacora.Alta(bitacora);

            this.lvpatentesAsignadas.Items.RemoveAt(lvpatentesAsignadas.SelectedIndices[0]);

            MessageBox.Show("La Familia se desasignó correctamente", "Desasignar Familia");
        }

        private void lvpatentes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
