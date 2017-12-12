namespace PIM.Desktop
{
    partial class frmApartamentoCadastrar
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
            this.btnCancelarCadApartamento = new System.Windows.Forms.Button();
            this.btnSalvarCadApartamento = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtCodContrato = new System.Windows.Forms.TextBox();
            this.txtBlocoApto = new System.Windows.Forms.TextBox();
            this.txtNumeroApto = new System.Windows.Forms.TextBox();
            this.lblCodContrato = new System.Windows.Forms.Label();
            this.lblNumeroApto = new System.Windows.Forms.Label();
            this.lblBlocoApto = new System.Windows.Forms.Label();
            this.lblCodigoApto = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.btnCancelarCadApartamento);
            this.panel7.Controls.Add(this.btnSalvarCadApartamento);
            this.panel7.Location = new System.Drawing.Point(30, 397);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(742, 78);
            this.panel7.TabIndex = 19;
            // 
            // btnCancelarCadApartamento
            // 
            this.btnCancelarCadApartamento.Location = new System.Drawing.Point(556, 28);
            this.btnCancelarCadApartamento.Name = "btnCancelarCadApartamento";
            this.btnCancelarCadApartamento.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCadApartamento.TabIndex = 12;
            this.btnCancelarCadApartamento.Text = "Cancelar";
            this.btnCancelarCadApartamento.UseVisualStyleBackColor = true;
            // 
            // btnSalvarCadApartamento
            // 
            this.btnSalvarCadApartamento.Location = new System.Drawing.Point(112, 28);
            this.btnSalvarCadApartamento.Name = "btnSalvarCadApartamento";
            this.btnSalvarCadApartamento.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarCadApartamento.TabIndex = 11;
            this.btnSalvarCadApartamento.Text = "Salvar";
            this.btnSalvarCadApartamento.UseVisualStyleBackColor = true;
            this.btnSalvarCadApartamento.Click += new System.EventHandler(this.btnSalvarCadApartamento_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txtCodContrato);
            this.panel6.Controls.Add(this.txtBlocoApto);
            this.panel6.Controls.Add(this.txtNumeroApto);
            this.panel6.Controls.Add(this.lblCodContrato);
            this.panel6.Controls.Add(this.lblNumeroApto);
            this.panel6.Controls.Add(this.lblBlocoApto);
            this.panel6.Controls.Add(this.lblCodigoApto);
            this.panel6.Location = new System.Drawing.Point(30, 64);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(742, 287);
            this.panel6.TabIndex = 18;
            // 
            // txtCodContrato
            // 
            this.txtCodContrato.Location = new System.Drawing.Point(524, 187);
            this.txtCodContrato.Name = "txtCodContrato";
            this.txtCodContrato.Size = new System.Drawing.Size(107, 22);
            this.txtCodContrato.TabIndex = 15;
            // 
            // txtBlocoApto
            // 
            this.txtBlocoApto.Location = new System.Drawing.Point(524, 55);
            this.txtBlocoApto.Name = "txtBlocoApto";
            this.txtBlocoApto.Size = new System.Drawing.Size(107, 22);
            this.txtBlocoApto.TabIndex = 14;
            // 
            // txtNumeroApto
            // 
            this.txtNumeroApto.Location = new System.Drawing.Point(145, 187);
            this.txtNumeroApto.Name = "txtNumeroApto";
            this.txtNumeroApto.Size = new System.Drawing.Size(107, 22);
            this.txtNumeroApto.TabIndex = 13;
            // 
            // lblCodContrato
            // 
            this.lblCodContrato.AutoSize = true;
            this.lblCodContrato.Location = new System.Drawing.Point(384, 192);
            this.lblCodContrato.Name = "lblCodContrato";
            this.lblCodContrato.Size = new System.Drawing.Size(134, 17);
            this.lblCodContrato.TabIndex = 11;
            this.lblCodContrato.Text = "Código do Contrato:";
            // 
            // lblNumeroApto
            // 
            this.lblNumeroApto.AutoSize = true;
            this.lblNumeroApto.Location = new System.Drawing.Point(68, 192);
            this.lblNumeroApto.Name = "lblNumeroApto";
            this.lblNumeroApto.Size = new System.Drawing.Size(62, 17);
            this.lblNumeroApto.TabIndex = 10;
            this.lblNumeroApto.Text = "Número:";
            // 
            // lblBlocoApto
            // 
            this.lblBlocoApto.AutoSize = true;
            this.lblBlocoApto.Location = new System.Drawing.Point(447, 60);
            this.lblBlocoApto.Name = "lblBlocoApto";
            this.lblBlocoApto.Size = new System.Drawing.Size(47, 17);
            this.lblBlocoApto.TabIndex = 9;
            this.lblBlocoApto.Text = "Bloco:";
            // 
            // lblCodigoApto
            // 
            this.lblCodigoApto.AutoSize = true;
            this.lblCodigoApto.Location = new System.Drawing.Point(109, 55);
            this.lblCodigoApto.Name = "lblCodigoApto";
            this.lblCodigoApto.Size = new System.Drawing.Size(0, 17);
            this.lblCodigoApto.TabIndex = 8;
            // 
            // frmApartamentoCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Name = "frmApartamentoCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Apartamento";
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnCancelarCadApartamento;
        private System.Windows.Forms.Button btnSalvarCadApartamento;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtCodContrato;
        private System.Windows.Forms.TextBox txtBlocoApto;
        private System.Windows.Forms.TextBox txtNumeroApto;
        private System.Windows.Forms.Label lblCodContrato;
        private System.Windows.Forms.Label lblNumeroApto;
        private System.Windows.Forms.Label lblBlocoApto;
        private System.Windows.Forms.Label lblCodigoApto;
    }
}