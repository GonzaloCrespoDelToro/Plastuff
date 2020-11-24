namespace Plustuff_TC.Negocio.Pantallas
{
    partial class Modificar_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar_Cliente));
            this.gbClienteSelec = new System.Windows.Forms.GroupBox();
            this.txtselectclient = new System.Windows.Forms.TextBox();
            this.lblcliente = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.gbModificar = new System.Windows.Forms.GroupBox();
            this.lblbaja = new System.Windows.Forms.Label();
            this.cbxbaja = new System.Windows.Forms.CheckBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtcontacto = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lblcontacto = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lbldni = new System.Windows.Forms.Label();
            this.lblmail = new System.Windows.Forms.Label();
            this.gbClienteSelec.SuspendLayout();
            this.gbModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbClienteSelec
            // 
            this.gbClienteSelec.Controls.Add(this.txtselectclient);
            this.gbClienteSelec.Controls.Add(this.lblcliente);
            this.gbClienteSelec.Location = new System.Drawing.Point(16, 15);
            this.gbClienteSelec.Margin = new System.Windows.Forms.Padding(4);
            this.gbClienteSelec.Name = "gbClienteSelec";
            this.gbClienteSelec.Padding = new System.Windows.Forms.Padding(4);
            this.gbClienteSelec.Size = new System.Drawing.Size(393, 60);
            this.gbClienteSelec.TabIndex = 12;
            this.gbClienteSelec.TabStop = false;
            this.gbClienteSelec.Text = "Usuario Seleccionado";
            // 
            // txtselectclient
            // 
            this.txtselectclient.Location = new System.Drawing.Point(115, 23);
            this.txtselectclient.Margin = new System.Windows.Forms.Padding(4);
            this.txtselectclient.Name = "txtselectclient";
            this.txtselectclient.ReadOnly = true;
            this.txtselectclient.Size = new System.Drawing.Size(193, 22);
            this.txtselectclient.TabIndex = 1;
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Location = new System.Drawing.Point(19, 27);
            this.lblcliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(49, 16);
            this.lblcliente.TabIndex = 0;
            this.lblcliente.Text = "Cliente";
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(229, 372);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(180, 36);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirmar.ForeColor = System.Drawing.Color.White;
            this.btnconfirmar.Location = new System.Drawing.Point(16, 372);
            this.btnconfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(180, 36);
            this.btnconfirmar.TabIndex = 10;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            this.btnconfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // gbModificar
            // 
            this.gbModificar.Controls.Add(this.lblbaja);
            this.gbModificar.Controls.Add(this.cbxbaja);
            this.gbModificar.Controls.Add(this.txtdni);
            this.gbModificar.Controls.Add(this.dtFecha);
            this.gbModificar.Controls.Add(this.txtnombre);
            this.gbModificar.Controls.Add(this.lblnombre);
            this.gbModificar.Controls.Add(this.lblapellido);
            this.gbModificar.Controls.Add(this.lblfecha);
            this.gbModificar.Controls.Add(this.txtapellido);
            this.gbModificar.Controls.Add(this.txtcontacto);
            this.gbModificar.Controls.Add(this.lbldireccion);
            this.gbModificar.Controls.Add(this.lblcontacto);
            this.gbModificar.Controls.Add(this.txtdireccion);
            this.gbModificar.Controls.Add(this.txtemail);
            this.gbModificar.Controls.Add(this.lbldni);
            this.gbModificar.Controls.Add(this.lblmail);
            this.gbModificar.Location = new System.Drawing.Point(16, 83);
            this.gbModificar.Margin = new System.Windows.Forms.Padding(4);
            this.gbModificar.Name = "gbModificar";
            this.gbModificar.Padding = new System.Windows.Forms.Padding(4);
            this.gbModificar.Size = new System.Drawing.Size(393, 281);
            this.gbModificar.TabIndex = 9;
            this.gbModificar.TabStop = false;
            this.gbModificar.Text = "Modificar";
            // 
            // lblbaja
            // 
            this.lblbaja.AutoSize = true;
            this.lblbaja.Location = new System.Drawing.Point(19, 247);
            this.lblbaja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbaja.Name = "lblbaja";
            this.lblbaja.Size = new System.Drawing.Size(36, 16);
            this.lblbaja.TabIndex = 33;
            this.lblbaja.Text = "Baja";
            // 
            // cbxbaja
            // 
            this.cbxbaja.AutoSize = true;
            this.cbxbaja.Location = new System.Drawing.Point(115, 247);
            this.cbxbaja.Margin = new System.Windows.Forms.Padding(4);
            this.cbxbaja.Name = "cbxbaja";
            this.cbxbaja.Size = new System.Drawing.Size(15, 14);
            this.cbxbaja.TabIndex = 32;
            this.cbxbaja.UseVisualStyleBackColor = true;
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(115, 87);
            this.txtdni.Margin = new System.Windows.Forms.Padding(4);
            this.txtdni.MaxLength = 8;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(139, 22);
            this.txtdni.TabIndex = 21;
            this.txtdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(115, 215);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(139, 22);
            this.dtFecha.TabIndex = 31;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(115, 23);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(251, 22);
            this.txtnombre.TabIndex = 19;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(19, 26);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(57, 16);
            this.lblnombre.TabIndex = 18;
            this.lblnombre.Text = "Nombre";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(19, 58);
            this.lblapellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(58, 16);
            this.lblapellido.TabIndex = 22;
            this.lblapellido.Text = "Apellido";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(19, 220);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(62, 16);
            this.lblfecha.TabIndex = 30;
            this.lblfecha.Text = "Fec. Nac";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(115, 55);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(251, 22);
            this.txtapellido.TabIndex = 20;
            // 
            // txtcontacto
            // 
            this.txtcontacto.Location = new System.Drawing.Point(115, 183);
            this.txtcontacto.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontacto.Name = "txtcontacto";
            this.txtcontacto.Size = new System.Drawing.Size(193, 22);
            this.txtcontacto.TabIndex = 26;
            this.txtcontacto.TextChanged += new System.EventHandler(this.txtcontacto_TextChanged);
            this.txtcontacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontacto_KeyPress);
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(19, 122);
            this.lbldireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(65, 16);
            this.lbldireccion.TabIndex = 24;
            this.lbldireccion.Text = "Direccion";
            // 
            // lblcontacto
            // 
            this.lblcontacto.AutoSize = true;
            this.lblcontacto.Location = new System.Drawing.Point(19, 186);
            this.lblcontacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcontacto.Name = "lblcontacto";
            this.lblcontacto.Size = new System.Drawing.Size(61, 16);
            this.lblcontacto.TabIndex = 29;
            this.lblcontacto.Text = "Contacto";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(115, 119);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(251, 22);
            this.txtdireccion.TabIndex = 23;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(115, 151);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(251, 22);
            this.txtemail.TabIndex = 25;
            // 
            // lbldni
            // 
            this.lbldni.AutoSize = true;
            this.lbldni.Location = new System.Drawing.Point(19, 90);
            this.lbldni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(31, 16);
            this.lbldni.TabIndex = 27;
            this.lbldni.Text = "DNI";
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(19, 154);
            this.lblmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(42, 16);
            this.lblmail.TabIndex = 28;
            this.lblmail.Text = "Email";
            // 
            // Modificar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 418);
            this.Controls.Add(this.gbClienteSelec);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.gbModificar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Modificar_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Modificar_Cliente_FormClosing);
            this.Load += new System.EventHandler(this.Modificar_Cliente_Load);
            this.gbClienteSelec.ResumeLayout(false);
            this.gbClienteSelec.PerformLayout();
            this.gbModificar.ResumeLayout(false);
            this.gbModificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClienteSelec;
        private System.Windows.Forms.TextBox txtselectclient;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.GroupBox gbModificar;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtcontacto;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblcontacto;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.CheckBox cbxbaja;
        private System.Windows.Forms.Label lblbaja;
    }
}