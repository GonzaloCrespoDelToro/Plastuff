namespace Plustuff_TC.Seguridad
{
    partial class Restore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restore));
            this.gbrestore = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.lblarchivo = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnrestore = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbrestore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbrestore
            // 
            this.gbrestore.Controls.Add(this.pictureBox1);
            this.gbrestore.Controls.Add(this.txtruta);
            this.gbrestore.Controls.Add(this.lblarchivo);
            this.gbrestore.Location = new System.Drawing.Point(16, 15);
            this.gbrestore.Margin = new System.Windows.Forms.Padding(4);
            this.gbrestore.Name = "gbrestore";
            this.gbrestore.Padding = new System.Windows.Forms.Padding(4);
            this.gbrestore.Size = new System.Drawing.Size(387, 72);
            this.gbrestore.TabIndex = 0;
            this.gbrestore.TabStop = false;
            this.gbrestore.Text = "Restore";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(354, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtruta
            // 
            this.txtruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruta.Location = new System.Drawing.Point(69, 30);
            this.txtruta.Margin = new System.Windows.Forms.Padding(4);
            this.txtruta.Name = "txtruta";
            this.txtruta.ReadOnly = true;
            this.txtruta.Size = new System.Drawing.Size(278, 22);
            this.txtruta.TabIndex = 5;
            // 
            // lblarchivo
            // 
            this.lblarchivo.AutoSize = true;
            this.lblarchivo.Location = new System.Drawing.Point(8, 33);
            this.lblarchivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblarchivo.Name = "lblarchivo";
            this.lblarchivo.Size = new System.Drawing.Size(53, 16);
            this.lblarchivo.TabIndex = 0;
            this.lblarchivo.Text = "Archivo";
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(238, 94);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(165, 29);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnrestore
            // 
            this.btnrestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnrestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrestore.ForeColor = System.Drawing.Color.White;
            this.btnrestore.Location = new System.Drawing.Point(16, 94);
            this.btnrestore.Name = "btnrestore";
            this.btnrestore.Size = new System.Drawing.Size(165, 29);
            this.btnrestore.TabIndex = 3;
            this.btnrestore.Text = "Realizar Restore";
            this.btnrestore.UseVisualStyleBackColor = false;
            this.btnrestore.Click += new System.EventHandler(this.btnrestore_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 134);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnrestore);
            this.Controls.Add(this.gbrestore);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Restore";
            this.Text = "Restaurar Backup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Restore_FormClosing);
            this.Load += new System.EventHandler(this.Restore_Load);
            this.gbrestore.ResumeLayout(false);
            this.gbrestore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbrestore;
        private System.Windows.Forms.Label lblarchivo;
        private System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnrestore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}