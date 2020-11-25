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
    public partial class Asignar_Pat_Usu : Form
    {
        C2_Negocio.Patente _Patentes = new C2_Negocio.Patente();
        List<Modelo.Patente> patentes;
        Modelo.Usuario Usuario;
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;
        C2_Negocio.Usuarios _Usuarios = new C2_Negocio.Usuarios();
        bool PatenteValida = false;

        public Asignar_Pat_Usu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Asignar_Pat_Usu_Load(object sender, EventArgs e)
        {
            cmbusuarios.DataSource = _Usuarios.Listar_Usuarios();
            this.cmbusuarios.DisplayMember = "Nombre";
            this.cmbusuarios.ValueMember = "id";

            patentes = _Patentes.Listar();

            ValidarPermisos();
            if (PatenteValida == false)
            {
                MessageBox.Show("No tiene permiso para ingresar a este formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(this.Close));
                return;
            }

            this.lvpatentes.Items.AddRange
            (
                (
                    from p in patentes
                    select new ListViewItem(p.Nombre)
                ).ToArray()
            );
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
                case "ASIGNACIÓN USUARIO-PATENTE":
                    this.btnasignar.Enabled = true;
                    PatenteValida = true;
                    break;
                case "QUITAR PATENTE-USUARIO":
                    this.btndesasignar.Enabled = true;
                    PatenteValida = true;
                    break;
            }
        }

        private void cmbusuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario = cmbusuarios.SelectedItem as Modelo.Usuario;

            this.lvpatentesAsignadas.Items.Clear();

            if (Usuario.Permisos != null && Usuario.Permisos.Any())
            {
                this.lvpatentesAsignadas.Items.Clear();
                var Patentes = (from f in Usuario.Permisos where f.Familia == false select new ListViewItem(f.Nombre)).ToArray();
                this.lvpatentesAsignadas.Items.AddRange(Patentes);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnasignar_Click(object sender, EventArgs e)
        {
            if (lvpatentes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una patente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Nombre = lvpatentes.SelectedItems[0].Text;

            Modelo.Patente patente = patentes.FirstOrDefault(p => !p.Familia && p.Nombre == Nombre) as Modelo.Patente;

            bool asignar = _Patentes.Asignar(Usuario, patente);
            if (!asignar)
            {
                MessageBox.Show("El usuario ya tiene la patente asignada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Da de alta en bitacora
            bitacora.Accion = "AsignacionPatente";
            bitacora.Descripcion = $"La patente: {patente.Nombre} se asigno al Usuario: {Usuario.Nombre}";
            bitacora.FechaHora = DateTime.Now;
            bitacora.U_id = Sesion.Usuario.id;
            bitacora.Criticidad = 3;
            _Bitacora.Alta(bitacora);

            this.lvpatentesAsignadas.Items.Add(patente.Nombre);
            Usuario.Permisos.Add(patente);

            MessageBox.Show("La Patente se asigno correctamente.", "Asignar Patente");
        }

        private void btndesasignar_Click(object sender, EventArgs e)
        {
            if (lvpatentesAsignadas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una patente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Nombre = lvpatentesAsignadas.SelectedItems[0].Text;

            Modelo.Patente patente = patentes.FirstOrDefault(p => !p.Familia && p.Nombre == Nombre) as Modelo.Patente;

            bool designar =_Patentes.Desasignar(Usuario, patente);
            if (!designar)
            {
                MessageBox.Show("El usuario ya tiene la patente asignada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Da de alta en bitacora
            bitacora.Accion = "DesasignacionPatente";
            bitacora.Descripcion = $"La patente: {patente.Nombre} se Desasigno del Usuario: {Usuario.Nombre}";
            bitacora.FechaHora = DateTime.Now;
            bitacora.U_id = Sesion.Usuario.id;
            bitacora.Criticidad = 3;
            _Bitacora.Alta(bitacora);

            this.lvpatentesAsignadas.Items.RemoveAt(lvpatentesAsignadas.SelectedIndices[0]);
            Usuario.Permisos.Remove(patente);

            MessageBox.Show("La Patente se Desasigno correctamente.", "Desasignar Patente");
        }
    }
}
