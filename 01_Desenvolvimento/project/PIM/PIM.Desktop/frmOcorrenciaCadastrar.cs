using PIM.Database.TO;
using PIM.Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.Desktop
{
    public partial class frmOcorrenciaCadastrar : Form
    {
        public frmOcorrenciaCadastrar()
        {
            InitializeComponent();
        }

        private void btnCancelarCadOcorrencia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarCadOcorrencia_Click(object sender, EventArgs e)
        {
            try
            {
                string erro = String.Empty;

                if (!ValidarCampos(out erro))
                {
                    MessageBox.Show(erro, "Atenção");
                }

                OcorrenciaTO ocorrenciaTO = new OcorrenciaTO();

                ocorrenciaTO.IdMorador = Convert.ToInt32(txtCodMorOcorrencia.Text);
                ocorrenciaTO.Motivo = txtMotivoOcorrencia.Text;
                ocorrenciaTO.DataOcorrencia = dtOcorrencia.Value.Date;
                ocorrenciaTO.Descricao = rtxtDescricaoOcorrencia.Text;


                OcorrenciaService.Criar(ocorrenciaTO);

                if (!ocorrenciaTO.Valido)
                {
                    MessageBox.Show(ocorrenciaTO.Mensagem, "Atenção");
                    return;
                }

                this.Close();
            }
            catch
            {

            }
            
        }

        private bool ValidarCampos(out string erro)
        {
            string msgErro = string.Empty;
            erro = string.Empty;

            if (string.IsNullOrEmpty(txtCodMorOcorrencia.Text))
            {
                msgErro += "Preenchimento do Código do Morador obrigatório\n";
            }

            if (string.IsNullOrEmpty(txtMotivoOcorrencia.Text))
            {
                msgErro += "Preenchimento do Motivo obrigatório\n";
            }

            if (string.IsNullOrEmpty(dtOcorrencia.Text))
            {
                msgErro += "Preenchimento da Data obrigatório\n";
            }

            if (string.IsNullOrEmpty(rtxtDescricaoOcorrencia.Text))
            {
                msgErro += "Preenchimento da Descrição obrigatório\n";
            }

            
            if (!string.IsNullOrEmpty(msgErro))
            {
                erro = msgErro;
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
