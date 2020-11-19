using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plustuff_TC.Negocio.Pantallas
{
    public partial class Mostrar_Filamentos : Form
    {
        C2_Negocio.Filamentos _FIlamentos = new C2_Negocio.Filamentos();
        public Mostrar_Filamentos()
        {
            InitializeComponent();
        }

        private void Mostrar_Filamentos_Load(object sender, EventArgs e)
        {
            var ListaFilamentos =_FIlamentos.ListarTipoFilamento();
            GridViewFilamentos.DataSource = (from f in ListaFilamentos
                                             select new
                                             {
                                                 Material = f.Tipo,
                                                 Precio = f.Precio
                                             }).ToList();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Modelo.TipoFilamento tipoFilamento = new Modelo.TipoFilamento();
            if (GridViewFilamentos.SelectedCells.Count > 0 && GridViewFilamentos.SelectedCells.Count < 2)
            {
                int selectedrowindex = GridViewFilamentos.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = GridViewFilamentos.Rows[selectedrowindex];
                string Tipo = Convert.ToString(selectedRow.Cells["Material"].Value);
                tipoFilamento.Tipo = Tipo;
                tipoFilamento = _FIlamentos.TraerTipoFilamentoPorTipo(tipoFilamento);
                                
                this.Close();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
