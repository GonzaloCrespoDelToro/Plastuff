namespace Plustuff_TC.Negocio.Pantallas
{
    partial class Mostrar_Filamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mostrar_Filamentos));
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gbfilamentos = new System.Windows.Forms.GroupBox();
            this.GridViewFilamentos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbfilamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFilamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.ForeColor = System.Drawing.Color.White;
            this.btncerrar.Location = new System.Drawing.Point(292, 140);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(5);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(121, 39);
            this.btncerrar.TabIndex = 22;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.ForeColor = System.Drawing.Color.White;
            this.btnBaja.Location = new System.Drawing.Point(292, 91);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(5);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(121, 39);
            this.btnBaja.TabIndex = 21;
            this.btnBaja.Text = "Borrar";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(292, 42);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(121, 39);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // gbfilamentos
            // 
            this.gbfilamentos.Controls.Add(this.GridViewFilamentos);
            this.gbfilamentos.Location = new System.Drawing.Point(16, 15);
            this.gbfilamentos.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gbfilamentos.Name = "gbfilamentos";
            this.gbfilamentos.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gbfilamentos.Size = new System.Drawing.Size(264, 320);
            this.gbfilamentos.TabIndex = 19;
            this.gbfilamentos.TabStop = false;
            this.gbfilamentos.Text = "Filamentos";
            // 
            // GridViewFilamentos
            // 
            this.GridViewFilamentos.AllowUserToAddRows = false;
            this.GridViewFilamentos.AllowUserToDeleteRows = false;
            this.GridViewFilamentos.AllowUserToOrderColumns = true;
            this.GridViewFilamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridViewFilamentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridViewFilamentos.BackgroundColor = System.Drawing.Color.White;
            this.GridViewFilamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewFilamentos.Location = new System.Drawing.Point(14, 27);
            this.GridViewFilamentos.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.GridViewFilamentos.Name = "GridViewFilamentos";
            this.GridViewFilamentos.ReadOnly = true;
            this.GridViewFilamentos.Size = new System.Drawing.Size(236, 275);
            this.GridViewFilamentos.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(290, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Mostrar_Filamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 345);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.gbfilamentos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Mostrar_Filamentos";
            this.Text = "Mostrar Filamentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mostrar_Filamentos_FormClosing);
            this.Load += new System.EventHandler(this.Mostrar_Filamentos_Load);
            this.gbfilamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFilamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox gbfilamentos;
        private System.Windows.Forms.DataGridView GridViewFilamentos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}