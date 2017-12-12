namespace PIM.Desktop
{
    partial class frmContratoEditar
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
            this.rtxtEditarDescricaoContrato = new System.Windows.Forms.RichTextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnCancelarEdicaoContrato = new System.Windows.Forms.Button();
            this.btnSalvarEdicaoContrato = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblEditarTipoContrato = new System.Windows.Forms.Label();
            this.cboEditarTipoContrato = new System.Windows.Forms.ComboBox();
            this.txtEditarParcelasContrato = new System.Windows.Forms.TextBox();
            this.lblEditarParcelasContrato = new System.Windows.Forms.Label();
            this.txtCodMorador = new System.Windows.Forms.TextBox();
            this.lblCodMorador = new System.Windows.Forms.Label();
            this.txtEditarValorContrato = new System.Windows.Forms.TextBox();
            this.lblEditarValorContrato = new System.Windows.Forms.Label();
            this.txtEditarDataContrato = new System.Windows.Forms.TextBox();
            this.lblEditarDataContrato = new System.Windows.Forms.Label();
            this.lblEditarCodContrato = new System.Windows.Forms.Label();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtEditarDescricaoContrato
            // 
            this.rtxtEditarDescricaoContrato.Location = new System.Drawing.Point(34, 194);
            this.rtxtEditarDescricaoContrato.Name = "rtxtEditarDescricaoContrato";
            this.rtxtEditarDescricaoContrato.Size = new System.Drawing.Size(736, 212);
            this.rtxtEditarDescricaoContrato.TabIndex = 33;
            this.rtxtEditarDescricaoContrato.Text = "";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.btnCancelarEdicaoContrato);
            this.panel9.Controls.Add(this.btnSalvarEdicaoContrato);
            this.panel9.Location = new System.Drawing.Point(34, 412);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(736, 67);
            this.panel9.TabIndex = 32;
            // 
            // btnCancelarEdicaoContrato
            // 
            this.btnCancelarEdicaoContrato.Location = new System.Drawing.Point(604, 22);
            this.btnCancelarEdicaoContrato.Name = "btnCancelarEdicaoContrato";
            this.btnCancelarEdicaoContrato.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarEdicaoContrato.TabIndex = 20;
            this.btnCancelarEdicaoContrato.Text = "Cancelar";
            this.btnCancelarEdicaoContrato.UseVisualStyleBackColor = true;
            this.btnCancelarEdicaoContrato.Click += new System.EventHandler(this.btnCancelarEdicaoContrato_Click);
            // 
            // btnSalvarEdicaoContrato
            // 
            this.btnSalvarEdicaoContrato.Location = new System.Drawing.Point(63, 22);
            this.btnSalvarEdicaoContrato.Name = "btnSalvarEdicaoContrato";
            this.btnSalvarEdicaoContrato.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarEdicaoContrato.TabIndex = 19;
            this.btnSalvarEdicaoContrato.Text = "Salvar";
            this.btnSalvarEdicaoContrato.UseVisualStyleBackColor = true;
            this.btnSalvarEdicaoContrato.Click += new System.EventHandler(this.btnSalvarEdicaoContrato_Click);
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.lblEditarTipoContrato);
            this.panel10.Controls.Add(this.cboEditarTipoContrato);
            this.panel10.Controls.Add(this.txtEditarParcelasContrato);
            this.panel10.Controls.Add(this.lblEditarParcelasContrato);
            this.panel10.Controls.Add(this.txtCodMorador);
            this.panel10.Controls.Add(this.lblCodMorador);
            this.panel10.Controls.Add(this.txtEditarValorContrato);
            this.panel10.Controls.Add(this.lblEditarValorContrato);
            this.panel10.Controls.Add(this.txtEditarDataContrato);
            this.panel10.Controls.Add(this.lblEditarDataContrato);
            this.panel10.Controls.Add(this.lblEditarCodContrato);
            this.panel10.Location = new System.Drawing.Point(34, 39);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(736, 149);
            this.panel10.TabIndex = 31;
            // 
            // lblEditarTipoContrato
            // 
            this.lblEditarTipoContrato.AutoSize = true;
            this.lblEditarTipoContrato.Location = new System.Drawing.Point(11, 115);
            this.lblEditarTipoContrato.Name = "lblEditarTipoContrato";
            this.lblEditarTipoContrato.Size = new System.Drawing.Size(118, 17);
            this.lblEditarTipoContrato.TabIndex = 28;
            this.lblEditarTipoContrato.Text = "Tipo de Contrato:";
            // 
            // cboEditarTipoContrato
            // 
            this.cboEditarTipoContrato.BackColor = System.Drawing.Color.White;
            this.cboEditarTipoContrato.FormattingEnabled = true;
            this.cboEditarTipoContrato.Items.AddRange(new object[] {
            "Locação ",
            "Compra"});
            this.cboEditarTipoContrato.Location = new System.Drawing.Point(150, 112);
            this.cboEditarTipoContrato.Name = "cboEditarTipoContrato";
            this.cboEditarTipoContrato.Size = new System.Drawing.Size(121, 24);
            this.cboEditarTipoContrato.TabIndex = 27;
            // 
            // txtEditarParcelasContrato
            // 
            this.txtEditarParcelasContrato.BackColor = System.Drawing.Color.White;
            this.txtEditarParcelasContrato.Location = new System.Drawing.Point(604, 66);
            this.txtEditarParcelasContrato.Name = "txtEditarParcelasContrato";
            this.txtEditarParcelasContrato.Size = new System.Drawing.Size(100, 22);
            this.txtEditarParcelasContrato.TabIndex = 26;
            // 
            // lblEditarParcelasContrato
            // 
            this.lblEditarParcelasContrato.AutoSize = true;
            this.lblEditarParcelasContrato.Location = new System.Drawing.Point(531, 69);
            this.lblEditarParcelasContrato.Name = "lblEditarParcelasContrato";
            this.lblEditarParcelasContrato.Size = new System.Drawing.Size(67, 17);
            this.lblEditarParcelasContrato.TabIndex = 25;
            this.lblEditarParcelasContrato.Text = "Parcelas:";
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
            // txtEditarValorContrato
            // 
            this.txtEditarValorContrato.BackColor = System.Drawing.Color.White;
            this.txtEditarValorContrato.Location = new System.Drawing.Point(357, 64);
            this.txtEditarValorContrato.Name = "txtEditarValorContrato";
            this.txtEditarValorContrato.Size = new System.Drawing.Size(142, 22);
            this.txtEditarValorContrato.TabIndex = 22;
            // 
            // lblEditarValorContrato
            // 
            this.lblEditarValorContrato.AutoSize = true;
            this.lblEditarValorContrato.Location = new System.Drawing.Point(306, 69);
            this.lblEditarValorContrato.Name = "lblEditarValorContrato";
            this.lblEditarValorContrato.Size = new System.Drawing.Size(45, 17);
            this.lblEditarValorContrato.TabIndex = 21;
            this.lblEditarValorContrato.Text = "Valor:";
            // 
            // txtEditarDataContrato
            // 
            this.txtEditarDataContrato.BackColor = System.Drawing.Color.White;
            this.txtEditarDataContrato.Location = new System.Drawing.Point(150, 64);
            this.txtEditarDataContrato.Name = "txtEditarDataContrato";
            this.txtEditarDataContrato.Size = new System.Drawing.Size(121, 22);
            this.txtEditarDataContrato.TabIndex = 20;
            // 
            // lblEditarDataContrato
            // 
            this.lblEditarDataContrato.AutoSize = true;
            this.lblEditarDataContrato.Location = new System.Drawing.Point(11, 69);
            this.lblEditarDataContrato.Name = "lblEditarDataContrato";
            this.lblEditarDataContrato.Size = new System.Drawing.Size(124, 17);
            this.lblEditarDataContrato.TabIndex = 19;
            this.lblEditarDataContrato.Text = "Data do Contrato: ";
            // 
            // lblEditarCodContrato
            // 
            this.lblEditarCodContrato.AutoSize = true;
            this.lblEditarCodContrato.Location = new System.Drawing.Point(78, 18);
            this.lblEditarCodContrato.Name = "lblEditarCodContrato";
            this.lblEditarCodContrato.Size = new System.Drawing.Size(0, 17);
            this.lblEditarCodContrato.TabIndex = 18;
            // 
            // frmContratoEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.rtxtEditarDescricaoContrato);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Name = "frmContratoEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Contrato";
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtEditarDescricaoContrato;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnCancelarEdicaoContrato;
        private System.Windows.Forms.Button btnSalvarEdicaoContrato;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblEditarTipoContrato;
        private System.Windows.Forms.ComboBox cboEditarTipoContrato;
        private System.Windows.Forms.TextBox txtEditarParcelasContrato;
        private System.Windows.Forms.Label lblEditarParcelasContrato;
        private System.Windows.Forms.TextBox txtCodMorador;
        private System.Windows.Forms.Label lblCodMorador;
        private System.Windows.Forms.TextBox txtEditarValorContrato;
        private System.Windows.Forms.Label lblEditarValorContrato;
        private System.Windows.Forms.TextBox txtEditarDataContrato;
        private System.Windows.Forms.Label lblEditarDataContrato;
        private System.Windows.Forms.Label lblEditarCodContrato;
    }
}