namespace PIM.Desktop
{
    partial class frmCadastrarOcorrencia
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
            this.btnCancelarOco = new System.Windows.Forms.Button();
            this.btnSalvarOco = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblDataCadOco = new System.Windows.Forms.Label();
            this.txtDataCadOco = new System.Windows.Forms.TextBox();
            this.rtxtDescricaoOco = new System.Windows.Forms.RichTextBox();
            this.lblDescricaoCadOco = new System.Windows.Forms.Label();
            this.txtMotivoCadOco = new System.Windows.Forms.TextBox();
            this.lblMotivoCadOco = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtCodMorCadOco = new System.Windows.Forms.TextBox();
            this.lblCodMorCadOco = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.btnCancelarOco);
            this.panel7.Controls.Add(this.btnSalvarOco);
            this.panel7.Location = new System.Drawing.Point(16, 437);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(771, 84);
            this.panel7.TabIndex = 20;
            // 
            // btnCancelarOco
            // 
            this.btnCancelarOco.Location = new System.Drawing.Point(486, 31);
            this.btnCancelarOco.Name = "btnCancelarOco";
            this.btnCancelarOco.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarOco.TabIndex = 18;
            this.btnCancelarOco.Text = "Cancelar";
            this.btnCancelarOco.UseVisualStyleBackColor = true;
            // 
            // btnSalvarOco
            // 
            this.btnSalvarOco.Location = new System.Drawing.Point(201, 31);
            this.btnSalvarOco.Name = "btnSalvarOco";
            this.btnSalvarOco.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarOco.TabIndex = 17;
            this.btnSalvarOco.Text = "Salvar";
            this.btnSalvarOco.UseVisualStyleBackColor = true;
            this.btnSalvarOco.Click += new System.EventHandler(this.btnSalvarOco_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblDataCadOco);
            this.panel6.Controls.Add(this.txtDataCadOco);
            this.panel6.Controls.Add(this.rtxtDescricaoOco);
            this.panel6.Controls.Add(this.lblDescricaoCadOco);
            this.panel6.Controls.Add(this.txtMotivoCadOco);
            this.panel6.Controls.Add(this.lblMotivoCadOco);
            this.panel6.Location = new System.Drawing.Point(16, 120);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(765, 311);
            this.panel6.TabIndex = 19;
            // 
            // lblDataCadOco
            // 
            this.lblDataCadOco.AutoSize = true;
            this.lblDataCadOco.Location = new System.Drawing.Point(483, 45);
            this.lblDataCadOco.Name = "lblDataCadOco";
            this.lblDataCadOco.Size = new System.Drawing.Size(42, 17);
            this.lblDataCadOco.TabIndex = 17;
            this.lblDataCadOco.Text = "Data:";
            // 
            // txtDataCadOco
            // 
            this.txtDataCadOco.Location = new System.Drawing.Point(531, 40);
            this.txtDataCadOco.Name = "txtDataCadOco";
            this.txtDataCadOco.Size = new System.Drawing.Size(194, 22);
            this.txtDataCadOco.TabIndex = 16;
            // 
            // rtxtDescricaoOco
            // 
            this.rtxtDescricaoOco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtDescricaoOco.Location = new System.Drawing.Point(118, 105);
            this.rtxtDescricaoOco.Name = "rtxtDescricaoOco";
            this.rtxtDescricaoOco.Size = new System.Drawing.Size(607, 165);
            this.rtxtDescricaoOco.TabIndex = 15;
            this.rtxtDescricaoOco.Text = "";
            // 
            // lblDescricaoCadOco
            // 
            this.lblDescricaoCadOco.AutoSize = true;
            this.lblDescricaoCadOco.Location = new System.Drawing.Point(30, 191);
            this.lblDescricaoCadOco.Name = "lblDescricaoCadOco";
            this.lblDescricaoCadOco.Size = new System.Drawing.Size(75, 17);
            this.lblDescricaoCadOco.TabIndex = 14;
            this.lblDescricaoCadOco.Text = "Descrição:";
            // 
            // txtMotivoCadOco
            // 
            this.txtMotivoCadOco.Location = new System.Drawing.Point(118, 28);
            this.txtMotivoCadOco.Multiline = true;
            this.txtMotivoCadOco.Name = "txtMotivoCadOco";
            this.txtMotivoCadOco.Size = new System.Drawing.Size(307, 53);
            this.txtMotivoCadOco.TabIndex = 13;
            // 
            // lblMotivoCadOco
            // 
            this.lblMotivoCadOco.AutoSize = true;
            this.lblMotivoCadOco.Location = new System.Drawing.Point(52, 47);
            this.lblMotivoCadOco.Name = "lblMotivoCadOco";
            this.lblMotivoCadOco.Size = new System.Drawing.Size(53, 17);
            this.lblMotivoCadOco.TabIndex = 12;
            this.lblMotivoCadOco.Text = "Motivo:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtCodMorCadOco);
            this.panel5.Controls.Add(this.lblCodMorCadOco);
            this.panel5.Location = new System.Drawing.Point(16, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(765, 102);
            this.panel5.TabIndex = 18;
            // 
            // txtCodMorCadOco
            // 
            this.txtCodMorCadOco.Location = new System.Drawing.Point(359, 35);
            this.txtCodMorCadOco.Name = "txtCodMorCadOco";
            this.txtCodMorCadOco.Size = new System.Drawing.Size(138, 22);
            this.txtCodMorCadOco.TabIndex = 11;
            // 
            // lblCodMorCadOco
            // 
            this.lblCodMorCadOco.AutoSize = true;
            this.lblCodMorCadOco.Location = new System.Drawing.Point(220, 40);
            this.lblCodMorCadOco.Name = "lblCodMorCadOco";
            this.lblCodMorCadOco.Size = new System.Drawing.Size(133, 17);
            this.lblCodMorCadOco.TabIndex = 10;
            this.lblCodMorCadOco.Text = "Código do Morador:";
            // 
            // frmCadastrarOcorrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Name = "frmCadastrarOcorrencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Ocorrência";
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnCancelarOco;
        private System.Windows.Forms.Button btnSalvarOco;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblDataCadOco;
        private System.Windows.Forms.TextBox txtDataCadOco;
        private System.Windows.Forms.RichTextBox rtxtDescricaoOco;
        private System.Windows.Forms.Label lblDescricaoCadOco;
        private System.Windows.Forms.TextBox txtMotivoCadOco;
        private System.Windows.Forms.Label lblMotivoCadOco;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtCodMorCadOco;
        private System.Windows.Forms.Label lblCodMorCadOco;
    }
}