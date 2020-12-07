namespace Plustuff_TC.Negocio.Pantallas
{
    partial class Modificar_Filamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar_Filamento));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtprecioselect = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaterialselect = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Filamentos = new System.Windows.Forms.GroupBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtmaterial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Filamentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtprecioselect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmaterialselect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filamento seleccionado";
            // 
            // txtprecioselect
            // 
            this.txtprecioselect.Location = new System.Drawing.Point(85, 49);
            this.txtprecioselect.Name = "txtprecioselect";
            this.txtprecioselect.ReadOnly = true;
            this.txtprecioselect.Size = new System.Drawing.Size(132, 22);
            this.txtprecioselect.TabIndex = 7;
            this.txtprecioselect.Text = "2500.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Precio/Kilo";
            // 
            // txtmaterialselect
            // 
            this.txtmaterialselect.Location = new System.Drawing.Point(85, 21);
            this.txtmaterialselect.Name = "txtmaterialselect";
            this.txtmaterialselect.ReadOnly = true;
            this.txtmaterialselect.Size = new System.Drawing.Size(153, 22);
            this.txtmaterialselect.TabIndex = 5;
            this.txtmaterialselect.Text = "PLA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Material";
            // 
            // Filamentos
            // 
            this.Filamentos.Controls.Add(this.txtprecio);
            this.Filamentos.Controls.Add(this.txtmaterial);
            this.Filamentos.Controls.Add(this.label4);
            this.Filamentos.Controls.Add(this.label5);
            this.Filamentos.Location = new System.Drawing.Point(12, 103);
            this.Filamentos.Name = "Filamentos";
            this.Filamentos.Size = new System.Drawing.Size(272, 102);
            this.Filamentos.TabIndex = 1;
            this.Filamentos.TabStop = false;
            this.Filamentos.Text = "Modificar Filamento";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(85, 60);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(132, 22);
            this.txtprecio.TabIndex = 13;
            this.txtprecio.Text = "2500.00";
            // 
            // txtmaterial
            // 
            this.txtmaterial.Location = new System.Drawing.Point(85, 32);
            this.txtmaterial.Name = "txtmaterial";
            this.txtmaterial.Size = new System.Drawing.Size(153, 22);
            this.txtmaterial.TabIndex = 11;
            this.txtmaterial.Text = "PLA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Precio/Kilo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Material";
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.ForeColor = System.Drawing.Color.White;
            this.btnmodificar.Location = new System.Drawing.Point(12, 211);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(110, 29);
            this.btnmodificar.TabIndex = 2;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(174, 211);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(110, 29);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Modificar_Filamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(296, 248);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.Filamentos);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Modificar_Filamento";
            this.Text = "Modificar Filamento";
            this.Load += new System.EventHandler(this.Modificar_Filamento_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Modificar_Filamento_HelpRequested);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Filamentos.ResumeLayout(false);
            this.Filamentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtprecioselect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaterialselect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Filamentos;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtmaterial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}