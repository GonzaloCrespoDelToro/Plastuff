namespace Plustuff_TC.Negocio.Empleado
{
    partial class Mostrar_Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mostrar_Empleados));
            this.gbemp = new System.Windows.Forms.GroupBox();
            this.GridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.gbfiltro = new System.Windows.Forms.GroupBox();
            this.btnclean = new System.Windows.Forms.Button();
            this.lblfiltro = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtfilter = new System.Windows.Forms.TextBox();
            this.gbemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEmpleados)).BeginInit();
            this.gbfiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbemp
            // 
            this.gbemp.Controls.Add(this.GridViewEmpleados);
            this.gbemp.Location = new System.Drawing.Point(16, 82);
            this.gbemp.Margin = new System.Windows.Forms.Padding(4);
            this.gbemp.Name = "gbemp";
            this.gbemp.Padding = new System.Windows.Forms.Padding(4);
            this.gbemp.Size = new System.Drawing.Size(448, 362);
            this.gbemp.TabIndex = 0;
            this.gbemp.TabStop = false;
            this.gbemp.Text = "Empleados";
            // 
            // GridViewEmpleados
            // 
            this.GridViewEmpleados.AllowUserToAddRows = false;
            this.GridViewEmpleados.AllowUserToDeleteRows = false;
            this.GridViewEmpleados.AllowUserToOrderColumns = true;
            this.GridViewEmpleados.BackgroundColor = System.Drawing.Color.White;
            this.GridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewEmpleados.Location = new System.Drawing.Point(8, 23);
            this.GridViewEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.GridViewEmpleados.Name = "GridViewEmpleados";
            this.GridViewEmpleados.ReadOnly = true;
            this.GridViewEmpleados.Size = new System.Drawing.Size(432, 331);
            this.GridViewEmpleados.TabIndex = 0;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(16, 451);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 26);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(187, 451);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(111, 26);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.ForeColor = System.Drawing.Color.White;
            this.btncerrar.Location = new System.Drawing.Point(353, 451);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(111, 26);
            this.btncerrar.TabIndex = 7;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = false;
            // 
            // gbfiltro
            // 
            this.gbfiltro.Controls.Add(this.btnclean);
            this.gbfiltro.Controls.Add(this.lblfiltro);
            this.gbfiltro.Controls.Add(this.btnbuscar);
            this.gbfiltro.Controls.Add(this.txtfilter);
            this.gbfiltro.Location = new System.Drawing.Point(16, 12);
            this.gbfiltro.Name = "gbfiltro";
            this.gbfiltro.Size = new System.Drawing.Size(448, 63);
            this.gbfiltro.TabIndex = 8;
            this.gbfiltro.TabStop = false;
            this.gbfiltro.Text = "Filtro";
            // 
            // btnclean
            // 
            this.btnclean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnclean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclean.ForeColor = System.Drawing.Color.White;
            this.btnclean.Location = new System.Drawing.Point(364, 23);
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
            this.lblfiltro.Size = new System.Drawing.Size(41, 16);
            this.lblfiltro.TabIndex = 1;
            this.lblfiltro.Text = "Filtrar";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(280, 23);
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
            this.txtfilter.Size = new System.Drawing.Size(221, 22);
            this.txtfilter.TabIndex = 9;
            // 
            // Mostrar_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(477, 487);
            this.Controls.Add(this.gbfiltro);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.gbemp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Mostrar_Empleados";
            this.Text = "Mostrar Empleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mostrar_Empleados_FormClosing);
            this.Load += new System.EventHandler(this.Mostrar_Empleados_Load);
            this.gbemp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEmpleados)).EndInit();
            this.gbfiltro.ResumeLayout(false);
            this.gbfiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbemp;
        private System.Windows.Forms.DataGridView GridViewEmpleados;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.GroupBox gbfiltro;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.Label lblfiltro;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtfilter;
    }
}