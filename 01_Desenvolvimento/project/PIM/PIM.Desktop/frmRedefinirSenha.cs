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
    public partial class frmRedefinirSenha : Form
    {
        public frmRedefinirSenha()
        {
            InitializeComponent();
        }

        private void btnCancelarRedefinicao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarNovaSenha_Click(object sender, EventArgs e)
        {
            string erro = String.Empty;

            if (!ValidarCampos(out erro))
            {
                MessageBox.Show(erro, "Atenção");
            }

            UsuarioTO usuarioTO = new UsuarioTO();

            usuarioTO.Login = txtInformarUsuario.Text;
            usuarioTO.Senha = txtNovaSenha.Text;
            
            UsuarioService.Criar(usuarioTO);

            if (!usuarioTO.Valido)
            {
                MessageBox.Show(usuarioTO.Mensagem, "Atenção");
                return;
            }

            this.Close();
        }

        private bool ValidarCampos(out string erro)
        {
            string msgErro = string.Empty;
            erro = string.Empty;

            if (string.IsNullOrEmpty(txtInformarUsuario.Text))
            {
                msgErro += "Preenchimento do Usuário obrigatório\n";
            }

            if (string.IsNullOrEmpty(txtNovaSenha.Text))
            {
                msgErro += "Preenchimento da Nova Senha obrigatório\n";
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
