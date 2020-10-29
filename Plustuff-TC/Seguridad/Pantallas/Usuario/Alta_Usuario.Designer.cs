namespace Plustuff_TC.Seguridad.Pantallas.Usuario
{
    partial class Alta_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alta_Usuario));
            this.gbdatos = new System.Windows.Forms.GroupBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.lblemp = new System.Windows.Forms.Label();
            this.cmbidioma = new System.Windows.Forms.ComboBox();
            this.lblidioma = new System.Windows.Forms.Label();
            this.txtnombreU = new System.Windows.Forms.TextBox();
            this.lblnombreusu = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbdatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbdatos
            // 
            this.gbdatos.Controls.Add(this.cmbEmpleado);
            this.gbdatos.Controls.Add(this.lblemp);
            this.gbdatos.Controls.Add(this.cmbidioma);
            this.gbdatos.Controls.Add(this.lblidioma);
            this.gbdatos.Controls.Add(this.txtnombreU);
            this.gbdatos.Controls.Add(this.lblnombreusu);
            this.gbdatos.Location = new System.Drawing.Point(12, 12);
            this.gbdatos.Name = "gbdatos";
            this.gbdatos.Size = new System.Drawing.Size(285, 122);
            this.gbdatos.TabIndex = 1;
            this.gbdatos.TabStop = false;
            this.gbdatos.Text = "Datos de usuario";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Items.AddRange(new object[] {
            "Gonzalo Crespo"});
            this.cmbEmpleado.Location = new System.Drawing.Point(105, 23);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(127, 24);
            this.cmbEmpleado.TabIndex = 7;
            // 
            // lblemp
            // 
            this.lblemp.AutoSize = true;
            this.lblemp.Location = new System.Drawing.Point(12, 26);
            this.lblemp.Name = "lblemp";
            this.lblemp.Size = new System.Drawing.Size(71, 16);
            this.lblemp.TabIndex = 6;
            this.lblemp.Text = "Empleado";
            this.toolTip1.SetToolTip(this.lblemp, "Seleccione un Empleado");
            // 
            // cmbidioma
            // 
            this.cmbidioma.FormattingEnabled = true;
            this.cmbidioma.Items.AddRange(new object[] {
            "Español",
            "Ingles"});
            this.cmbidioma.Location = new System.Drawing.Point(105, 81);
            this.cmbidioma.Name = "cmbidioma";
            this.cmbidioma.Size = new System.Drawing.Size(96, 24);
            this.cmbidioma.TabIndex = 5;
            // 
            // lblidioma
            // 
            this.lblidioma.AutoSize = true;
            this.lblidioma.Location = new System.Drawing.Point(12, 84);
            this.lblidioma.Name = "lblidioma";
            this.lblidioma.Size = new System.Drawing.Size(49, 16);
            this.lblidioma.TabIndex = 4;
            this.lblidioma.Text = "Idioma";
            this.toolTip1.SetToolTip(this.lblidioma, "Seleccione un idioma");
            // 
            // txtnombreU
            // 
            this.txtnombreU.Location = new System.Drawing.Point(105, 53);
            this.txtnombreU.Name = "txtnombreU";
            this.txtnombreU.Size = new System.Drawing.Size(127, 22);
            this.txtnombreU.TabIndex = 3;
            // 
            // lblnombreusu
            // 
            this.lblnombreusu.AutoSize = true;
            this.lblnombreusu.Location = new System.Drawing.Point(12, 56);
            this.lblnombreusu.Name = "lblnombreusu";
            this.lblnombreusu.Size = new System.Drawing.Size(87, 16);
            this.lblnombreusu.TabIndex = 2;
            this.lblnombreusu.Text = "Nombre Usu.";
            this.toolTip1.SetToolTip(this.lblnombreusu, "Nombre de Usuario");
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(162, 140);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(135, 29);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirmar.ForeColor = System.Drawing.Color.White;
            this.btnconfirmar.Location = new System.Drawing.Point(12, 140);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(135, 29);
            this.btnconfirmar.TabIndex = 4;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // Alta_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(307, 175);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gbdatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Alta_Usuario";
            this.Text = "Nuevo Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Alta_Usuario_FormClosing);
            this.Load += new System.EventHandler(this.Alta_Usuario_Load);
            this.gbdatos.ResumeLayout(false);
            this.gbdatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbdatos;
        private System.Windows.Forms.ComboBox cmbidioma;
        private System.Windows.Forms.Label lblidioma;
        private System.Windows.Forms.TextBox txtnombreU;
        private System.Windows.Forms.Label lblnombreusu;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label lblemp;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}