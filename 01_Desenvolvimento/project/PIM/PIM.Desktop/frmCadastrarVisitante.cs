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
    public partial class frmCadastrarVisitante : Form
    {
        public frmCadastrarVisitante()
        {
            InitializeComponent();
        }

        private void btnCancelarVisit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidaCampos(out string msgErro)
        {
            string erro = string.Empty;

            if (string.IsNullOrEmpty(txtCodMorVisit.Text))
            {
                erro += " Preenchimento do Nome obrigatório\n";
            }
            if (string.IsNullOrEmpty(txtNomeVisit.Text))
            {
                erro += " Preenchimento do Nome obrigatório\n";
            }
            if (string.IsNullOrEmpty(txtCodVisitante.Text))
            {
                erro += " Preenchimento do Código do visitante obrigatório\n";
            }
            if (string.IsNullOrEmpty(txtAutorizacaoVisitante.Text))
            {
                erro += " Preenchimento da Autorização é obrigatório\n";
            }

            if (!string.IsNullOrEmpty(erro))
            {
                msgErro = erro;
                return false;
            }
            msgErro = string.Empty;
            return true;
        }



        private void btnSalvarVisit_Click(object sender, EventArgs e)
        {
            string erro = String.Empty;

            if (!ValidarCampos(out erro))
            {
                MessageBox.Show(erro, "Atenção");
            }

            VisitanteTO visitanteTO = new VisitanteTO();

            visitanteTO.Identificador = Convert.ToInt32(txtCodVisitante.Text);
            visitanteTO.Nome = txtNomeVisit.Text;
            visitanteTO.IdMorador = Convert.ToInt32(txtCodMorVisit.Text);
            visitanteTO.Mensagem = txtAutorizacaoVisitante.Text;
            
            VisitanteService.Criar(visitanteTO);

            if (!visitanteTO.Valido)
            {
                MessageBox.Show(visitanteTO.Mensagem, "Atenção");
                return;
            }

            this.Close();
        }

        private bool ValidarCampos(out string erro)
        {
            string msgErro = string.Empty;
            erro = string.Empty;

            if (string.IsNullOrEmpty(txtCodVisitante.Text))
            {
                msgErro += "Preenchimento do Código obrigatório\n";
            }

            if (string.IsNullOrEmpty(txtNomeVisit.Text))
            {
                msgErro += "Preenchimento do Nome obrigatório\n";
            }

            if (string.IsNullOrEmpty(txtCodMorVisit.Text))
            {
                msgErro += "Preenchimento do ´Código do Morador obrigatório\n";
            }

            if (string.IsNullOrEmpty(txtAutorizacaoVisitante.Text))
            {
                msgErro += "Preenchimento da Autorização obrigatório\n";
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





