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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mostrar_Clientes));
            this.gbfiltro = new System.Windows.Forms.GroupBox();
            this.btnclean = new System.Windows.Forms.Button();
            this.lblfiltro = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtfilter = new System.Windows.Forms.TextBox();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gbclientes = new System.Windows.Forms.GroupBox();
            this.GridViewClientes = new System.Windows.Forms.DataGridView();
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
            this.gbfiltro.Location = new System.Drawing.Point(12, 12);
            this.gbfiltro.Name = "gbfiltro";
            this.gbfiltro.Size = new System.Drawing.Size(377, 63);
            this.gbfiltro.TabIndex = 18;
            this.gbfiltro.TabStop = false;
            this.gbfiltro.Text = "Filtro";
            // 
            // btnclean
            // 
            this.btnclean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnclean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclean.ForeColor = System.Drawing.Color.White;
            this.btnclean.Location = new System.Drawing.Point(290, 21);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(78, 26);
            this.btnclean.TabIndex = 10;
            this.btnclean.Text = "Limpiar";
            this.btnclean.UseVisualStyleBackColor = false;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // lblfiltro
            // 
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.Location = new System.Drawing.Point(6, 28);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(32, 13);
            this.lblfiltro.TabIndex = 1;
            this.lblfiltro.Text = "Filtrar";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(206, 21);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(78, 26);
            this.btnbuscar.TabIndex = 9;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // txtfilter
            // 
            this.txtfilter.Location = new System.Drawing.Point(53, 25);
            this.txtfilter.Name = "txtfilter";
            this.txtfilter.Size = new System.Drawing.Size(147, 20);
            this.txtfilter.TabIndex = 9;
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.ForeColor = System.Drawing.Color.White;
            this.btncerrar.Location = new System.Drawing.Point(278, 451);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(111, 26);
            this.btncerrar.TabIndex = 17;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(146, 451);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(111, 26);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(12, 451);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 26);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // gbclientes
            // 
            this.gbclientes.Controls.Add(this.GridViewClientes);
            this.gbclientes.Location = new System.Drawing.Point(12, 82);
            this.gbclientes.Margin = new System.Windows.Forms.Padding(4);
            this.gbclientes.Name = "gbclientes";
            this.gbclientes.Padding = new System.Windows.Forms.Padding(4);
            this.gbclientes.Size = new System.Drawing.Size(376, 362);
            this.gbclientes.TabIndex = 14;
            this.gbclientes.TabStop = false;
            this.gbclientes.Text = "Clientes";
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
            this.GridViewClientes.Location = new System.Drawing.Point(8, 21);
            this.GridViewClientes.Margin = new System.Windows.Forms.Padding(4);
            this.GridViewClientes.Name = "GridViewClientes";
            this.GridViewClientes.ReadOnly = true;
            this.GridViewClientes.Size = new System.Drawing.Size(360, 333);
            this.GridViewClientes.TabIndex = 0;
            // 
            // Mostrar_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 482);
            this.Controls.Add(this.gbfiltro);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.gbclientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Mostrar_Clientes";
            this.Text = "Mostrar Clientes";
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
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox gbclientes;
        private System.Windows.Forms.DataGridView GridViewClientes;
    }
}