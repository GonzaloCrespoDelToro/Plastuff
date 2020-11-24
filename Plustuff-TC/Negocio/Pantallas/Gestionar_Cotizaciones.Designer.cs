namespace Plustuff_TC.Negocio.Pantallas
{
    partial class Gestionar_Cotizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestionar_Cotizaciones));
            this.Cotizaciones = new System.Windows.Forms.GroupBox();
            this.GridViewCotizaciones = new System.Windows.Forms.DataGridView();
            this.Filtro = new System.Windows.Forms.GroupBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.txtCotizacion = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.rbCotiID = new System.Windows.Forms.RadioButton();
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.Cotizaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCotizaciones)).BeginInit();
            this.Filtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cotizaciones
            // 
            this.Cotizaciones.Controls.Add(this.GridViewCotizaciones);
            this.Cotizaciones.Controls.Add(this.Filtro);
            this.Cotizaciones.Location = new System.Drawing.Point(12, 12);
            this.Cotizaciones.Name = "Cotizaciones";
            this.Cotizaciones.Size = new System.Drawing.Size(448, 436);
            this.Cotizaciones.TabIndex = 0;
            this.Cotizaciones.TabStop = false;
            this.Cotizaciones.Text = "Cotizaciones";
            this.Cotizaciones.Enter += new System.EventHandler(this.Cotizaciones_Enter);
            // 
            // GridViewCotizaciones
            // 
            this.GridViewCotizaciones.AllowUserToAddRows = false;
            this.GridViewCotizaciones.AllowUserToDeleteRows = false;
            this.GridViewCotizaciones.AllowUserToOrderColumns = true;
            this.GridViewCotizaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridViewCotizaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridViewCotizaciones.BackgroundColor = System.Drawing.Color.White;
            this.GridViewCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCotizaciones.Location = new System.Drawing.Point(6, 106);
            this.GridViewCotizaciones.Margin = new System.Windows.Forms.Padding(5);
            this.GridViewCotizaciones.Name = "GridViewCotizaciones";
            this.GridViewCotizaciones.ReadOnly = true;
            this.GridViewCotizaciones.Size = new System.Drawing.Size(436, 322);
            this.GridViewCotizaciones.TabIndex = 1;
            // 
            // Filtro
            // 
            this.Filtro.Controls.Add(this.btnlimpiar);
            this.Filtro.Controls.Add(this.btnfiltrar);
            this.Filtro.Controls.Add(this.txtCotizacion);
            this.Filtro.Controls.Add(this.txtDNI);
            this.Filtro.Controls.Add(this.rbCotiID);
            this.Filtro.Controls.Add(this.rbDNI);
            this.Filtro.Location = new System.Drawing.Point(6, 21);
            this.Filtro.Name = "Filtro";
            this.Filtro.Size = new System.Drawing.Size(436, 80);
            this.Filtro.TabIndex = 0;
            this.Filtro.TabStop = false;
            this.Filtro.Text = "Filtro";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar.Location = new System.Drawing.Point(347, 27);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(83, 36);
            this.btnlimpiar.TabIndex = 4;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnfiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfiltrar.ForeColor = System.Drawing.Color.White;
            this.btnfiltrar.Location = new System.Drawing.Point(258, 27);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(83, 36);
            this.btnfiltrar.TabIndex = 1;
            this.btnfiltrar.Text = "Filtrar";
            this.btnfiltrar.UseVisualStyleBackColor = false;
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            // 
            // txtCotizacion
            // 
            this.txtCotizacion.Location = new System.Drawing.Point(115, 46);
            this.txtCotizacion.Name = "txtCotizacion";
            this.txtCotizacion.Size = new System.Drawing.Size(137, 22);
            this.txtCotizacion.TabIndex = 3;
            this.txtCotizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCotizacion_KeyPress);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(115, 20);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(137, 22);
            this.txtDNI.TabIndex = 2;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // rbCotiID
            // 
            this.rbCotiID.AutoSize = true;
            this.rbCotiID.Location = new System.Drawing.Point(6, 47);
            this.rbCotiID.Name = "rbCotiID";
            this.rbCotiID.Size = new System.Drawing.Size(104, 20);
            this.rbCotiID.TabIndex = 1;
            this.rbCotiID.TabStop = true;
            this.rbCotiID.Text = "Cotizacion ID";
            this.rbCotiID.UseVisualStyleBackColor = true;
            this.rbCotiID.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbDNI
            // 
            this.rbDNI.AutoSize = true;
            this.rbDNI.Location = new System.Drawing.Point(6, 21);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(49, 20);
            this.rbDNI.TabIndex = 0;
            this.rbDNI.TabStop = true;
            this.rbDNI.Text = "DNI";
            this.rbDNI.UseVisualStyleBackColor = true;
            this.rbDNI.CheckedChanged += new System.EventHandler(this.DNI_CheckedChanged);
            // 
            // btnaceptar
            // 
            this.btnaceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.ForeColor = System.Drawing.Color.White;
            this.btnaceptar.Location = new System.Drawing.Point(12, 454);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(186, 31);
            this.btnaceptar.TabIndex = 1;
            this.btnaceptar.Text = "Aceptar Cotizacion";
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(12, 491);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(448, 31);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.ForeColor = System.Drawing.Color.White;
            this.btnmodificar.Location = new System.Drawing.Point(274, 454);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(186, 31);
            this.btnmodificar.TabIndex = 3;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // Gestionar_Cotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(471, 527);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.Cotizaciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Gestionar_Cotizaciones";
            this.Text = "Gestionar Cotizaciones";
            this.Load += new System.EventHandler(this.Gestionar_Cotizaciones_Load);
            this.Cotizaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCotizaciones)).EndInit();
            this.Filtro.ResumeLayout(false);
            this.Filtro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Cotizaciones;
        private System.Windows.Forms.GroupBox Filtro;
        private System.Windows.Forms.Button btnfiltrar;
        private System.Windows.Forms.TextBox txtCotizacion;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.RadioButton rbCotiID;
        private System.Windows.Forms.RadioButton rbDNI;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridView GridViewCotizaciones;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnmodificar;
    }
}