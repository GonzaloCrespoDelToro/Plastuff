namespace Plustuff_TC.Negocio.Pantallas
{
    partial class Modificar_Estado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar_Estado));
            this.gbPedidoSelec = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gbModificar = new System.Windows.Forms.GroupBox();
            this.cbestados = new System.Windows.Forms.ComboBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.gbPedidoSelec.SuspendLayout();
            this.gbModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPedidoSelec
            // 
            this.gbPedidoSelec.Controls.Add(this.txtid);
            this.gbPedidoSelec.Controls.Add(this.lblid);
            this.gbPedidoSelec.Location = new System.Drawing.Point(13, 13);
            this.gbPedidoSelec.Margin = new System.Windows.Forms.Padding(4);
            this.gbPedidoSelec.Name = "gbPedidoSelec";
            this.gbPedidoSelec.Padding = new System.Windows.Forms.Padding(4);
            this.gbPedidoSelec.Size = new System.Drawing.Size(251, 60);
            this.gbPedidoSelec.TabIndex = 16;
            this.gbPedidoSelec.TabStop = false;
            this.gbPedidoSelec.Text = "Pedido Seleccionado";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(115, 23);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(65, 22);
            this.txtid.TabIndex = 1;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(19, 27);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(89, 16);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID del pedido";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(156, 150);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 36);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(13, 150);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(108, 36);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // gbModificar
            // 
            this.gbModificar.Controls.Add(this.cbestados);
            this.gbModificar.Controls.Add(this.lblestado);
            this.gbModificar.Location = new System.Drawing.Point(13, 81);
            this.gbModificar.Margin = new System.Windows.Forms.Padding(4);
            this.gbModificar.Name = "gbModificar";
            this.gbModificar.Padding = new System.Windows.Forms.Padding(4);
            this.gbModificar.Size = new System.Drawing.Size(251, 61);
            this.gbModificar.TabIndex = 13;
            this.gbModificar.TabStop = false;
            this.gbModificar.Text = "Modificar Estado";
            // 
            // cbestados
            // 
            this.cbestados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbestados.FormattingEnabled = true;
            this.cbestados.Location = new System.Drawing.Point(77, 23);
            this.cbestados.Name = "cbestados";
            this.cbestados.Size = new System.Drawing.Size(130, 24);
            this.cbestados.TabIndex = 19;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(19, 26);
            this.lblestado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(51, 16);
            this.lblestado.TabIndex = 18;
            this.lblestado.Text = "Estado";
            // 
            // Modificar_Estado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(278, 193);
            this.Controls.Add(this.gbPedidoSelec);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gbModificar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Modificar_Estado";
            this.Text = "Modificar Estado";
            this.Load += new System.EventHandler(this.Modificar_Estado_Load);
            this.gbPedidoSelec.ResumeLayout(false);
            this.gbPedidoSelec.PerformLayout();
            this.gbModificar.ResumeLayout(false);
            this.gbModificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPedidoSelec;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox gbModificar;
        private System.Windows.Forms.ComboBox cbestados;
        private System.Windows.Forms.Label lblestado;
    }
}