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
    public partial class frmVisitanteVisualizar : Form
    {
        public frmVisitanteVisualizar(int idVisitante)
        {
            InitializeComponent();
            PreencherCampos(idVisitante);
        }

        private void BloquearCampos()
        {
            txtVisualizaCodVisitante.ReadOnly = true;
            txtVisualizaNomeVisit.ReadOnly = true;
            txtVisualizaAutorizacaoVisitante.ReadOnly = true;
        }

        private void btnFecharVisualizacaoVisit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVisitanteVisualizar_Load(object sender, EventArgs e)
        {
            BloquearCampos();
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

            txtVisualizaNomeVisit.Text = visitanteTO.Nome;
            txtVisualizaAutorizacaoVisitante.Text = visitanteTO.Mensagem;

            lblVisualizaCodVisit.Text = visitanteTO.Identificador.ToString();
        }
    }
}
