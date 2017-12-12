namespace PIM.Desktop
{
    partial class frmTipoDeReservaEditar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelarEdicaoTipoReserva = new System.Windows.Forms.Button();
            this.btnSalvarEdicaoTipoReserva = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEditarCodTipoReserva = new System.Windows.Forms.TextBox();
            this.txtEditarTipoReserva = new System.Windows.Forms.TextBox();
            this.lblEditarTipoReserva = new System.Windows.Forms.Label();
            this.lblEditarCodTipoReserva = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancelarEdicaoTipoReserva);
            this.panel1.Controls.Add(this.btnSalvarEdicaoTipoReserva);
            this.panel1.Location = new System.Drawing.Point(31, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 96);
            this.panel1.TabIndex = 22;
            // 
            // btnCancelarEdicaoTipoReserva
            // 
            this.btnCancelarEdicaoTipoReserva.Location = new System.Drawing.Point(526, 37);
            this.btnCancelarEdicaoTipoReserva.Name = "btnCancelarEdicaoTipoReserva";
            this.btnCancelarEdicaoTipoReserva.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarEdicaoTipoReserva.TabIndex = 19;
            this.btnCancelarEdicaoTipoReserva.Text = "Cancelar";
            this.btnCancelarEdicaoTipoReserva.UseVisualStyleBackColor = true;
            this.btnCancelarEdicaoTipoReserva.Click += new System.EventHandler(this.btnCancelarEdicaoTipoReserva_Click);
            // 
            // btnSalvarEdicaoTipoReserva
            // 
            this.btnSalvarEdicaoTipoReserva.Location = new System.Drawing.Point(139, 37);
            this.btnSalvarEdicaoTipoReserva.Name = "btnSalvarEdicaoTipoReserva";
            this.btnSalvarEdicaoTipoReserva.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarEdicaoTipoReserva.TabIndex = 18;
            this.btnSalvarEdicaoTipoReserva.Text = "Salvar";
            this.btnSalvarEdicaoTipoReserva.UseVisualStyleBackColor = true;
            this.btnSalvarEdicaoTipoReserva.Click += new System.EventHandler(this.btnSalvarEdicaoTipoReserva_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtEditarCodTipoReserva);
            this.panel2.Controls.Add(this.txtEditarTipoReserva);
            this.panel2.Controls.Add(this.lblEditarTipoReserva);
            this.panel2.Controls.Add(this.lblEditarCodTipoReserva);
            this.panel2.Location = new System.Drawing.Point(31, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 248);
            this.panel2.TabIndex = 21;
            // 
            // txtEditarCodTipoReserva
            // 
            this.txtEditarCodTipoReserva.Location = new System.Drawing.Point(131, 106);
            this.txtEditarCodTipoReserva.Name = "txtEditarCodTipoReserva";
            this.txtEditarCodTipoReserva.Size = new System.Drawing.Size(100, 22);
            this.txtEditarCodTipoReserva.TabIndex = 3;
            // 
            // txtEditarTipoReserva
            // 
            this.txtEditarTipoReserva.Location = new System.Drawing.Point(514, 104);
            this.txtEditarTipoReserva.Name = "txtEditarTipoReserva";
            this.txtEditarTipoReserva.Size = new System.Drawing.Size(155, 22);
            this.txtEditarTipoReserva.TabIndex = 2;
            // 
            // lblEditarTipoReserva
            // 
            this.lblEditarTipoReserva.AutoSize = true;
            this.lblEditarTipoReserva.Location = new System.Drawing.Point(391, 109);
            this.lblEditarTipoReserva.Name = "lblEditarTipoReserva";
            this.lblEditarTipoReserva.Size = new System.Drawing.Size(117, 17);
            this.lblEditarTipoReserva.TabIndex = 1;
            this.lblEditarTipoReserva.Text = "Tipo de Reserva:";
            // 
            // lblEditarCodTipoReserva
            // 
            this.lblEditarCodTipoReserva.AutoSize = true;
            this.lblEditarCodTipoReserva.Location = new System.Drawing.Point(67, 111);
            this.lblEditarCodTipoReserva.Name = "lblEditarCodTipoReserva";
            this.lblEditarCodTipoReserva.Size = new System.Drawing.Size(56, 17);
            this.lblEditarCodTipoReserva.TabIndex = 0;
            this.lblEditarCodTipoReserva.Text = "Código:";
            // 
            // frmTipoDeReservaEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmTipoDeReservaEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Tipo de Reserva";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelarEdicaoTipoReserva;
        private System.Windows.Forms.Button btnSalvarEdicaoTipoReserva;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEditarCodTipoReserva;
        private System.Windows.Forms.TextBox txtEditarTipoReserva;
        private System.Windows.Forms.Label lblEditarTipoReserva;
        private System.Windows.Forms.Label lblEditarCodTipoReserva;
    }
}