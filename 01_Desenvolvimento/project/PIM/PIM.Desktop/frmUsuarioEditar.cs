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
    public partial class frmUsuarioEditar : Form
    {
        public frmUsuarioEditar(int id)
        {
            InitializeComponent();
            PreencherCampos(id);
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

                txtLoginUsuario.Text = usuarioTO.Login;
                txtEditarSenhaUsuario.Text = usuarioTO.Senha;
                txtGrupoUsuario.Text = Convert.ToString(usuarioTO.IdGrupo);
                txtEditarColabUsuario.Text = Convert.ToString(usuarioTO.IdColaborador);

                lblIdentificarUsuario.Text = usuarioTO.Identificador.ToString();
            }

            private void btnSalvarUsuario_Click(object sender, EventArgs e)
            {
                UsuarioTO usuarioTO = new UsuarioTO();

                usuarioTO.IdColaborador = Convert.ToInt32(txtEditarColabUsuario.Text);
                usuarioTO.Login = txtLoginUsuario.Text;
                usuarioTO.Senha = txtEditarSenhaUsuario.Text;
                usuarioTO.IdGrupo = Convert.ToInt32(txtGrupoUsuario.Text);
                usuarioTO.Identificador = Convert.ToInt32(lblIdentificarUsuario.Text);


                UsuarioService.Atualizar(usuarioTO);

                if (!usuarioTO.Valido)
                    MessageBox.Show(usuarioTO.Mensagem);

                this.Close();

            }
    }
}
