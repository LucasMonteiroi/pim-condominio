namespace PIM.Desktop
{
    partial class frmReservaEditar
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
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.btnSalvarReserva = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblEditarCodReserva = new System.Windows.Forms.Label();
            this.txtEditarCodMorReserva = new System.Windows.Forms.TextBox();
            this.lblEditarCodMorReserva = new System.Windows.Forms.Label();
            this.cboEditarTipoReserva = new System.Windows.Forms.ComboBox();
            this.lblEditarTipoReserva = new System.Windows.Forms.Label();
            this.dtEditarDataReserva = new System.Windows.Forms.DateTimePicker();
            this.lblEditarDataReserva = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnCancelarReserva);
            this.panel5.Controls.Add(this.btnSalvarReserva);
            this.panel5.Location = new System.Drawing.Point(28, 433);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(747, 75);
            this.panel5.TabIndex = 14;
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Location = new System.Drawing.Point(482, 24);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarReserva.TabIndex = 1;
            this.btnCancelarReserva.Text = "Cancelar";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // btnSalvarReserva
            // 
            this.btnSalvarReserva.Location = new System.Drawing.Point(149, 24);
            this.btnSalvarReserva.Name = "btnSalvarReserva";
            this.btnSalvarReserva.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarReserva.TabIndex = 0;
            this.btnSalvarReserva.Text = "Salvar";
            this.btnSalvarReserva.UseVisualStyleBackColor = true;
            this.btnSalvarReserva.Click += new System.EventHandler(this.btnSalvarReserva_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lblEditarCodReserva);
            this.panel7.Controls.Add(this.txtEditarCodMorReserva);
            this.panel7.Controls.Add(this.lblEditarCodMorReserva);
            this.panel7.Controls.Add(this.cboEditarTipoReserva);
            this.panel7.Controls.Add(this.lblEditarTipoReserva);
            this.panel7.Controls.Add(this.dtEditarDataReserva);
            this.panel7.Controls.Add(this.lblEditarDataReserva);
            this.panel7.Location = new System.Drawing.Point(28, 25);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(747, 402);
            this.panel7.TabIndex = 13;
            // 
            // lblEditarCodReserva
            // 
            this.lblEditarCodReserva.AutoSize = true;
            this.lblEditarCodReserva.Location = new System.Drawing.Point(336, 54);
            this.lblEditarCodReserva.Name = "lblEditarCodReserva";
            this.lblEditarCodReserva.Size = new System.Drawing.Size(0, 17);
            this.lblEditarCodReserva.TabIndex = 5;
            // 
            // txtEditarCodMorReserva
            // 
            this.txtEditarCodMorReserva.Location = new System.Drawing.Point(339, 140);
            this.txtEditarCodMorReserva.Name = "txtEditarCodMorReserva";
            this.txtEditarCodMorReserva.Size = new System.Drawing.Size(141, 22);
            this.txtEditarCodMorReserva.TabIndex = 1;
            // 
            // lblEditarCodMorReserva
            // 
            this.lblEditarCodMorReserva.AutoSize = true;
            this.lblEditarCodMorReserva.Location = new System.Drawing.Point(200, 145);
            this.lblEditarCodMorReserva.Name = "lblEditarCodMorReserva";
            this.lblEditarCodMorReserva.Size = new System.Drawing.Size(133, 17);
            this.lblEditarCodMorReserva.TabIndex = 0;
            this.lblEditarCodMorReserva.Text = "Código do Morador:";
            // 
            // cboEditarTipoReserva
            // 
            this.cboEditarTipoReserva.FormattingEnabled = true;
            this.cboEditarTipoReserva.Items.AddRange(new object[] {
            "Churrasqueira",
            "Salão de Festas"});
            this.cboEditarTipoReserva.Location = new System.Drawing.Point(274, 232);
            this.cboEditarTipoReserva.Name = "cboEditarTipoReserva";
            this.cboEditarTipoReserva.Size = new System.Drawing.Size(283, 24);
            this.cboEditarTipoReserva.TabIndex = 4;
            // 
            // lblEditarTipoReserva
            // 
            this.lblEditarTipoReserva.AutoSize = true;
            this.lblEditarTipoReserva.Location = new System.Drawing.Point(150, 241);
            this.lblEditarTipoReserva.Name = "lblEditarTipoReserva";
            this.lblEditarTipoReserva.Size = new System.Drawing.Size(117, 17);
            this.lblEditarTipoReserva.TabIndex = 3;
            this.lblEditarTipoReserva.Text = "Tipo de Reserva:";
            // 
            // dtEditarDataReserva
            // 
            this.dtEditarDataReserva.Location = new System.Drawing.Point(272, 324);
            this.dtEditarDataReserva.Name = "dtEditarDataReserva";
            this.dtEditarDataReserva.Size = new System.Drawing.Size(285, 22);
            this.dtEditarDataReserva.TabIndex = 1;
            // 
            // lblEditarDataReserva
            // 
            this.lblEditarDataReserva.AutoSize = true;
            this.lblEditarDataReserva.Location = new System.Drawing.Point(147, 329);
            this.lblEditarDataReserva.Name = "lblEditarDataReserva";
            this.lblEditarDataReserva.Size = new System.Drawing.Size(119, 17);
            this.lblEditarDataReserva.TabIndex = 0;
            this.lblEditarDataReserva.Text = "Data da Reserva:";
            // 
            // frmReservaEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Name = "frmReservaEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Reserva";
            this.Load += new System.EventHandler(this.frmReservaEditar_Load);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.Button btnSalvarReserva;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblEditarCodReserva;
        private System.Windows.Forms.TextBox txtEditarCodMorReserva;
        private System.Windows.Forms.Label lblEditarCodMorReserva;
        private System.Windows.Forms.ComboBox cboEditarTipoReserva;
        private System.Windows.Forms.Label lblEditarTipoReserva;
        private System.Windows.Forms.DateTimePicker dtEditarDataReserva;
        private System.Windows.Forms.Label lblEditarDataReserva;
    }
}