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
    public partial class frmCadastrarOcorrencia : Form
    {
        public frmCadastrarOcorrencia()
        {
            InitializeComponent();
        }

        private void btnCancelarOco_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarOco_Click(object sender, EventArgs e)
        {
            string erro = String.Empty;

            if (!ValidarCampos(out erro))
            {
                MessageBox.Show(erro, "Atenção");
            }

            OcorrenciaTO ocorrenciaTO = new OcorrenciaTO();

            ocorrenciaTO.IdMorador = Convert.ToInt32(txtCodMorCadOco.Text);
            ocorrenciaTO.DataOcorrencia = Convert.ToDateTime(txtDataCadOco.Text);
            ocorrenciaTO.Motivo = txtMotivoCadOco.Text;
            ocorrenciaTO.Descricao = rtxtDescricaoOco.Text;

            OcorrenciaService.Criar(ocorrenciaTO);

            if (!ocorrenciaTO.Valido)
            {
                MessageBox.Show(ocorrenciaTO.Mensagem, "Atenção");
                return;
            }

            this.Close();
        }

        private bool ValidarCampos(out string erro)
        {
            string msgErro = string.Empty;
            erro = string.Empty;

            if (string.IsNullOrEmpty(txtCodMorCadOco.Text))
            {
                msgErro += "Preenchimento do Código obrigatório\n";
            }

            if (string.IsNullOrEmpty(txtDataCadOco.Text))
            {
                msgErro += "Preenchimento da data obrigatório\n";
            }

            if (string.IsNullOrEmpty(txtMotivoCadOco.Text))
            {
                msgErro += "Preenchimento do Motivo obrigatório\n";
            }

            if (string.IsNullOrEmpty(rtxtDescricaoOco.Text))
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
