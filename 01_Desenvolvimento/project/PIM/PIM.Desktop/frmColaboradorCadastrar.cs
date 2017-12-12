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
    public partial class frmColaboradorCadastrar : Form
    {
        public frmColaboradorCadastrar()
        {
            InitializeComponent();
        }

        
        private void btnCancelarColaborador_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
                
        private void btnSalvarColaborador_Click(object sender, EventArgs e)
        {
            
            string erro = String.Empty;

            if (!ValidarCampos(out erro))
            {
                MessageBox.Show(erro, "Atenção");
            }

            ColaboradorTO colaboradorTO = new ColaboradorTO();

            colaboradorTO.Nome = txtNomeColab.Text;
            colaboradorTO.RG = txtColabRG.Text;
            colaboradorTO.CPF = txtCpfColab.Text;
            colaboradorTO.Salario = Convert.ToInt32(txtSalarioColab.Text);
            colaboradorTO.Funcao = txtFuncaoColab.Text;
            colaboradorTO.DataContrato = dtDataContrato.Value.Date;

            ColaboradorService.Criar(colaboradorTO);

            if (!colaboradorTO.Valido)
            {
                 MessageBox.Show(colaboradorTO.Mensagem, "Atenção");
                 return;
            }

                this.Close();
        }

        private bool ValidarCampos(out string erro)
        {
             string msgErro = string.Empty;
             erro = string.Empty;

             if (string.IsNullOrEmpty(txtNomeColab.Text))
             {
                 msgErro += "Preenchimento do Nome obrigatório\n";
             }

             if (string.IsNullOrEmpty(txtColabRG.Text))
             {
                 msgErro += "Preenchimento do RG obrigatório\n";
             }

             if (string.IsNullOrEmpty(txtCpfColab.Text))
             {
                 msgErro += "Preenchimento do CPF obrigatório\n";
             }

             if (string.IsNullOrEmpty(txtSalarioColab.Text))
             {
                 msgErro += "Preenchimento do Salário obrigatório\n";
             }

             if (string.IsNullOrEmpty(txtFuncaoColab.Text))
             {
                 msgErro += "Preenchimento da Função obrigatório\n";
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