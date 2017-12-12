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
    public partial class frmUsuarioCadastrar : Form
    {
        public frmUsuarioCadastrar()
        {
            InitializeComponent();
        }



        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            string erro = String.Empty;

            if (!ValidarCampos(out erro))
            {
                MessageBox.Show(erro, "Atenção");
            }

            UsuarioTO usuarioTO = new UsuarioTO();

            usuarioTO.Login = txtLoginUsuario.Text;
            usuarioTO.Senha = txtSenhaUsuario.Text;
            //usuarioTO.IdGrupo = cboGrupoUsuario.SelectedItem;
            usuarioTO.IdColaborador = Convert.ToInt32(txtColabUsuario.Text);

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

            if (string.IsNullOrEmpty(txtLoginUsuario.Text))
            {
                msgErro += "Preenchimento do Login obrigatorio\n";
            }

            if (string.IsNullOrEmpty(txtSenhaUsuario.Text))
            {
                msgErro += "Preenchimento da Senha obrigatório\n";
            }

            if (string.IsNullOrEmpty(cboGrupoUsuario.Text))
            {
                msgErro += "Preenchimento do Grupo obrigatório\n";
            }

            if (string.IsNullOrEmpty(txtColabUsuario.Text))
            {
                msgErro += "Preenchimento do Colaborador obrigatório\n";
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

        private void btnCancelarCadastramento_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                
        private void frmUsuarioCadastrar_Load(object sender, EventArgs e)
        {
            cboGrupoUsuario.Items.Add("1 - Administrador");
            cboGrupoUsuario.Items.Add("2 - Sindicos");
            cboGrupoUsuario.Items.Add("3 - Porteiro");
        }
    }
 }

