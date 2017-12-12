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
    public partial class frmOcorrenciaExcluir : Form
    {
        public frmOcorrenciaExcluir(int idOcorrencia)
        {
            InitializeComponent();
            PreencherCampos(idOcorrencia);
        }

        private void btnCancelarExcluirOcorrencia_Click(object sender, EventArgs e)
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
                MessageBox.Show(ocorrenciaTO.Mensagem, "Atenção");
                this.Close();
            }

            txtExcluirCodMorOcorrencia.Text = Convert.ToString(ocorrenciaTO.IdMorador);
            txtExcluirMotivoOcorrencia.Text = ocorrenciaTO.Motivo;
            rtxtExcluirDescricaoOcorrencia.Text = ocorrenciaTO.Descricao;

            lblExcluirCodOcorrencia.Text = ocorrenciaTO.Identificador.ToString();
        }

        private void BloquearCampos()
        {
            txtExcluirMotivoOcorrencia.ReadOnly = true;
            txtExcluirCodMorOcorrencia.ReadOnly = true;
            rtxtExcluirDescricaoOcorrencia.ReadOnly = true;
        }

        private void frmOcorrenciaExcluir_Load(object sender, EventArgs e)
        {
            BloquearCampos();
        }

        private void btnExcluirOcorrencia_Click(object sender, EventArgs e)
        {
            int idOcorrencia = Convert.ToInt32(lblExcluirCodOcorrencia.Text);

            RetornoTO retorno = new RetornoTO();

            retorno = OcorrenciaService.Remover(idOcorrencia);

            if(!retorno.Valido)
            {
                //Todo: Retornar mensagem se nao for valido
                MessageBox.Show(retorno.Mensagem, "Atenção");
            }
                        
            this.Close();
        }
    }
}
