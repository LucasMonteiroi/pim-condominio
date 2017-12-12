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
    public partial class frmContratoCadastrar : Form
    {
        public frmContratoCadastrar()
        {
            InitializeComponent();
        }

        private void btnSalvarContrato_Click(object sender, EventArgs e)
        {
            string erro = String.Empty;

            if (!ValidarCampos(out erro))
            {
                MessageBox.Show(erro, "Atenção");
            }

            ContratoTO contratoTO = new ContratoTO();

            contratoTO.IdMorador = Convert.ToInt32(txtCodMorador.Text);
            contratoTO.DataContrato = Convert.ToDateTime(txtDataContrato.Text);
            contratoTO.Valor = Convert.ToInt32(txtValorContrato.Text);
            contratoTO.Parcelas = Convert.ToInt32(txtParcelasContrato.Text);
            contratoTO.TipoContrato = cboTipoContrato.Text;
            contratoTO.Descricao = rtxtDescricaoContrato.Text;


            ContratoService.Criar(contratoTO);

            if (!contratoTO.Valido)
            {
                MessageBox.Show(contratoTO.Mensagem, "Atenção");
                return;
            }

            this.Close();
        }

        private bool ValidarCampos(out string erro)
        {
            string msgErro = string.Empty;
            erro = string.Empty;

            if (string.IsNullOrEmpty(txtCodMorador.Text))
            {
                msgErro += "Preenchimento do Codigo do Morador obrigatorio\n";
            }

            if (string.IsNullOrEmpty(txtDataContrato.Text))
            {
                msgErro += "Preenchimento do Contrato obrigatorio\n";
            }

            if (string.IsNullOrEmpty(txtValorContrato.Text))
            {
                msgErro += "Preenchimento do Valor Contrato obrigatório\n";
            }

            if (string.IsNullOrEmpty(txtParcelasContrato.Text))
            {
                msgErro += "Preenchimento da Parcelas Contrato obrigatório\n";
            }

            if (string.IsNullOrEmpty(cboTipoContrato.Text))
            {
                msgErro += "Preenchimento do Tipo de Contrato obrigatório\n";
            }

            if (string.IsNullOrEmpty(rtxtDescricaoContrato.Text))
            {
                msgErro += "Preenchimento da Descrição obrigatória\n";
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

        private void btnCancelarTelaContrato_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }

