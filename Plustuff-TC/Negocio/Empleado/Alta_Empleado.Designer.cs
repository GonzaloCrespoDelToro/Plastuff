namespace Plustuff_TC.Negocio.Empleado
{
    partial class Alta_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alta_Empleado));
            this.gbempleado = new System.Windows.Forms.GroupBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtcontacto = new System.Windows.Forms.TextBox();
            this.lblcontacto = new System.Windows.Forms.Label();
            this.txtdirecc = new System.Windows.Forms.TextBox();
            this.lbldirec = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.lblmail = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.lblapellido = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.gbempleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbempleado
            // 
            this.gbempleado.Controls.Add(this.txtdni);
            this.gbempleado.Controls.Add(this.dtFecha);
            this.gbempleado.Controls.Add(this.txtcontacto);
            this.gbempleado.Controls.Add(this.lblcontacto);
            this.gbempleado.Controls.Add(this.txtdirecc);
            this.gbempleado.Controls.Add(this.lbldirec);
            this.gbempleado.Controls.Add(this.txtmail);
            this.gbempleado.Controls.Add(this.lblmail);
            this.gbempleado.Controls.Add(this.lblfecha);
            this.gbempleado.Controls.Add(this.lblDNI);
            this.gbempleado.Controls.Add(this.txtapellido);
            this.gbempleado.Controls.Add(this.lblapellido);
            this.gbempleado.Controls.Add(this.txtnombre);
            this.gbempleado.Controls.Add(this.lblnombre);
            this.gbempleado.Location = new System.Drawing.Point(12, 12);
            this.gbempleado.Name = "gbempleado";
            this.gbempleado.Size = new System.Drawing.Size(260, 228);
            this.gbempleado.TabIndex = 0;
            this.gbempleado.TabStop = false;
            this.gbempleado.Text = "Nuevo Empleado";
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(88, 136);
            this.txtdni.MaxLength = 8;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(105, 22);
            this.txtdni.TabIndex = 17;
            this.txtdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(88, 80);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(105, 22);
            this.dtFecha.TabIndex = 16;
            // 
            // txtcontacto
            // 
            this.txtcontacto.Location = new System.Drawing.Point(88, 192);
            this.txtcontacto.Name = "txtcontacto";
            this.txtcontacto.Size = new System.Drawing.Size(123, 22);
            this.txtcontacto.TabIndex = 13;
            this.txtcontacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontacto_KeyPress);
            // 
            // lblcontacto
            // 
            this.lblcontacto.AutoSize = true;
            this.lblcontacto.Location = new System.Drawing.Point(6, 195);
            this.lblcontacto.Name = "lblcontacto";
            this.lblcontacto.Size = new System.Drawing.Size(61, 16);
            this.lblcontacto.TabIndex = 12;
            this.lblcontacto.Text = "Contacto";
            // 
            // txtdirecc
            // 
            this.txtdirecc.Location = new System.Drawing.Point(88, 108);
            this.txtdirecc.Name = "txtdirecc";
            this.txtdirecc.Size = new System.Drawing.Size(158, 22);
            this.txtdirecc.TabIndex = 11;
            // 
            // lbldirec
            // 
            this.lbldirec.AutoSize = true;
            this.lbldirec.Location = new System.Drawing.Point(5, 111);
            this.lbldirec.Name = "lbldirec";
            this.lbldirec.Size = new System.Drawing.Size(65, 16);
            this.lbldirec.TabIndex = 10;
            this.lbldirec.Text = "Direccion";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(88, 164);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(158, 22);
            this.txtmail.TabIndex = 9;
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(6, 167);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(42, 16);
            this.lblmail.TabIndex = 8;
            this.lblmail.Text = "Email";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(5, 83);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(77, 16);
            this.lblfecha.TabIndex = 6;
            this.lblfecha.Text = "Fecha Nac.";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(6, 139);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(31, 16);
            this.lblDNI.TabIndex = 4;
            this.lblDNI.Text = "DNI";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(88, 52);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(158, 22);
            this.txtapellido.TabIndex = 3;
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(6, 55);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(58, 16);
            this.lblapellido.TabIndex = 2;
            this.lblapellido.Text = "Apellido";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(88, 24);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(158, 22);
            this.txtnombre.TabIndex = 1;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(6, 27);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(57, 16);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre";
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirmar.ForeColor = System.Drawing.Color.White;
            this.btnconfirmar.Location = new System.Drawing.Point(12, 246);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(111, 26);
            this.btnconfirmar.TabIndex = 1;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            this.btnconfirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(161, 246);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(111, 26);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Alta_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(280, 282);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.gbempleado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Alta_Empleado";
            this.Text = "Alta Empleado";
            this.Load += new System.EventHandler(this.Alta_Empleado_Load);
            this.gbempleado.ResumeLayout(false);
            this.gbempleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbempleado;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtcontacto;
        private System.Windows.Forms.Label lblcontacto;
        private System.Windows.Forms.TextBox txtdirecc;
        private System.Windows.Forms.Label lbldirec;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox txtdni;
    }
}