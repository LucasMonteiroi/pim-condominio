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
    public partial class frmOcorrenciaEditar : Form
    {
        public frmOcorrenciaEditar(int id)
        {
            InitializeComponent();
            PreencherCampos(id);
        }

        private void btnCancelarEdicaoOcorrencia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreencherCampos(int id)
        {
            OcorrenciaTO ocorrenciaTO = new OcorrenciaTO();

            ocorrenciaTO = OcorrenciaService.Obter(id);

            if (!ocorrenciaTO.Valido)
            {
                //Todo: Exibir Mensagem e Fechar Form
                MessageBox.Show(ocorrenciaTO.Mensagem);

                this.Close();
            }

            txtEditarCodMorOcorrencia.Text = Convert.ToString(ocorrenciaTO.IdMorador);
            txtEditarMotivoOcorrencia.Text = ocorrenciaTO.Motivo;
            rtxtEditarDescricaoOcorrencia.Text = ocorrenciaTO.Descricao;
            
            lblEditarCodOcorrencia.Text = ocorrenciaTO.Identificador.ToString();
        }

        private void btnSalvarEdicaoOcorrencia_Click(object sender, EventArgs e)
        {
            OcorrenciaTO ocorrenciaTO = new OcorrenciaTO();

            ocorrenciaTO.Motivo = txtEditarMotivoOcorrencia.Text;
            ocorrenciaTO.Identificador = Convert.ToInt32(lblEditarCodOcorrencia.Text);
            ocorrenciaTO.Descricao = rtxtEditarDescricaoOcorrencia.Text;
            
            OcorrenciaService.Atualizar(ocorrenciaTO);

            if (!ocorrenciaTO.Valido)
                MessageBox.Show(ocorrenciaTO.Mensagem);

            this.Close();
        }
    }
}
