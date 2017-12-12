namespace PIM.Desktop
{
    partial class frmContratoCadastrar
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnCancelarTelaContrato = new System.Windows.Forms.Button();
            this.btnSalvarContrato = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblTipoContrato = new System.Windows.Forms.Label();
            this.cboTipoContrato = new System.Windows.Forms.ComboBox();
            this.txtParcelasContrato = new System.Windows.Forms.TextBox();
            this.lblParcelasContrato = new System.Windows.Forms.Label();
            this.txtCodMorador = new System.Windows.Forms.TextBox();
            this.lblCodMorador = new System.Windows.Forms.Label();
            this.txtValorContrato = new System.Windows.Forms.TextBox();
            this.lblValorContrato = new System.Windows.Forms.Label();
            this.txtDataContrato = new System.Windows.Forms.TextBox();
            this.lblDataContrato = new System.Windows.Forms.Label();
            this.lblCodContrato = new System.Windows.Forms.Label();
            this.rtxtDescricaoContrato = new System.Windows.Forms.RichTextBox();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.btnCancelarTelaContrato);
            this.panel9.Controls.Add(this.btnSalvarContrato);
            this.panel9.Location = new System.Drawing.Point(26, 399);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(736, 67);
            this.panel9.TabIndex = 29;
            // 
            // btnCancelarTelaContrato
            // 
            this.btnCancelarTelaContrato.Location = new System.Drawing.Point(604, 22);
            this.btnCancelarTelaContrato.Name = "btnCancelarTelaContrato";
            this.btnCancelarTelaContrato.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarTelaContrato.TabIndex = 20;
            this.btnCancelarTelaContrato.Text = "Cancelar";
            this.btnCancelarTelaContrato.UseVisualStyleBackColor = true;
            this.btnCancelarTelaContrato.Click += new System.EventHandler(this.btnCancelarTelaContrato_Click);
            // 
            // btnSalvarContrato
            // 
            this.btnSalvarContrato.Location = new System.Drawing.Point(63, 22);
            this.btnSalvarContrato.Name = "btnSalvarContrato";
            this.btnSalvarContrato.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarContrato.TabIndex = 19;
            this.btnSalvarContrato.Text = "Salvar";
            this.btnSalvarContrato.UseVisualStyleBackColor = true;
            this.btnSalvarContrato.Click += new System.EventHandler(this.btnSalvarContrato_Click);
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.lblTipoContrato);
            this.panel10.Controls.Add(this.cboTipoContrato);
            this.panel10.Controls.Add(this.txtParcelasContrato);
            this.panel10.Controls.Add(this.lblParcelasContrato);
            this.panel10.Controls.Add(this.txtCodMorador);
            this.panel10.Controls.Add(this.lblCodMorador);
            this.panel10.Controls.Add(this.txtValorContrato);
            this.panel10.Controls.Add(this.lblValorContrato);
            this.panel10.Controls.Add(this.txtDataContrato);
            this.panel10.Controls.Add(this.lblDataContrato);
            this.panel10.Controls.Add(this.lblCodContrato);
            this.panel10.Location = new System.Drawing.Point(26, 26);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(736, 149);
            this.panel10.TabIndex = 28;
            // 
            // lblTipoContrato
            // 
            this.lblTipoContrato.AutoSize = true;
            this.lblTipoContrato.Location = new System.Drawing.Point(11, 115);
            this.lblTipoContrato.Name = "lblTipoContrato";
            this.lblTipoContrato.Size = new System.Drawing.Size(118, 17);
            this.lblTipoContrato.TabIndex = 28;
            this.lblTipoContrato.Text = "Tipo de Contrato:";
            // 
            // cboTipoContrato
            // 
            this.cboTipoContrato.BackColor = System.Drawing.Color.White;
            this.cboTipoContrato.FormattingEnabled = true;
            this.cboTipoContrato.Items.AddRange(new object[] {
            "Locação ",
            "Compra"});
            this.cboTipoContrato.Location = new System.Drawing.Point(150, 112);
            this.cboTipoContrato.Name = "cboTipoContrato";
            this.cboTipoContrato.Size = new System.Drawing.Size(121, 24);
            this.cboTipoContrato.TabIndex = 27;
            // 
            // txtParcelasContrato
            // 
            this.txtParcelasContrato.BackColor = System.Drawing.Color.White;
            this.txtParcelasContrato.Location = new System.Drawing.Point(604, 66);
            this.txtParcelasContrato.Name = "txtParcelasContrato";
            this.txtParcelasContrato.Size = new System.Drawing.Size(100, 22);
            this.txtParcelasContrato.TabIndex = 26;
            // 
            // lblParcelasContrato
            // 
            this.lblParcelasContrato.AutoSize = true;
            this.lblParcelasContrato.Location = new System.Drawing.Point(531, 69);
            this.lblParcelasContrato.Name = "lblParcelasContrato";
            this.lblParcelasContrato.Size = new System.Drawing.Size(67, 17);
            this.lblParcelasContrato.TabIndex = 25;
            this.lblParcelasContrato.Text = "Parcelas:";
            // 
            // txtCodMorador
            // 
            this.txtCodMorador.BackColor = System.Drawing.Color.White;
            this.txtCodMorador.Location = new System.Drawing.Point(411, 13);
            this.txtCodMorador.Name = "txtCodMorador";
            this.txtCodMorador.Size = new System.Drawing.Size(200, 22);
            this.txtCodMorador.TabIndex = 24;
            // 
            // lblCodMorador
            // 
            this.lblCodMorador.AutoSize = true;
            this.lblCodMorador.Location = new System.Drawing.Point(272, 18);
            this.lblCodMorador.Name = "lblCodMorador";
            this.lblCodMorador.Size = new System.Drawing.Size(133, 17);
            this.lblCodMorador.TabIndex = 23;
            this.lblCodMorador.Text = "Código de Morador:";
            // 
            // txtValorContrato
            // 
            this.txtValorContrato.BackColor = System.Drawing.Color.White;
            this.txtValorContrato.Location = new System.Drawing.Point(357, 64);
            this.txtValorContrato.Name = "txtValorContrato";
            this.txtValorContrato.Size = new System.Drawing.Size(142, 22);
            this.txtValorContrato.TabIndex = 22;
            // 
            // lblValorContrato
            // 
            this.lblValorContrato.AutoSize = true;
            this.lblValorContrato.Location = new System.Drawing.Point(306, 69);
            this.lblValorContrato.Name = "lblValorContrato";
            this.lblValorContrato.Size = new System.Drawing.Size(45, 17);
            this.lblValorContrato.TabIndex = 21;
            this.lblValorContrato.Text = "Valor:";
            // 
            // txtDataContrato
            // 
            this.txtDataContrato.BackColor = System.Drawing.Color.White;
            this.txtDataContrato.Location = new System.Drawing.Point(150, 64);
            this.txtDataContrato.Name = "txtDataContrato";
            this.txtDataContrato.Size = new System.Drawing.Size(121, 22);
            this.txtDataContrato.TabIndex = 20;
            // 
            // lblDataContrato
            // 
            this.lblDataContrato.AutoSize = true;
            this.lblDataContrato.Location = new System.Drawing.Point(11, 69);
            this.lblDataContrato.Name = "lblDataContrato";
            this.lblDataContrato.Size = new System.Drawing.Size(124, 17);
            this.lblDataContrato.TabIndex = 19;
            this.lblDataContrato.Text = "Data do Contrato: ";
            // 
            // lblCodContrato
            // 
            this.lblCodContrato.AutoSize = true;
            this.lblCodContrato.Location = new System.Drawing.Point(78, 18);
            this.lblCodContrato.Name = "lblCodContrato";
            this.lblCodContrato.Size = new System.Drawing.Size(0, 17);
            this.lblCodContrato.TabIndex = 18;
            // 
            // rtxtDescricaoContrato
            // 
            this.rtxtDescricaoContrato.Location = new System.Drawing.Point(26, 181);
            this.rtxtDescricaoContrato.Name = "rtxtDescricaoContrato";
            this.rtxtDescricaoContrato.Size = new System.Drawing.Size(736, 212);
            this.rtxtDescricaoContrato.TabIndex = 30;
            this.rtxtDescricaoContrato.Text = "";
            // 
            // frmContratoCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.rtxtDescricaoContrato);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Name = "frmContratoCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Contrato";
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnSalvarContrato;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblTipoContrato;
        private System.Windows.Forms.ComboBox cboTipoContrato;
        private System.Windows.Forms.TextBox txtParcelasContrato;
        private System.Windows.Forms.Label lblParcelasContrato;
        private System.Windows.Forms.TextBox txtCodMorador;
        private System.Windows.Forms.Label lblCodMorador;
        private System.Windows.Forms.TextBox txtValorContrato;
        private System.Windows.Forms.Label lblValorContrato;
        private System.Windows.Forms.TextBox txtDataContrato;
        private System.Windows.Forms.Label lblDataContrato;
        private System.Windows.Forms.Label lblCodContrato;
        private System.Windows.Forms.Button btnCancelarTelaContrato;
        private System.Windows.Forms.RichTextBox rtxtDescricaoContrato;
    }
}