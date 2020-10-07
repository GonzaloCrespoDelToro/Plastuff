namespace Plustuff_TC.LogIn
{
    partial class Datos_Conexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datos_Conexion));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtBDD = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnAceptar);
            this.GroupBox1.Controls.Add(this.txtBDD);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.txtServidor);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, -4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(346, 207);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 171);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(326, 30);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar y Guardar la Conexion";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtBDD
            // 
            this.txtBDD.Location = new System.Drawing.Point(81, 139);
            this.txtBDD.Name = "txtBDD";
            this.txtBDD.Size = new System.Drawing.Size(257, 26);
            this.txtBDD.TabIndex = 6;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(8, 142);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(48, 20);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "BDD:";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(81, 107);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(257, 26);
            this.txtServidor.TabIndex = 4;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(8, 110);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(71, 20);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Servidor:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(8, 58);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(186, 20);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "ingreselos manualmente:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(8, 38);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(330, 20);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "a la base de  datos son incorrectos. Por  favor";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(331, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Se ha detectado que los datos de la conexion";
            // 
            // Datos_Conexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 215);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Datos_Conexion";
            this.Text = "Datos de Conexion";
            this.Load += new System.EventHandler(this.Datos_Conexion_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnAceptar;
        internal System.Windows.Forms.TextBox txtBDD;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtServidor;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}