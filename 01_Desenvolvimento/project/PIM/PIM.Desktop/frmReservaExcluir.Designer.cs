namespace PIM.Desktop
{
    partial class frmReservaExcluir
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCancelarExclusaoReserva = new System.Windows.Forms.Button();
            this.btnConfirmaExclusaoReserva = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblExcluirCodReserva = new System.Windows.Forms.Label();
            this.txtExcluirCodMorReserva = new System.Windows.Forms.TextBox();
            this.lblExcluirCodMorReserva = new System.Windows.Forms.Label();
            this.cboExcluirTipoReserva = new System.Windows.Forms.ComboBox();
            this.lblExcluirTipoReserva = new System.Windows.Forms.Label();
            this.dtExcluirDataReserva = new System.Windows.Forms.DateTimePicker();
            this.lblExcluirDataReserva = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnCancelarExclusaoReserva);
            this.panel5.Controls.Add(this.btnConfirmaExclusaoReserva);
            this.panel5.Location = new System.Drawing.Point(28, 433);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(747, 75);
            this.panel5.TabIndex = 16;
            // 
            // btnCancelarExclusaoReserva
            // 
            this.btnCancelarExclusaoReserva.Location = new System.Drawing.Point(482, 24);
            this.btnCancelarExclusaoReserva.Name = "btnCancelarExclusaoReserva";
            this.btnCancelarExclusaoReserva.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarExclusaoReserva.TabIndex = 1;
            this.btnCancelarExclusaoReserva.Text = "Cancelar";
            this.btnCancelarExclusaoReserva.UseVisualStyleBackColor = true;
            this.btnCancelarExclusaoReserva.Click += new System.EventHandler(this.btnCancelarExclusaoReserva_Click);
            // 
            // btnConfirmaExclusaoReserva
            // 
            this.btnConfirmaExclusaoReserva.Location = new System.Drawing.Point(149, 24);
            this.btnConfirmaExclusaoReserva.Name = "btnConfirmaExclusaoReserva";
            this.btnConfirmaExclusaoReserva.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmaExclusaoReserva.TabIndex = 0;
            this.btnConfirmaExclusaoReserva.Text = "Excluir";
            this.btnConfirmaExclusaoReserva.UseVisualStyleBackColor = true;
            this.btnConfirmaExclusaoReserva.Click += new System.EventHandler(this.btnConfirmaExclusaoReserva_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lblExcluirCodReserva);
            this.panel7.Controls.Add(this.txtExcluirCodMorReserva);
            this.panel7.Controls.Add(this.lblExcluirCodMorReserva);
            this.panel7.Controls.Add(this.cboExcluirTipoReserva);
            this.panel7.Controls.Add(this.lblExcluirTipoReserva);
            this.panel7.Controls.Add(this.dtExcluirDataReserva);
            this.panel7.Controls.Add(this.lblExcluirDataReserva);
            this.panel7.Location = new System.Drawing.Point(28, 25);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(747, 402);
            this.panel7.TabIndex = 15;
            // 
            // lblExcluirCodReserva
            // 
            this.lblExcluirCodReserva.AutoSize = true;
            this.lblExcluirCodReserva.Location = new System.Drawing.Point(336, 54);
            this.lblExcluirCodReserva.Name = "lblExcluirCodReserva";
            this.lblExcluirCodReserva.Size = new System.Drawing.Size(0, 17);
            this.lblExcluirCodReserva.TabIndex = 5;
            // 
            // txtExcluirCodMorReserva
            // 
            this.txtExcluirCodMorReserva.Location = new System.Drawing.Point(339, 140);
            this.txtExcluirCodMorReserva.Name = "txtExcluirCodMorReserva";
            this.txtExcluirCodMorReserva.Size = new System.Drawing.Size(141, 22);
            this.txtExcluirCodMorReserva.TabIndex = 1;
            // 
            // lblExcluirCodMorReserva
            // 
            this.lblExcluirCodMorReserva.AutoSize = true;
            this.lblExcluirCodMorReserva.Location = new System.Drawing.Point(200, 145);
            this.lblExcluirCodMorReserva.Name = "lblExcluirCodMorReserva";
            this.lblExcluirCodMorReserva.Size = new System.Drawing.Size(133, 17);
            this.lblExcluirCodMorReserva.TabIndex = 0;
            this.lblExcluirCodMorReserva.Text = "Código do Morador:";
            // 
            // cboExcluirTipoReserva
            // 
            this.cboExcluirTipoReserva.FormattingEnabled = true;
            this.cboExcluirTipoReserva.Items.AddRange(new object[] {
            "Churrasqueira",
            "Salão de Festas"});
            this.cboExcluirTipoReserva.Location = new System.Drawing.Point(274, 232);
            this.cboExcluirTipoReserva.Name = "cboExcluirTipoReserva";
            this.cboExcluirTipoReserva.Size = new System.Drawing.Size(283, 24);
            this.cboExcluirTipoReserva.TabIndex = 4;
            // 
            // lblExcluirTipoReserva
            // 
            this.lblExcluirTipoReserva.AutoSize = true;
            this.lblExcluirTipoReserva.Location = new System.Drawing.Point(150, 241);
            this.lblExcluirTipoReserva.Name = "lblExcluirTipoReserva";
            this.lblExcluirTipoReserva.Size = new System.Drawing.Size(117, 17);
            this.lblExcluirTipoReserva.TabIndex = 3;
            this.lblExcluirTipoReserva.Text = "Tipo de Reserva:";
            // 
            // dtExcluirDataReserva
            // 
            this.dtExcluirDataReserva.Location = new System.Drawing.Point(272, 324);
            this.dtExcluirDataReserva.Name = "dtExcluirDataReserva";
            this.dtExcluirDataReserva.Size = new System.Drawing.Size(285, 22);
            this.dtExcluirDataReserva.TabIndex = 1;
            // 
            // lblExcluirDataReserva
            // 
            this.lblExcluirDataReserva.AutoSize = true;
            this.lblExcluirDataReserva.Location = new System.Drawing.Point(147, 329);
            this.lblExcluirDataReserva.Name = "lblExcluirDataReserva";
            this.lblExcluirDataReserva.Size = new System.Drawing.Size(119, 17);
            this.lblExcluirDataReserva.TabIndex = 0;
            this.lblExcluirDataReserva.Text = "Data da Reserva:";
            // 
            // frmReservaExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Name = "frmReservaExcluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Reserva";
            this.Load += new System.EventHandler(this.frmReservaExcluir_Load);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCancelarExclusaoReserva;
        private System.Windows.Forms.Button btnConfirmaExclusaoReserva;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblExcluirCodReserva;
        private System.Windows.Forms.TextBox txtExcluirCodMorReserva;
        private System.Windows.Forms.Label lblExcluirCodMorReserva;
        private System.Windows.Forms.ComboBox cboExcluirTipoReserva;
        private System.Windows.Forms.Label lblExcluirTipoReserva;
        private System.Windows.Forms.DateTimePicker dtExcluirDataReserva;
        private System.Windows.Forms.Label lblExcluirDataReserva;
    }
}