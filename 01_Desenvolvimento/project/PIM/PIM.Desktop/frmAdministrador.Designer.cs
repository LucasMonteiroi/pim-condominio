namespace PIM.Desktop
{
    partial class frmAdministrador
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
            this.menuAdministrador = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admCondomínioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpApartamento = new System.Windows.Forms.TabPage();
            this.dgApartamento = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnVisualizarApartamento = new System.Windows.Forms.Button();
            this.btnExcluirApartamento = new System.Windows.Forms.Button();
            this.btnEditarApartamento = new System.Windows.Forms.Button();
            this.btnNovoApartamento = new System.Windows.Forms.Button();
            this.tpColaborador = new System.Windows.Forms.TabPage();
            this.dgColaborador = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEditarColaborador = new System.Windows.Forms.Button();
            this.btnVisualizarColab = new System.Windows.Forms.Button();
            this.btnExcluirColab = new System.Windows.Forms.Button();
            this.btnIncluirColab = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTituloColab = new System.Windows.Forms.Label();
            this.tpTipoReserva = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgTipoReserva = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditarTipoReserva = new System.Windows.Forms.Button();
            this.btnExcluirTipoReserva = new System.Windows.Forms.Button();
            this.btnVisualizarTippoReserva = new System.Windows.Forms.Button();
            this.btnNovoTipoReserva = new System.Windows.Forms.Button();
            this.tpUsuario = new System.Windows.Forms.TabPage();
            this.dgUsuario = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnVisualzarUsuario = new System.Windows.Forms.Button();
            this.btnExcluirUsuario = new System.Windows.Forms.Button();
            this.btnIncluirUsuario = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblTituloUsuario = new System.Windows.Forms.Label();
            this.btnAtualizarAdministrador = new System.Windows.Forms.Button();
            this.menuAdministrador.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpApartamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgApartamento)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tpColaborador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgColaborador)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tpTipoReserva.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTipoReserva)).BeginInit();
            this.panel1.SuspendLayout();
            this.tpUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAdministrador
            // 
            this.menuAdministrador.BackColor = System.Drawing.SystemColors.Control;
            this.menuAdministrador.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuAdministrador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuAdministrador.Location = new System.Drawing.Point(0, 0);
            this.menuAdministrador.Name = "menuAdministrador";
            this.menuAdministrador.Size = new System.Drawing.Size(802, 28);
            this.menuAdministrador.TabIndex = 0;
            this.menuAdministrador.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admCondomínioToolStripMenuItem,
            this.moradorToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // admCondomínioToolStripMenuItem
            // 
            this.admCondomínioToolStripMenuItem.Name = "admCondomínioToolStripMenuItem";
            this.admCondomínioToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.admCondomínioToolStripMenuItem.Text = "Adm. Condomínio";
            this.admCondomínioToolStripMenuItem.Click += new System.EventHandler(this.admCondomínioToolStripMenuItem_Click);
            // 
            // moradorToolStripMenuItem
            // 
            this.moradorToolStripMenuItem.Name = "moradorToolStripMenuItem";
            this.moradorToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.moradorToolStripMenuItem.Text = "Morador";
            this.moradorToolStripMenuItem.Click += new System.EventHandler(this.moradorToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpApartamento);
            this.tabControl1.Controls.Add(this.tpColaborador);
            this.tabControl1.Controls.Add(this.tpTipoReserva);
            this.tabControl1.Controls.Add(this.tpUsuario);
            this.tabControl1.Location = new System.Drawing.Point(12, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(781, 437);
            this.tabControl1.TabIndex = 1;
            // 
            // tpApartamento
            // 
            this.tpApartamento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpApartamento.Controls.Add(this.dgApartamento);
            this.tpApartamento.Controls.Add(this.panel7);
            this.tpApartamento.Controls.Add(this.panel6);
            this.tpApartamento.Location = new System.Drawing.Point(4, 25);
            this.tpApartamento.Name = "tpApartamento";
            this.tpApartamento.Padding = new System.Windows.Forms.Padding(3);
            this.tpApartamento.Size = new System.Drawing.Size(773, 408);
            this.tpApartamento.TabIndex = 0;
            this.tpApartamento.Text = "Apartamento";
            // 
            // dgApartamento
            // 
            this.dgApartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgApartamento.Location = new System.Drawing.Point(20, 83);
            this.dgApartamento.Name = "dgApartamento";
            this.dgApartamento.RowTemplate.Height = 24;
            this.dgApartamento.Size = new System.Drawing.Size(732, 245);
            this.dgApartamento.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(20, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(732, 74);
            this.panel7.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(198, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "APARTAMENTOS CADASTRADOS";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnVisualizarApartamento);
            this.panel6.Controls.Add(this.btnExcluirApartamento);
            this.panel6.Controls.Add(this.btnEditarApartamento);
            this.panel6.Controls.Add(this.btnNovoApartamento);
            this.panel6.Location = new System.Drawing.Point(20, 334);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(732, 71);
            this.panel6.TabIndex = 0;
            // 
            // btnVisualizarApartamento
            // 
            this.btnVisualizarApartamento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVisualizarApartamento.Location = new System.Drawing.Point(568, 22);
            this.btnVisualizarApartamento.Name = "btnVisualizarApartamento";
            this.btnVisualizarApartamento.Size = new System.Drawing.Size(88, 28);
            this.btnVisualizarApartamento.TabIndex = 3;
            this.btnVisualizarApartamento.Text = "Visualizar";
            this.btnVisualizarApartamento.UseVisualStyleBackColor = false;
            this.btnVisualizarApartamento.Click += new System.EventHandler(this.btnVisualizarApartamento_Click);
            // 
            // btnExcluirApartamento
            // 
            this.btnExcluirApartamento.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnExcluirApartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluirApartamento.Location = new System.Drawing.Point(399, 22);
            this.btnExcluirApartamento.Name = "btnExcluirApartamento";
            this.btnExcluirApartamento.Size = new System.Drawing.Size(82, 28);
            this.btnExcluirApartamento.TabIndex = 2;
            this.btnExcluirApartamento.Text = "Excluir";
            this.btnExcluirApartamento.UseVisualStyleBackColor = false;
            this.btnExcluirApartamento.Click += new System.EventHandler(this.btnExcluirApartamento_Click);
            // 
            // btnEditarApartamento
            // 
            this.btnEditarApartamento.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEditarApartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditarApartamento.Location = new System.Drawing.Point(235, 22);
            this.btnEditarApartamento.Name = "btnEditarApartamento";
            this.btnEditarApartamento.Size = new System.Drawing.Size(83, 28);
            this.btnEditarApartamento.TabIndex = 1;
            this.btnEditarApartamento.Text = "Editar";
            this.btnEditarApartamento.UseVisualStyleBackColor = false;
            this.btnEditarApartamento.Click += new System.EventHandler(this.btnEditarApartamento_Click);
            // 
            // btnNovoApartamento
            // 
            this.btnNovoApartamento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNovoApartamento.Location = new System.Drawing.Point(73, 22);
            this.btnNovoApartamento.Name = "btnNovoApartamento";
            this.btnNovoApartamento.Size = new System.Drawing.Size(76, 28);
            this.btnNovoApartamento.TabIndex = 0;
            this.btnNovoApartamento.Text = "Novo";
            this.btnNovoApartamento.UseVisualStyleBackColor = false;
            this.btnNovoApartamento.Click += new System.EventHandler(this.btnNovoApartamento_Click);
            // 
            // tpColaborador
            // 
            this.tpColaborador.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpColaborador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tpColaborador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpColaborador.Controls.Add(this.dgColaborador);
            this.tpColaborador.Controls.Add(this.panel4);
            this.tpColaborador.Controls.Add(this.panel3);
            this.tpColaborador.Location = new System.Drawing.Point(4, 25);
            this.tpColaborador.Name = "tpColaborador";
            this.tpColaborador.Padding = new System.Windows.Forms.Padding(3);
            this.tpColaborador.Size = new System.Drawing.Size(773, 408);
            this.tpColaborador.TabIndex = 1;
            this.tpColaborador.Text = "Colaborador";
            // 
            // dgColaborador
            // 
            this.dgColaborador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgColaborador.Location = new System.Drawing.Point(20, 83);
            this.dgColaborador.Name = "dgColaborador";
            this.dgColaborador.RowTemplate.Height = 24;
            this.dgColaborador.Size = new System.Drawing.Size(732, 245);
            this.dgColaborador.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnEditarColaborador);
            this.panel4.Controls.Add(this.btnVisualizarColab);
            this.panel4.Controls.Add(this.btnExcluirColab);
            this.panel4.Controls.Add(this.btnIncluirColab);
            this.panel4.Location = new System.Drawing.Point(20, 343);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(732, 54);
            this.panel4.TabIndex = 21;
            // 
            // btnEditarColaborador
            // 
            this.btnEditarColaborador.Location = new System.Drawing.Point(231, 16);
            this.btnEditarColaborador.Name = "btnEditarColaborador";
            this.btnEditarColaborador.Size = new System.Drawing.Size(75, 23);
            this.btnEditarColaborador.TabIndex = 9;
            this.btnEditarColaborador.Text = "Editar";
            this.btnEditarColaborador.UseVisualStyleBackColor = true;
            this.btnEditarColaborador.Click += new System.EventHandler(this.btnEditarColaborador_Click);
            // 
            // btnVisualizarColab
            // 
            this.btnVisualizarColab.Location = new System.Drawing.Point(591, 16);
            this.btnVisualizarColab.Name = "btnVisualizarColab";
            this.btnVisualizarColab.Size = new System.Drawing.Size(81, 23);
            this.btnVisualizarColab.TabIndex = 8;
            this.btnVisualizarColab.Text = "Visualizar";
            this.btnVisualizarColab.UseVisualStyleBackColor = true;
            this.btnVisualizarColab.Click += new System.EventHandler(this.btnVisualizarColab_Click);
            // 
            // btnExcluirColab
            // 
            this.btnExcluirColab.Location = new System.Drawing.Point(414, 16);
            this.btnExcluirColab.Name = "btnExcluirColab";
            this.btnExcluirColab.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirColab.TabIndex = 7;
            this.btnExcluirColab.Text = "Excluir";
            this.btnExcluirColab.UseVisualStyleBackColor = true;
            this.btnExcluirColab.Click += new System.EventHandler(this.btnExcluirColab_Click);
            // 
            // btnIncluirColab
            // 
            this.btnIncluirColab.Location = new System.Drawing.Point(56, 16);
            this.btnIncluirColab.Name = "btnIncluirColab";
            this.btnIncluirColab.Size = new System.Drawing.Size(79, 23);
            this.btnIncluirColab.TabIndex = 6;
            this.btnIncluirColab.Text = "Novo";
            this.btnIncluirColab.UseVisualStyleBackColor = true;
            this.btnIncluirColab.Click += new System.EventHandler(this.btnIncluirColab_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblTituloColab);
            this.panel3.Location = new System.Drawing.Point(20, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(732, 65);
            this.panel3.TabIndex = 20;
            // 
            // lblTituloColab
            // 
            this.lblTituloColab.AutoSize = true;
            this.lblTituloColab.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloColab.Location = new System.Drawing.Point(182, 15);
            this.lblTituloColab.Name = "lblTituloColab";
            this.lblTituloColab.Size = new System.Drawing.Size(348, 29);
            this.lblTituloColab.TabIndex = 6;
            this.lblTituloColab.Text = "COLABORADORES CADASTRADOS";
            // 
            // tpTipoReserva
            // 
            this.tpTipoReserva.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpTipoReserva.Controls.Add(this.panel2);
            this.tpTipoReserva.Controls.Add(this.dgTipoReserva);
            this.tpTipoReserva.Controls.Add(this.panel1);
            this.tpTipoReserva.Location = new System.Drawing.Point(4, 25);
            this.tpTipoReserva.Name = "tpTipoReserva";
            this.tpTipoReserva.Padding = new System.Windows.Forms.Padding(3);
            this.tpTipoReserva.Size = new System.Drawing.Size(773, 408);
            this.tpTipoReserva.TabIndex = 2;
            this.tpTipoReserva.Text = "Tipo de Reserva";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(20, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 65);
            this.panel2.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(253, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "TIPOS DE RESERVA";
            // 
            // dgTipoReserva
            // 
            this.dgTipoReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTipoReserva.Location = new System.Drawing.Point(20, 83);
            this.dgTipoReserva.Name = "dgTipoReserva";
            this.dgTipoReserva.RowTemplate.Height = 24;
            this.dgTipoReserva.Size = new System.Drawing.Size(732, 245);
            this.dgTipoReserva.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEditarTipoReserva);
            this.panel1.Controls.Add(this.btnExcluirTipoReserva);
            this.panel1.Controls.Add(this.btnVisualizarTippoReserva);
            this.panel1.Controls.Add(this.btnNovoTipoReserva);
            this.panel1.Location = new System.Drawing.Point(20, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 54);
            this.panel1.TabIndex = 18;
            // 
            // btnEditarTipoReserva
            // 
            this.btnEditarTipoReserva.Location = new System.Drawing.Point(224, 16);
            this.btnEditarTipoReserva.Name = "btnEditarTipoReserva";
            this.btnEditarTipoReserva.Size = new System.Drawing.Size(75, 23);
            this.btnEditarTipoReserva.TabIndex = 21;
            this.btnEditarTipoReserva.Text = "Editar";
            this.btnEditarTipoReserva.UseVisualStyleBackColor = true;
            this.btnEditarTipoReserva.Click += new System.EventHandler(this.btnEditarTipoReserva_Click);
            // 
            // btnExcluirTipoReserva
            // 
            this.btnExcluirTipoReserva.Location = new System.Drawing.Point(416, 16);
            this.btnExcluirTipoReserva.Name = "btnExcluirTipoReserva";
            this.btnExcluirTipoReserva.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirTipoReserva.TabIndex = 20;
            this.btnExcluirTipoReserva.Text = "Excluir";
            this.btnExcluirTipoReserva.UseVisualStyleBackColor = true;
            this.btnExcluirTipoReserva.Click += new System.EventHandler(this.btnExcluirTipoReserva_Click);
            // 
            // btnVisualizarTippoReserva
            // 
            this.btnVisualizarTippoReserva.Location = new System.Drawing.Point(592, 16);
            this.btnVisualizarTippoReserva.Name = "btnVisualizarTippoReserva";
            this.btnVisualizarTippoReserva.Size = new System.Drawing.Size(84, 23);
            this.btnVisualizarTippoReserva.TabIndex = 19;
            this.btnVisualizarTippoReserva.Text = "Visualizar";
            this.btnVisualizarTippoReserva.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVisualizarTippoReserva.UseVisualStyleBackColor = true;
            this.btnVisualizarTippoReserva.Click += new System.EventHandler(this.btnVisualizarTippoReserva_Click);
            // 
            // btnNovoTipoReserva
            // 
            this.btnNovoTipoReserva.Location = new System.Drawing.Point(54, 16);
            this.btnNovoTipoReserva.Name = "btnNovoTipoReserva";
            this.btnNovoTipoReserva.Size = new System.Drawing.Size(75, 23);
            this.btnNovoTipoReserva.TabIndex = 18;
            this.btnNovoTipoReserva.Text = "Novo";
            this.btnNovoTipoReserva.UseVisualStyleBackColor = true;
            this.btnNovoTipoReserva.Click += new System.EventHandler(this.btnNovoTipoReserva_Click);
            // 
            // tpUsuario
            // 
            this.tpUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpUsuario.Controls.Add(this.dgUsuario);
            this.tpUsuario.Controls.Add(this.panel5);
            this.tpUsuario.Controls.Add(this.panel8);
            this.tpUsuario.Location = new System.Drawing.Point(4, 25);
            this.tpUsuario.Name = "tpUsuario";
            this.tpUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsuario.Size = new System.Drawing.Size(773, 408);
            this.tpUsuario.TabIndex = 3;
            this.tpUsuario.Text = "Usuário";
            // 
            // dgUsuario
            // 
            this.dgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuario.Location = new System.Drawing.Point(20, 84);
            this.dgUsuario.Name = "dgUsuario";
            this.dgUsuario.RowTemplate.Height = 24;
            this.dgUsuario.Size = new System.Drawing.Size(732, 253);
            this.dgUsuario.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnEditarUsuario);
            this.panel5.Controls.Add(this.btnVisualzarUsuario);
            this.panel5.Controls.Add(this.btnExcluirUsuario);
            this.panel5.Controls.Add(this.btnIncluirUsuario);
            this.panel5.Location = new System.Drawing.Point(20, 343);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(732, 54);
            this.panel5.TabIndex = 24;
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Location = new System.Drawing.Point(231, 16);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnEditarUsuario.TabIndex = 9;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnVisualzarUsuario
            // 
            this.btnVisualzarUsuario.Location = new System.Drawing.Point(591, 16);
            this.btnVisualzarUsuario.Name = "btnVisualzarUsuario";
            this.btnVisualzarUsuario.Size = new System.Drawing.Size(81, 23);
            this.btnVisualzarUsuario.TabIndex = 8;
            this.btnVisualzarUsuario.Text = "Visualizar";
            this.btnVisualzarUsuario.UseVisualStyleBackColor = true;
            this.btnVisualzarUsuario.Click += new System.EventHandler(this.btnVisualzarUsuario_Click);
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.Location = new System.Drawing.Point(414, 16);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirUsuario.TabIndex = 7;
            this.btnExcluirUsuario.Text = "Excluir";
            this.btnExcluirUsuario.UseVisualStyleBackColor = true;
            this.btnExcluirUsuario.Click += new System.EventHandler(this.btnExcluirUsuario_Click);
            // 
            // btnIncluirUsuario
            // 
            this.btnIncluirUsuario.Location = new System.Drawing.Point(56, 16);
            this.btnIncluirUsuario.Name = "btnIncluirUsuario";
            this.btnIncluirUsuario.Size = new System.Drawing.Size(79, 23);
            this.btnIncluirUsuario.TabIndex = 6;
            this.btnIncluirUsuario.Text = "Novo";
            this.btnIncluirUsuario.UseVisualStyleBackColor = true;
            this.btnIncluirUsuario.Click += new System.EventHandler(this.btnIncluirUsuario_Click);
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.lblTituloUsuario);
            this.panel8.Location = new System.Drawing.Point(20, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(732, 65);
            this.panel8.TabIndex = 23;
            // 
            // lblTituloUsuario
            // 
            this.lblTituloUsuario.AutoSize = true;
            this.lblTituloUsuario.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloUsuario.Location = new System.Drawing.Point(216, 16);
            this.lblTituloUsuario.Name = "lblTituloUsuario";
            this.lblTituloUsuario.Size = new System.Drawing.Size(273, 29);
            this.lblTituloUsuario.TabIndex = 6;
            this.lblTituloUsuario.Text = "USUÁRIOS CADASTRADOS";
            // 
            // btnAtualizarAdministrador
            // 
            this.btnAtualizarAdministrador.Location = new System.Drawing.Point(714, 36);
            this.btnAtualizarAdministrador.Name = "btnAtualizarAdministrador";
            this.btnAtualizarAdministrador.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarAdministrador.TabIndex = 2;
            this.btnAtualizarAdministrador.Text = "Atualizar";
            this.btnAtualizarAdministrador.UseVisualStyleBackColor = true;
            this.btnAtualizarAdministrador.Click += new System.EventHandler(this.btnAtualizarAdministrador_Click);
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.btnAtualizarAdministrador);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuAdministrador);
            this.MainMenuStrip = this.menuAdministrador;
            this.Name = "frmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGACON - SISTEMA DE GESTÃO DE ADMINISTRAÇÃO DE CONDOMÍNIO";
            this.menuAdministrador.ResumeLayout(false);
            this.menuAdministrador.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpApartamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgApartamento)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.tpColaborador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgColaborador)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tpTipoReserva.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTipoReserva)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tpUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAdministrador;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admCondomínioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpApartamento;
        private System.Windows.Forms.TabPage tpColaborador;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnVisualizarColab;
        private System.Windows.Forms.Button btnExcluirColab;
        private System.Windows.Forms.Button btnIncluirColab;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTituloColab;
        private System.Windows.Forms.TabPage tpTipoReserva;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVisualizarTippoReserva;
        private System.Windows.Forms.Button btnNovoTipoReserva;
        private System.Windows.Forms.TabPage tpUsuario;
        private System.Windows.Forms.Button btnEditarColaborador;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnVisualzarUsuario;
        private System.Windows.Forms.Button btnExcluirUsuario;
        private System.Windows.Forms.Button btnIncluirUsuario;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblTituloUsuario;
        private System.Windows.Forms.DataGridView dgUsuario;
        private System.Windows.Forms.Button btnAtualizarAdministrador;
        private System.Windows.Forms.DataGridView dgTipoReserva;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEditarTipoReserva;
        private System.Windows.Forms.Button btnExcluirTipoReserva;
        private System.Windows.Forms.DataGridView dgColaborador;
        private System.Windows.Forms.DataGridView dgApartamento;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnVisualizarApartamento;
        private System.Windows.Forms.Button btnExcluirApartamento;
        private System.Windows.Forms.Button btnEditarApartamento;
        private System.Windows.Forms.Button btnNovoApartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}