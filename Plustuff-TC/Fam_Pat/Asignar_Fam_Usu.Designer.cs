namespace Plustuff_TC.Fam_Pat
{
    partial class Asignar_Fam_Usu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asignar_Fam_Usu));
            this.gbusuario = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbusuarios = new System.Windows.Forms.ComboBox();
            this.lblusu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvpatentesAsignadas = new System.Windows.Forms.ListView();
            this.lvpatentes = new System.Windows.Forms.ListView();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btndesasignar = new System.Windows.Forms.Button();
            this.btnasignar = new System.Windows.Forms.Button();
            this.gbusuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbusuario
            // 
            this.gbusuario.Controls.Add(this.pictureBox1);
            this.gbusuario.Controls.Add(this.cmbusuarios);
            this.gbusuario.Controls.Add(this.lblusu);
            this.gbusuario.Location = new System.Drawing.Point(17, 16);
            this.gbusuario.Margin = new System.Windows.Forms.Padding(5);
            this.gbusuario.Name = "gbusuario";
            this.gbusuario.Padding = new System.Windows.Forms.Padding(5);
            this.gbusuario.Size = new System.Drawing.Size(566, 78);
            this.gbusuario.TabIndex = 1;
            this.gbusuario.TabStop = false;
            this.gbusuario.Text = "Seleccione Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(273, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // cmbusuarios
            // 
            this.cmbusuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbusuarios.FormattingEnabled = true;
            this.cmbusuarios.Location = new System.Drawing.Point(74, 31);
            this.cmbusuarios.Name = "cmbusuarios";
            this.cmbusuarios.Size = new System.Drawing.Size(193, 24);
            this.cmbusuarios.TabIndex = 3;
            this.cmbusuarios.SelectedIndexChanged += new System.EventHandler(this.cmbusuarios_SelectedIndexChanged);
            // 
            // lblusu
            // 
            this.lblusu.AutoSize = true;
            this.lblusu.Location = new System.Drawing.Point(11, 34);
            this.lblusu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblusu.Name = "lblusu";
            this.lblusu.Size = new System.Drawing.Size(55, 16);
            this.lblusu.TabIndex = 1;
            this.lblusu.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Familias Asignadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Familias sin Asignar";
            // 
            // lvpatentesAsignadas
            // 
            this.lvpatentesAsignadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lvpatentesAsignadas.HideSelection = false;
            this.lvpatentesAsignadas.Location = new System.Drawing.Point(363, 118);
            this.lvpatentesAsignadas.Name = "lvpatentesAsignadas";
            this.lvpatentesAsignadas.Size = new System.Drawing.Size(220, 239);
            this.lvpatentesAsignadas.TabIndex = 13;
            this.lvpatentesAsignadas.UseCompatibleStateImageBehavior = false;
            this.lvpatentesAsignadas.View = System.Windows.Forms.View.List;
            // 
            // lvpatentes
            // 
            this.lvpatentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvpatentes.HideSelection = false;
            this.lvpatentes.Location = new System.Drawing.Point(17, 118);
            this.lvpatentes.Name = "lvpatentes";
            this.lvpatentes.Size = new System.Drawing.Size(220, 239);
            this.lvpatentes.TabIndex = 12;
            this.lvpatentes.UseCompatibleStateImageBehavior = false;
            this.lvpatentes.View = System.Windows.Forms.View.List;
            this.lvpatentes.SelectedIndexChanged += new System.EventHandler(this.lvpatentes_SelectedIndexChanged);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(242, 328);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(114, 29);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btndesasignar
            // 
            this.btndesasignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btndesasignar.Enabled = false;
            this.btndesasignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndesasignar.ForeColor = System.Drawing.Color.White;
            this.btndesasignar.Location = new System.Drawing.Point(243, 153);
            this.btndesasignar.Name = "btndesasignar";
            this.btndesasignar.Size = new System.Drawing.Size(114, 29);
            this.btndesasignar.TabIndex = 10;
            this.btndesasignar.Text = "<- Desasignar";
            this.btndesasignar.UseVisualStyleBackColor = false;
            this.btndesasignar.Click += new System.EventHandler(this.btndesasignar_Click);
            // 
            // btnasignar
            // 
            this.btnasignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnasignar.Enabled = false;
            this.btnasignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnasignar.ForeColor = System.Drawing.Color.White;
            this.btnasignar.Location = new System.Drawing.Point(243, 118);
            this.btnasignar.Name = "btnasignar";
            this.btnasignar.Size = new System.Drawing.Size(114, 29);
            this.btnasignar.TabIndex = 8;
            this.btnasignar.Text = "Asignar ->";
            this.btnasignar.UseVisualStyleBackColor = false;
            this.btnasignar.Click += new System.EventHandler(this.btnasignar_Click);
            // 
            // Asignar_Fam_Usu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 367);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvpatentesAsignadas);
            this.Controls.Add(this.lvpatentes);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btndesasignar);
            this.Controls.Add(this.btnasignar);
            this.Controls.Add(this.gbusuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Asignar_Fam_Usu";
            this.Text = "Asignar Familia";
            this.Load += new System.EventHandler(this.Asignar_Fam_Usu_Load);
            this.gbusuario.ResumeLayout(false);
            this.gbusuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbusuario;
        private System.Windows.Forms.Label lblusu;
        private System.Windows.Forms.ComboBox cmbusuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvpatentesAsignadas;
        private System.Windows.Forms.ListView lvpatentes;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btndesasignar;
        private System.Windows.Forms.Button btnasignar;
    }
}