namespace Plustuff_TC.Negocio.Pantallas
{
    partial class Gestionar_Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestionar_Pedidos));
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.gbPedidos = new System.Windows.Forms.GroupBox();
            this.GridViewPedidos = new System.Windows.Forms.DataGridView();
            this.Filtro = new System.Windows.Forms.GroupBox();
            this.cbestados = new System.Windows.Forms.ComboBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.rbEstado = new System.Windows.Forms.RadioButton();
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.gbPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPedidos)).BeginInit();
            this.Filtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(300, 454);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(160, 31);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.ForeColor = System.Drawing.Color.White;
            this.btnmodificar.Location = new System.Drawing.Point(12, 454);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(160, 31);
            this.btnmodificar.TabIndex = 4;
            this.btnmodificar.Text = "Modificar Estado";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // gbPedidos
            // 
            this.gbPedidos.Controls.Add(this.GridViewPedidos);
            this.gbPedidos.Controls.Add(this.Filtro);
            this.gbPedidos.Location = new System.Drawing.Point(12, 12);
            this.gbPedidos.Name = "gbPedidos";
            this.gbPedidos.Size = new System.Drawing.Size(448, 436);
            this.gbPedidos.TabIndex = 3;
            this.gbPedidos.TabStop = false;
            this.gbPedidos.Text = "Pedidos";
            // 
            // GridViewPedidos
            // 
            this.GridViewPedidos.AllowUserToAddRows = false;
            this.GridViewPedidos.AllowUserToDeleteRows = false;
            this.GridViewPedidos.AllowUserToOrderColumns = true;
            this.GridViewPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridViewPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridViewPedidos.BackgroundColor = System.Drawing.Color.White;
            this.GridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewPedidos.Location = new System.Drawing.Point(6, 106);
            this.GridViewPedidos.Margin = new System.Windows.Forms.Padding(5);
            this.GridViewPedidos.Name = "GridViewPedidos";
            this.GridViewPedidos.ReadOnly = true;
            this.GridViewPedidos.Size = new System.Drawing.Size(436, 322);
            this.GridViewPedidos.TabIndex = 1;
            // 
            // Filtro
            // 
            this.Filtro.Controls.Add(this.cbestados);
            this.Filtro.Controls.Add(this.btnlimpiar);
            this.Filtro.Controls.Add(this.btnfiltrar);
            this.Filtro.Controls.Add(this.txtDNI);
            this.Filtro.Controls.Add(this.rbEstado);
            this.Filtro.Controls.Add(this.rbDNI);
            this.Filtro.Location = new System.Drawing.Point(6, 21);
            this.Filtro.Name = "Filtro";
            this.Filtro.Size = new System.Drawing.Size(436, 80);
            this.Filtro.TabIndex = 0;
            this.Filtro.TabStop = false;
            this.Filtro.Text = "Filtro";
            // 
            // cbestados
            // 
            this.cbestados.FormattingEnabled = true;
            this.cbestados.Location = new System.Drawing.Point(115, 46);
            this.cbestados.Name = "cbestados";
            this.cbestados.Size = new System.Drawing.Size(121, 24);
            this.cbestados.TabIndex = 5;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar.Location = new System.Drawing.Point(347, 31);
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
            this.btnfiltrar.Location = new System.Drawing.Point(258, 31);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(83, 36);
            this.btnfiltrar.TabIndex = 1;
            this.btnfiltrar.Text = "Filtrar";
            this.btnfiltrar.UseVisualStyleBackColor = false;
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(115, 20);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(121, 22);
            this.txtDNI.TabIndex = 2;
            // 
            // rbEstado
            // 
            this.rbEstado.AutoSize = true;
            this.rbEstado.Location = new System.Drawing.Point(6, 47);
            this.rbEstado.Name = "rbEstado";
            this.rbEstado.Size = new System.Drawing.Size(69, 20);
            this.rbEstado.TabIndex = 1;
            this.rbEstado.TabStop = true;
            this.rbEstado.Text = "Estado";
            this.rbEstado.UseVisualStyleBackColor = true;
            this.rbEstado.CheckedChanged += new System.EventHandler(this.rbEstado_CheckedChanged);
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
            this.rbDNI.CheckedChanged += new System.EventHandler(this.rbDNI_CheckedChanged);
            // 
            // Gestionar_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(471, 495);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.gbPedidos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Gestionar_Pedidos";
            this.Text = "Gestionar Pedidos";
            this.Load += new System.EventHandler(this.Gestionar_Pedidos_Load);
            this.gbPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPedidos)).EndInit();
            this.Filtro.ResumeLayout(false);
            this.Filtro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.GroupBox gbPedidos;
        private System.Windows.Forms.DataGridView GridViewPedidos;
        private System.Windows.Forms.GroupBox Filtro;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnfiltrar;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.RadioButton rbEstado;
        private System.Windows.Forms.RadioButton rbDNI;
        private System.Windows.Forms.ComboBox cbestados;
    }
}