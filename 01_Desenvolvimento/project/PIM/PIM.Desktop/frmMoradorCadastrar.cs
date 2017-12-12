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
    public partial class frmMoradorCadastrar : Form
    {
        public frmMoradorCadastrar()
        {
            InitializeComponent();
        }

        private void btnCancelarMor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarMor_Click(object sender, EventArgs e)
        {
            string erro = String.Empty;

            if (!ValidarCampos(out erro))
            {
                MessageBox.Show(erro, "Atenção");
            }

            MoradorTO moradorTO = new MoradorTO();

            moradorTO.Nome = txtNomeMor.Text;
            moradorTO.RG = txtRgMor.Text;
            moradorTO.CPF = txtCpfMor.Text;
            moradorTO.Telefone = txtTelefoneMor.Text;
            moradorTO.Celular = txtCelularMor.Text;
            moradorTO.DataNascimento = dtNascimento.Value.Date;
            moradorTO.Email = txtEmailMor.Text;

            MoradorService.Criar(moradorTO);

            if (!moradorTO.Valido)
            {
                MessageBox.Show(moradorTO.Mensagem, "Atenção");
                return;
            }

            this.Close();
        }

        private bool ValidarCampos(out string erro)
        {
            string msgErro = string.Empty;
            erro = string.Empty;

            if (string.IsNullOrEmpty(txtNomeMor.Text))
            {
                msgErro += "Preenchimento do Nome obrigatório\n";
            }

            if (string.IsNullOrEmpty(txtRgMor.Text))
            {
                msgErro += "Preenchimento do RG obrigatório\n";
            }

            if (string.IsNullOrEmpty(txtCpfMor.Text))
            {
                msgErro += "Preenchimento do CPF obrigatório\n";
            }

            if (string.IsNullOrEmpty(txtTelefoneMor.Text))
            {
                msgErro += "Preenchimento do Telefone obrigatório\n";
            }

            if (string.IsNullOrEmpty(txtEmailMor.Text))
            {
                msgErro += "Preenchimento do Telefone obrigatório\n";
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

        private void btnCancelarMor_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
