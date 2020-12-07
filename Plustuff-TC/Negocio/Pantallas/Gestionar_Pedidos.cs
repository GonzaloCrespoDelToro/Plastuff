using Modelo;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Plustuff_TC.Negocio.Pantallas
{
    public partial class Gestionar_Pedidos : Form, IObserverIdioma
    {
        C2_Negocio.Cotizaciones _Cotizaciones = new C2_Negocio.Cotizaciones();
        public Menu_Principal Menu_Principal = new Menu_Principal();
        Servicios.SessionManager Sesion = Servicios.SessionManager.Getinstance;
        private string nombredearchivo;
        private string titulo;
        private string parrafo;

        bool PatenteValida = false;
        public Gestionar_Pedidos()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            var Pedidos = _Cotizaciones.ListarPedidos();
            GridViewPedidos.DataSource = (from p in Pedidos
                                          select new
                                          {
                                              ID = p.ID,
                                              NombreCliente = $"{p.Cotizacion.Cliente.Nombre} {p.Cotizacion.Cliente.Apellido}",
                                              DNI = p.Cotizacion.Cliente.DNI,
                                              Estado = p.Estados.Estado,
                                              PrecioFinal = p.Cotizacion.PrecioFinal,
                                              Fecha = p.Fecha
                                          }).ToList();
        }

        private void Gestionar_Pedidos_Load(object sender, EventArgs e)
        {
            this.Traducir();
            Servicios.ManagerIdioma.Suscribir(this);

            this.Listar();

            var estados = _Cotizaciones.ListarEstados();
            cbestados.DataSource = estados;
            cbestados.DisplayMember = "Estado";
            cbestados.ValueMember = "ID";

            ValidarPermisos();
            if (PatenteValida == false)
            {
                MessageBox.Show("No tiene permiso para ingresar a este formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(this.Close));
                return;
            }
        }

        public void ActualizarIdioma(Idioma idioma)
        {
            this.Traducir();
        }

        private void Traducir()
        {
            Traductor traductor = new Traductor();
            Modelo.Formulario formulario = new Formulario();
            formulario.Nombre = "GestionarPedidos";
            var traducciones = traductor.ObtenerTraducciones(Sesion.Usuario.Idioma, formulario);
            if (traducciones.Any(t => t.Etiqueta == this.Name))
            {
                this.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.Name).Descripcion;
            }
            foreach (Control item in this.Controls)
            {
                if (traducciones.Any(t => t.Etiqueta == item.Name))
                {
                    item.Text = traducciones.FirstOrDefault(t => t.Etiqueta == item.Name).Descripcion;
                }

                TraducirControlesInternos(item, traducciones);
            }
        }

        private void TraducirControlesInternos(Control item, List<Traduccion> traducciones)
        {
            if (item is GroupBox)
            {
                foreach (Control subItem in item.Controls)
                {
                    if (traducciones.Any(t => t.Etiqueta == subItem.Name))
                    {
                        subItem.Text = traducciones.FirstOrDefault(t => t.Etiqueta == subItem.Name).Descripcion;
                    }

                    TraducirControlesInternos(subItem, traducciones);
                }
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
                case "MODIFICAR PEDIDOS":
                    PatenteValida = true;
                    break;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            var Pedidos = _Cotizaciones.ListarPedidos();

            if (rbDNI.Checked == true && !string.IsNullOrEmpty(txtDNI.Text))
            {
                GridViewPedidos.DataSource = (from p in Pedidos
                                              where (p.Cotizacion.Cliente.DNI == txtDNI.Text)
                                              select new
                                              {
                                                  ID = p.ID,
                                                  NombreCliente = $"{p.Cotizacion.Cliente.Nombre} {p.Cotizacion.Cliente.Apellido}",
                                                  DNI = p.Cotizacion.Cliente.DNI,
                                                  Estado = p.Estados.Estado,
                                                  PrecioFinal = p.Cotizacion.PrecioFinal,
                                                  Fecha = p.Fecha
                                              }).ToList();
            }
            else if (rbEstado.Checked == true && !string.IsNullOrEmpty(cbestados.Text))
            {
                GridViewPedidos.DataSource = (from p in Pedidos
                                              where (p.Estados.Estado == cbestados.Text)
                                              select new
                                              {
                                                  ID = p.ID,
                                                  NombreCliente = $"{p.Cotizacion.Cliente.Nombre} {p.Cotizacion.Cliente.Apellido}",
                                                  DNI = p.Cotizacion.Cliente.DNI,
                                                  Estado = p.Estados.Estado,
                                                  PrecioFinal = p.Cotizacion.PrecioFinal,
                                                  Fecha = p.Fecha
                                              }).ToList();
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            this.Listar();
            txtDNI.Clear();
        }

        private void rbDNI_CheckedChanged(object sender, EventArgs e)
        {
            txtDNI.Enabled = true;
            cbestados.Enabled = false;
        }

        private void rbEstado_CheckedChanged(object sender, EventArgs e)
        {
            cbestados.Enabled = true;
            txtDNI.Enabled = false;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Modelo.Pedidos _pedido = new Modelo.Pedidos();
            if (GridViewPedidos.SelectedCells.Count > 0 && GridViewPedidos.SelectedCells.Count < 2)
            {
                int selectedrowindex = GridViewPedidos.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = GridViewPedidos.Rows[selectedrowindex];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                _pedido.ID = id;
                _pedido = _Cotizaciones.TraerPedidoPorID(_pedido);

                Modificar_Estado modificar_Estado = new Modificar_Estado();
                modificar_Estado._Pedido = _pedido;
                modificar_Estado.MdiParent = Menu_Principal;
                modificar_Estado.Show();
                this.Close();
            }
        }

        private void Gestionar_Pedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Servicios.ManagerIdioma.Desuscribir(this);
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            try
            {
                nombredearchivo = "ReportePedidos";
                titulo = "Reporte de Pedidos";
                parrafo = "Pedidos a dia de hoy";
                if (GridViewPedidos.Rows.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "PDF (*.pdf)|*.pdf";
                    sfd.FileName = this.nombredearchivo;
                    bool fileError = false;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(sfd.FileName))
                        {
                            File.Delete(sfd.FileName);
                        }
                        if (!fileError)
                        {
                            PdfPTable pdfTable = new PdfPTable(GridViewPedidos.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in GridViewPedidos.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in GridViewPedidos.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);

                                pdfDoc.Open();

                                iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 26);
                                titleFont.IsUnderlined();

                                iTextSharp.text.Font regularFont = FontFactory.GetFont("Arial", 15);

                                Paragraph title = new Paragraph(this.titulo, titleFont);
                                title.Alignment = Element.ALIGN_CENTER;
                                pdfDoc.Add(title);

                                pdfDoc.Add(new Chunk("\n"));

                                Paragraph text = new Paragraph(this.parrafo, regularFont);
                                pdfDoc.Add(text);

                                pdfDoc.Add(new Chunk("\n"));

                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Reporte creado exitosamente.", "Reporte", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay registros en la tabla para exportar.", "Reporte", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Gestionar_Pedidos_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Ruta = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + @"\Plaware Help.chm";
            Help.ShowHelp(this, Ruta, "ListarPedidos.htm");
        }
    }
}
