namespace Plustuff_TC.LogIn
{
    partial class Error_Base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error_Base));
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            this.gbbitacora = new System.Windows.Forms.GroupBox();
            this.btnRecalcular = new System.Windows.Forms.Button();
            this.btnrestore = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.gbfiltro = new System.Windows.Forms.GroupBox();
            this.txttexto = new System.Windows.Forms.TextBox();
            this.rbtexto = new System.Windows.Forms.RadioButton();
            this.btnclean = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.cmbCriticidad = new System.Windows.Forms.ComboBox();
            this.rbCriticidad = new System.Windows.Forms.RadioButton();
            this.rbFecha = new System.Windows.Forms.RadioButton();
            this.lblhasta = new System.Windows.Forms.Label();
            this.lbldesde = new System.Windows.Forms.Label();
            this.dtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtFechaDesde = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            this.gbbitacora.SuspendLayout();
            this.gbfiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.AllowUserToAddRows = false;
            this.dgvBitacora.AllowUserToDeleteRows = false;
            this.dgvBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBitacora.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBitacora.BackgroundColor = System.Drawing.Color.White;
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacora.Location = new System.Drawing.Point(6, 19);
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.ReadOnly = true;
            this.dgvBitacora.Size = new System.Drawing.Size(544, 350);
            this.dgvBitacora.TabIndex = 0;
            // 
            // gbbitacora
            // 
            this.gbbitacora.Controls.Add(this.dgvBitacora);
            this.gbbitacora.Location = new System.Drawing.Point(12, 129);
            this.gbbitacora.Name = "gbbitacora";
            this.gbbitacora.Size = new System.Drawing.Size(556, 375);
            this.gbbitacora.TabIndex = 1;
            this.gbbitacora.TabStop = false;
            this.gbbitacora.Text = "Bitacora";
            // 
            // btnRecalcular
            // 
            this.btnRecalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnRecalcular.Enabled = false;
            this.btnRecalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecalcular.ForeColor = System.Drawing.Color.White;
            this.btnRecalcular.Location = new System.Drawing.Point(12, 510);
            this.btnRecalcular.Name = "btnRecalcular";
            this.btnRecalcular.Size = new System.Drawing.Size(212, 23);
            this.btnRecalcular.TabIndex = 2;
            this.btnRecalcular.Text = "Recalcular Digitos";
            this.btnRecalcular.UseVisualStyleBackColor = false;
            this.btnRecalcular.Click += new System.EventHandler(this.btnRecalcular_Click);
            // 
            // btnrestore
            // 
            this.btnrestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnrestore.Enabled = false;
            this.btnrestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrestore.ForeColor = System.Drawing.Color.White;
            this.btnrestore.Location = new System.Drawing.Point(358, 510);
            this.btnrestore.Name = "btnrestore";
            this.btnrestore.Size = new System.Drawing.Size(210, 23);
            this.btnrestore.TabIndex = 3;
            this.btnrestore.Text = "Realizar restore";
            this.btnrestore.UseVisualStyleBackColor = false;
            this.btnrestore.Click += new System.EventHandler(this.button2_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(12, 539);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(556, 23);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbfiltro
            // 
            this.gbfiltro.Controls.Add(this.txttexto);
            this.gbfiltro.Controls.Add(this.rbtexto);
            this.gbfiltro.Controls.Add(this.btnclean);
            this.gbfiltro.Controls.Add(this.btnbuscar);
            this.gbfiltro.Controls.Add(this.cmbCriticidad);
            this.gbfiltro.Controls.Add(this.rbCriticidad);
            this.gbfiltro.Controls.Add(this.rbFecha);
            this.gbfiltro.Controls.Add(this.lblhasta);
            this.gbfiltro.Controls.Add(this.lbldesde);
            this.gbfiltro.Controls.Add(this.dtFechaHasta);
            this.gbfiltro.Controls.Add(this.dtFechaDesde);
            this.gbfiltro.Location = new System.Drawing.Point(12, 12);
            this.gbfiltro.Name = "gbfiltro";
            this.gbfiltro.Size = new System.Drawing.Size(556, 111);
            this.gbfiltro.TabIndex = 9;
            this.gbfiltro.TabStop = false;
            this.gbfiltro.Text = "Filtro";
            // 
            // txttexto
            // 
            this.txttexto.Location = new System.Drawing.Point(139, 77);
            this.txttexto.Name = "txttexto";
            this.txttexto.Size = new System.Drawing.Size(159, 20);
            this.txttexto.TabIndex = 24;
            // 
            // rbtexto
            // 
            this.rbtexto.AutoSize = true;
            this.rbtexto.Location = new System.Drawing.Point(6, 78);
            this.rbtexto.Name = "rbtexto";
            this.rbtexto.Size = new System.Drawing.Size(52, 17);
            this.rbtexto.TabIndex = 23;
            this.rbtexto.TabStop = true;
            this.rbtexto.Text = "Texto";
            this.rbtexto.UseVisualStyleBackColor = true;
            this.rbtexto.CheckedChanged += new System.EventHandler(this.rbtexto_CheckedChanged);
            // 
            // btnclean
            // 
            this.btnclean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnclean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclean.ForeColor = System.Drawing.Color.White;
            this.btnclean.Location = new System.Drawing.Point(472, 46);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(78, 26);
            this.btnclean.TabIndex = 10;
            this.btnclean.Text = "Limpiar";
            this.btnclean.UseVisualStyleBackColor = false;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(388, 45);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(78, 26);
            this.btnbuscar.TabIndex = 9;
            this.btnbuscar.Text = "Filtrar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // cmbCriticidad
            // 
            this.cmbCriticidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriticidad.FormattingEnabled = true;
            this.cmbCriticidad.Location = new System.Drawing.Point(139, 50);
            this.cmbCriticidad.Name = "cmbCriticidad";
            this.cmbCriticidad.Size = new System.Drawing.Size(105, 21);
            this.cmbCriticidad.TabIndex = 22;
            // 
            // rbCriticidad
            // 
            this.rbCriticidad.AutoSize = true;
            this.rbCriticidad.Location = new System.Drawing.Point(6, 51);
            this.rbCriticidad.Name = "rbCriticidad";
            this.rbCriticidad.Size = new System.Drawing.Size(68, 17);
            this.rbCriticidad.TabIndex = 21;
            this.rbCriticidad.TabStop = true;
            this.rbCriticidad.Text = "Criticidad";
            this.rbCriticidad.UseVisualStyleBackColor = true;
            this.rbCriticidad.CheckedChanged += new System.EventHandler(this.rbCriticidad_CheckedChanged);
            // 
            // rbFecha
            // 
            this.rbFecha.AutoSize = true;
            this.rbFecha.Location = new System.Drawing.Point(6, 26);
            this.rbFecha.Name = "rbFecha";
            this.rbFecha.Size = new System.Drawing.Size(55, 17);
            this.rbFecha.TabIndex = 20;
            this.rbFecha.TabStop = true;
            this.rbFecha.Text = "Fecha";
            this.rbFecha.UseVisualStyleBackColor = true;
            this.rbFecha.CheckedChanged += new System.EventHandler(this.rbFecha_CheckedChanged);
            // 
            // lblhasta
            // 
            this.lblhasta.AutoSize = true;
            this.lblhasta.Location = new System.Drawing.Point(240, 28);
            this.lblhasta.Name = "lblhasta";
            this.lblhasta.Size = new System.Drawing.Size(35, 13);
            this.lblhasta.TabIndex = 2;
            this.lblhasta.Text = "Hasta";
            // 
            // lbldesde
            // 
            this.lbldesde.AutoSize = true;
            this.lbldesde.Location = new System.Drawing.Point(95, 27);
            this.lbldesde.Name = "lbldesde";
            this.lbldesde.Size = new System.Drawing.Size(38, 13);
            this.lbldesde.TabIndex = 1;
            this.lbldesde.Text = "Desde";
            this.lbldesde.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaHasta.Location = new System.Drawing.Point(281, 25);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Size = new System.Drawing.Size(97, 20);
            this.dtFechaHasta.TabIndex = 18;
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaDesde.Location = new System.Drawing.Point(139, 24);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Size = new System.Drawing.Size(95, 20);
            this.dtFechaDesde.TabIndex = 17;
            // 
            // Error_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 569);
            this.Controls.Add(this.gbfiltro);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnrestore);
            this.Controls.Add(this.btnRecalcular);
            this.Controls.Add(this.gbbitacora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Error_Base";
            this.Text = "Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Error_Base_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Error_Base_FormClosed);
            this.Load += new System.EventHandler(this.Error_Base_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            this.gbbitacora.ResumeLayout(false);
            this.gbfiltro.ResumeLayout(false);
            this.gbfiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.Windows.Forms.GroupBox gbbitacora;
        private System.Windows.Forms.Button btnRecalcular;
        private System.Windows.Forms.Button btnrestore;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.GroupBox gbfiltro;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblhasta;
        private System.Windows.Forms.Label lbldesde;
        private System.Windows.Forms.DateTimePicker dtFechaHasta;
        private System.Windows.Forms.DateTimePicker dtFechaDesde;
        private System.Windows.Forms.RadioButton rbCriticidad;
        private System.Windows.Forms.RadioButton rbFecha;
        private System.Windows.Forms.TextBox txttexto;
        private System.Windows.Forms.RadioButton rbtexto;
        private System.Windows.Forms.ComboBox cmbCriticidad;
    }
}