namespace PIM.Desktop
{
    partial class frmTipoDeReservaCadastrar
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
            this.btnCancelarTipoReserva = new System.Windows.Forms.Button();
            this.btnSalvarTipoReserva = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCodTipoReserva = new System.Windows.Forms.TextBox();
            this.txtTipoReserva = new System.Windows.Forms.TextBox();
            this.lblTipoReserva = new System.Windows.Forms.Label();
            this.lblCodTipoReserva = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancelarTipoReserva);
            this.panel1.Controls.Add(this.btnSalvarTipoReserva);
            this.panel1.Location = new System.Drawing.Point(31, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 96);
            this.panel1.TabIndex = 20;
            // 
            // btnCancelarTipoReserva
            // 
            this.btnCancelarTipoReserva.Location = new System.Drawing.Point(526, 37);
            this.btnCancelarTipoReserva.Name = "btnCancelarTipoReserva";
            this.btnCancelarTipoReserva.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarTipoReserva.TabIndex = 19;
            this.btnCancelarTipoReserva.Text = "Cancelar";
            this.btnCancelarTipoReserva.UseVisualStyleBackColor = true;
            this.btnCancelarTipoReserva.Click += new System.EventHandler(this.btnCancelarTipoReserva_Click);
            // 
            // btnSalvarTipoReserva
            // 
            this.btnSalvarTipoReserva.Location = new System.Drawing.Point(139, 37);
            this.btnSalvarTipoReserva.Name = "btnSalvarTipoReserva";
            this.btnSalvarTipoReserva.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarTipoReserva.TabIndex = 18;
            this.btnSalvarTipoReserva.Text = "Salvar";
            this.btnSalvarTipoReserva.UseVisualStyleBackColor = true;
            this.btnSalvarTipoReserva.Click += new System.EventHandler(this.btnSalvarTipoReserva_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtCodTipoReserva);
            this.panel2.Controls.Add(this.txtTipoReserva);
            this.panel2.Controls.Add(this.lblTipoReserva);
            this.panel2.Controls.Add(this.lblCodTipoReserva);
            this.panel2.Location = new System.Drawing.Point(31, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 248);
            this.panel2.TabIndex = 19;
            // 
            // txtCodTipoReserva
            // 
            this.txtCodTipoReserva.Location = new System.Drawing.Point(131, 106);
            this.txtCodTipoReserva.Name = "txtCodTipoReserva";
            this.txtCodTipoReserva.Size = new System.Drawing.Size(100, 22);
            this.txtCodTipoReserva.TabIndex = 3;
            // 
            // txtTipoReserva
            // 
            this.txtTipoReserva.Location = new System.Drawing.Point(514, 104);
            this.txtTipoReserva.Name = "txtTipoReserva";
            this.txtTipoReserva.Size = new System.Drawing.Size(155, 22);
            this.txtTipoReserva.TabIndex = 2;
            // 
            // lblTipoReserva
            // 
            this.lblTipoReserva.AutoSize = true;
            this.lblTipoReserva.Location = new System.Drawing.Point(391, 109);
            this.lblTipoReserva.Name = "lblTipoReserva";
            this.lblTipoReserva.Size = new System.Drawing.Size(117, 17);
            this.lblTipoReserva.TabIndex = 1;
            this.lblTipoReserva.Text = "Tipo de Reserva:";
            // 
            // lblCodTipoReserva
            // 
            this.lblCodTipoReserva.AutoSize = true;
            this.lblCodTipoReserva.Location = new System.Drawing.Point(67, 111);
            this.lblCodTipoReserva.Name = "lblCodTipoReserva";
            this.lblCodTipoReserva.Size = new System.Drawing.Size(56, 17);
            this.lblCodTipoReserva.TabIndex = 0;
            this.lblCodTipoReserva.Text = "Código:";
            // 
            // frmTipoDeReservaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmTipoDeReservaCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Tipo de Reserva";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelarTipoReserva;
        private System.Windows.Forms.Button btnSalvarTipoReserva;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCodTipoReserva;
        private System.Windows.Forms.TextBox txtTipoReserva;
        private System.Windows.Forms.Label lblTipoReserva;
        private System.Windows.Forms.Label lblCodTipoReserva;
    }
}