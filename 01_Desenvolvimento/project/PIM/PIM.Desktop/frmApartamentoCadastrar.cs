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
    public partial class frmApartamentoCadastrar : Form
    {
        public frmApartamentoCadastrar()
        {
            InitializeComponent();
        }

        private void btnSalvarCadApartamento_Click(object sender, EventArgs e)
        {
            string erro = String.Empty;
             

            if (!ValidarCampos(out erro))
            {
                MessageBox.Show(erro, "Atenção");
            }

            ApartamentoTO apartamentoTO = new ApartamentoTO();

            apartamentoTO.Bloco = Convert.ToInt32(txtBlocoApto.Text);
            apartamentoTO.Identificador = Convert.ToInt32(lblCodigoApto.Text);
            apartamentoTO.Numero = txtNumeroApto.Text;
            apartamentoTO.IdContrato = Convert.ToInt32(txtCodContrato.Text);
            
            ApartamentoService.Criar(apartamentoTO);

            if (!apartamentoTO.Valido)
            {
                MessageBox.Show(apartamentoTO.Mensagem, "Atenção");
                return;
            }
            
            this.Close();
        }

        private bool ValidarCampos(out string erro)
        {
            string msgErro = string.Empty;
            erro = string.Empty;

            if (string.IsNullOrEmpty(txtBlocoApto.Text))
            {
                msgErro += "Preenchimento do Bloco obrigatório\n";
            }

            if (string.IsNullOrEmpty(txtNumeroApto.Text))
            {
                msgErro += "Preenchimento do Número do Apartamento obrigatório\n";
            }

            if (string.IsNullOrEmpty(txtCodContrato.Text))
            {
                msgErro += "Preenchimento do CPF obrigatório\n";
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
