namespace PIM.Desktop
{
    partial class frmMorador
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
            this.btnMorAtualizar = new System.Windows.Forms.Button();
            this.lblTituloMorador = new System.Windows.Forms.Label();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgOcorrencia = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnMorVisualizarOcorrencia = new System.Windows.Forms.Button();
            this.btnMorExcluirOcorrencia = new System.Windows.Forms.Button();
            this.btnMorEditarOcorrencia = new System.Windows.Forms.Button();
            this.btnMorCadastrarOcorrencia = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.cboMorListarCodMor = new System.Windows.Forms.ComboBox();
            this.lblMorListarCodMor = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgVisitantes = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnVisualizarVisitante = new System.Windows.Forms.Button();
            this.btnEditarVisitante = new System.Windows.Forms.Button();
            this.btnExcluirVisitante = new System.Windows.Forms.Button();
            this.btnNovoVisitante = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTituloVisitante = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dgMorDependentes = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMorVisualizarDependente = new System.Windows.Forms.Button();
            this.btnMorEditarDependente = new System.Windows.Forms.Button();
            this.btnMorExcluirDepemdemte = new System.Windows.Forms.Button();
            this.btnMorNovoDep = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTituloDependende = new System.Windows.Forms.Label();
            this.dgReservasMor = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTituloReservaMor = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnVisualizarReservaMor = new System.Windows.Forms.Button();
            this.btnExcluirReservaMor = new System.Windows.Forms.Button();
            this.btnEditarReservaMor = new System.Windows.Forms.Button();
            this.btnNovaReservaMor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOcorrencia)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisitantes)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMorDependentes)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservasMor)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnMorAtualizar);
            this.panel1.Controls.Add(this.lblTituloMorador);
            this.panel1.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 46);
            this.panel1.TabIndex = 9;
            // 
            // btnMorAtualizar
            // 
            this.btnMorAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnMorAtualizar.Location = new System.Drawing.Point(18, 6);
            this.btnMorAtualizar.Name = "btnMorAtualizar";
            this.btnMorAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnMorAtualizar.TabIndex = 1;
            this.btnMorAtualizar.Text = "Atualizar ";
            this.btnMorAtualizar.UseVisualStyleBackColor = true;
            this.btnMorAtualizar.Click += new System.EventHandler(this.btnMorAtualizar_Click);
            // 
            // lblTituloMorador
            // 
            this.lblTituloMorador.AutoSize = true;
            this.lblTituloMorador.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMorador.Location = new System.Drawing.Point(315, 0);
            this.lblTituloMorador.Name = "lblTituloMorador";
            this.lblTituloMorador.Size = new System.Drawing.Size(124, 29);
            this.lblTituloMorador.TabIndex = 0;
            this.lblTituloMorador.Text = "MORADOR";
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabPage3);
            this.tabPrincipal.Controls.Add(this.tabPage4);
            this.tabPrincipal.Controls.Add(this.tabPage5);
            this.tabPrincipal.Controls.Add(this.tabPage7);
            this.tabPrincipal.Location = new System.Drawing.Point(12, 64);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(781, 438);
            this.tabPrincipal.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.dgOcorrencia);
            this.tabPage3.Controls.Add(this.panel9);
            this.tabPage3.Controls.Add(this.panel11);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(773, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ocorrência";
            // 
            // dgOcorrencia
            // 
            this.dgOcorrencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOcorrencia.Location = new System.Drawing.Point(12, 67);
            this.dgOcorrencia.Name = "dgOcorrencia";
            this.dgOcorrencia.RowTemplate.Height = 24;
            this.dgOcorrencia.Size = new System.Drawing.Size(744, 262);
            this.dgOcorrencia.TabIndex = 18;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.btnMorVisualizarOcorrencia);
            this.panel9.Controls.Add(this.btnMorExcluirOcorrencia);
            this.panel9.Controls.Add(this.btnMorEditarOcorrencia);
            this.panel9.Controls.Add(this.btnMorCadastrarOcorrencia);
            this.panel9.Location = new System.Drawing.Point(12, 335);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(744, 64);
            this.panel9.TabIndex = 17;
            // 
            // btnMorVisualizarOcorrencia
            // 
            this.btnMorVisualizarOcorrencia.Location = new System.Drawing.Point(594, 20);
            this.btnMorVisualizarOcorrencia.Name = "btnMorVisualizarOcorrencia";
            this.btnMorVisualizarOcorrencia.Size = new System.Drawing.Size(79, 23);
            this.btnMorVisualizarOcorrencia.TabIndex = 3;
            this.btnMorVisualizarOcorrencia.Text = "Visualizar";
            this.btnMorVisualizarOcorrencia.UseVisualStyleBackColor = true;
            this.btnMorVisualizarOcorrencia.Click += new System.EventHandler(this.btnMorVisualizarOcorrencia_Click);
            // 
            // btnMorExcluirOcorrencia
            // 
            this.btnMorExcluirOcorrencia.Location = new System.Drawing.Point(427, 20);
            this.btnMorExcluirOcorrencia.Name = "btnMorExcluirOcorrencia";
            this.btnMorExcluirOcorrencia.Size = new System.Drawing.Size(75, 23);
            this.btnMorExcluirOcorrencia.TabIndex = 2;
            this.btnMorExcluirOcorrencia.Text = "Excluir";
            this.btnMorExcluirOcorrencia.UseVisualStyleBackColor = true;
            this.btnMorExcluirOcorrencia.Click += new System.EventHandler(this.btnMorExcluirOcorrencia_Click);
            // 
            // btnMorEditarOcorrencia
            // 
            this.btnMorEditarOcorrencia.Location = new System.Drawing.Point(230, 20);
            this.btnMorEditarOcorrencia.Name = "btnMorEditarOcorrencia";
            this.btnMorEditarOcorrencia.Size = new System.Drawing.Size(75, 23);
            this.btnMorEditarOcorrencia.TabIndex = 1;
            this.btnMorEditarOcorrencia.Text = "Editar";
            this.btnMorEditarOcorrencia.UseVisualStyleBackColor = true;
            this.btnMorEditarOcorrencia.Click += new System.EventHandler(this.btnMorEditarOcorrencia_Click);
            // 
            // btnMorCadastrarOcorrencia
            // 
            this.btnMorCadastrarOcorrencia.Location = new System.Drawing.Point(56, 20);
            this.btnMorCadastrarOcorrencia.Name = "btnMorCadastrarOcorrencia";
            this.btnMorCadastrarOcorrencia.Size = new System.Drawing.Size(75, 23);
            this.btnMorCadastrarOcorrencia.TabIndex = 0;
            this.btnMorCadastrarOcorrencia.Text = "Novo";
            this.btnMorCadastrarOcorrencia.UseVisualStyleBackColor = true;
            this.btnMorCadastrarOcorrencia.Click += new System.EventHandler(this.btnMorCadastrarOcorrencia_Click);
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.cboMorListarCodMor);
            this.panel11.Controls.Add(this.lblMorListarCodMor);
            this.panel11.Location = new System.Drawing.Point(12, 8);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(744, 53);
            this.panel11.TabIndex = 15;
            // 
            // cboMorListarCodMor
            // 
            this.cboMorListarCodMor.FormattingEnabled = true;
            this.cboMorListarCodMor.Location = new System.Drawing.Point(348, 11);
            this.cboMorListarCodMor.Name = "cboMorListarCodMor";
            this.cboMorListarCodMor.Size = new System.Drawing.Size(169, 24);
            this.cboMorListarCodMor.TabIndex = 11;
            // 
            // lblMorListarCodMor
            // 
            this.lblMorListarCodMor.AutoSize = true;
            this.lblMorListarCodMor.Location = new System.Drawing.Point(209, 18);
            this.lblMorListarCodMor.Name = "lblMorListarCodMor";
            this.lblMorListarCodMor.Size = new System.Drawing.Size(133, 17);
            this.lblMorListarCodMor.TabIndex = 10;
            this.lblMorListarCodMor.Text = "Código do Morador:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage4.Controls.Add(this.dgReservasMor);
            this.tabPage4.Controls.Add(this.panel6);
            this.tabPage4.Controls.Add(this.panel7);
            this.tabPage4.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(773, 409);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reserva";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage5.Controls.Add(this.dgVisitantes);
            this.tabPage5.Controls.Add(this.panel5);
            this.tabPage5.Controls.Add(this.panel4);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(773, 409);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Visitante";
            // 
            // dgVisitantes
            // 
            this.dgVisitantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVisitantes.Location = new System.Drawing.Point(15, 92);
            this.dgVisitantes.Name = "dgVisitantes";
            this.dgVisitantes.RowTemplate.Height = 24;
            this.dgVisitantes.Size = new System.Drawing.Size(738, 227);
            this.dgVisitantes.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnVisualizarVisitante);
            this.panel5.Controls.Add(this.btnEditarVisitante);
            this.panel5.Controls.Add(this.btnExcluirVisitante);
            this.panel5.Controls.Add(this.btnNovoVisitante);
            this.panel5.Location = new System.Drawing.Point(15, 325);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(739, 68);
            this.panel5.TabIndex = 2;
            // 
            // btnVisualizarVisitante
            // 
            this.btnVisualizarVisitante.Location = new System.Drawing.Point(611, 22);
            this.btnVisualizarVisitante.Name = "btnVisualizarVisitante";
            this.btnVisualizarVisitante.Size = new System.Drawing.Size(88, 23);
            this.btnVisualizarVisitante.TabIndex = 3;
            this.btnVisualizarVisitante.Text = "Visualizar";
            this.btnVisualizarVisitante.UseVisualStyleBackColor = true;
            this.btnVisualizarVisitante.Click += new System.EventHandler(this.btnVisualizarVisitante_Click);
            // 
            // btnEditarVisitante
            // 
            this.btnEditarVisitante.Location = new System.Drawing.Point(222, 22);
            this.btnEditarVisitante.Name = "btnEditarVisitante";
            this.btnEditarVisitante.Size = new System.Drawing.Size(75, 23);
            this.btnEditarVisitante.TabIndex = 14;
            this.btnEditarVisitante.Text = "Editar";
            this.btnEditarVisitante.UseVisualStyleBackColor = true;
            this.btnEditarVisitante.Click += new System.EventHandler(this.btnEditarVisitante_Click);
            // 
            // btnExcluirVisitante
            // 
            this.btnExcluirVisitante.Location = new System.Drawing.Point(427, 23);
            this.btnExcluirVisitante.Name = "btnExcluirVisitante";
            this.btnExcluirVisitante.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirVisitante.TabIndex = 13;
            this.btnExcluirVisitante.Text = "Excluir";
            this.btnExcluirVisitante.UseVisualStyleBackColor = true;
            this.btnExcluirVisitante.Click += new System.EventHandler(this.btnExcluirVisitante_Click);
            // 
            // btnNovoVisitante
            // 
            this.btnNovoVisitante.Location = new System.Drawing.Point(50, 23);
            this.btnNovoVisitante.Name = "btnNovoVisitante";
            this.btnNovoVisitante.Size = new System.Drawing.Size(75, 23);
            this.btnNovoVisitante.TabIndex = 0;
            this.btnNovoVisitante.Text = "Novo";
            this.btnNovoVisitante.UseVisualStyleBackColor = true;
            this.btnNovoVisitante.Click += new System.EventHandler(this.btnNovoVisitante_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblTituloVisitante);
            this.panel4.Location = new System.Drawing.Point(14, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(739, 71);
            this.panel4.TabIndex = 0;
            // 
            // lblTituloVisitante
            // 
            this.lblTituloVisitante.AutoSize = true;
            this.lblTituloVisitante.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVisitante.Location = new System.Drawing.Point(239, 19);
            this.lblTituloVisitante.Name = "lblTituloVisitante";
            this.lblTituloVisitante.Size = new System.Drawing.Size(282, 29);
            this.lblTituloVisitante.TabIndex = 1;
            this.lblTituloVisitante.Text = "VISITANTES CADASTRADOS";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage7.Controls.Add(this.dgMorDependentes);
            this.tabPage7.Controls.Add(this.panel3);
            this.tabPage7.Controls.Add(this.panel2);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(773, 409);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Dependente";
            // 
            // dgMorDependentes
            // 
            this.dgMorDependentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMorDependentes.Location = new System.Drawing.Point(14, 80);
            this.dgMorDependentes.Name = "dgMorDependentes";
            this.dgMorDependentes.RowTemplate.Height = 24;
            this.dgMorDependentes.Size = new System.Drawing.Size(739, 237);
            this.dgMorDependentes.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnMorVisualizarDependente);
            this.panel3.Controls.Add(this.btnMorEditarDependente);
            this.panel3.Controls.Add(this.btnMorExcluirDepemdemte);
            this.panel3.Controls.Add(this.btnMorNovoDep);
            this.panel3.Location = new System.Drawing.Point(14, 323);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(739, 68);
            this.panel3.TabIndex = 11;
            // 
            // btnMorVisualizarDependente
            // 
            this.btnMorVisualizarDependente.Location = new System.Drawing.Point(575, 22);
            this.btnMorVisualizarDependente.Name = "btnMorVisualizarDependente";
            this.btnMorVisualizarDependente.Size = new System.Drawing.Size(77, 23);
            this.btnMorVisualizarDependente.TabIndex = 14;
            this.btnMorVisualizarDependente.Text = "Visualizar";
            this.btnMorVisualizarDependente.UseVisualStyleBackColor = true;
            this.btnMorVisualizarDependente.Click += new System.EventHandler(this.btnMorVisualizarDependente_Click);
            // 
            // btnMorEditarDependente
            // 
            this.btnMorEditarDependente.Location = new System.Drawing.Point(221, 22);
            this.btnMorEditarDependente.Name = "btnMorEditarDependente";
            this.btnMorEditarDependente.Size = new System.Drawing.Size(75, 23);
            this.btnMorEditarDependente.TabIndex = 13;
            this.btnMorEditarDependente.Text = "Editar";
            this.btnMorEditarDependente.UseVisualStyleBackColor = true;
            this.btnMorEditarDependente.Click += new System.EventHandler(this.btnMorEditarDependente_Click);
            // 
            // btnMorExcluirDepemdemte
            // 
            this.btnMorExcluirDepemdemte.Location = new System.Drawing.Point(402, 22);
            this.btnMorExcluirDepemdemte.Name = "btnMorExcluirDepemdemte";
            this.btnMorExcluirDepemdemte.Size = new System.Drawing.Size(75, 23);
            this.btnMorExcluirDepemdemte.TabIndex = 12;
            this.btnMorExcluirDepemdemte.Text = "Excluir";
            this.btnMorExcluirDepemdemte.UseVisualStyleBackColor = true;
            this.btnMorExcluirDepemdemte.Click += new System.EventHandler(this.btnMorExcluirDepemdemte_Click);
            // 
            // btnMorNovoDep
            // 
            this.btnMorNovoDep.Location = new System.Drawing.Point(67, 23);
            this.btnMorNovoDep.Name = "btnMorNovoDep";
            this.btnMorNovoDep.Size = new System.Drawing.Size(79, 23);
            this.btnMorNovoDep.TabIndex = 11;
            this.btnMorNovoDep.Text = "Novo";
            this.btnMorNovoDep.UseVisualStyleBackColor = true;
            this.btnMorNovoDep.Click += new System.EventHandler(this.btnMorNovoDep_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTituloDependende);
            this.panel2.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(14, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 71);
            this.panel2.TabIndex = 8;
            // 
            // lblTituloDependende
            // 
            this.lblTituloDependende.AutoSize = true;
            this.lblTituloDependende.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDependende.Location = new System.Drawing.Point(205, 17);
            this.lblTituloDependende.Name = "lblTituloDependende";
            this.lblTituloDependende.Size = new System.Drawing.Size(315, 29);
            this.lblTituloDependende.TabIndex = 0;
            this.lblTituloDependende.Text = "DEPENDENTES CADASTRADOS";
            // 
            // dgReservasMor
            // 
            this.dgReservasMor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservasMor.Location = new System.Drawing.Point(12, 93);
            this.dgReservasMor.Name = "dgReservasMor";
            this.dgReservasMor.RowTemplate.Height = 24;
            this.dgReservasMor.Size = new System.Drawing.Size(747, 234);
            this.dgReservasMor.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblTituloReservaMor);
            this.panel6.Location = new System.Drawing.Point(12, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(747, 77);
            this.panel6.TabIndex = 14;
            // 
            // lblTituloReservaMor
            // 
            this.lblTituloReservaMor.AutoSize = true;
            this.lblTituloReservaMor.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTituloReservaMor.Location = new System.Drawing.Point(224, 24);
            this.lblTituloReservaMor.Name = "lblTituloReservaMor";
            this.lblTituloReservaMor.Size = new System.Drawing.Size(270, 29);
            this.lblTituloReservaMor.TabIndex = 0;
            this.lblTituloReservaMor.Text = "RESERVAS CADASTRADAS";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.btnVisualizarReservaMor);
            this.panel7.Controls.Add(this.btnExcluirReservaMor);
            this.panel7.Controls.Add(this.btnEditarReservaMor);
            this.panel7.Controls.Add(this.btnNovaReservaMor);
            this.panel7.Location = new System.Drawing.Point(12, 343);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(747, 55);
            this.panel7.TabIndex = 13;
            // 
            // btnVisualizarReservaMor
            // 
            this.btnVisualizarReservaMor.Location = new System.Drawing.Point(585, 15);
            this.btnVisualizarReservaMor.Name = "btnVisualizarReservaMor";
            this.btnVisualizarReservaMor.Size = new System.Drawing.Size(86, 23);
            this.btnVisualizarReservaMor.TabIndex = 3;
            this.btnVisualizarReservaMor.Text = "Visualizar";
            this.btnVisualizarReservaMor.UseVisualStyleBackColor = true;
            this.btnVisualizarReservaMor.Click += new System.EventHandler(this.btnVisualizarReservaMor_Click);
            // 
            // btnExcluirReservaMor
            // 
            this.btnExcluirReservaMor.Location = new System.Drawing.Point(397, 15);
            this.btnExcluirReservaMor.Name = "btnExcluirReservaMor";
            this.btnExcluirReservaMor.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirReservaMor.TabIndex = 2;
            this.btnExcluirReservaMor.Text = "Excluir";
            this.btnExcluirReservaMor.UseVisualStyleBackColor = true;
            this.btnExcluirReservaMor.Click += new System.EventHandler(this.btnExcluirReservaMor_Click);
            // 
            // btnEditarReservaMor
            // 
            this.btnEditarReservaMor.Location = new System.Drawing.Point(214, 15);
            this.btnEditarReservaMor.Name = "btnEditarReservaMor";
            this.btnEditarReservaMor.Size = new System.Drawing.Size(75, 23);
            this.btnEditarReservaMor.TabIndex = 1;
            this.btnEditarReservaMor.Text = "Editar";
            this.btnEditarReservaMor.UseVisualStyleBackColor = true;
            this.btnEditarReservaMor.Click += new System.EventHandler(this.btnEditarReservaMor_Click);
            // 
            // btnNovaReservaMor
            // 
            this.btnNovaReservaMor.Location = new System.Drawing.Point(56, 15);
            this.btnNovaReservaMor.Name = "btnNovaReservaMor";
            this.btnNovaReservaMor.Size = new System.Drawing.Size(75, 23);
            this.btnNovaReservaMor.TabIndex = 0;
            this.btnNovaReservaMor.Text = "Novo";
            this.btnNovaReservaMor.UseVisualStyleBackColor = true;
            this.btnNovaReservaMor.Click += new System.EventHandler(this.btnNovaReservaMor_Click);
            // 
            // frmMorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabPrincipal);
            this.Name = "frmMorador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGACON - SISTEMA DE GESTÃO DE ADMINISTRAÇÃO DE CONDOMÍNIO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPrincipal.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOcorrencia)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVisitantes)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMorDependentes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservasMor)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloMorador;
        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lblMorListarCodMor;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnExcluirVisitante;
        private System.Windows.Forms.Button btnNovoVisitante;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTituloVisitante;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMorExcluirDepemdemte;
        private System.Windows.Forms.Button btnMorNovoDep;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTituloDependende;
        private System.Windows.Forms.Button btnVisualizarVisitante;
        private System.Windows.Forms.Button btnEditarVisitante;
        private System.Windows.Forms.Button btnMorVisualizarDependente;
        private System.Windows.Forms.Button btnMorEditarDependente;
        private System.Windows.Forms.ComboBox cboMorListarCodMor;
        private System.Windows.Forms.Button btnMorVisualizarOcorrencia;
        private System.Windows.Forms.Button btnMorExcluirOcorrencia;
        private System.Windows.Forms.Button btnMorEditarOcorrencia;
        private System.Windows.Forms.Button btnMorCadastrarOcorrencia;
        private System.Windows.Forms.DataGridView dgVisitantes;
        private System.Windows.Forms.DataGridView dgOcorrencia;
        private System.Windows.Forms.DataGridView dgMorDependentes;
        private System.Windows.Forms.Button btnMorAtualizar;
        private System.Windows.Forms.DataGridView dgReservasMor;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTituloReservaMor;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnVisualizarReservaMor;
        private System.Windows.Forms.Button btnExcluirReservaMor;
        private System.Windows.Forms.Button btnEditarReservaMor;
        private System.Windows.Forms.Button btnNovaReservaMor;
    }
}