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
    public partial class frmMoradorEditar : Form
    {
        public frmMoradorEditar(int id)
        {
            InitializeComponent();
            PreencherCampos(id);
        }

        private void PreencherCampos(int id)
        {
            MoradorTO moradorTO = new MoradorTO();

            moradorTO = MoradorService.Obter(id);

            if (!moradorTO.Valido)
            {
                MessageBox.Show(moradorTO.Mensagem, "Atenção");
                this.Close();
            }

            txtEditarNomeMor.Text = moradorTO.Nome;
            txtEditarCelularMor.Text = moradorTO.Celular;
            txtEditarCpfMor.Text = moradorTO.CPF;
            txtEditarEditarEmailMor.Text = moradorTO.Email;
            txtEditarRgMor.Text = moradorTO.RG;
            txtEditarTelefoneMor.Text = moradorTO.Telefone;
            
            lblCodigoMorador.Text = moradorTO.Identificador.ToString();
        }

        private void btnSalvarEdicaoMor_Click(object sender, EventArgs e)
        {
            MoradorTO moradorTO = new MoradorTO();

            moradorTO.Nome = txtEditarNomeMor.Text;
            moradorTO.Identificador = Convert.ToInt32(lblCodigoMorador.Text);
            moradorTO.RG = txtEditarRgMor.Text;
            moradorTO.CPF = txtEditarCpfMor.Text;
            moradorTO.Email = txtEditarEditarEmailMor.Text;
            moradorTO.Celular = txtEditarCelularMor.Text;
            moradorTO.Telefone = txtEditarTelefoneMor.Text;

            MoradorService.Atualizar(moradorTO);

            if (!moradorTO.Valido)
                MessageBox.Show(moradorTO.Mensagem);

            this.Close();
        }
    }
}
