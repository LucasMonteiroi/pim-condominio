namespace PIM.Desktop
{
    partial class frmApartamentoEditar
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnCancelarEdicaoApartamento = new System.Windows.Forms.Button();
            this.btnSalvarEdicaoApartamento = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtEditarCodContrato = new System.Windows.Forms.TextBox();
            this.txtEditarBlocoApto = new System.Windows.Forms.TextBox();
            this.txtEditarNumeroApto = new System.Windows.Forms.TextBox();
            this.lblEditarCodContrato = new System.Windows.Forms.Label();
            this.lblEditarNumeroApto = new System.Windows.Forms.Label();
            this.lblEditarBlocoApto = new System.Windows.Forms.Label();
            this.lblEditarCodigoApto = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.btnCancelarEdicaoApartamento);
            this.panel7.Controls.Add(this.btnSalvarEdicaoApartamento);
            this.panel7.Location = new System.Drawing.Point(30, 394);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(742, 78);
            this.panel7.TabIndex = 21;
            // 
            // btnCancelarEdicaoApartamento
            // 
            this.btnCancelarEdicaoApartamento.Location = new System.Drawing.Point(556, 28);
            this.btnCancelarEdicaoApartamento.Name = "btnCancelarEdicaoApartamento";
            this.btnCancelarEdicaoApartamento.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarEdicaoApartamento.TabIndex = 12;
            this.btnCancelarEdicaoApartamento.Text = "Cancelar";
            this.btnCancelarEdicaoApartamento.UseVisualStyleBackColor = true;
            this.btnCancelarEdicaoApartamento.Click += new System.EventHandler(this.btnCancelarEdicaoApartamento_Click);
            // 
            // btnSalvarEdicaoApartamento
            // 
            this.btnSalvarEdicaoApartamento.Location = new System.Drawing.Point(112, 28);
            this.btnSalvarEdicaoApartamento.Name = "btnSalvarEdicaoApartamento";
            this.btnSalvarEdicaoApartamento.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarEdicaoApartamento.TabIndex = 11;
            this.btnSalvarEdicaoApartamento.Text = "Salvar";
            this.btnSalvarEdicaoApartamento.UseVisualStyleBackColor = true;
            this.btnSalvarEdicaoApartamento.Click += new System.EventHandler(this.btnSalvarEdicaoApartamento_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txtEditarCodContrato);
            this.panel6.Controls.Add(this.txtEditarBlocoApto);
            this.panel6.Controls.Add(this.txtEditarNumeroApto);
            this.panel6.Controls.Add(this.lblEditarCodContrato);
            this.panel6.Controls.Add(this.lblEditarNumeroApto);
            this.panel6.Controls.Add(this.lblEditarBlocoApto);
            this.panel6.Controls.Add(this.lblEditarCodigoApto);
            this.panel6.Location = new System.Drawing.Point(30, 61);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(742, 287);
            this.panel6.TabIndex = 20;
            // 
            // txtEditarCodContrato
            // 
            this.txtEditarCodContrato.Location = new System.Drawing.Point(524, 187);
            this.txtEditarCodContrato.Name = "txtEditarCodContrato";
            this.txtEditarCodContrato.Size = new System.Drawing.Size(107, 22);
            this.txtEditarCodContrato.TabIndex = 15;
            // 
            // txtEditarBlocoApto
            // 
            this.txtEditarBlocoApto.Location = new System.Drawing.Point(524, 55);
            this.txtEditarBlocoApto.Name = "txtEditarBlocoApto";
            this.txtEditarBlocoApto.Size = new System.Drawing.Size(107, 22);
            this.txtEditarBlocoApto.TabIndex = 14;
            // 
            // txtEditarNumeroApto
            // 
            this.txtEditarNumeroApto.Location = new System.Drawing.Point(145, 187);
            this.txtEditarNumeroApto.Name = "txtEditarNumeroApto";
            this.txtEditarNumeroApto.Size = new System.Drawing.Size(107, 22);
            this.txtEditarNumeroApto.TabIndex = 13;
            // 
            // lblEditarCodContrato
            // 
            this.lblEditarCodContrato.AutoSize = true;
            this.lblEditarCodContrato.Location = new System.Drawing.Point(384, 192);
            this.lblEditarCodContrato.Name = "lblEditarCodContrato";
            this.lblEditarCodContrato.Size = new System.Drawing.Size(134, 17);
            this.lblEditarCodContrato.TabIndex = 11;
            this.lblEditarCodContrato.Text = "Código do Contrato:";
            // 
            // lblEditarNumeroApto
            // 
            this.lblEditarNumeroApto.AutoSize = true;
            this.lblEditarNumeroApto.Location = new System.Drawing.Point(68, 192);
            this.lblEditarNumeroApto.Name = "lblEditarNumeroApto";
            this.lblEditarNumeroApto.Size = new System.Drawing.Size(62, 17);
            this.lblEditarNumeroApto.TabIndex = 10;
            this.lblEditarNumeroApto.Text = "Número:";
            // 
            // lblEditarBlocoApto
            // 
            this.lblEditarBlocoApto.AutoSize = true;
            this.lblEditarBlocoApto.Location = new System.Drawing.Point(447, 60);
            this.lblEditarBlocoApto.Name = "lblEditarBlocoApto";
            this.lblEditarBlocoApto.Size = new System.Drawing.Size(47, 17);
            this.lblEditarBlocoApto.TabIndex = 9;
            this.lblEditarBlocoApto.Text = "Bloco:";
            // 
            // lblEditarCodigoApto
            // 
            this.lblEditarCodigoApto.AutoSize = true;
            this.lblEditarCodigoApto.Location = new System.Drawing.Point(109, 55);
            this.lblEditarCodigoApto.Name = "lblEditarCodigoApto";
            this.lblEditarCodigoApto.Size = new System.Drawing.Size(0, 17);
            this.lblEditarCodigoApto.TabIndex = 8;
            // 
            // frmApartamentoEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Name = "frmApartamentoEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Apartamento";
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnCancelarEdicaoApartamento;
        private System.Windows.Forms.Button btnSalvarEdicaoApartamento;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtEditarCodContrato;
        private System.Windows.Forms.TextBox txtEditarBlocoApto;
        private System.Windows.Forms.TextBox txtEditarNumeroApto;
        private System.Windows.Forms.Label lblEditarCodContrato;
        private System.Windows.Forms.Label lblEditarNumeroApto;
        private System.Windows.Forms.Label lblEditarBlocoApto;
        private System.Windows.Forms.Label lblEditarCodigoApto;
    }
}