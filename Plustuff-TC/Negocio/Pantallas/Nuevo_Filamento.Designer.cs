namespace Plustuff_TC.Negocio.Pantallas
{
    partial class Nuevo_Filamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevo_Filamento));
            this.gbfilamento = new System.Windows.Forms.GroupBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.txtmaterial = new System.Windows.Forms.TextBox();
            this.lblmaterial = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbfilamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbfilamento
            // 
            this.gbfilamento.Controls.Add(this.txtprecio);
            this.gbfilamento.Controls.Add(this.lblprecio);
            this.gbfilamento.Controls.Add(this.txtmaterial);
            this.gbfilamento.Controls.Add(this.lblmaterial);
            this.gbfilamento.Location = new System.Drawing.Point(13, 13);
            this.gbfilamento.Margin = new System.Windows.Forms.Padding(4);
            this.gbfilamento.Name = "gbfilamento";
            this.gbfilamento.Padding = new System.Windows.Forms.Padding(4);
            this.gbfilamento.Size = new System.Drawing.Size(207, 109);
            this.gbfilamento.TabIndex = 0;
            this.gbfilamento.TabStop = false;
            this.gbfilamento.Text = "Nuevo Filamento";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(86, 63);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(69, 22);
            this.txtprecio.TabIndex = 3;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(7, 66);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(73, 16);
            this.lblprecio.TabIndex = 2;
            this.lblprecio.Text = "Precio/Kilo";
            this.toolTip1.SetToolTip(this.lblprecio, "Precio por kilogramo");
            // 
            // txtmaterial
            // 
            this.txtmaterial.Location = new System.Drawing.Point(86, 32);
            this.txtmaterial.Name = "txtmaterial";
            this.txtmaterial.Size = new System.Drawing.Size(93, 22);
            this.txtmaterial.TabIndex = 1;
            // 
            // lblmaterial
            // 
            this.lblmaterial.AutoSize = true;
            this.lblmaterial.Location = new System.Drawing.Point(7, 35);
            this.lblmaterial.Name = "lblmaterial";
            this.lblmaterial.Size = new System.Drawing.Size(56, 16);
            this.lblmaterial.TabIndex = 0;
            this.lblmaterial.Text = "Material";
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(13, 129);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(100, 28);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(120, 129);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(100, 28);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Nuevo_Filamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(232, 166);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.gbfilamento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Nuevo_Filamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Filamento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Nuevo_Filamento_FormClosing);
            this.Load += new System.EventHandler(this.Nuevo_Filamento_Load);
            this.gbfilamento.ResumeLayout(false);
            this.gbfilamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbfilamento;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox txtmaterial;
        private System.Windows.Forms.Label lblmaterial;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}