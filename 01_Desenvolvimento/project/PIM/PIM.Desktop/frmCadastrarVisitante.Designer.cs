namespace PIM.Desktop
{
    partial class frmCadastrarVisitante
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAutorizacaoVisitante = new System.Windows.Forms.Label();
            this.txtAutorizacaoVisitante = new System.Windows.Forms.TextBox();
            this.txtCodVisitante = new System.Windows.Forms.TextBox();
            this.lblCodVisit = new System.Windows.Forms.Label();
            this.txtNomeVisit = new System.Windows.Forms.TextBox();
            this.lblNomeVisit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelarVisit = new System.Windows.Forms.Button();
            this.btnSalvarVisit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodMorVisit = new System.Windows.Forms.TextBox();
            this.lblCodMorVisit = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblAutorizacaoVisitante);
            this.panel3.Controls.Add(this.txtAutorizacaoVisitante);
            this.panel3.Controls.Add(this.txtCodVisitante);
            this.panel3.Controls.Add(this.lblCodVisit);
            this.panel3.Controls.Add(this.txtNomeVisit);
            this.panel3.Controls.Add(this.lblNomeVisit);
            this.panel3.Location = new System.Drawing.Point(13, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 282);
            this.panel3.TabIndex = 5;
            // 
            // lblAutorizacaoVisitante
            // 
            this.lblAutorizacaoVisitante.AutoSize = true;
            this.lblAutorizacaoVisitante.Location = new System.Drawing.Point(61, 201);
            this.lblAutorizacaoVisitante.Name = "lblAutorizacaoVisitante";
            this.lblAutorizacaoVisitante.Size = new System.Drawing.Size(87, 17);
            this.lblAutorizacaoVisitante.TabIndex = 5;
            this.lblAutorizacaoVisitante.Text = "Autorização:";
            // 
            // txtAutorizacaoVisitante
            // 
            this.txtAutorizacaoVisitante.Location = new System.Drawing.Point(191, 197);
            this.txtAutorizacaoVisitante.Name = "txtAutorizacaoVisitante";
            this.txtAutorizacaoVisitante.Size = new System.Drawing.Size(100, 22);
            this.txtAutorizacaoVisitante.TabIndex = 4;
            // 
            // txtCodVisitante
            // 
            this.txtCodVisitante.Location = new System.Drawing.Point(191, 119);
            this.txtCodVisitante.Name = "txtCodVisitante";
            this.txtCodVisitante.Size = new System.Drawing.Size(160, 22);
            this.txtCodVisitante.TabIndex = 3;
            // 
            // lblCodVisit
            // 
            this.lblCodVisit.AutoSize = true;
            this.lblCodVisit.Location = new System.Drawing.Point(58, 124);
            this.lblCodVisit.Name = "lblCodVisit";
            this.lblCodVisit.Size = new System.Drawing.Size(134, 17);
            this.lblCodVisit.TabIndex = 2;
            this.lblCodVisit.Text = "Código do Visitante:";
            // 
            // txtNomeVisit
            // 
            this.txtNomeVisit.Location = new System.Drawing.Point(191, 48);
            this.txtNomeVisit.Name = "txtNomeVisit";
            this.txtNomeVisit.Size = new System.Drawing.Size(502, 22);
            this.txtNomeVisit.TabIndex = 1;
            // 
            // lblNomeVisit
            // 
            this.lblNomeVisit.AutoSize = true;
            this.lblNomeVisit.Location = new System.Drawing.Point(58, 51);
            this.lblNomeVisit.Name = "lblNomeVisit";
            this.lblNomeVisit.Size = new System.Drawing.Size(127, 17);
            this.lblNomeVisit.TabIndex = 0;
            this.lblNomeVisit.Text = "Nome do Visitante:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCancelarVisit);
            this.panel2.Controls.Add(this.btnSalvarVisit);
            this.panel2.Location = new System.Drawing.Point(13, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 76);
            this.panel2.TabIndex = 4;
            // 
            // btnCancelarVisit
            // 
            this.btnCancelarVisit.Location = new System.Drawing.Point(558, 27);
            this.btnCancelarVisit.Name = "btnCancelarVisit";
            this.btnCancelarVisit.Size = new System.Drawing.Size(82, 23);
            this.btnCancelarVisit.TabIndex = 31;
            this.btnCancelarVisit.Text = "Cancelar";
            this.btnCancelarVisit.UseVisualStyleBackColor = true;
            this.btnCancelarVisit.Click += new System.EventHandler(this.btnCancelarVisit_Click);
            // 
            // btnSalvarVisit
            // 
            this.btnSalvarVisit.Location = new System.Drawing.Point(136, 27);
            this.btnSalvarVisit.Name = "btnSalvarVisit";
            this.btnSalvarVisit.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarVisit.TabIndex = 30;
            this.btnSalvarVisit.Text = "Salvar";
            this.btnSalvarVisit.UseVisualStyleBackColor = true;
            this.btnSalvarVisit.Click += new System.EventHandler(this.btnSalvarVisit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtCodMorVisit);
            this.panel1.Controls.Add(this.lblCodMorVisit);
            this.panel1.Location = new System.Drawing.Point(13, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 100);
            this.panel1.TabIndex = 3;
            // 
            // txtCodMorVisit
            // 
            this.txtCodMorVisit.Location = new System.Drawing.Point(348, 33);
            this.txtCodMorVisit.Name = "txtCodMorVisit";
            this.txtCodMorVisit.Size = new System.Drawing.Size(177, 22);
            this.txtCodMorVisit.TabIndex = 1;
            // 
            // lblCodMorVisit
            // 
            this.lblCodMorVisit.AutoSize = true;
            this.lblCodMorVisit.Location = new System.Drawing.Point(209, 38);
            this.lblCodMorVisit.Name = "lblCodMorVisit";
            this.lblCodMorVisit.Size = new System.Drawing.Size(133, 17);
            this.lblCodMorVisit.TabIndex = 0;
            this.lblCodMorVisit.Text = "Código do Morador:";
            // 
            // frmCadastrarVisitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCadastrarVisitante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Visitantes";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAutorizacaoVisitante;
        private System.Windows.Forms.TextBox txtAutorizacaoVisitante;
        private System.Windows.Forms.TextBox txtCodVisitante;
        private System.Windows.Forms.Label lblCodVisit;
        private System.Windows.Forms.TextBox txtNomeVisit;
        private System.Windows.Forms.Label lblNomeVisit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelarVisit;
        private System.Windows.Forms.Button btnSalvarVisit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCodMorVisit;
        private System.Windows.Forms.Label lblCodMorVisit;
    }
}