namespace Plustuff_TC.Seguridad.Pantallas.Usuario
{
    partial class Mostrar_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mostrar_Usuario));
            this.gbfiltro = new System.Windows.Forms.GroupBox();
            this.btnclean = new System.Windows.Forms.Button();
            this.lblfiltro = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtfilter = new System.Windows.Forms.TextBox();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gbusuarios = new System.Windows.Forms.GroupBox();
            this.GridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.btndesbloquear = new System.Windows.Forms.Button();
            this.gbfiltro.SuspendLayout();
            this.gbusuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsuarios)).BeginInit();
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
            this.gbfiltro.TabIndex = 13;
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
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
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
            this.btncerrar.Location = new System.Drawing.Point(12, 483);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(377, 26);
            this.btncerrar.TabIndex = 12;
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
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(12, 451);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 26);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // gbusuarios
            // 
            this.gbusuarios.Controls.Add(this.GridViewUsuarios);
            this.gbusuarios.Location = new System.Drawing.Point(12, 82);
            this.gbusuarios.Margin = new System.Windows.Forms.Padding(4);
            this.gbusuarios.Name = "gbusuarios";
            this.gbusuarios.Padding = new System.Windows.Forms.Padding(4);
            this.gbusuarios.Size = new System.Drawing.Size(376, 362);
            this.gbusuarios.TabIndex = 9;
            this.gbusuarios.TabStop = false;
            this.gbusuarios.Text = "Usuarios";
            // 
            // GridViewUsuarios
            // 
            this.GridViewUsuarios.AllowUserToAddRows = false;
            this.GridViewUsuarios.AllowUserToDeleteRows = false;
            this.GridViewUsuarios.AllowUserToOrderColumns = true;
            this.GridViewUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridViewUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridViewUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.GridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewUsuarios.Location = new System.Drawing.Point(8, 21);
            this.GridViewUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.GridViewUsuarios.Name = "GridViewUsuarios";
            this.GridViewUsuarios.ReadOnly = true;
            this.GridViewUsuarios.Size = new System.Drawing.Size(360, 333);
            this.GridViewUsuarios.TabIndex = 0;
            this.GridViewUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewUsuarios_CellContentClick);
            // 
            // btndesbloquear
            // 
            this.btndesbloquear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btndesbloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndesbloquear.ForeColor = System.Drawing.Color.White;
            this.btndesbloquear.Location = new System.Drawing.Point(278, 451);
            this.btndesbloquear.Name = "btndesbloquear";
            this.btndesbloquear.Size = new System.Drawing.Size(111, 26);
            this.btndesbloquear.TabIndex = 14;
            this.btndesbloquear.Text = "Desbloquear";
            this.btndesbloquear.UseVisualStyleBackColor = false;
            this.btndesbloquear.Click += new System.EventHandler(this.btndesbloquear_Click);
            // 
            // Mostrar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 517);
            this.Controls.Add(this.btndesbloquear);
            this.Controls.Add(this.gbfiltro);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.gbusuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Mostrar_Usuario";
            this.Text = "Mostrar Usuarios";
            this.Load += new System.EventHandler(this.Mostrar_Usuario_Load);
            this.gbfiltro.ResumeLayout(false);
            this.gbfiltro.PerformLayout();
            this.gbusuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsuarios)).EndInit();
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
        private System.Windows.Forms.GroupBox gbusuarios;
        private System.Windows.Forms.DataGridView GridViewUsuarios;
        private System.Windows.Forms.Button btndesbloquear;
    }
}