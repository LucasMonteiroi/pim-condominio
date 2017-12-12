namespace PIM.Desktop
{
    partial class frmTipoDeReservaVisualizar
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCodTipoReserva = new System.Windows.Forms.Label();
            this.txtVisualizarCodTipoReserva = new System.Windows.Forms.TextBox();
            this.txtVisualizarTipoReserva = new System.Windows.Forms.TextBox();
            this.lblVisualizarTipoReserva = new System.Windows.Forms.Label();
            this.lblVisualizarCodTipoReserva = new System.Windows.Forms.Label();
            this.btnFecharVisualizacao = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnFecharVisualizacao);
            this.panel1.Location = new System.Drawing.Point(33, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 96);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblCodTipoReserva);
            this.panel2.Controls.Add(this.txtVisualizarCodTipoReserva);
            this.panel2.Controls.Add(this.txtVisualizarTipoReserva);
            this.panel2.Controls.Add(this.lblVisualizarTipoReserva);
            this.panel2.Controls.Add(this.lblVisualizarCodTipoReserva);
            this.panel2.Location = new System.Drawing.Point(33, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 248);
            this.panel2.TabIndex = 25;
            // 
            // lblCodTipoReserva
            // 
            this.lblCodTipoReserva.AutoSize = true;
            this.lblCodTipoReserva.Location = new System.Drawing.Point(128, 35);
            this.lblCodTipoReserva.Name = "lblCodTipoReserva";
            this.lblCodTipoReserva.Size = new System.Drawing.Size(0, 17);
            this.lblCodTipoReserva.TabIndex = 4;
            // 
            // txtVisualizarCodTipoReserva
            // 
            this.txtVisualizarCodTipoReserva.Location = new System.Drawing.Point(131, 106);
            this.txtVisualizarCodTipoReserva.Name = "txtVisualizarCodTipoReserva";
            this.txtVisualizarCodTipoReserva.Size = new System.Drawing.Size(100, 22);
            this.txtVisualizarCodTipoReserva.TabIndex = 3;
            // 
            // txtVisualizarTipoReserva
            // 
            this.txtVisualizarTipoReserva.Location = new System.Drawing.Point(514, 104);
            this.txtVisualizarTipoReserva.Name = "txtVisualizarTipoReserva";
            this.txtVisualizarTipoReserva.Size = new System.Drawing.Size(155, 22);
            this.txtVisualizarTipoReserva.TabIndex = 2;
            // 
            // lblVisualizarTipoReserva
            // 
            this.lblVisualizarTipoReserva.AutoSize = true;
            this.lblVisualizarTipoReserva.Location = new System.Drawing.Point(391, 109);
            this.lblVisualizarTipoReserva.Name = "lblVisualizarTipoReserva";
            this.lblVisualizarTipoReserva.Size = new System.Drawing.Size(117, 17);
            this.lblVisualizarTipoReserva.TabIndex = 1;
            this.lblVisualizarTipoReserva.Text = "Tipo de Reserva:";
            // 
            // lblVisualizarCodTipoReserva
            // 
            this.lblVisualizarCodTipoReserva.AutoSize = true;
            this.lblVisualizarCodTipoReserva.Location = new System.Drawing.Point(67, 111);
            this.lblVisualizarCodTipoReserva.Name = "lblVisualizarCodTipoReserva";
            this.lblVisualizarCodTipoReserva.Size = new System.Drawing.Size(56, 17);
            this.lblVisualizarCodTipoReserva.TabIndex = 0;
            this.lblVisualizarCodTipoReserva.Text = "Código:";
            // 
            // btnFecharVisualizacao
            // 
            this.btnFecharVisualizacao.Location = new System.Drawing.Point(307, 39);
            this.btnFecharVisualizacao.Name = "btnFecharVisualizacao";
            this.btnFecharVisualizacao.Size = new System.Drawing.Size(75, 23);
            this.btnFecharVisualizacao.TabIndex = 0;
            this.btnFecharVisualizacao.Text = "Fechar";
            this.btnFecharVisualizacao.UseVisualStyleBackColor = true;
            this.btnFecharVisualizacao.Click += new System.EventHandler(this.btnFecharVisualizacao_Click);
            // 
            // frmTipoDeReservaVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmTipoDeReservaVisualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Tipo de Reserva";
            this.Load += new System.EventHandler(this.frmTipoDeReservaVisualizar_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFecharVisualizacao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCodTipoReserva;
        private System.Windows.Forms.TextBox txtVisualizarCodTipoReserva;
        private System.Windows.Forms.TextBox txtVisualizarTipoReserva;
        private System.Windows.Forms.Label lblVisualizarTipoReserva;
        private System.Windows.Forms.Label lblVisualizarCodTipoReserva;
    }
}