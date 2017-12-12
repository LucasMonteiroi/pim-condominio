namespace PIM.Desktop
{
    partial class frmDependenteEditar
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelarEdicaoDep = new System.Windows.Forms.Button();
            this.btnSalvarEdicaoDep = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEditarMoradorResp = new System.Windows.Forms.TextBox();
            this.cboEditarGrauParentesco = new System.Windows.Forms.ComboBox();
            this.txtEditarTelefoneDep = new System.Windows.Forms.TextBox();
            this.txtEditarRgDep = new System.Windows.Forms.TextBox();
            this.txtEditarNomeDep = new System.Windows.Forms.TextBox();
            this.lblGrauParent = new System.Windows.Forms.Label();
            this.lblEditarMorResp = new System.Windows.Forms.Label();
            this.lblEditarTelefoneDep = new System.Windows.Forms.Label();
            this.lblEditarRgDep = new System.Windows.Forms.Label();
            this.lblNomeCodigoDep = new System.Windows.Forms.Label();
            this.lblEditarCodigoDep = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCancelarEdicaoDep);
            this.panel2.Controls.Add(this.btnSalvarEdicaoDep);
            this.panel2.Location = new System.Drawing.Point(13, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 100);
            this.panel2.TabIndex = 5;
            // 
            // btnCancelarEdicaoDep
            // 
            this.btnCancelarEdicaoDep.Location = new System.Drawing.Point(557, 36);
            this.btnCancelarEdicaoDep.Name = "btnCancelarEdicaoDep";
            this.btnCancelarEdicaoDep.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarEdicaoDep.TabIndex = 1;
            this.btnCancelarEdicaoDep.Text = "Cancelar";
            this.btnCancelarEdicaoDep.UseVisualStyleBackColor = true;
            this.btnCancelarEdicaoDep.Click += new System.EventHandler(this.btnCancelarEdicaoDep_Click);
            // 
            // btnSalvarEdicaoDep
            // 
            this.btnSalvarEdicaoDep.Location = new System.Drawing.Point(108, 36);
            this.btnSalvarEdicaoDep.Name = "btnSalvarEdicaoDep";
            this.btnSalvarEdicaoDep.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarEdicaoDep.TabIndex = 0;
            this.btnSalvarEdicaoDep.Text = "Salvar";
            this.btnSalvarEdicaoDep.UseVisualStyleBackColor = true;
            this.btnSalvarEdicaoDep.Click += new System.EventHandler(this.btnSalvarEdicaoDep_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtEditarMoradorResp);
            this.panel1.Controls.Add(this.cboEditarGrauParentesco);
            this.panel1.Controls.Add(this.txtEditarTelefoneDep);
            this.panel1.Controls.Add(this.txtEditarRgDep);
            this.panel1.Controls.Add(this.txtEditarNomeDep);
            this.panel1.Controls.Add(this.lblGrauParent);
            this.panel1.Controls.Add(this.lblEditarMorResp);
            this.panel1.Controls.Add(this.lblEditarTelefoneDep);
            this.panel1.Controls.Add(this.lblEditarRgDep);
            this.panel1.Controls.Add(this.lblNomeCodigoDep);
            this.panel1.Controls.Add(this.lblEditarCodigoDep);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 397);
            this.panel1.TabIndex = 4;
            // 
            // txtEditarMoradorResp
            // 
            this.txtEditarMoradorResp.Location = new System.Drawing.Point(270, 269);
            this.txtEditarMoradorResp.Name = "txtEditarMoradorResp";
            this.txtEditarMoradorResp.Size = new System.Drawing.Size(373, 22);
            this.txtEditarMoradorResp.TabIndex = 11;
            // 
            // cboEditarGrauParentesco
            // 
            this.cboEditarGrauParentesco.FormattingEnabled = true;
            this.cboEditarGrauParentesco.Items.AddRange(new object[] {
            "Filho(a)",
            "Mãe",
            "Pai",
            "Conjugê",
            "Tio(a)"});
            this.cboEditarGrauParentesco.Location = new System.Drawing.Point(270, 332);
            this.cboEditarGrauParentesco.Name = "cboEditarGrauParentesco";
            this.cboEditarGrauParentesco.Size = new System.Drawing.Size(166, 24);
            this.cboEditarGrauParentesco.TabIndex = 10;
            // 
            // txtEditarTelefoneDep
            // 
            this.txtEditarTelefoneDep.Location = new System.Drawing.Point(183, 211);
            this.txtEditarTelefoneDep.Name = "txtEditarTelefoneDep";
            this.txtEditarTelefoneDep.Size = new System.Drawing.Size(214, 22);
            this.txtEditarTelefoneDep.TabIndex = 9;
            // 
            // txtEditarRgDep
            // 
            this.txtEditarRgDep.Location = new System.Drawing.Point(168, 150);
            this.txtEditarRgDep.Name = "txtEditarRgDep";
            this.txtEditarRgDep.Size = new System.Drawing.Size(214, 22);
            this.txtEditarRgDep.TabIndex = 8;
            // 
            // txtEditarNomeDep
            // 
            this.txtEditarNomeDep.Location = new System.Drawing.Point(168, 93);
            this.txtEditarNomeDep.Name = "txtEditarNomeDep";
            this.txtEditarNomeDep.Size = new System.Drawing.Size(475, 22);
            this.txtEditarNomeDep.TabIndex = 7;
            // 
            // lblGrauParent
            // 
            this.lblGrauParent.AutoSize = true;
            this.lblGrauParent.Location = new System.Drawing.Point(109, 335);
            this.lblGrauParent.Name = "lblGrauParent";
            this.lblGrauParent.Size = new System.Drawing.Size(140, 17);
            this.lblGrauParent.TabIndex = 5;
            this.lblGrauParent.Text = "Grau de Parentesco:";
            // 
            // lblEditarMorResp
            // 
            this.lblEditarMorResp.AutoSize = true;
            this.lblEditarMorResp.Location = new System.Drawing.Point(109, 274);
            this.lblEditarMorResp.Name = "lblEditarMorResp";
            this.lblEditarMorResp.Size = new System.Drawing.Size(155, 17);
            this.lblEditarMorResp.TabIndex = 4;
            this.lblEditarMorResp.Text = "Morador Responsável: ";
            // 
            // lblEditarTelefoneDep
            // 
            this.lblEditarTelefoneDep.AutoSize = true;
            this.lblEditarTelefoneDep.Location = new System.Drawing.Point(109, 216);
            this.lblEditarTelefoneDep.Name = "lblEditarTelefoneDep";
            this.lblEditarTelefoneDep.Size = new System.Drawing.Size(68, 17);
            this.lblEditarTelefoneDep.TabIndex = 3;
            this.lblEditarTelefoneDep.Text = "Telefone:";
            // 
            // lblEditarRgDep
            // 
            this.lblEditarRgDep.AutoSize = true;
            this.lblEditarRgDep.Location = new System.Drawing.Point(109, 155);
            this.lblEditarRgDep.Name = "lblEditarRgDep";
            this.lblEditarRgDep.Size = new System.Drawing.Size(33, 17);
            this.lblEditarRgDep.TabIndex = 2;
            this.lblEditarRgDep.Text = "RG:";
            // 
            // lblNomeCodigoDep
            // 
            this.lblNomeCodigoDep.AutoSize = true;
            this.lblNomeCodigoDep.Location = new System.Drawing.Point(109, 98);
            this.lblNomeCodigoDep.Name = "lblNomeCodigoDep";
            this.lblNomeCodigoDep.Size = new System.Drawing.Size(53, 17);
            this.lblNomeCodigoDep.TabIndex = 1;
            this.lblNomeCodigoDep.Text = "Nome: ";
            // 
            // lblEditarCodigoDep
            // 
            this.lblEditarCodigoDep.AutoSize = true;
            this.lblEditarCodigoDep.Location = new System.Drawing.Point(109, 42);
            this.lblEditarCodigoDep.Name = "lblEditarCodigoDep";
            this.lblEditarCodigoDep.Size = new System.Drawing.Size(0, 17);
            this.lblEditarCodigoDep.TabIndex = 0;
            // 
            // frmDependenteEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDependenteEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Cadastro de Dependentes";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelarEdicaoDep;
        private System.Windows.Forms.Button btnSalvarEdicaoDep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEditarMoradorResp;
        private System.Windows.Forms.ComboBox cboEditarGrauParentesco;
        private System.Windows.Forms.TextBox txtEditarTelefoneDep;
        private System.Windows.Forms.TextBox txtEditarRgDep;
        private System.Windows.Forms.TextBox txtEditarNomeDep;
        private System.Windows.Forms.Label lblGrauParent;
        private System.Windows.Forms.Label lblEditarMorResp;
        private System.Windows.Forms.Label lblEditarTelefoneDep;
        private System.Windows.Forms.Label lblEditarRgDep;
        private System.Windows.Forms.Label lblNomeCodigoDep;
        private System.Windows.Forms.Label lblEditarCodigoDep;
    }
}