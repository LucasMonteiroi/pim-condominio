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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load_1(object sender, EventArgs e)
        {
            cboPerfil.Items.Add("Administrador");
            cboPerfil.Items.Add("Sindico");
            cboPerfil.Items.Add("Morador");
            cboPerfil.Items.Add("Porteiro");
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
                
                PIM.Database.TO.UsuarioTO to = new PIM.Database.TO.UsuarioTO();
                string perfil = string.Empty;
                switch (cboPerfil.SelectedItem)
                {
                    case ("Sindico"):
                        perfil = cboPerfil.SelectedItem.ToString();
                        // Prencher usuário
                        to.Login = txtUsuario.Text;
                        to.Senha = txtSenha.Text;
                        frmAdministrarCondominio administrarCondominio = new frmAdministrarCondominio();
                        administrarCondominio.Show();
                    break;
                    case ("Administrador"):
                        perfil = cboPerfil.SelectedItem.ToString();
                    // Prencher usuário
                        to.Login = txtUsuario.Text;
                        to.Senha = txtSenha.Text;
                        frmAdministrador administrador = new frmAdministrador();
                        administrador.Show();
                    break;
                    case ("Morador"):
                        perfil = cboPerfil.SelectedItem.ToString();
                    // Prencher cpf
                        to.Senha = txtCpfLogin.Text;
                    frmMorador morador = new frmMorador();
                    morador.Show();
                        break;
                    case ("Porteiro"):
                        perfil = cboPerfil.SelectedItem.ToString();
                    // Prencher usuário
                        to.Login = txtUsuario.Text;
                        to.Senha = txtSenha.Text;
                    frmPorteiro porteiro = new frmPorteiro();
                    porteiro.Show();
                    break;

                    UsuarioTO usuarioTO = new UsuarioTO();
                    usuarioTO.Login = txtUsuario.Text;
                    usuarioTO.Senha = txtSenha.Text;
                    usuarioTO.IdGrupo = Convert.ToInt32(label1);

                    UsuarioService.RealizarLogin(txtUsuario.Text, txtSenha.Text);

                    
                        if(!usuarioTO.Valido)
                        {
                            MessageBox.Show(usuarioTO.Mensagem);
                        }
                        else
                        {
                            
                        }
                               
                }

                MessageBox.Show(perfil);
            }

        private void cboPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ("Administrador".Equals(cboPerfil.SelectedItem))
            {
                txtUsuario.Enabled = true;
                txtCpfLogin.Enabled = false;
                txtSenha.Enabled = true;


            }
            else if ("Sindico".Equals(cboPerfil.SelectedItem))
            {
                txtUsuario.Enabled = true;
                txtCpfLogin.Enabled = false;
                txtSenha.Enabled = true;


            }
            else if ("Morador".Equals(cboPerfil.SelectedItem))
            {
                txtUsuario.Enabled = false;
                txtSenha.Enabled = false;
                txtCpfLogin.Enabled = true;
            }
            else
            {
                txtUsuario.Enabled = true;
                txtCpfLogin.Enabled = false;
                txtSenha.Enabled = true;
            }
        }
            private bool ValidarCampos(out string erro)
            {
                string msgErro = string.Empty;
                erro = string.Empty;

                if (string.IsNullOrEmpty(txtUsuario.Text))
                {
                    msgErro += "Preenchimento do Usuário obrigatório\n";
                }

                if (string.IsNullOrEmpty(txtSenha.Text))
                {
                    msgErro += "Preenchimento da Senha obrigatório\n";
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

        private void llblEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRedefinirSenha redefinirSenha = new frmRedefinirSenha();
            redefinirSenha.Show();

        }
    }
    
}


