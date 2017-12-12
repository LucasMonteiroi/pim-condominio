using PIM.Database.Infra;
using PIM.Database.TO;
using PIM.Service.Services;
using System;
using System.Windows.Forms;

namespace PIM.Desktop
{
    public partial class frmMoradorExcluir : Form
    {
        public frmMoradorExcluir(int idMorador)
        {
            InitializeComponent();
            PreencherCampos(idMorador);
        }

        private void PreencherCampos(int id)
        {
            MoradorTO moradorTO = new MoradorTO();
            moradorTO = MoradorService.Obter(id);

            if (!moradorTO.Valido)
            {
                MessageBox.Show(moradorTO.Mensagem, "Atenção");
            }

            txtExcluirNomeMor.Text = moradorTO.Nome;
            txtExcluirCelularMor.Text = moradorTO.Celular;
            txtExcluirCpfMor.Text = moradorTO.CPF;
            txtExcluirEmailMor.Text = moradorTO.Email;
            txtExcluirRgMor.Text = moradorTO.RG;
            txtExcluirTelefoneMor.Text = moradorTO.Telefone;

            lblCodigoMorador.Text = moradorTO.Identificador.ToString();
        }

        private void frmMoradorExcluir_Load(object sender, EventArgs e)
        {
            BloquearCampos();
        }

        private void BloquearCampos()
        {
            txtExcluirNomeMor.ReadOnly = true;
            txtExcluirNomeMor.ReadOnly = true;
            txtExcluirCelularMor.ReadOnly = true;
            txtExcluirCpfMor.ReadOnly = true;
            txtExcluirEmailMor.ReadOnly = true;
            txtExcluirRgMor.ReadOnly = true;
            txtExcluirTelefoneMor.ReadOnly = true;
        }

        private void btnExcluirMorador_Click(object sender, EventArgs e)
        {
            int idMorador = Convert.ToInt32(lblCodigoMorador.Text);

            RetornoTO retorno = new RetornoTO();

            retorno = MoradorService.Remover(idMorador);

            //Todo: Retornar mensagem se nao for valido
            if (!retorno.Valido)
            {
                MessageBox.Show(retorno.Mensagem, "Atenção");
            }

            this.Close();
        }

        private void btnCancelarExclusaoMor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
