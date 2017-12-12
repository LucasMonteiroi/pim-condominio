namespace PIM.Desktop
{
    partial class frmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloLogin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCpfLogin = new System.Windows.Forms.TextBox();
            this.lblCpfLogin = new System.Windows.Forms.Label();
            this.llblEsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTituloLogin);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 79);
            this.panel1.TabIndex = 0;
            // 
            // lblTituloLogin
            // 
            this.lblTituloLogin.AutoSize = true;
            this.lblTituloLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLogin.Location = new System.Drawing.Point(75, 29);
            this.lblTituloLogin.Name = "lblTituloLogin";
            this.lblTituloLogin.Size = new System.Drawing.Size(603, 24);
            this.lblTituloLogin.TabIndex = 0;
            this.lblTituloLogin.Text = "SIGACON - SISTEMA DE GESTÃO DE ADMINISTRAÇÃO DE CONDOMÍNIO";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cboPerfil);
            this.panel2.Controls.Add(this.lblPerfil);
            this.panel2.Location = new System.Drawing.Point(13, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 66);
            this.panel2.TabIndex = 1;
            // 
            // cboPerfil
            // 
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Location = new System.Drawing.Point(267, 21);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(278, 24);
            this.cboPerfil.TabIndex = 15;
            this.cboPerfil.SelectedIndexChanged += new System.EventHandler(this.cboPerfil_SelectedIndexChanged);
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(217, 28);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(44, 17);
            this.lblPerfil.TabIndex = 0;
            this.lblPerfil.Text = "Perfil:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtCpfLogin);
            this.panel3.Controls.Add(this.lblCpfLogin);
            this.panel3.Controls.Add(this.llblEsqueceuSenha);
            this.panel3.Controls.Add(this.btnLogin);
            this.panel3.Controls.Add(this.txtSenha);
            this.panel3.Controls.Add(this.txtUsuario);
            this.panel3.Controls.Add(this.lblSenha);
            this.panel3.Controls.Add(this.lblUsuario);
            this.panel3.Location = new System.Drawing.Point(13, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 352);
            this.panel3.TabIndex = 2;
            // 
            // txtCpfLogin
            // 
            this.txtCpfLogin.Location = new System.Drawing.Point(268, 161);
            this.txtCpfLogin.Name = "txtCpfLogin";
            this.txtCpfLogin.Size = new System.Drawing.Size(277, 22);
            this.txtCpfLogin.TabIndex = 14;
            // 
            // lblCpfLogin
            // 
            this.lblCpfLogin.AutoSize = true;
            this.lblCpfLogin.Location = new System.Drawing.Point(213, 167);
            this.lblCpfLogin.Name = "lblCpfLogin";
            this.lblCpfLogin.Size = new System.Drawing.Size(38, 17);
            this.lblCpfLogin.TabIndex = 13;
            this.lblCpfLogin.Text = "CPF:";
            // 
            // llblEsqueceuSenha
            // 
            this.llblEsqueceuSenha.AutoSize = true;
            this.llblEsqueceuSenha.Location = new System.Drawing.Point(395, 244);
            this.llblEsqueceuSenha.Name = "llblEsqueceuSenha";
            this.llblEsqueceuSenha.Size = new System.Drawing.Size(149, 17);
            this.llblEsqueceuSenha.TabIndex = 5;
            this.llblEsqueceuSenha.TabStop = true;
            this.llblEsqueceuSenha.Text = "Esqueceu sua senha?";
            this.llblEsqueceuSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblEsqueceuSenha_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(267, 238);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 29);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(268, 123);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(277, 22);
            this.txtSenha.TabIndex = 12;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(267, 79);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(277, 22);
            this.txtUsuario.TabIndex = 11;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(207, 128);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(53, 17);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(199, 85);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 17);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 15;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboPerfil;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.LinkLabel llblEsqueceuSenha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtCpfLogin;
        private System.Windows.Forms.Label lblCpfLogin;
        private System.Windows.Forms.Label label1;
    }
}