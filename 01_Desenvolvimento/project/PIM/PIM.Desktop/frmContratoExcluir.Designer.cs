namespace PIM.Desktop
{
    partial class frmContratoExcluir
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
            this.rtxtExcluirDescricaoContrato = new System.Windows.Forms.RichTextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnCancelarExclusaoContrato = new System.Windows.Forms.Button();
            this.btnConfirmarExcluirContrato = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblExcluirTipoContrato = new System.Windows.Forms.Label();
            this.cboExcluirTipoContrato = new System.Windows.Forms.ComboBox();
            this.txtExcluirParcelasContrato = new System.Windows.Forms.TextBox();
            this.lblExcluirParcelasContrato = new System.Windows.Forms.Label();
            this.txtExcluirCodMorador = new System.Windows.Forms.TextBox();
            this.lblExcluirCodMorador = new System.Windows.Forms.Label();
            this.txtExcluirValorContrato = new System.Windows.Forms.TextBox();
            this.lblExcluirValorContrato = new System.Windows.Forms.Label();
            this.txtExcluirDataContrato = new System.Windows.Forms.TextBox();
            this.lblExcluirEditarDataContrato = new System.Windows.Forms.Label();
            this.lblExcluirCodContrato = new System.Windows.Forms.Label();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtExcluirDescricaoContrato
            // 
            this.rtxtExcluirDescricaoContrato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtExcluirDescricaoContrato.Location = new System.Drawing.Point(29, 198);
            this.rtxtExcluirDescricaoContrato.Name = "rtxtExcluirDescricaoContrato";
            this.rtxtExcluirDescricaoContrato.Size = new System.Drawing.Size(736, 212);
            this.rtxtExcluirDescricaoContrato.TabIndex = 36;
            this.rtxtExcluirDescricaoContrato.Text = "";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.btnCancelarExclusaoContrato);
            this.panel9.Controls.Add(this.btnConfirmarExcluirContrato);
            this.panel9.Location = new System.Drawing.Point(29, 416);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(736, 67);
            this.panel9.TabIndex = 35;
            // 
            // btnCancelarExclusaoContrato
            // 
            this.btnCancelarExclusaoContrato.Location = new System.Drawing.Point(604, 22);
            this.btnCancelarExclusaoContrato.Name = "btnCancelarExclusaoContrato";
            this.btnCancelarExclusaoContrato.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarExclusaoContrato.TabIndex = 20;
            this.btnCancelarExclusaoContrato.Text = "Cancelar";
            this.btnCancelarExclusaoContrato.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarExcluirContrato
            // 
            this.btnConfirmarExcluirContrato.Location = new System.Drawing.Point(63, 22);
            this.btnConfirmarExcluirContrato.Name = "btnConfirmarExcluirContrato";
            this.btnConfirmarExcluirContrato.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarExcluirContrato.TabIndex = 19;
            this.btnConfirmarExcluirContrato.Text = "Excluir";
            this.btnConfirmarExcluirContrato.UseVisualStyleBackColor = true;
            this.btnConfirmarExcluirContrato.Click += new System.EventHandler(this.btnConfirmarExcluirContrato_Click);
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.lblExcluirTipoContrato);
            this.panel10.Controls.Add(this.cboExcluirTipoContrato);
            this.panel10.Controls.Add(this.txtExcluirParcelasContrato);
            this.panel10.Controls.Add(this.lblExcluirParcelasContrato);
            this.panel10.Controls.Add(this.txtExcluirCodMorador);
            this.panel10.Controls.Add(this.lblExcluirCodMorador);
            this.panel10.Controls.Add(this.txtExcluirValorContrato);
            this.panel10.Controls.Add(this.lblExcluirValorContrato);
            this.panel10.Controls.Add(this.txtExcluirDataContrato);
            this.panel10.Controls.Add(this.lblExcluirEditarDataContrato);
            this.panel10.Controls.Add(this.lblExcluirCodContrato);
            this.panel10.Location = new System.Drawing.Point(29, 43);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(736, 149);
            this.panel10.TabIndex = 34;
            // 
            // lblExcluirTipoContrato
            // 
            this.lblExcluirTipoContrato.AutoSize = true;
            this.lblExcluirTipoContrato.Location = new System.Drawing.Point(11, 115);
            this.lblExcluirTipoContrato.Name = "lblExcluirTipoContrato";
            this.lblExcluirTipoContrato.Size = new System.Drawing.Size(118, 17);
            this.lblExcluirTipoContrato.TabIndex = 28;
            this.lblExcluirTipoContrato.Text = "Tipo de Contrato:";
            // 
            // cboExcluirTipoContrato
            // 
            this.cboExcluirTipoContrato.BackColor = System.Drawing.Color.White;
            this.cboExcluirTipoContrato.FormattingEnabled = true;
            this.cboExcluirTipoContrato.Items.AddRange(new object[] {
            "Locação ",
            "Compra"});
            this.cboExcluirTipoContrato.Location = new System.Drawing.Point(150, 112);
            this.cboExcluirTipoContrato.Name = "cboExcluirTipoContrato";
            this.cboExcluirTipoContrato.Size = new System.Drawing.Size(121, 24);
            this.cboExcluirTipoContrato.TabIndex = 27;
            // 
            // txtExcluirParcelasContrato
            // 
            this.txtExcluirParcelasContrato.BackColor = System.Drawing.Color.White;
            this.txtExcluirParcelasContrato.Location = new System.Drawing.Point(604, 66);
            this.txtExcluirParcelasContrato.Name = "txtExcluirParcelasContrato";
            this.txtExcluirParcelasContrato.Size = new System.Drawing.Size(100, 22);
            this.txtExcluirParcelasContrato.TabIndex = 26;
            // 
            // lblExcluirParcelasContrato
            // 
            this.lblExcluirParcelasContrato.AutoSize = true;
            this.lblExcluirParcelasContrato.Location = new System.Drawing.Point(531, 69);
            this.lblExcluirParcelasContrato.Name = "lblExcluirParcelasContrato";
            this.lblExcluirParcelasContrato.Size = new System.Drawing.Size(67, 17);
            this.lblExcluirParcelasContrato.TabIndex = 25;
            this.lblExcluirParcelasContrato.Text = "Parcelas:";
            // 
            // txtExcluirCodMorador
            // 
            this.txtExcluirCodMorador.BackColor = System.Drawing.Color.White;
            this.txtExcluirCodMorador.Location = new System.Drawing.Point(411, 13);
            this.txtExcluirCodMorador.Name = "txtExcluirCodMorador";
            this.txtExcluirCodMorador.Size = new System.Drawing.Size(200, 22);
            this.txtExcluirCodMorador.TabIndex = 24;
            // 
            // lblExcluirCodMorador
            // 
            this.lblExcluirCodMorador.AutoSize = true;
            this.lblExcluirCodMorador.Location = new System.Drawing.Point(272, 18);
            this.lblExcluirCodMorador.Name = "lblExcluirCodMorador";
            this.lblExcluirCodMorador.Size = new System.Drawing.Size(133, 17);
            this.lblExcluirCodMorador.TabIndex = 23;
            this.lblExcluirCodMorador.Text = "Código de Morador:";
            // 
            // txtExcluirValorContrato
            // 
            this.txtExcluirValorContrato.BackColor = System.Drawing.Color.White;
            this.txtExcluirValorContrato.Location = new System.Drawing.Point(357, 64);
            this.txtExcluirValorContrato.Name = "txtExcluirValorContrato";
            this.txtExcluirValorContrato.Size = new System.Drawing.Size(142, 22);
            this.txtExcluirValorContrato.TabIndex = 22;
            // 
            // lblExcluirValorContrato
            // 
            this.lblExcluirValorContrato.AutoSize = true;
            this.lblExcluirValorContrato.Location = new System.Drawing.Point(306, 69);
            this.lblExcluirValorContrato.Name = "lblExcluirValorContrato";
            this.lblExcluirValorContrato.Size = new System.Drawing.Size(45, 17);
            this.lblExcluirValorContrato.TabIndex = 21;
            this.lblExcluirValorContrato.Text = "Valor:";
            // 
            // txtExcluirDataContrato
            // 
            this.txtExcluirDataContrato.BackColor = System.Drawing.Color.White;
            this.txtExcluirDataContrato.Location = new System.Drawing.Point(150, 64);
            this.txtExcluirDataContrato.Name = "txtExcluirDataContrato";
            this.txtExcluirDataContrato.Size = new System.Drawing.Size(121, 22);
            this.txtExcluirDataContrato.TabIndex = 20;
            // 
            // lblExcluirEditarDataContrato
            // 
            this.lblExcluirEditarDataContrato.AutoSize = true;
            this.lblExcluirEditarDataContrato.Location = new System.Drawing.Point(11, 69);
            this.lblExcluirEditarDataContrato.Name = "lblExcluirEditarDataContrato";
            this.lblExcluirEditarDataContrato.Size = new System.Drawing.Size(124, 17);
            this.lblExcluirEditarDataContrato.TabIndex = 19;
            this.lblExcluirEditarDataContrato.Text = "Data do Contrato: ";
            // 
            // lblExcluirCodContrato
            // 
            this.lblExcluirCodContrato.AutoSize = true;
            this.lblExcluirCodContrato.Location = new System.Drawing.Point(78, 18);
            this.lblExcluirCodContrato.Name = "lblExcluirCodContrato";
            this.lblExcluirCodContrato.Size = new System.Drawing.Size(0, 17);
            this.lblExcluirCodContrato.TabIndex = 18;
            // 
            // frmContratoExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.rtxtExcluirDescricaoContrato);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Name = "frmContratoExcluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Contrato";
            this.Load += new System.EventHandler(this.frmContratoExcluir_Load);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtExcluirDescricaoContrato;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnCancelarExclusaoContrato;
        private System.Windows.Forms.Button btnConfirmarExcluirContrato;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblExcluirTipoContrato;
        private System.Windows.Forms.ComboBox cboExcluirTipoContrato;
        private System.Windows.Forms.TextBox txtExcluirParcelasContrato;
        private System.Windows.Forms.Label lblExcluirParcelasContrato;
        private System.Windows.Forms.TextBox txtExcluirCodMorador;
        private System.Windows.Forms.Label lblExcluirCodMorador;
        private System.Windows.Forms.TextBox txtExcluirValorContrato;
        private System.Windows.Forms.Label lblExcluirValorContrato;
        private System.Windows.Forms.TextBox txtExcluirDataContrato;
        private System.Windows.Forms.Label lblExcluirEditarDataContrato;
        private System.Windows.Forms.Label lblExcluirCodContrato;
    }
}