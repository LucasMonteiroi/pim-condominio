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
    public partial class frmVisitanteEditar : Form
    {
        public frmVisitanteEditar(int id)
        {
            InitializeComponent();
            PreencherCampos(id);
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

            txtEditarNomeVisit.Text = visitanteTO.Nome;
            
            txtEditarAutorizacaoVisitante.Text = visitanteTO.Mensagem;

            lblEditarCodMorVisit.Text = visitanteTO.Identificador.ToString();
        }

        private void btnSalvarEdicaoVisit_Click(object sender, EventArgs e)
        {
            VisitanteTO visitanteTO = new VisitanteTO();

            visitanteTO.Identificador = Convert.ToInt32(lblEditarCodMorVisit.Text);
            visitanteTO.Nome = txtEditarNomeVisit.Text;
            visitanteTO.IdMorador = Convert.ToInt32(txtEditarCodMorVisit.Text);
            visitanteTO.Mensagem = txtEditarAutorizacaoVisitante.Text;
            VisitanteService.Atualizar(visitanteTO);

            if (!visitanteTO.Valido)
                MessageBox.Show(visitanteTO.Mensagem);

            this.Close();
        }
    }
}
