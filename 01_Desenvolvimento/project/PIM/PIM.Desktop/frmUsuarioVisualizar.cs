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
    public partial class frmUsuarioVisualizar : Form
    {
        public frmUsuarioVisualizar(int idUsuario)
        {
            InitializeComponent();
            PreencherCampos(idUsuario);
        }

        private void btnFecharTelaVisualizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BloquearCampos()
        {
            //cboVisualizarLogin.ReadOnly = true;
            txtEditarSenhaUsuario.ReadOnly = true;
            //cboEditarGrupoUsuario.ReadOnly = true;
            txtEditarColabUsuario.ReadOnly = true;

        }

        private void frmUsuarioVisualizar_Load(object sender, EventArgs e)
        {
            BloquearCampos();
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

            cboVisualizarLogin.Text = usuarioTO.Login;
            txtEditarSenhaUsuario.Text = usuarioTO.Senha;
            cboEditarGrupoUsuario.Text = Convert.ToString(usuarioTO.IdGrupo);
            txtEditarColabUsuario.Text = Convert.ToString(usuarioTO.IdColaborador);
        }
    }
}
