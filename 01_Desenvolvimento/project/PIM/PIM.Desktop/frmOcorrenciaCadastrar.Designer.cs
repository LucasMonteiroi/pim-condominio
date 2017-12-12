namespace PIM.Desktop
{
    partial class frmOcorrenciaCadastrar
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
            this.btnCancelarCadOcorrencia = new System.Windows.Forms.Button();
            this.btnSalvarCadOcorrencia = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblDataOcorrencia = new System.Windows.Forms.Label();
            this.rtxtDescricaoOcorrencia = new System.Windows.Forms.RichTextBox();
            this.lblDescricaoOcorrencia = new System.Windows.Forms.Label();
            this.txtMotivoOcorrencia = new System.Windows.Forms.TextBox();
            this.lblMotivoOcorrencia = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtCodMorOcorrencia = new System.Windows.Forms.TextBox();
            this.lblCodMorOcorrencia = new System.Windows.Forms.Label();
            this.lblCodOcorrencia = new System.Windows.Forms.Label();
            this.dtOcorrencia = new System.Windows.Forms.DateTimePicker();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.btnCancelarCadOcorrencia);
            this.panel9.Controls.Add(this.btnSalvarCadOcorrencia);
            this.panel9.Location = new System.Drawing.Point(28, 443);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(744, 64);
            this.panel9.TabIndex = 20;
            // 
            // btnCancelarCadOcorrencia
            // 
            this.btnCancelarCadOcorrencia.Location = new System.Drawing.Point(538, 20);
            this.btnCancelarCadOcorrencia.Name = "btnCancelarCadOcorrencia";
            this.btnCancelarCadOcorrencia.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCadOcorrencia.TabIndex = 18;
            this.btnCancelarCadOcorrencia.Text = "Cancelar";
            this.btnCancelarCadOcorrencia.UseVisualStyleBackColor = true;
            this.btnCancelarCadOcorrencia.Click += new System.EventHandler(this.btnCancelarCadOcorrencia_Click);
            // 
            // btnSalvarCadOcorrencia
            // 
            this.btnSalvarCadOcorrencia.Location = new System.Drawing.Point(131, 20);
            this.btnSalvarCadOcorrencia.Name = "btnSalvarCadOcorrencia";
            this.btnSalvarCadOcorrencia.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarCadOcorrencia.TabIndex = 17;
            this.btnSalvarCadOcorrencia.Text = "Salvar";
            this.btnSalvarCadOcorrencia.UseVisualStyleBackColor = true;
            this.btnSalvarCadOcorrencia.Click += new System.EventHandler(this.btnSalvarCadOcorrencia_Click);
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.dtOcorrencia);
            this.panel10.Controls.Add(this.txtCodMorOcorrencia);
            this.panel10.Controls.Add(this.lblCodMorOcorrencia);
            this.panel10.Controls.Add(this.lblDataOcorrencia);
            this.panel10.Controls.Add(this.rtxtDescricaoOcorrencia);
            this.panel10.Controls.Add(this.lblDescricaoOcorrencia);
            this.panel10.Controls.Add(this.txtMotivoOcorrencia);
            this.panel10.Controls.Add(this.lblMotivoOcorrencia);
            this.panel10.Location = new System.Drawing.Point(28, 80);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(744, 357);
            this.panel10.TabIndex = 19;
            // 
            // lblDataOcorrencia
            // 
            this.lblDataOcorrencia.AutoSize = true;
            this.lblDataOcorrencia.Location = new System.Drawing.Point(383, 19);
            this.lblDataOcorrencia.Name = "lblDataOcorrencia";
            this.lblDataOcorrencia.Size = new System.Drawing.Size(42, 17);
            this.lblDataOcorrencia.TabIndex = 17;
            this.lblDataOcorrencia.Text = "Data:";
            // 
            // rtxtDescricaoOcorrencia
            // 
            this.rtxtDescricaoOcorrencia.BackColor = System.Drawing.Color.White;
            this.rtxtDescricaoOcorrencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtDescricaoOcorrencia.Location = new System.Drawing.Point(95, 136);
            this.rtxtDescricaoOcorrencia.Name = "rtxtDescricaoOcorrencia";
            this.rtxtDescricaoOcorrencia.Size = new System.Drawing.Size(607, 203);
            this.rtxtDescricaoOcorrencia.TabIndex = 15;
            this.rtxtDescricaoOcorrencia.Text = "";
            // 
            // lblDescricaoOcorrencia
            // 
            this.lblDescricaoOcorrencia.AutoSize = true;
            this.lblDescricaoOcorrencia.Location = new System.Drawing.Point(14, 199);
            this.lblDescricaoOcorrencia.Name = "lblDescricaoOcorrencia";
            this.lblDescricaoOcorrencia.Size = new System.Drawing.Size(75, 17);
            this.lblDescricaoOcorrencia.TabIndex = 14;
            this.lblDescricaoOcorrencia.Text = "Descrição:";
            this.lblDescricaoOcorrencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMotivoOcorrencia
            // 
            this.txtMotivoOcorrencia.BackColor = System.Drawing.Color.White;
            this.txtMotivoOcorrencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotivoOcorrencia.Location = new System.Drawing.Point(95, 64);
            this.txtMotivoOcorrencia.Multiline = true;
            this.txtMotivoOcorrencia.Name = "txtMotivoOcorrencia";
            this.txtMotivoOcorrencia.Size = new System.Drawing.Size(314, 53);
            this.txtMotivoOcorrencia.TabIndex = 13;
            // 
            // lblMotivoOcorrencia
            // 
            this.lblMotivoOcorrencia.AutoSize = true;
            this.lblMotivoOcorrencia.Location = new System.Drawing.Point(36, 78);
            this.lblMotivoOcorrencia.Name = "lblMotivoOcorrencia";
            this.lblMotivoOcorrencia.Size = new System.Drawing.Size(53, 17);
            this.lblMotivoOcorrencia.TabIndex = 12;
            this.lblMotivoOcorrencia.Text = "Motivo:";
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.lblCodOcorrencia);
            this.panel11.Location = new System.Drawing.Point(28, 21);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(744, 53);
            this.panel11.TabIndex = 18;
            // 
            // txtCodMorOcorrencia
            // 
            this.txtCodMorOcorrencia.BackColor = System.Drawing.Color.White;
            this.txtCodMorOcorrencia.Location = new System.Drawing.Point(178, 14);
            this.txtCodMorOcorrencia.Name = "txtCodMorOcorrencia";
            this.txtCodMorOcorrencia.Size = new System.Drawing.Size(131, 22);
            this.txtCodMorOcorrencia.TabIndex = 11;
            // 
            // lblCodMorOcorrencia
            // 
            this.lblCodMorOcorrencia.AutoSize = true;
            this.lblCodMorOcorrencia.Location = new System.Drawing.Point(39, 19);
            this.lblCodMorOcorrencia.Name = "lblCodMorOcorrencia";
            this.lblCodMorOcorrencia.Size = new System.Drawing.Size(133, 17);
            this.lblCodMorOcorrencia.TabIndex = 10;
            this.lblCodMorOcorrencia.Text = "Código do Morador:";
            // 
            // lblCodOcorrencia
            // 
            this.lblCodOcorrencia.AutoSize = true;
            this.lblCodOcorrencia.Location = new System.Drawing.Point(43, 11);
            this.lblCodOcorrencia.Name = "lblCodOcorrencia";
            this.lblCodOcorrencia.Size = new System.Drawing.Size(0, 17);
            this.lblCodOcorrencia.TabIndex = 0;
            // 
            // dtOcorrencia
            // 
            this.dtOcorrencia.Location = new System.Drawing.Point(431, 14);
            this.dtOcorrencia.Name = "dtOcorrencia";
            this.dtOcorrencia.Size = new System.Drawing.Size(271, 22);
            this.dtOcorrencia.TabIndex = 18;
            // 
            // frmOcorrenciaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel11);
            this.Name = "frmOcorrenciaCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Ocorrência";
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnCancelarCadOcorrencia;
        private System.Windows.Forms.Button btnSalvarCadOcorrencia;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblDataOcorrencia;
        private System.Windows.Forms.RichTextBox rtxtDescricaoOcorrencia;
        private System.Windows.Forms.Label lblDescricaoOcorrencia;
        private System.Windows.Forms.TextBox txtMotivoOcorrencia;
        private System.Windows.Forms.Label lblMotivoOcorrencia;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtCodMorOcorrencia;
        private System.Windows.Forms.Label lblCodMorOcorrencia;
        private System.Windows.Forms.Label lblCodOcorrencia;
        private System.Windows.Forms.DateTimePicker dtOcorrencia;
    }
}