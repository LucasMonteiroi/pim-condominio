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
    public partial class frmVisitanteExcluir : Form
    {
        public frmVisitanteExcluir(int idVisitante)
        {
            InitializeComponent();
            PreencherCampos(idVisitante);
        }

        private void PreencherCampos(int id)
        {
            VisitanteTO visitanteTO = new VisitanteTO();

            visitanteTO = VisitanteService.Obter(id);

            if (!visitanteTO.Valido)
            {
                //Todo: Exibir Mensagem e Fechar Form
                MessageBox.Show(visitanteTO.Mensagem, "Atenção");
                this.Close();
            }

            txtExcluirNomeVisit.Text = visitanteTO.Nome;
            txtExcluirAutorizacaoVisitante.Text = visitanteTO.Mensagem;

            lblExcluirCodMorador.Text = visitanteTO.Identificador.ToString();
        }

        private void BloquearCampos()
        {
            txtExcluirCodVisitante.ReadOnly = true;
            txtExcluirNomeVisit.ReadOnly = true;
            txtExcluirAutorizacaoVisitante.ReadOnly = true;
        }

        private void frmVisitanteExcluir_Load(object sender, EventArgs e)
        {
            BloquearCampos();
        }

        private void btnExcluirVisitante_Click(object sender, EventArgs e)
        {
            int idVisitante = Convert.ToInt32(lblMorCodVisitante.Text);

             RetornoTO retorno = new RetornoTO();

            retorno = MoradorService.Remover(idVisitante);

            //Todo: Retornar mensagem se nao for valido
            if (!retorno.Valido)
            {
                MessageBox.Show(retorno.Mensagem, "Atenção");
            }

            this.Close();
        }

        private void btnCancelarExclusaoVisit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
