namespace PIM.Desktop
{
    partial class frmTipoDeReservaExcluir
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
            this.btnCancelarExclusaoTipoReserva = new System.Windows.Forms.Button();
            this.btnConfirmarExclusaoTipoReserva = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtExcluirCodTipoReserva = new System.Windows.Forms.TextBox();
            this.txtExcluirTipoReserva = new System.Windows.Forms.TextBox();
            this.lblExcluirTipoReserva = new System.Windows.Forms.Label();
            this.lblExcluirCodTipoReserva = new System.Windows.Forms.Label();
            this.lblCodTipoReserva = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancelarExclusaoTipoReserva);
            this.panel1.Controls.Add(this.btnConfirmarExclusaoTipoReserva);
            this.panel1.Location = new System.Drawing.Point(31, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 96);
            this.panel1.TabIndex = 24;
            // 
            // btnCancelarExclusaoTipoReserva
            // 
            this.btnCancelarExclusaoTipoReserva.Location = new System.Drawing.Point(526, 37);
            this.btnCancelarExclusaoTipoReserva.Name = "btnCancelarExclusaoTipoReserva";
            this.btnCancelarExclusaoTipoReserva.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarExclusaoTipoReserva.TabIndex = 19;
            this.btnCancelarExclusaoTipoReserva.Text = "Cancelar";
            this.btnCancelarExclusaoTipoReserva.UseVisualStyleBackColor = true;
            this.btnCancelarExclusaoTipoReserva.Click += new System.EventHandler(this.btnCancelarExclusaoTipoReserva_Click);
            // 
            // btnConfirmarExclusaoTipoReserva
            // 
            this.btnConfirmarExclusaoTipoReserva.Location = new System.Drawing.Point(139, 37);
            this.btnConfirmarExclusaoTipoReserva.Name = "btnConfirmarExclusaoTipoReserva";
            this.btnConfirmarExclusaoTipoReserva.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarExclusaoTipoReserva.TabIndex = 18;
            this.btnConfirmarExclusaoTipoReserva.Text = "Salvar";
            this.btnConfirmarExclusaoTipoReserva.UseVisualStyleBackColor = true;
            this.btnConfirmarExclusaoTipoReserva.Click += new System.EventHandler(this.btnConfirmarExclusaoTipoReserva_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblCodTipoReserva);
            this.panel2.Controls.Add(this.txtExcluirCodTipoReserva);
            this.panel2.Controls.Add(this.txtExcluirTipoReserva);
            this.panel2.Controls.Add(this.lblExcluirTipoReserva);
            this.panel2.Controls.Add(this.lblExcluirCodTipoReserva);
            this.panel2.Location = new System.Drawing.Point(31, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 248);
            this.panel2.TabIndex = 23;
            // 
            // txtExcluirCodTipoReserva
            // 
            this.txtExcluirCodTipoReserva.Location = new System.Drawing.Point(131, 106);
            this.txtExcluirCodTipoReserva.Name = "txtExcluirCodTipoReserva";
            this.txtExcluirCodTipoReserva.Size = new System.Drawing.Size(100, 22);
            this.txtExcluirCodTipoReserva.TabIndex = 3;
            // 
            // txtExcluirTipoReserva
            // 
            this.txtExcluirTipoReserva.Location = new System.Drawing.Point(514, 104);
            this.txtExcluirTipoReserva.Name = "txtExcluirTipoReserva";
            this.txtExcluirTipoReserva.Size = new System.Drawing.Size(155, 22);
            this.txtExcluirTipoReserva.TabIndex = 2;
            // 
            // lblExcluirTipoReserva
            // 
            this.lblExcluirTipoReserva.AutoSize = true;
            this.lblExcluirTipoReserva.Location = new System.Drawing.Point(391, 109);
            this.lblExcluirTipoReserva.Name = "lblExcluirTipoReserva";
            this.lblExcluirTipoReserva.Size = new System.Drawing.Size(117, 17);
            this.lblExcluirTipoReserva.TabIndex = 1;
            this.lblExcluirTipoReserva.Text = "Tipo de Reserva:";
            // 
            // lblExcluirCodTipoReserva
            // 
            this.lblExcluirCodTipoReserva.AutoSize = true;
            this.lblExcluirCodTipoReserva.Location = new System.Drawing.Point(67, 111);
            this.lblExcluirCodTipoReserva.Name = "lblExcluirCodTipoReserva";
            this.lblExcluirCodTipoReserva.Size = new System.Drawing.Size(56, 17);
            this.lblExcluirCodTipoReserva.TabIndex = 0;
            this.lblExcluirCodTipoReserva.Text = "Código:";
            // 
            // lblCodTipoReserva
            // 
            this.lblCodTipoReserva.AutoSize = true;
            this.lblCodTipoReserva.Location = new System.Drawing.Point(128, 35);
            this.lblCodTipoReserva.Name = "lblCodTipoReserva";
            this.lblCodTipoReserva.Size = new System.Drawing.Size(0, 17);
            this.lblCodTipoReserva.TabIndex = 4;
            // 
            // frmTipoDeReservaExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmTipoDeReservaExcluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Tipo de Reserva";
            this.Load += new System.EventHandler(this.frmTipoDeReservaExcluir_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelarExclusaoTipoReserva;
        private System.Windows.Forms.Button btnConfirmarExclusaoTipoReserva;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtExcluirCodTipoReserva;
        private System.Windows.Forms.TextBox txtExcluirTipoReserva;
        private System.Windows.Forms.Label lblExcluirTipoReserva;
        private System.Windows.Forms.Label lblExcluirCodTipoReserva;
        private System.Windows.Forms.Label lblCodTipoReserva;
    }
}