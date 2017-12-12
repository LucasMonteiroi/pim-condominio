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
    public partial class frmDependenteExcluir : Form
    {
        public frmDependenteExcluir(int idDependente)
        {
            InitializeComponent();
            PreencherCampos(idDependente);
        }

        private void PreencherCampos(int id)
        {
            DependenteTO dependenteTO = new DependenteTO();

            dependenteTO = DependenteService.Obter(id);

            if (!dependenteTO.Valido)
            {
                //Todo: Exibir Mensagem e Fechar Form
                MessageBox.Show(dependenteTO.Mensagem);
                this.Close();
            }

            txtExcluirNomeDep.Text = dependenteTO.Nome;
            txtExcluirRgDep.Text = dependenteTO.RG;
            txtExcluirTelefoneDep.Text = dependenteTO.Telefone;
            txtExcluirGrauParent.Text = dependenteTO.GrauParentesco;
            txtExcluirMoradorResp.Text = Convert.ToString(dependenteTO.IdMorador);
            lblExcluirCodigoDep.Text = dependenteTO.Identificador.ToString();
        }

        private void BloquearCampos()
        {
            txtExcluirNomeDep.ReadOnly = true;
            txtExcluirRgDep.ReadOnly = true;
            txtExcluirTelefoneDep.ReadOnly = true;
            txtExcluirMoradorResp.ReadOnly = true;
            txtExcluirGrauParent.ReadOnly = true;                
        }

        private void btnExcluirDependente_Click(object sender, EventArgs e)
        {
            int idDependente = Convert.ToInt32(lblExcluirCodigoDep.Text);

            RetornoTO retorno = new RetornoTO();

            retorno = DependenteService.Remover(idDependente);

            //Todo: Retornar mensagem se nao for valido
            if (!retorno.Valido)
                MessageBox.Show(retorno.Mensagem);

            this.Close();
        }

        private void btnCancelarDep_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
