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
    public partial class frmOcorrenciaVisualizar : Form
    {
        public frmOcorrenciaVisualizar(int idOcorrencia)
        {
            InitializeComponent();
            PreencherCampos(idOcorrencia);
        }

        private void btnFecharVisualizacaoOcorrencia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BloquearCampos()
        {
            txtVisualizarMotivoOcorrencia.ReadOnly = true;
            txtVisualizarCodMorOcorrencia.ReadOnly = true;
            rtxtVisualizarDescricaoOcorrencia.ReadOnly = true;
        }

        private void frmOcorrenciaVisualizar_Load(object sender, EventArgs e)
        {
            BloquearCampos();
        }

        private void PreencherCampos(int id)
        {
            OcorrenciaTO ocorrenciaTO = new OcorrenciaTO();

            ocorrenciaTO = OcorrenciaService.Obter(id);

            if (!ocorrenciaTO.Valido)
            {
                //Todo: Exibir Mensagem e Fechar Form
                MessageBox.Show(ocorrenciaTO.Mensagem, "Atenção");
                this.Close();
            }

            txtVisualizarCodMorOcorrencia.Text = Convert.ToString(ocorrenciaTO.IdMorador);
            txtVisualizarMotivoOcorrencia.Text = ocorrenciaTO.Motivo;
            rtxtVisualizarDescricaoOcorrencia.Text = ocorrenciaTO.Descricao;

            lblVisualizarCodOcorrencia.Text = ocorrenciaTO.Identificador.ToString();
        }
    }
}
