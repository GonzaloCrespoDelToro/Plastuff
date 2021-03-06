﻿namespace Plustuff_TC.Seguridad.Pantallas.Usuario
{
    partial class Cambiar_Contraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cambiar_Contraseña));
            this.gbpass = new System.Windows.Forms.GroupBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.pbinfo = new System.Windows.Forms.PictureBox();
            this.txtrepetpass = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lblrepass = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbpass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbpass
            // 
            this.gbpass.Controls.Add(this.lblerror);
            this.gbpass.Controls.Add(this.pbinfo);
            this.gbpass.Controls.Add(this.txtrepetpass);
            this.gbpass.Controls.Add(this.txtpass);
            this.gbpass.Controls.Add(this.lblrepass);
            this.gbpass.Controls.Add(this.lblpass);
            this.gbpass.Location = new System.Drawing.Point(12, 12);
            this.gbpass.Name = "gbpass";
            this.gbpass.Size = new System.Drawing.Size(349, 114);
            this.gbpass.TabIndex = 0;
            this.gbpass.TabStop = false;
            this.gbpass.Text = "Nueva Contraseña";
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(133, 92);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(45, 16);
            this.lblerror.TabIndex = 8;
            this.lblerror.Text = "label3";
            this.lblerror.Visible = false;
            // 
            // pbinfo
            // 
            this.pbinfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbinfo.Image = ((System.Drawing.Image)(resources.GetObject("pbinfo.Image")));
            this.pbinfo.Location = new System.Drawing.Point(317, 30);
            this.pbinfo.Name = "pbinfo";
            this.pbinfo.Size = new System.Drawing.Size(26, 22);
            this.pbinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbinfo.TabIndex = 3;
            this.pbinfo.TabStop = false;
            this.toolTip1.SetToolTip(this.pbinfo, "La contraseña deberá tener de 8 a 12 caracteres los cuales debe contener al\r\nmeno" +
        "s una mayúscula, un número, minúsculas y un carácter especial. ");
            // 
            // txtrepetpass
            // 
            this.txtrepetpass.Location = new System.Drawing.Point(136, 67);
            this.txtrepetpass.Name = "txtrepetpass";
            this.txtrepetpass.PasswordChar = '*';
            this.txtrepetpass.Size = new System.Drawing.Size(178, 22);
            this.txtrepetpass.TabIndex = 2;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(136, 30);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(178, 22);
            this.txtpass.TabIndex = 1;
            // 
            // lblrepass
            // 
            this.lblrepass.AutoSize = true;
            this.lblrepass.Location = new System.Drawing.Point(6, 67);
            this.lblrepass.Name = "lblrepass";
            this.lblrepass.Size = new System.Drawing.Size(106, 16);
            this.lblrepass.TabIndex = 1;
            this.lblrepass.Text = "Rep.Contraseña";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(6, 33);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(77, 16);
            this.lblpass.TabIndex = 0;
            this.lblpass.Text = "Contraseña";
            // 
            // btnconfirm
            // 
            this.btnconfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirm.ForeColor = System.Drawing.Color.White;
            this.btnconfirm.Location = new System.Drawing.Point(12, 132);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(157, 28);
            this.btnconfirm.TabIndex = 1;
            this.btnconfirm.Text = "Confirmar";
            this.btnconfirm.UseVisualStyleBackColor = false;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(204, 132);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(157, 28);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Cambiar_Contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 166);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.gbpass);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cambiar_Contraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cambiar_Contraseña_FormClosing);
            this.Load += new System.EventHandler(this.Cambiar_Contraseña_Load);
            this.gbpass.ResumeLayout(false);
            this.gbpass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbinfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbpass;
        private System.Windows.Forms.TextBox txtrepetpass;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label lblrepass;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.PictureBox pbinfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblerror;
    }
}