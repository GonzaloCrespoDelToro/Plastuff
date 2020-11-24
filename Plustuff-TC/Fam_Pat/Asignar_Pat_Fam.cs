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
    public partial class Asignar_Pat_Fam : Form
    {
        C2_Negocio.Familias _Familias = new C2_Negocio.Familias();
        C2_Negocio.Patente _Patentes = new C2_Negocio.Patente();
        List<Modelo.Patente> patentes;
        Modelo.Familia familia;
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;

        public Asignar_Pat_Fam()
        {
            InitializeComponent();
        }

        private void Asignar_Pat_Fam_Load(object sender, EventArgs e)
        {
            try
            {
                this.cmbFamilias.DataSource = _Familias.ListarFamilias();
                this.cmbFamilias.DisplayMember = "Nombre";
                this.cmbFamilias.ValueMember = "Id";
                patentes = _Patentes.Listar();

                this.lvpatentes.Items.AddRange
                (
                    (
                        from p in patentes
                        select new ListViewItem(p.Nombre)
                    ).ToArray()
                );
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvpatentesAsignadas.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una patente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string Nombre = lvpatentesAsignadas.SelectedItems[0].Text;

                Modelo.Patente patente = familia.Permisos.FirstOrDefault(p => !p.Familia && p.Nombre == Nombre) as Modelo.Patente;

                bool desasignar = _Familias.Desasignar(familia, patente);
                if (!desasignar)
                {
                    MessageBox.Show("No se puede Desasignar esta patente, Ya que esta patente no se encuentra asignada en otra Familia/Usuario ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bitacora.Accion = "DesasignacionPatente";
                bitacora.Descripcion = $"La patente: {patente.Nombre} se Desasigno de la familia: {familia.Nombre}";
                bitacora.FechaHora = DateTime.Now;
                bitacora.U_id = Sesion.Usuario.id;
                bitacora.Criticidad = 3;
                _Bitacora.Alta(bitacora);

                this.lvpatentesAsignadas.Items.RemoveAt(lvpatentesAsignadas.SelectedIndices[0]);
                familia.Permisos.Remove(patente);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al Desasignar la patente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnasignar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lvpatentes.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una patente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string Nombre = this.lvpatentes.SelectedItems[0].Text;

                Modelo.Patente patente = patentes.FirstOrDefault(p => !p.Familia && p.Nombre == Nombre) as Modelo.Patente;

                var asignar =_Familias.Asignar(familia, patente);
                if (!asignar)
                {
                    MessageBox.Show("La familia ya tiene la patente asignada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Da de alta en bitacora
                bitacora.Accion = "AsignacionPatente";
                bitacora.Descripcion = $"La patente: {patente.Nombre} se asigno a la familia: {familia.Nombre}";
                bitacora.FechaHora = DateTime.Now;
                bitacora.U_id = Sesion.Usuario.id;
                bitacora.Criticidad = 3;
                _Bitacora.Alta(bitacora);

                this.lvpatentesAsignadas.Items.Add(patente.Nombre);
                familia.Permisos.Add(patente);

                MessageBox.Show("La patente se asigno correctamente.", "Asignar Patente");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cmbFamilias_SelectedIndexChanged(object sender, EventArgs e)
        {
            familia = cmbFamilias.SelectedItem as Modelo.Familia;
            this.lvpatentesAsignadas.Items.Clear();

            if (familia.Permisos != null)
            {
                this.lvpatentesAsignadas.Items.AddRange
                (
                    (
                        from f in familia.Permisos
                        select new ListViewItem(f.Nombre)
                    ).ToArray()
                );
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
