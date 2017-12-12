namespace PIM.Desktop
{
    partial class frmPorteiro
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
            this.lblTituloPorteiro = new System.Windows.Forms.Label();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tpColaborador = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnVisualizarColab = new System.Windows.Forms.Button();
            this.dgPorteiroVisualizarColab = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tpDependente = new System.Windows.Forms.TabPage();
            this.dgPorteiroDependentes = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnVisualizarDependentes = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblTituloDependente = new System.Windows.Forms.Label();
            this.tpVisitante = new System.Windows.Forms.TabPage();
            this.dgPorteiroVisualizarVisitante = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnVisualizarVisitante = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTituloVisitante = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtCodMorVisit = new System.Windows.Forms.TextBox();
            this.lblCodMorVisit = new System.Windows.Forms.Label();
            this.btnAtualizarJanelaPorteiro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.tpColaborador.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPorteiroVisualizarColab)).BeginInit();
            this.panel2.SuspendLayout();
            this.tpDependente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPorteiroDependentes)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tpVisitante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPorteiroVisualizarVisitante)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAtualizarJanelaPorteiro);
            this.panel1.Controls.Add(this.lblTituloPorteiro);
            this.panel1.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 46);
            this.panel1.TabIndex = 10;
            // 
            // lblTituloPorteiro
            // 
            this.lblTituloPorteiro.AutoSize = true;
            this.lblTituloPorteiro.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPorteiro.Location = new System.Drawing.Point(329, 9);
            this.lblTituloPorteiro.Name = "lblTituloPorteiro";
            this.lblTituloPorteiro.Size = new System.Drawing.Size(116, 29);
            this.lblTituloPorteiro.TabIndex = 0;
            this.lblTituloPorteiro.Text = "PORTEIRO";
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tpColaborador);
            this.tabPrincipal.Controls.Add(this.tpDependente);
            this.tabPrincipal.Controls.Add(this.tpVisitante);
            this.tabPrincipal.Location = new System.Drawing.Point(11, 74);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(781, 437);
            this.tabPrincipal.TabIndex = 9;
            // 
            // tpColaborador
            // 
            this.tpColaborador.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpColaborador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpColaborador.Controls.Add(this.panel3);
            this.tpColaborador.Controls.Add(this.dgPorteiroVisualizarColab);
            this.tpColaborador.Controls.Add(this.panel2);
            this.tpColaborador.Location = new System.Drawing.Point(4, 25);
            this.tpColaborador.Name = "tpColaborador";
            this.tpColaborador.Size = new System.Drawing.Size(773, 408);
            this.tpColaborador.TabIndex = 2;
            this.tpColaborador.Text = "Colaborador";
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnVisualizarColab);
            this.panel3.Location = new System.Drawing.Point(4, 329);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 74);
            this.panel3.TabIndex = 2;
            // 
            // btnVisualizarColab
            // 
            this.btnVisualizarColab.Location = new System.Drawing.Point(329, 25);
            this.btnVisualizarColab.Name = "btnVisualizarColab";
            this.btnVisualizarColab.Size = new System.Drawing.Size(92, 23);
            this.btnVisualizarColab.TabIndex = 0;
            this.btnVisualizarColab.Text = "Visualizar";
            this.btnVisualizarColab.UseVisualStyleBackColor = true;
            this.btnVisualizarColab.Click += new System.EventHandler(this.btnVisualizarColab_Click);
            // 
            // dgPorteiroVisualizarColab
            // 
            this.dgPorteiroVisualizarColab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPorteiroVisualizarColab.Location = new System.Drawing.Point(4, 79);
            this.dgPorteiroVisualizarColab.Name = "dgPorteiroVisualizarColab";
            this.dgPorteiroVisualizarColab.RowTemplate.Height = 24;
            this.dgPorteiroVisualizarColab.Size = new System.Drawing.Size(764, 243);
            this.dgPorteiroVisualizarColab.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 69);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "COLABORADORES CADASTRADOS";
            // 
            // tpDependente
            // 
            this.tpDependente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpDependente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpDependente.Controls.Add(this.dgPorteiroDependentes);
            this.tpDependente.Controls.Add(this.panel5);
            this.tpDependente.Controls.Add(this.panel8);
            this.tpDependente.Location = new System.Drawing.Point(4, 25);
            this.tpDependente.Name = "tpDependente";
            this.tpDependente.Size = new System.Drawing.Size(773, 408);
            this.tpDependente.TabIndex = 4;
            this.tpDependente.Text = "Dependente";
            // 
            // dgPorteiroDependentes
            // 
            this.dgPorteiroDependentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPorteiroDependentes.Location = new System.Drawing.Point(4, 80);
            this.dgPorteiroDependentes.Name = "dgPorteiroDependentes";
            this.dgPorteiroDependentes.RowTemplate.Height = 24;
            this.dgPorteiroDependentes.Size = new System.Drawing.Size(763, 243);
            this.dgPorteiroDependentes.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnVisualizarDependentes);
            this.panel5.Location = new System.Drawing.Point(4, 329);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(764, 74);
            this.panel5.TabIndex = 8;
            // 
            // btnVisualizarDependentes
            // 
            this.btnVisualizarDependentes.Location = new System.Drawing.Point(329, 25);
            this.btnVisualizarDependentes.Name = "btnVisualizarDependentes";
            this.btnVisualizarDependentes.Size = new System.Drawing.Size(92, 23);
            this.btnVisualizarDependentes.TabIndex = 0;
            this.btnVisualizarDependentes.Text = "Visualizar";
            this.btnVisualizarDependentes.UseVisualStyleBackColor = true;
            this.btnVisualizarDependentes.Click += new System.EventHandler(this.btnVisualizarDependentes_Click);
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.lblTituloDependente);
            this.panel8.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.panel8.Location = new System.Drawing.Point(3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(764, 69);
            this.panel8.TabIndex = 7;
            // 
            // lblTituloDependente
            // 
            this.lblTituloDependente.AutoSize = true;
            this.lblTituloDependente.Location = new System.Drawing.Point(227, 18);
            this.lblTituloDependente.Name = "lblTituloDependente";
            this.lblTituloDependente.Size = new System.Drawing.Size(315, 29);
            this.lblTituloDependente.TabIndex = 0;
            this.lblTituloDependente.Text = "DEPENDENTES CADASTRADOS";
            // 
            // tpVisitante
            // 
            this.tpVisitante.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpVisitante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpVisitante.Controls.Add(this.dgPorteiroVisualizarVisitante);
            this.tpVisitante.Controls.Add(this.panel7);
            this.tpVisitante.Controls.Add(this.panel4);
            this.tpVisitante.Controls.Add(this.panel6);
            this.tpVisitante.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tpVisitante.Location = new System.Drawing.Point(4, 25);
            this.tpVisitante.Name = "tpVisitante";
            this.tpVisitante.Size = new System.Drawing.Size(773, 408);
            this.tpVisitante.TabIndex = 3;
            this.tpVisitante.Text = "Visitante";
            // 
            // dgPorteiroVisualizarVisitante
            // 
            this.dgPorteiroVisualizarVisitante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPorteiroVisualizarVisitante.Location = new System.Drawing.Point(5, 80);
            this.dgPorteiroVisualizarVisitante.Name = "dgPorteiroVisualizarVisitante";
            this.dgPorteiroVisualizarVisitante.RowTemplate.Height = 24;
            this.dgPorteiroVisualizarVisitante.Size = new System.Drawing.Size(763, 243);
            this.dgPorteiroVisualizarVisitante.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.btnVisualizarVisitante);
            this.panel7.Location = new System.Drawing.Point(5, 329);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(764, 74);
            this.panel7.TabIndex = 5;
            // 
            // btnVisualizarVisitante
            // 
            this.btnVisualizarVisitante.Location = new System.Drawing.Point(329, 25);
            this.btnVisualizarVisitante.Name = "btnVisualizarVisitante";
            this.btnVisualizarVisitante.Size = new System.Drawing.Size(92, 23);
            this.btnVisualizarVisitante.TabIndex = 0;
            this.btnVisualizarVisitante.Text = "Visualizar";
            this.btnVisualizarVisitante.UseVisualStyleBackColor = true;
            this.btnVisualizarVisitante.Click += new System.EventHandler(this.btnVisualizarVisitante_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblTituloVisitante);
            this.panel4.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(764, 69);
            this.panel4.TabIndex = 4;
            // 
            // lblTituloVisitante
            // 
            this.lblTituloVisitante.AutoSize = true;
            this.lblTituloVisitante.Location = new System.Drawing.Point(227, 18);
            this.lblTituloVisitante.Name = "lblTituloVisitante";
            this.lblTituloVisitante.Size = new System.Drawing.Size(282, 29);
            this.lblTituloVisitante.TabIndex = 0;
            this.lblTituloVisitante.Text = "VISITANTES CADASTRADOS";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txtCodMorVisit);
            this.panel6.Controls.Add(this.lblCodMorVisit);
            this.panel6.Location = new System.Drawing.Point(-3, -45);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(777, 32);
            this.panel6.TabIndex = 3;
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
            // btnAtualizarJanelaPorteiro
            // 
            this.btnAtualizarJanelaPorteiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnAtualizarJanelaPorteiro.Location = new System.Drawing.Point(13, 9);
            this.btnAtualizarJanelaPorteiro.Name = "btnAtualizarJanelaPorteiro";
            this.btnAtualizarJanelaPorteiro.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarJanelaPorteiro.TabIndex = 1;
            this.btnAtualizarJanelaPorteiro.Text = "Atualizar";
            this.btnAtualizarJanelaPorteiro.UseVisualStyleBackColor = true;
            this.btnAtualizarJanelaPorteiro.Click += new System.EventHandler(this.btnAtualizarJanelaPorteiro_Click);
            // 
            // frmPorteiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabPrincipal);
            this.Name = "frmPorteiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGACON - SISTEMA DE GESTÃO DE ADMINISTRAÇÃO DE CONDOMÍNIO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPrincipal.ResumeLayout(false);
            this.tpColaborador.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPorteiroVisualizarColab)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tpDependente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPorteiroDependentes)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tpVisitante.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPorteiroVisualizarVisitante)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloPorteiro;
        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tpColaborador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tpDependente;
        private System.Windows.Forms.TabPage tpVisitante;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtCodMorVisit;
        private System.Windows.Forms.Label lblCodMorVisit;
        private System.Windows.Forms.DataGridView dgPorteiroVisualizarColab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVisualizarColab;
        private System.Windows.Forms.DataGridView dgPorteiroVisualizarVisitante;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTituloVisitante;
        private System.Windows.Forms.Button btnVisualizarVisitante;
        private System.Windows.Forms.DataGridView dgPorteiroDependentes;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnVisualizarDependentes;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblTituloDependente;
        private System.Windows.Forms.Button btnAtualizarJanelaPorteiro;
    }
}