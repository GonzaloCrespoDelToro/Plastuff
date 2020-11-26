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
    public partial class Gestionar_Familias : Form
    {
        C2_Negocio.Familias _familia = new C2_Negocio.Familias();
        List<Modelo.Familia> familias;
        Modelo.Bitacora bitacora = new Modelo.Bitacora();
        C2_Negocio.Bitacora _Bitacora = new C2_Negocio.Bitacora();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;
        public Menu_Principal Menu_Principal = new Menu_Principal();
        bool PatenteValida = false;

        public Gestionar_Familias()
        {
            InitializeComponent();
        }

        private void Gestionar_Familias_Load(object sender, EventArgs e)
        {
            listar();
            ValidarPermisos();
            if (PatenteValida == false)
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
                case "BAJA FAMILIA":
                    this.btnBaja.Enabled = true;
                    PatenteValida = true;
                    break;
                case "MODIFICAR FAMILIA":
                    this.btnModificar.Enabled = true;
                    PatenteValida = true;
                    break;
            }
        }

        void listar()
        {
            familias = _familia.ListarFamilias();
            GridViewFamilia.DataSource = (from f in familias
                                          select new
                                          {
                                              Nombre = f.Nombre,
                                              Descripcion = f.Descripcion
                                          }).ToArray();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (GridViewFamilia.SelectedCells.Count > 0 && GridViewFamilia.SelectedCells.Count < 2)
            {
                int selectedrowindex = GridViewFamilia.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = GridViewFamilia.Rows[selectedrowindex];
                string nombre = Convert.ToString(selectedRow.Cells["Nombre"].Value);

                Modelo.Familia familia = familias.FirstOrDefault(f => f.Familia && f.Nombre == nombre) as Modelo.Familia;

                Fam_Pat.Modificar_Familia mod_familia = new Modificar_Familia();
                mod_familia.MdiParent = Menu_Principal;
                mod_familia.familia = familia;
                mod_familia.Show();
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (GridViewFamilia.SelectedCells.Count > 0 && GridViewFamilia.SelectedCells.Count < 2)
            {
                int selectedrowindex = GridViewFamilia.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = GridViewFamilia.Rows[selectedrowindex];
                string nombre = Convert.ToString(selectedRow.Cells["Nombre"].Value);

                Modelo.Familia familia = familias.FirstOrDefault(f => f.Familia && f.Nombre == nombre) as Modelo.Familia;

                var baja = _familia.Baja(familia);
                if (!baja)
                {
                    MessageBox.Show("No se puede Borrar esta Familia, Ya que esta no se encuentra asignada a un Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bitacora.Accion = "BorrarFamilia";
                bitacora.Descripcion = $"La familia: {nombre} se elimino";
                bitacora.FechaHora = DateTime.Now;
                bitacora.U_id = Sesion.Usuario.id;
                bitacora.Criticidad = 3;
                _Bitacora.Alta(bitacora);

                MessageBox.Show("La Familia se Elimino correctamente", "Asignar Patente");

                this.listar();
            }
        }
    }
}
