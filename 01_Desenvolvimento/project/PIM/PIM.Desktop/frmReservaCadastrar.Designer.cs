namespace PIM.Desktop
{
    partial class frmReservaCadastrar
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
            this.lblCodReserva = new System.Windows.Forms.Label();
            this.txtCodMorReserva = new System.Windows.Forms.TextBox();
            this.lblCodMorReserva = new System.Windows.Forms.Label();
            this.cboTipoReserva = new System.Windows.Forms.ComboBox();
            this.lblTipoReserva = new System.Windows.Forms.Label();
            this.dtDataReserva = new System.Windows.Forms.DateTimePicker();
            this.lblDataReserva = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnCancelarReserva);
            this.panel5.Controls.Add(this.btnSalvarReserva);
            this.panel5.Location = new System.Drawing.Point(28, 451);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(747, 55);
            this.panel5.TabIndex = 12;
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Location = new System.Drawing.Point(487, 19);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarReserva.TabIndex = 1;
            this.btnCancelarReserva.Text = "Cancelar";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // btnSalvarReserva
            // 
            this.btnSalvarReserva.Location = new System.Drawing.Point(154, 19);
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
            this.panel7.Controls.Add(this.lblCodReserva);
            this.panel7.Controls.Add(this.txtCodMorReserva);
            this.panel7.Controls.Add(this.lblCodMorReserva);
            this.panel7.Controls.Add(this.cboTipoReserva);
            this.panel7.Controls.Add(this.lblTipoReserva);
            this.panel7.Controls.Add(this.dtDataReserva);
            this.panel7.Controls.Add(this.lblDataReserva);
            this.panel7.Location = new System.Drawing.Point(28, 23);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(747, 422);
            this.panel7.TabIndex = 11;
            // 
            // lblCodReserva
            // 
            this.lblCodReserva.AutoSize = true;
            this.lblCodReserva.Location = new System.Drawing.Point(365, 40);
            this.lblCodReserva.Name = "lblCodReserva";
            this.lblCodReserva.Size = new System.Drawing.Size(0, 17);
            this.lblCodReserva.TabIndex = 5;
            // 
            // txtCodMorReserva
            // 
            this.txtCodMorReserva.Location = new System.Drawing.Point(365, 116);
            this.txtCodMorReserva.Name = "txtCodMorReserva";
            this.txtCodMorReserva.Size = new System.Drawing.Size(141, 22);
            this.txtCodMorReserva.TabIndex = 1;
            // 
            // lblCodMorReserva
            // 
            this.lblCodMorReserva.AutoSize = true;
            this.lblCodMorReserva.Location = new System.Drawing.Point(226, 121);
            this.lblCodMorReserva.Name = "lblCodMorReserva";
            this.lblCodMorReserva.Size = new System.Drawing.Size(133, 17);
            this.lblCodMorReserva.TabIndex = 0;
            this.lblCodMorReserva.Text = "Código do Morador:";
            // 
            // cboTipoReserva
            // 
            this.cboTipoReserva.FormattingEnabled = true;
            this.cboTipoReserva.Items.AddRange(new object[] {
            "Churrasqueira",
            "Salão de Festas"});
            this.cboTipoReserva.Location = new System.Drawing.Point(303, 232);
            this.cboTipoReserva.Name = "cboTipoReserva";
            this.cboTipoReserva.Size = new System.Drawing.Size(283, 24);
            this.cboTipoReserva.TabIndex = 4;
            // 
            // lblTipoReserva
            // 
            this.lblTipoReserva.AutoSize = true;
            this.lblTipoReserva.Location = new System.Drawing.Point(179, 241);
            this.lblTipoReserva.Name = "lblTipoReserva";
            this.lblTipoReserva.Size = new System.Drawing.Size(117, 17);
            this.lblTipoReserva.TabIndex = 3;
            this.lblTipoReserva.Text = "Tipo de Reserva:";
            // 
            // dtDataReserva
            // 
            this.dtDataReserva.Location = new System.Drawing.Point(301, 324);
            this.dtDataReserva.Name = "dtDataReserva";
            this.dtDataReserva.Size = new System.Drawing.Size(285, 22);
            this.dtDataReserva.TabIndex = 1;
            // 
            // lblDataReserva
            // 
            this.lblDataReserva.AutoSize = true;
            this.lblDataReserva.Location = new System.Drawing.Point(176, 329);
            this.lblDataReserva.Name = "lblDataReserva";
            this.lblDataReserva.Size = new System.Drawing.Size(119, 17);
            this.lblDataReserva.TabIndex = 0;
            this.lblDataReserva.Text = "Data da Reserva:";
            // 
            // frmReservaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Name = "frmReservaCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Reserva";
            this.Load += new System.EventHandler(this.frmReservaCadastrar_Load);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtCodMorReserva;
        private System.Windows.Forms.Label lblCodMorReserva;
        private System.Windows.Forms.ComboBox cboTipoReserva;
        private System.Windows.Forms.Label lblTipoReserva;
        private System.Windows.Forms.DateTimePicker dtDataReserva;
        private System.Windows.Forms.Label lblDataReserva;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.Button btnSalvarReserva;
        private System.Windows.Forms.Label lblCodReserva;
    }
}