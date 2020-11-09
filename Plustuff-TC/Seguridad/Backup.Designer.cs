namespace Plustuff_TC.Seguridad
{
    partial class Backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblfechahora = new System.Windows.Forms.Label();
            this.lblultimogenerado = new System.Windows.Forms.Label();
            this.lblubicacion = new System.Windows.Forms.Label();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombrearchivo = new System.Windows.Forms.Label();
            this.btngenerar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblfechahora);
            this.groupBox1.Controls.Add(this.lblultimogenerado);
            this.groupBox1.Controls.Add(this.lblubicacion);
            this.groupBox1.Controls.Add(this.txtruta);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.lblnombrearchivo);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(417, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(376, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Seleccione el archivo");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblfechahora
            // 
            this.lblfechahora.AutoSize = true;
            this.lblfechahora.ForeColor = System.Drawing.Color.Green;
            this.lblfechahora.Location = new System.Drawing.Point(114, 123);
            this.lblfechahora.Name = "lblfechahora";
            this.lblfechahora.Size = new System.Drawing.Size(123, 16);
            this.lblfechahora.TabIndex = 2;
            this.lblfechahora.Text = "05/04/2020 15:00:00";
            // 
            // lblultimogenerado
            // 
            this.lblultimogenerado.AutoSize = true;
            this.lblultimogenerado.ForeColor = System.Drawing.Color.Green;
            this.lblultimogenerado.Location = new System.Drawing.Point(7, 123);
            this.lblultimogenerado.Name = "lblultimogenerado";
            this.lblultimogenerado.Size = new System.Drawing.Size(111, 16);
            this.lblultimogenerado.TabIndex = 6;
            this.lblultimogenerado.Text = "Ultimo generado:";
            // 
            // lblubicacion
            // 
            this.lblubicacion.AutoSize = true;
            this.lblubicacion.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblubicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblubicacion.Location = new System.Drawing.Point(8, 75);
            this.lblubicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblubicacion.Name = "lblubicacion";
            this.lblubicacion.Size = new System.Drawing.Size(69, 16);
            this.lblubicacion.TabIndex = 5;
            this.lblubicacion.Text = "Ubicacion";
            this.toolTip1.SetToolTip(this.lblubicacion, "Seleccione la carpeta donde se guardara el Backup");
            // 
            // txtruta
            // 
            this.txtruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruta.Location = new System.Drawing.Point(142, 72);
            this.txtruta.Margin = new System.Windows.Forms.Padding(4);
            this.txtruta.Name = "txtruta";
            this.txtruta.ReadOnly = true;
            this.txtruta.Size = new System.Drawing.Size(227, 22);
            this.txtruta.TabIndex = 3;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(142, 30);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(227, 22);
            this.txtnombre.TabIndex = 1;
            // 
            // lblnombrearchivo
            // 
            this.lblnombrearchivo.AutoSize = true;
            this.lblnombrearchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombrearchivo.Location = new System.Drawing.Point(8, 33);
            this.lblnombrearchivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombrearchivo.Name = "lblnombrearchivo";
            this.lblnombrearchivo.Size = new System.Drawing.Size(126, 16);
            this.lblnombrearchivo.TabIndex = 0;
            this.lblnombrearchivo.Text = "Nombre del archivo";
            // 
            // btngenerar
            // 
            this.btngenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btngenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerar.ForeColor = System.Drawing.Color.White;
            this.btngenerar.Location = new System.Drawing.Point(16, 162);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(173, 29);
            this.btngenerar.TabIndex = 1;
            this.btngenerar.Text = "Generar Backup";
            this.btngenerar.UseVisualStyleBackColor = false;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(260, 162);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(173, 29);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 197);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Backup";
            this.Text = "Generar Backup";
            this.Load += new System.EventHandler(this.Backup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombrearchivo;
        private System.Windows.Forms.Label lblfechahora;
        private System.Windows.Forms.Label lblultimogenerado;
        private System.Windows.Forms.Label lblubicacion;
        private System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}