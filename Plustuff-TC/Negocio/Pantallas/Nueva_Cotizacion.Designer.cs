namespace Plustuff_TC.Negocio
{
    partial class Nueva_Cotizacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nueva_Cotizacion));
            this.txtruta = new System.Windows.Forms.TextBox();
            this.lblruta = new System.Windows.Forms.Label();
            this.gbgenerar = new System.Windows.Forms.GroupBox();
            this.pbruta = new System.Windows.Forms.PictureBox();
            this.lbldetalle = new System.Windows.Forms.Label();
            this.txtdetalle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cbxfilamento = new System.Windows.Forms.ComboBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.txtgramos = new System.Windows.Forms.TextBox();
            this.lblgramos = new System.Windows.Forms.Label();
            this.txttiempo = new System.Windows.Forms.TextBox();
            this.lbltiempo = new System.Windows.Forms.Label();
            this.lbltotalc = new System.Windows.Forms.Label();
            this.gbcotizacion = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.lblcliente = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbgenerar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbruta)).BeginInit();
            this.gbcotizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtruta
            // 
            this.txtruta.Location = new System.Drawing.Point(164, 33);
            this.txtruta.Margin = new System.Windows.Forms.Padding(4);
            this.txtruta.Name = "txtruta";
            this.txtruta.ReadOnly = true;
            this.txtruta.Size = new System.Drawing.Size(203, 22);
            this.txtruta.TabIndex = 0;
            // 
            // lblruta
            // 
            this.lblruta.AutoSize = true;
            this.lblruta.Location = new System.Drawing.Point(8, 37);
            this.lblruta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblruta.Name = "lblruta";
            this.lblruta.Size = new System.Drawing.Size(83, 16);
            this.lblruta.TabIndex = 1;
            this.lblruta.Text = "Ruta archivo";
            // 
            // gbgenerar
            // 
            this.gbgenerar.Controls.Add(this.pbruta);
            this.gbgenerar.Controls.Add(this.lbldetalle);
            this.gbgenerar.Controls.Add(this.txtdetalle);
            this.gbgenerar.Controls.Add(this.label7);
            this.gbgenerar.Controls.Add(this.btnCalcular);
            this.gbgenerar.Controls.Add(this.cbxfilamento);
            this.gbgenerar.Controls.Add(this.lbltipo);
            this.gbgenerar.Controls.Add(this.txtgramos);
            this.gbgenerar.Controls.Add(this.lblgramos);
            this.gbgenerar.Controls.Add(this.txttiempo);
            this.gbgenerar.Controls.Add(this.lbltiempo);
            this.gbgenerar.Controls.Add(this.lblruta);
            this.gbgenerar.Controls.Add(this.txtruta);
            this.gbgenerar.Location = new System.Drawing.Point(16, 15);
            this.gbgenerar.Margin = new System.Windows.Forms.Padding(4);
            this.gbgenerar.Name = "gbgenerar";
            this.gbgenerar.Padding = new System.Windows.Forms.Padding(4);
            this.gbgenerar.Size = new System.Drawing.Size(420, 242);
            this.gbgenerar.TabIndex = 2;
            this.gbgenerar.TabStop = false;
            this.gbgenerar.Text = "Generar Cotizacion";
            // 
            // pbruta
            // 
            this.pbruta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbruta.Image = ((System.Drawing.Image)(resources.GetObject("pbruta.Image")));
            this.pbruta.Location = new System.Drawing.Point(374, 31);
            this.pbruta.Margin = new System.Windows.Forms.Padding(4);
            this.pbruta.Name = "pbruta";
            this.pbruta.Size = new System.Drawing.Size(36, 25);
            this.pbruta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbruta.TabIndex = 14;
            this.pbruta.TabStop = false;
            this.toolTip1.SetToolTip(this.pbruta, "Seleccione el archivo");
            this.pbruta.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbldetalle
            // 
            this.lbldetalle.AutoSize = true;
            this.lbldetalle.Location = new System.Drawing.Point(8, 69);
            this.lbldetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldetalle.Name = "lbldetalle";
            this.lbldetalle.Size = new System.Drawing.Size(51, 16);
            this.lbldetalle.TabIndex = 13;
            this.lbldetalle.Text = "Detalle";
            // 
            // txtdetalle
            // 
            this.txtdetalle.Location = new System.Drawing.Point(164, 65);
            this.txtdetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtdetalle.Name = "txtdetalle";
            this.txtdetalle.Size = new System.Drawing.Size(203, 22);
            this.txtdetalle.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(204, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Minutos";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(8, 207);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(404, 28);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular Cotizacion";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cbxfilamento
            // 
            this.cbxfilamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxfilamento.FormattingEnabled = true;
            this.cbxfilamento.Items.AddRange(new object[] {
            "PLA",
            "ABS",
            "FLEX"});
            this.cbxfilamento.Location = new System.Drawing.Point(164, 161);
            this.cbxfilamento.Margin = new System.Windows.Forms.Padding(4);
            this.cbxfilamento.Name = "cbxfilamento";
            this.cbxfilamento.Size = new System.Drawing.Size(119, 24);
            this.cbxfilamento.TabIndex = 9;
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(8, 165);
            this.lbltipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(98, 16);
            this.lbltipo.TabIndex = 8;
            this.lbltipo.Text = "Tipo Filamento";
            // 
            // txtgramos
            // 
            this.txtgramos.Location = new System.Drawing.Point(164, 129);
            this.txtgramos.Margin = new System.Windows.Forms.Padding(4);
            this.txtgramos.Name = "txtgramos";
            this.txtgramos.Size = new System.Drawing.Size(119, 22);
            this.txtgramos.TabIndex = 6;
            // 
            // lblgramos
            // 
            this.lblgramos.AutoSize = true;
            this.lblgramos.Location = new System.Drawing.Point(8, 133);
            this.lblgramos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgramos.Name = "lblgramos";
            this.lblgramos.Size = new System.Drawing.Size(137, 16);
            this.lblgramos.TabIndex = 5;
            this.lblgramos.Text = "Gramos de Filamento";
            // 
            // txttiempo
            // 
            this.txttiempo.Location = new System.Drawing.Point(164, 97);
            this.txttiempo.Margin = new System.Windows.Forms.Padding(4);
            this.txttiempo.MaxLength = 3;
            this.txttiempo.Name = "txttiempo";
            this.txttiempo.Size = new System.Drawing.Size(100, 22);
            this.txttiempo.TabIndex = 4;
            // 
            // lbltiempo
            // 
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.Location = new System.Drawing.Point(8, 101);
            this.lbltiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(136, 16);
            this.lbltiempo.TabIndex = 3;
            this.lbltiempo.Text = "Tiempo de impresion";
            // 
            // lbltotalc
            // 
            this.lbltotalc.AutoSize = true;
            this.lbltotalc.Location = new System.Drawing.Point(8, 38);
            this.lbltotalc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotalc.Name = "lbltotalc";
            this.lbltotalc.Size = new System.Drawing.Size(104, 16);
            this.lbltotalc.TabIndex = 3;
            this.lbltotalc.Text = "Total Cotizacion";
            // 
            // gbcotizacion
            // 
            this.gbcotizacion.Controls.Add(this.lblTotal);
            this.gbcotizacion.Controls.Add(this.cbClientes);
            this.gbcotizacion.Controls.Add(this.lblcliente);
            this.gbcotizacion.Controls.Add(this.label8);
            this.gbcotizacion.Controls.Add(this.lbltotalc);
            this.gbcotizacion.Location = new System.Drawing.Point(16, 265);
            this.gbcotizacion.Margin = new System.Windows.Forms.Padding(4);
            this.gbcotizacion.Name = "gbcotizacion";
            this.gbcotizacion.Padding = new System.Windows.Forms.Padding(4);
            this.gbcotizacion.Size = new System.Drawing.Size(420, 118);
            this.gbcotizacion.TabIndex = 4;
            this.gbcotizacion.TabStop = false;
            this.gbcotizacion.Text = "Cotizacion";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(172, 38);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(15, 16);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "0";
            this.lblTotal.TextChanged += new System.EventHandler(this.lblTotal_TextChanged);
            // 
            // cbClientes
            // 
            this.cbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Items.AddRange(new object[] {
            "Santiago Lopez"});
            this.cbClientes.Location = new System.Drawing.Point(164, 69);
            this.cbClientes.Margin = new System.Windows.Forms.Padding(4);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(160, 24);
            this.cbClientes.TabIndex = 7;
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblcliente.Location = new System.Drawing.Point(8, 72);
            this.lblcliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(49, 16);
            this.lblcliente.TabIndex = 6;
            this.lblcliente.Text = "Cliente";
            this.toolTip1.SetToolTip(this.lblcliente, "Seleccione el cliente");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "$";
            // 
            // btnaceptar
            // 
            this.btnaceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnaceptar.Enabled = false;
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.ForeColor = System.Drawing.Color.White;
            this.btnaceptar.Location = new System.Drawing.Point(16, 390);
            this.btnaceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(192, 28);
            this.btnaceptar.TabIndex = 5;
            this.btnaceptar.Text = "Aceptar Cotizacion";
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(16, 426);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(420, 28);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnguardar.Enabled = false;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Location = new System.Drawing.Point(244, 390);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(192, 28);
            this.btnguardar.TabIndex = 7;
            this.btnguardar.Text = "Guardar Cotizacion";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Nueva_Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(452, 462);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.gbcotizacion);
            this.Controls.Add(this.gbgenerar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Nueva_Cotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva Cotizacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Nueva_Cotizacion_FormClosing);
            this.Load += new System.EventHandler(this.Nueva_Cotizacion_Load);
            this.gbgenerar.ResumeLayout(false);
            this.gbgenerar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbruta)).EndInit();
            this.gbcotizacion.ResumeLayout(false);
            this.gbcotizacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.Label lblruta;
        private System.Windows.Forms.GroupBox gbgenerar;
        private System.Windows.Forms.TextBox txttiempo;
        private System.Windows.Forms.Label lbltiempo;
        private System.Windows.Forms.TextBox txtgramos;
        private System.Windows.Forms.Label lblgramos;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cbxfilamento;
        private System.Windows.Forms.Label lbltotalc;
        private System.Windows.Forms.GroupBox gbcotizacion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label lbldetalle;
        private System.Windows.Forms.TextBox txtdetalle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbruta;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}