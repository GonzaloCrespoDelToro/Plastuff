namespace Plustuff_TC.Negocio.Pantallas
{
    partial class Mostrar_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mostrar_Clientes));
            this.gbfiltro = new System.Windows.Forms.GroupBox();
            this.btnclean = new System.Windows.Forms.Button();
            this.lblfiltro = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtfilter = new System.Windows.Forms.TextBox();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gbclientes = new System.Windows.Forms.GroupBox();
            this.GridViewClientes = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbfiltro.SuspendLayout();
            this.gbclientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbfiltro
            // 
            this.gbfiltro.Controls.Add(this.btnclean);
            this.gbfiltro.Controls.Add(this.lblfiltro);
            this.gbfiltro.Controls.Add(this.btnbuscar);
            this.gbfiltro.Controls.Add(this.txtfilter);
            this.gbfiltro.Location = new System.Drawing.Point(16, 15);
            this.gbfiltro.Margin = new System.Windows.Forms.Padding(4);
            this.gbfiltro.Name = "gbfiltro";
            this.gbfiltro.Padding = new System.Windows.Forms.Padding(4);
            this.gbfiltro.Size = new System.Drawing.Size(503, 78);
            this.gbfiltro.TabIndex = 18;
            this.gbfiltro.TabStop = false;
            this.gbfiltro.Text = "Filtro";
            this.gbfiltro.Enter += new System.EventHandler(this.gbfiltro_Enter);
            // 
            // btnclean
            // 
            this.btnclean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnclean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclean.ForeColor = System.Drawing.Color.White;
            this.btnclean.Location = new System.Drawing.Point(387, 26);
            this.btnclean.Margin = new System.Windows.Forms.Padding(4);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(104, 32);
            this.btnclean.TabIndex = 10;
            this.btnclean.Text = "Limpiar";
            this.btnclean.UseVisualStyleBackColor = false;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // lblfiltro
            // 
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.Location = new System.Drawing.Point(8, 34);
            this.lblfiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(41, 16);
            this.lblfiltro.TabIndex = 1;
            this.lblfiltro.Text = "Filtrar";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(275, 26);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(104, 32);
            this.btnbuscar.TabIndex = 9;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // txtfilter
            // 
            this.txtfilter.Location = new System.Drawing.Point(71, 31);
            this.txtfilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtfilter.Name = "txtfilter";
            this.txtfilter.Size = new System.Drawing.Size(195, 22);
            this.txtfilter.TabIndex = 9;
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.ForeColor = System.Drawing.Color.White;
            this.btncerrar.Location = new System.Drawing.Point(369, 555);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(148, 32);
            this.btncerrar.TabIndex = 17;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.ForeColor = System.Drawing.Color.White;
            this.btnBaja.Location = new System.Drawing.Point(195, 555);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(148, 32);
            this.btnBaja.TabIndex = 16;
            this.btnBaja.Text = "Baja";
            this.toolTip1.SetToolTip(this.btnBaja, "Da de baja al cliente selecionado");
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(16, 555);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(148, 32);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // gbclientes
            // 
            this.gbclientes.Controls.Add(this.GridViewClientes);
            this.gbclientes.Location = new System.Drawing.Point(16, 101);
            this.gbclientes.Margin = new System.Windows.Forms.Padding(5);
            this.gbclientes.Name = "gbclientes";
            this.gbclientes.Padding = new System.Windows.Forms.Padding(5);
            this.gbclientes.Size = new System.Drawing.Size(501, 446);
            this.gbclientes.TabIndex = 14;
            this.gbclientes.TabStop = false;
            this.gbclientes.Text = "Clientes";
            this.gbclientes.Enter += new System.EventHandler(this.gbclientes_Enter);
            // 
            // GridViewClientes
            // 
            this.GridViewClientes.AllowUserToAddRows = false;
            this.GridViewClientes.AllowUserToDeleteRows = false;
            this.GridViewClientes.AllowUserToOrderColumns = true;
            this.GridViewClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridViewClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridViewClientes.BackgroundColor = System.Drawing.Color.White;
            this.GridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewClientes.Location = new System.Drawing.Point(11, 26);
            this.GridViewClientes.Margin = new System.Windows.Forms.Padding(5);
            this.GridViewClientes.Name = "GridViewClientes";
            this.GridViewClientes.ReadOnly = true;
            this.GridViewClientes.Size = new System.Drawing.Size(480, 410);
            this.GridViewClientes.TabIndex = 0;
            // 
            // Mostrar_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 593);
            this.Controls.Add(this.gbfiltro);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.gbclientes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Mostrar_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mostrar Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mostrar_Clientes_FormClosing);
            this.Load += new System.EventHandler(this.Mostrar_Clientes_Load);
            this.gbfiltro.ResumeLayout(false);
            this.gbfiltro.PerformLayout();
            this.gbclientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbfiltro;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.Label lblfiltro;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtfilter;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox gbclientes;
        private System.Windows.Forms.DataGridView GridViewClientes;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}