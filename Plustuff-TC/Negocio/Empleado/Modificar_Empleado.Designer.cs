namespace Plustuff_TC.Negocio.Empleado
{
    partial class Modificar_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar_Empleado));
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gbmod = new System.Windows.Forms.GroupBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtcontacto = new System.Windows.Forms.TextBox();
            this.lblcontacto = new System.Windows.Forms.Label();
            this.txtdirecc = new System.Windows.Forms.TextBox();
            this.lbldirec = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblmail = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.lblapellido = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.gbempleado = new System.Windows.Forms.GroupBox();
            this.txtdniselect = new System.Windows.Forms.TextBox();
            this.txtnombreselect = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.gbmod.SuspendLayout();
            this.gbempleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(161, 338);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(111, 26);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(12, 338);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(111, 26);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // gbmod
            // 
            this.gbmod.Controls.Add(this.dtFecha);
            this.gbmod.Controls.Add(this.txtdni);
            this.gbmod.Controls.Add(this.txtcontacto);
            this.gbmod.Controls.Add(this.lblcontacto);
            this.gbmod.Controls.Add(this.txtdirecc);
            this.gbmod.Controls.Add(this.lbldirec);
            this.gbmod.Controls.Add(this.txtemail);
            this.gbmod.Controls.Add(this.lblmail);
            this.gbmod.Controls.Add(this.lblfecha);
            this.gbmod.Controls.Add(this.label3);
            this.gbmod.Controls.Add(this.txtapellido);
            this.gbmod.Controls.Add(this.lblapellido);
            this.gbmod.Controls.Add(this.txtnombre);
            this.gbmod.Controls.Add(this.lblname);
            this.gbmod.Location = new System.Drawing.Point(12, 104);
            this.gbmod.Name = "gbmod";
            this.gbmod.Size = new System.Drawing.Size(260, 228);
            this.gbmod.TabIndex = 3;
            this.gbmod.TabStop = false;
            this.gbmod.Text = "Modificar Empleado";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(88, 80);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(105, 22);
            this.dtFecha.TabIndex = 17;
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(88, 136);
            this.txtdni.MaxLength = 8;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(123, 22);
            this.txtdni.TabIndex = 4;
            this.txtdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            // 
            // txtcontacto
            // 
            this.txtcontacto.Location = new System.Drawing.Point(88, 192);
            this.txtcontacto.Name = "txtcontacto";
            this.txtcontacto.Size = new System.Drawing.Size(123, 22);
            this.txtcontacto.TabIndex = 6;
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
            this.txtdirecc.TabIndex = 3;
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
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(88, 164);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(158, 22);
            this.txtemail.TabIndex = 5;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(88, 52);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(158, 22);
            this.txtapellido.TabIndex = 2;
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
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(6, 27);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(57, 16);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Nombre";
            // 
            // gbempleado
            // 
            this.gbempleado.Controls.Add(this.txtdniselect);
            this.gbempleado.Controls.Add(this.txtnombreselect);
            this.gbempleado.Controls.Add(this.label9);
            this.gbempleado.Controls.Add(this.lblnombre);
            this.gbempleado.Location = new System.Drawing.Point(12, 12);
            this.gbempleado.Name = "gbempleado";
            this.gbempleado.Size = new System.Drawing.Size(260, 86);
            this.gbempleado.TabIndex = 6;
            this.gbempleado.TabStop = false;
            this.gbempleado.Text = "Empleado seleccionado";
            // 
            // txtdniselect
            // 
            this.txtdniselect.Location = new System.Drawing.Point(92, 54);
            this.txtdniselect.MaxLength = 8;
            this.txtdniselect.Name = "txtdniselect";
            this.txtdniselect.ReadOnly = true;
            this.txtdniselect.Size = new System.Drawing.Size(123, 22);
            this.txtdniselect.TabIndex = 16;
            // 
            // txtnombreselect
            // 
            this.txtnombreselect.Location = new System.Drawing.Point(92, 26);
            this.txtnombreselect.Name = "txtnombreselect";
            this.txtnombreselect.ReadOnly = true;
            this.txtnombreselect.Size = new System.Drawing.Size(154, 22);
            this.txtnombreselect.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "DNI";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(10, 29);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(57, 16);
            this.lblnombre.TabIndex = 16;
            this.lblnombre.Text = "Nombre";
            // 
            // Modificar_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(281, 373);
            this.Controls.Add(this.gbempleado);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gbmod);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Modificar_Empleado";
            this.Text = "Modificar Empleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Modificar_Empleado_FormClosing);
            this.Load += new System.EventHandler(this.Modificar_Empleado_Load);
            this.gbmod.ResumeLayout(false);
            this.gbmod.PerformLayout();
            this.gbempleado.ResumeLayout(false);
            this.gbempleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox gbmod;
        private System.Windows.Forms.TextBox txtcontacto;
        private System.Windows.Forms.Label lblcontacto;
        private System.Windows.Forms.TextBox txtdirecc;
        private System.Windows.Forms.Label lbldirec;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.GroupBox gbempleado;
        private System.Windows.Forms.TextBox txtnombreselect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtdniselect;
        private System.Windows.Forms.DateTimePicker dtFecha;
    }
}