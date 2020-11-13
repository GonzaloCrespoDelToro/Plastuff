namespace Plustuff_TC.Negocio.Pantallas
{
    partial class Nuevo_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevo_Cliente));
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.lblapellido = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lbldni = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblmail = new System.Windows.Forms.Label();
            this.txtcontacto = new System.Windows.Forms.TextBox();
            this.lblcontacto = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.gbnuevocliente = new System.Windows.Forms.GroupBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.gbnuevocliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(15, 24);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(57, 16);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(86, 21);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(189, 22);
            this.txtnombre.TabIndex = 1;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(86, 49);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(189, 22);
            this.txtapellido.TabIndex = 2;
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(15, 52);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(58, 16);
            this.lblapellido.TabIndex = 3;
            this.lblapellido.Text = "Apellido";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(86, 105);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(189, 22);
            this.txtdireccion.TabIndex = 4;
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(15, 108);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(65, 16);
            this.lbldireccion.TabIndex = 5;
            this.lbldireccion.Text = "Direccion";
            // 
            // lbldni
            // 
            this.lbldni.AutoSize = true;
            this.lbldni.Location = new System.Drawing.Point(15, 80);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(31, 16);
            this.lbldni.TabIndex = 7;
            this.lbldni.Text = "DNI";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(86, 133);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(189, 22);
            this.txtemail.TabIndex = 5;
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(15, 136);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(42, 16);
            this.lblmail.TabIndex = 9;
            this.lblmail.Text = "Email";
            // 
            // txtcontacto
            // 
            this.txtcontacto.Location = new System.Drawing.Point(86, 161);
            this.txtcontacto.Name = "txtcontacto";
            this.txtcontacto.Size = new System.Drawing.Size(146, 22);
            this.txtcontacto.TabIndex = 6;
            this.txtcontacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontacto_KeyPress);
            // 
            // lblcontacto
            // 
            this.lblcontacto.AutoSize = true;
            this.lblcontacto.Location = new System.Drawing.Point(15, 164);
            this.lblcontacto.Name = "lblcontacto";
            this.lblcontacto.Size = new System.Drawing.Size(61, 16);
            this.lblcontacto.TabIndex = 11;
            this.lblcontacto.Text = "Contacto";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(15, 192);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(62, 16);
            this.lblfecha.TabIndex = 13;
            this.lblfecha.Text = "Fec. Nac";
            // 
            // gbnuevocliente
            // 
            this.gbnuevocliente.Controls.Add(this.txtdni);
            this.gbnuevocliente.Controls.Add(this.dtFecha);
            this.gbnuevocliente.Controls.Add(this.txtnombre);
            this.gbnuevocliente.Controls.Add(this.lblnombre);
            this.gbnuevocliente.Controls.Add(this.lblapellido);
            this.gbnuevocliente.Controls.Add(this.lblfecha);
            this.gbnuevocliente.Controls.Add(this.txtapellido);
            this.gbnuevocliente.Controls.Add(this.txtcontacto);
            this.gbnuevocliente.Controls.Add(this.lbldireccion);
            this.gbnuevocliente.Controls.Add(this.lblcontacto);
            this.gbnuevocliente.Controls.Add(this.txtdireccion);
            this.gbnuevocliente.Controls.Add(this.txtemail);
            this.gbnuevocliente.Controls.Add(this.lbldni);
            this.gbnuevocliente.Controls.Add(this.lblmail);
            this.gbnuevocliente.Location = new System.Drawing.Point(12, 12);
            this.gbnuevocliente.Name = "gbnuevocliente";
            this.gbnuevocliente.Size = new System.Drawing.Size(281, 225);
            this.gbnuevocliente.TabIndex = 17;
            this.gbnuevocliente.TabStop = false;
            this.gbnuevocliente.Text = "Nuevo Cliente";
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(86, 77);
            this.txtdni.MaxLength = 8;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(105, 22);
            this.txtdni.TabIndex = 3;
            this.txtdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(86, 189);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(105, 22);
            this.dtFecha.TabIndex = 17;
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirmar.ForeColor = System.Drawing.Color.White;
            this.btnconfirmar.Location = new System.Drawing.Point(12, 243);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(111, 26);
            this.btnconfirmar.TabIndex = 19;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(182, 243);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(111, 26);
            this.btncancelar.TabIndex = 20;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Nuevo_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(305, 277);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.gbnuevocliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Nuevo_Cliente";
            this.Text = "Nuevo_Cliente";
            this.gbnuevocliente.ResumeLayout(false);
            this.gbnuevocliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.TextBox txtcontacto;
        private System.Windows.Forms.Label lblcontacto;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.GroupBox gbnuevocliente;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox txtdni;
    }
}