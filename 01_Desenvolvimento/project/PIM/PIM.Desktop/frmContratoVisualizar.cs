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
    public partial class frmContratoVisualizar : Form
    {
        public frmContratoVisualizar(int idContrato)
        {
            InitializeComponent();
            PreencherCampos(idContrato);
        }

        private void btnFecharVisualizacao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BloquearCampos()
        {
            txtVisualizarCodMorador.ReadOnly = true;
            txtVisualizarrDataContrato.ReadOnly = true;
            txtVisualizarParcelasContrato.ReadOnly = true;
            txtVisualizarValorContrato.ReadOnly = true;
            rtxtVisualizarDescricaoContrato.ReadOnly = true;

        }

        private void frmContratoVisualizar_Load(object sender, EventArgs e)
        {
            BloquearCampos();
        }

        private void PreencherCampos(int id)
        {
            ContratoTO contratoTO = new ContratoTO();

            contratoTO = ContratoService.Obter(id);

            if (!contratoTO.Valido)
            {
                //Todo: Exibir Mensagem e Fechar Form
                MessageBox.Show(contratoTO.Mensagem);
                this.Close();
            }

            txtVisualizarCodMorador.Text = Convert.ToString(contratoTO.IdMorador);
            txtVisualizarParcelasContrato.Text = Convert.ToString(contratoTO.Parcelas);
            txtVisualizarrDataContrato.Text = Convert.ToString(contratoTO.DataContrato);
            txtVisualizarValorContrato.Text = Convert.ToString(contratoTO.Valor);
            rtxtVisualizarDescricaoContrato.Text = contratoTO.Descricao;

            lblVisualizarCodContrato.Text = contratoTO.Identificador.ToString();
        }
    }
}
