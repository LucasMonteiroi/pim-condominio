namespace PIM.Desktop
{
    partial class frmUsuarioCadastrar
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnCancelarCadastramento = new System.Windows.Forms.Button();
            this.btnSalvarUsuario = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cboGrupoUsuario = new System.Windows.Forms.ComboBox();
            this.txtColabUsuario = new System.Windows.Forms.TextBox();
            this.lblColabUsuario = new System.Windows.Forms.Label();
            this.lblGrupoUsuario = new System.Windows.Forms.Label();
            this.lblSenhaUsuario = new System.Windows.Forms.Label();
            this.lblLoginUsuario = new System.Windows.Forms.Label();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.btnCancelarCadastramento);
            this.panel8.Controls.Add(this.btnSalvarUsuario);
            this.panel8.Location = new System.Drawing.Point(12, 454);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(778, 68);
            this.panel8.TabIndex = 14;
            // 
            // btnCancelarCadastramento
            // 
            this.btnCancelarCadastramento.Location = new System.Drawing.Point(442, 28);
            this.btnCancelarCadastramento.Name = "btnCancelarCadastramento";
            this.btnCancelarCadastramento.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCadastramento.TabIndex = 13;
            this.btnCancelarCadastramento.Text = "Cancelar";
            this.btnCancelarCadastramento.UseVisualStyleBackColor = true;
            this.btnCancelarCadastramento.Click += new System.EventHandler(this.btnCancelarCadastramento_Click);
            // 
            // btnSalvarUsuario
            // 
            this.btnSalvarUsuario.Location = new System.Drawing.Point(222, 28);
            this.btnSalvarUsuario.Name = "btnSalvarUsuario";
            this.btnSalvarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarUsuario.TabIndex = 12;
            this.btnSalvarUsuario.Text = "Salvar";
            this.btnSalvarUsuario.UseVisualStyleBackColor = true;
            this.btnSalvarUsuario.Click += new System.EventHandler(this.btnSalvarUsuario_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.cboGrupoUsuario);
            this.panel5.Controls.Add(this.txtColabUsuario);
            this.panel5.Controls.Add(this.lblColabUsuario);
            this.panel5.Controls.Add(this.lblGrupoUsuario);
            this.panel5.Controls.Add(this.lblSenhaUsuario);
            this.panel5.Controls.Add(this.lblLoginUsuario);
            this.panel5.Controls.Add(this.txtSenhaUsuario);
            this.panel5.Controls.Add(this.txtLoginUsuario);
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(778, 421);
            this.panel5.TabIndex = 13;
            // 
            // cboGrupoUsuario
            // 
            this.cboGrupoUsuario.FormattingEnabled = true;
            this.cboGrupoUsuario.Location = new System.Drawing.Point(366, 221);
            this.cboGrupoUsuario.Name = "cboGrupoUsuario";
            this.cboGrupoUsuario.Size = new System.Drawing.Size(138, 24);
            this.cboGrupoUsuario.TabIndex = 16;
            // 
            // txtColabUsuario
            // 
            this.txtColabUsuario.Location = new System.Drawing.Point(337, 312);
            this.txtColabUsuario.Name = "txtColabUsuario";
            this.txtColabUsuario.Size = new System.Drawing.Size(167, 22);
            this.txtColabUsuario.TabIndex = 15;
            // 
            // lblColabUsuario
            // 
            this.lblColabUsuario.AutoSize = true;
            this.lblColabUsuario.Location = new System.Drawing.Point(241, 317);
            this.lblColabUsuario.Name = "lblColabUsuario";
            this.lblColabUsuario.Size = new System.Drawing.Size(90, 17);
            this.lblColabUsuario.TabIndex = 14;
            this.lblColabUsuario.Text = "Colaborador:";
            // 
            // lblGrupoUsuario
            // 
            this.lblGrupoUsuario.AutoSize = true;
            this.lblGrupoUsuario.Location = new System.Drawing.Point(239, 230);
            this.lblGrupoUsuario.Name = "lblGrupoUsuario";
            this.lblGrupoUsuario.Size = new System.Drawing.Size(129, 17);
            this.lblGrupoUsuario.TabIndex = 13;
            this.lblGrupoUsuario.Text = "Grupo de Usuário: ";
            // 
            // lblSenhaUsuario
            // 
            this.lblSenhaUsuario.AutoSize = true;
            this.lblSenhaUsuario.Location = new System.Drawing.Point(235, 141);
            this.lblSenhaUsuario.Name = "lblSenhaUsuario";
            this.lblSenhaUsuario.Size = new System.Drawing.Size(53, 17);
            this.lblSenhaUsuario.TabIndex = 12;
            this.lblSenhaUsuario.Text = "Senha:";
            // 
            // lblLoginUsuario
            // 
            this.lblLoginUsuario.AutoSize = true;
            this.lblLoginUsuario.Location = new System.Drawing.Point(234, 50);
            this.lblLoginUsuario.Name = "lblLoginUsuario";
            this.lblLoginUsuario.Size = new System.Drawing.Size(47, 17);
            this.lblLoginUsuario.TabIndex = 11;
            this.lblLoginUsuario.Text = "Login:";
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Location = new System.Drawing.Point(302, 136);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.Size = new System.Drawing.Size(202, 22);
            this.txtSenhaUsuario.TabIndex = 10;
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.Location = new System.Drawing.Point(301, 45);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(202, 22);
            this.txtLoginUsuario.TabIndex = 9;
            // 
            // frmUsuarioCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Name = "frmUsuarioCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Usuários";
            this.Load += new System.EventHandler(this.frmUsuarioCadastrar_Load);
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnCancelarCadastramento;
        private System.Windows.Forms.Button btnSalvarUsuario;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtColabUsuario;
        private System.Windows.Forms.Label lblColabUsuario;
        private System.Windows.Forms.Label lblGrupoUsuario;
        private System.Windows.Forms.Label lblSenhaUsuario;
        private System.Windows.Forms.Label lblLoginUsuario;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.ComboBox cboGrupoUsuario;
    }
}