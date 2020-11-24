namespace Plustuff_TC.Fam_Pat
{
    partial class Asignar_Pat_Fam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asignar_Pat_Fam));
            this.gbfamilia = new System.Windows.Forms.GroupBox();
            this.cmbFamilias = new System.Windows.Forms.ComboBox();
            this.lblfamilia = new System.Windows.Forms.Label();
            this.btnasignar = new System.Windows.Forms.Button();
            this.btndesasignar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lvpatentes = new System.Windows.Forms.ListView();
            this.lvpatentesAsignadas = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbfamilia.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbfamilia
            // 
            this.gbfamilia.Controls.Add(this.cmbFamilias);
            this.gbfamilia.Controls.Add(this.lblfamilia);
            this.gbfamilia.Location = new System.Drawing.Point(12, 15);
            this.gbfamilia.Margin = new System.Windows.Forms.Padding(4);
            this.gbfamilia.Name = "gbfamilia";
            this.gbfamilia.Padding = new System.Windows.Forms.Padding(4);
            this.gbfamilia.Size = new System.Drawing.Size(566, 62);
            this.gbfamilia.TabIndex = 0;
            this.gbfamilia.TabStop = false;
            this.gbfamilia.Text = "Seleccione Familia";
            // 
            // cmbFamilias
            // 
            this.cmbFamilias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFamilias.FormattingEnabled = true;
            this.cmbFamilias.Location = new System.Drawing.Point(67, 25);
            this.cmbFamilias.Name = "cmbFamilias";
            this.cmbFamilias.Size = new System.Drawing.Size(163, 24);
            this.cmbFamilias.TabIndex = 2;
            this.cmbFamilias.SelectedIndexChanged += new System.EventHandler(this.cmbFamilias_SelectedIndexChanged);
            // 
            // lblfamilia
            // 
            this.lblfamilia.AutoSize = true;
            this.lblfamilia.Location = new System.Drawing.Point(8, 28);
            this.lblfamilia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfamilia.Name = "lblfamilia";
            this.lblfamilia.Size = new System.Drawing.Size(52, 16);
            this.lblfamilia.TabIndex = 1;
            this.lblfamilia.Text = "Familia";
            // 
            // btnasignar
            // 
            this.btnasignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnasignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnasignar.ForeColor = System.Drawing.Color.White;
            this.btnasignar.Location = new System.Drawing.Point(238, 100);
            this.btnasignar.Name = "btnasignar";
            this.btnasignar.Size = new System.Drawing.Size(114, 29);
            this.btnasignar.TabIndex = 2;
            this.btnasignar.Text = "Asignar ->";
            this.btnasignar.UseVisualStyleBackColor = false;
            this.btnasignar.Click += new System.EventHandler(this.btnasignar_Click);
            // 
            // btndesasignar
            // 
            this.btndesasignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btndesasignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndesasignar.ForeColor = System.Drawing.Color.White;
            this.btndesasignar.Location = new System.Drawing.Point(238, 135);
            this.btndesasignar.Name = "btndesasignar";
            this.btndesasignar.Size = new System.Drawing.Size(114, 29);
            this.btndesasignar.TabIndex = 3;
            this.btndesasignar.Text = "<- Desasignar";
            this.btndesasignar.UseVisualStyleBackColor = false;
            this.btndesasignar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(237, 310);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(114, 29);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lvpatentes
            // 
            this.lvpatentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvpatentes.HideSelection = false;
            this.lvpatentes.Location = new System.Drawing.Point(12, 100);
            this.lvpatentes.Name = "lvpatentes";
            this.lvpatentes.Size = new System.Drawing.Size(220, 239);
            this.lvpatentes.TabIndex = 5;
            this.lvpatentes.UseCompatibleStateImageBehavior = false;
            this.lvpatentes.View = System.Windows.Forms.View.List;
            // 
            // lvpatentesAsignadas
            // 
            this.lvpatentesAsignadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lvpatentesAsignadas.HideSelection = false;
            this.lvpatentesAsignadas.Location = new System.Drawing.Point(358, 100);
            this.lvpatentesAsignadas.Name = "lvpatentesAsignadas";
            this.lvpatentesAsignadas.Size = new System.Drawing.Size(220, 239);
            this.lvpatentesAsignadas.TabIndex = 6;
            this.lvpatentesAsignadas.UseCompatibleStateImageBehavior = false;
            this.lvpatentesAsignadas.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patentes sin Asignar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Patentes Asignadas";
            // 
            // Asignar_Pat_Fam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 345);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvpatentesAsignadas);
            this.Controls.Add(this.lvpatentes);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btndesasignar);
            this.Controls.Add(this.btnasignar);
            this.Controls.Add(this.gbfamilia);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Asignar_Pat_Fam";
            this.Text = "Asignar Patentes";
            this.Load += new System.EventHandler(this.Asignar_Pat_Fam_Load);
            this.gbfamilia.ResumeLayout(false);
            this.gbfamilia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbfamilia;
        private System.Windows.Forms.Label lblfamilia;
        private System.Windows.Forms.Button btnasignar;
        private System.Windows.Forms.Button btndesasignar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.ComboBox cmbFamilias;
        private System.Windows.Forms.ListView lvpatentes;
        private System.Windows.Forms.ListView lvpatentesAsignadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}