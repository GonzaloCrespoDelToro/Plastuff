namespace Plustuff_TC.Seguridad.Pantallas.Usuario
{
    partial class Mod_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mod_Usuario));
            this.gbModificar = new System.Windows.Forms.GroupBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.cmbidioma = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.txtreppass = new System.Windows.Forms.TextBox();
            this.lblRepetirPass = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lblNuevaPass = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gbUsuSelect = new System.Windows.Forms.GroupBox();
            this.txtselectusu = new System.Windows.Forms.TextBox();
            this.lblusu = new System.Windows.Forms.Label();
            this.gbModificar.SuspendLayout();
            this.gbUsuSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbModificar
            // 
            this.gbModificar.Controls.Add(this.lblerror);
            this.gbModificar.Controls.Add(this.cmbidioma);
            this.gbModificar.Controls.Add(this.lblIdioma);
            this.gbModificar.Controls.Add(this.txtreppass);
            this.gbModificar.Controls.Add(this.lblRepetirPass);
            this.gbModificar.Controls.Add(this.txtpass);
            this.gbModificar.Controls.Add(this.lblNuevaPass);
            this.gbModificar.Controls.Add(this.txtnombre);
            this.gbModificar.Controls.Add(this.lblNombre);
            this.gbModificar.Location = new System.Drawing.Point(12, 89);
            this.gbModificar.Name = "gbModificar";
            this.gbModificar.Size = new System.Drawing.Size(281, 179);
            this.gbModificar.TabIndex = 1;
            this.gbModificar.TabStop = false;
            this.gbModificar.Text = "Modificar";
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(100, 122);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(45, 16);
            this.lblerror.TabIndex = 8;
            this.lblerror.Text = "label3";
            this.lblerror.Visible = false;
            // 
            // cmbidioma
            // 
            this.cmbidioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbidioma.FormattingEnabled = true;
            this.cmbidioma.Items.AddRange(new object[] {
            "Español",
            "Ingles"});
            this.cmbidioma.Location = new System.Drawing.Point(102, 141);
            this.cmbidioma.Name = "cmbidioma";
            this.cmbidioma.Size = new System.Drawing.Size(121, 24);
            this.cmbidioma.TabIndex = 7;
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(15, 144);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(49, 16);
            this.lblIdioma.TabIndex = 6;
            this.lblIdioma.Text = "Idioma";
            // 
            // txtreppass
            // 
            this.txtreppass.Location = new System.Drawing.Point(103, 97);
            this.txtreppass.Name = "txtreppass";
            this.txtreppass.PasswordChar = '*';
            this.txtreppass.Size = new System.Drawing.Size(122, 22);
            this.txtreppass.TabIndex = 5;
            // 
            // lblRepetirPass
            // 
            this.lblRepetirPass.AutoSize = true;
            this.lblRepetirPass.Location = new System.Drawing.Point(15, 100);
            this.lblRepetirPass.Name = "lblRepetirPass";
            this.lblRepetirPass.Size = new System.Drawing.Size(86, 16);
            this.lblRepetirPass.TabIndex = 4;
            this.lblRepetirPass.Text = "Repetir Pass";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(103, 69);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(122, 22);
            this.txtpass.TabIndex = 3;
            // 
            // lblNuevaPass
            // 
            this.lblNuevaPass.AutoSize = true;
            this.lblNuevaPass.Location = new System.Drawing.Point(15, 72);
            this.lblNuevaPass.Name = "lblNuevaPass";
            this.lblNuevaPass.Size = new System.Drawing.Size(82, 16);
            this.lblNuevaPass.TabIndex = 2;
            this.lblNuevaPass.Text = "Nueva Pass";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(102, 32);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(122, 22);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.Text = "G.CrespoDelToro";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(158, 274);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 29);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(12, 274);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(135, 29);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // gbUsuSelect
            // 
            this.gbUsuSelect.Controls.Add(this.txtselectusu);
            this.gbUsuSelect.Controls.Add(this.lblusu);
            this.gbUsuSelect.Location = new System.Drawing.Point(12, 12);
            this.gbUsuSelect.Name = "gbUsuSelect";
            this.gbUsuSelect.Size = new System.Drawing.Size(281, 71);
            this.gbUsuSelect.TabIndex = 8;
            this.gbUsuSelect.TabStop = false;
            this.gbUsuSelect.Text = "Usuario Seleccionado";
            // 
            // txtselectusu
            // 
            this.txtselectusu.Location = new System.Drawing.Point(102, 32);
            this.txtselectusu.Name = "txtselectusu";
            this.txtselectusu.ReadOnly = true;
            this.txtselectusu.Size = new System.Drawing.Size(122, 22);
            this.txtselectusu.TabIndex = 1;
            // 
            // lblusu
            // 
            this.lblusu.AutoSize = true;
            this.lblusu.Location = new System.Drawing.Point(14, 35);
            this.lblusu.Name = "lblusu";
            this.lblusu.Size = new System.Drawing.Size(55, 16);
            this.lblusu.TabIndex = 0;
            this.lblusu.Text = "Usuario";
            // 
            // Mod_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(305, 312);
            this.Controls.Add(this.gbUsuSelect);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gbModificar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mod_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Usuario";
            this.Load += new System.EventHandler(this.Mod_Usuario_Load);
            this.gbModificar.ResumeLayout(false);
            this.gbModificar.PerformLayout();
            this.gbUsuSelect.ResumeLayout(false);
            this.gbUsuSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbModificar;
        private System.Windows.Forms.ComboBox cmbidioma;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.TextBox txtreppass;
        private System.Windows.Forms.Label lblRepetirPass;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label lblNuevaPass;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox gbUsuSelect;
        private System.Windows.Forms.TextBox txtselectusu;
        private System.Windows.Forms.Label lblusu;
        private System.Windows.Forms.Label lblerror;
    }
}