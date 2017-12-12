using PIM.Database.Infra;
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
    public partial class frmUsuarioExcluir : Form
    {
        public frmUsuarioExcluir(int idUsuario)
        {
            InitializeComponent();
            PreencherCampos(idUsuario);
        }

        private void PreencherCampos(int id)
        {
            UsuarioTO usuarioTO = new UsuarioTO();

            usuarioTO = UsuarioService.Obter(id);

            if (!usuarioTO.Valido)
            {
                //Todo: Exibir Mensagem e Fechar Form
                MessageBox.Show(usuarioTO.Mensagem, "Atenção");
                this.Close();
            }

            txtExcluirLogin.Text = usuarioTO.Login;
            txtSenhaUsuario.Text = usuarioTO.Senha;
            //cboGrupoUsuario.Text = usuarioTO.IdGrupo;
            txtColabUsuario.Text = Convert.ToString(usuarioTO.IdColaborador);


        }

        private void frmUsuarioExcluir_Load(object sender, EventArgs e)
        {
            BloquearCampos();
        }

        private void BloquearCampos()
        {
            txtExcluirLogin.ReadOnly = true;
            txtSenhaUsuario.ReadOnly = true;
            //cboGrupoUsuario.ReadOnly = true;
            txtColabUsuario.ReadOnly = true;

        }

        private void btnConfirmarExclusaoUsuario_Click(object sender, EventArgs e)
        {
            int idUsuario = Convert.ToInt32(lblCodigoUsuario.Text);

            RetornoTO retorno = new RetornoTO();

            retorno = UsuarioService.Remover(idUsuario);

            //Todo: Retornar mensagem se nao for valido
            if (!retorno.Valido)
            {
                MessageBox.Show(retorno.Mensagem, "Atenção");
            }

            this.Close();
        }

        private void btnCancelarExclusaoUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
