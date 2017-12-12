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
    public partial class frmDependenteCadastrar : Form
    {
        public frmDependenteCadastrar()
        {
            InitializeComponent();
        }

        private void btnCancelarDep_Click(object sender, EventArgs e)
        {
            txtCodigoDep.Clear();
            txtNomeDep.Clear();
            txtRgDep.Clear();
            txtTelefoneDep.Clear();
            txtMoradorResp.Clear();
        }

        private void btnCancelarCadDep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarCampos(out string erro)
        {
            string msgErro = string.Empty;
            erro = string.Empty;

            if (string.IsNullOrEmpty(txtNomeDep.Text))
            {
                msgErro += "Preenchimento do Nome obrigatório\n";
            }

            if (string.IsNullOrEmpty(txtRgDep.Text))
            {
                msgErro += "Preenchimento do RG obrigatório\n";
            }

            if (string.IsNullOrEmpty(txtTelefoneDep.Text))
            {
                msgErro += "Preenchimento do Telefone obrigatório\n";
            }

            if (string.IsNullOrEmpty(txtMoradorResp.Text))
            {
                msgErro += "Preenchimento do Nome do Titular obrigatório\n";
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

        private void btnSalvarDep_Click(object sender, EventArgs e)
        {
            string erro = String.Empty;

            if (!ValidarCampos(out erro))
            {
                MessageBox.Show(erro, "Atenção");
            }

            DependenteTO dependenteTO = new DependenteTO();

            dependenteTO.Nome = txtNomeDep.Text;
            dependenteTO.RG = txtRgDep.Text;
            dependenteTO.Telefone = txtTelefoneDep.Text;
            dependenteTO.IdMorador = Convert.ToInt32(txtMoradorResp);
            dependenteTO.GrauParentesco = Convert.ToString(cboGrauParentesco.Text);

            DependenteService.Criar(dependenteTO);

            if (!dependenteTO.Valido)
            {
                MessageBox.Show(dependenteTO.Mensagem, "Atenção");
                return;
            }

            this.Close();
        }

        private void frmDependenteCadastrar_Load(object sender, EventArgs e)
        {
            cboGrauParentesco.Items.Add("Filho(a)");
            cboGrauParentesco.Items.Add("Mãe");
            cboGrauParentesco.Items.Add("Pai");
            cboGrauParentesco.Items.Add("Conjugê");
            cboGrauParentesco.Items.Add("Tio(a)");
        }
    }
}
