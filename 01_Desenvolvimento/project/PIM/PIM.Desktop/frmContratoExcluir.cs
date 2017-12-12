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
    public partial class frmContratoExcluir : Form
    {
        public frmContratoExcluir(int idContrato)
        {
            InitializeComponent();
            PreencherCampos(idContrato);
        }

        private void PreencherCampos(int id)
        {
            ContratoTO contratoTO = new ContratoTO();

            contratoTO = ContratoService.Obter(id);

            if (!contratoTO.Valido)
            {
                //Todo: Exibir Mensagem e Fechar Form
                MessageBox.Show(contratoTO.Mensagem, "Atenção");
                this.Close();
            }

            txtExcluirCodMorador.Text = Convert.ToString(contratoTO.IdMorador);
            txtExcluirDataContrato.Text = Convert.ToString(contratoTO.DataContrato);
            txtExcluirParcelasContrato.Text = Convert.ToString(contratoTO.Parcelas);
            txtExcluirValorContrato.Text = Convert.ToString(contratoTO.Valor);
            rtxtExcluirDescricaoContrato.Text = Convert.ToString(contratoTO.DataContrato);

            lblExcluirCodContrato.Text = contratoTO.Identificador.ToString();
        }

        private void BloquearCampos()
        {
            txtExcluirCodMorador.ReadOnly = true;
            txtExcluirDataContrato.ReadOnly = true;
            txtExcluirParcelasContrato.ReadOnly = true;
            txtExcluirValorContrato.ReadOnly = true;
            rtxtExcluirDescricaoContrato.ReadOnly = true;
            
        }

        private void frmContratoExcluir_Load(object sender, EventArgs e)
        {
            BloquearCampos();
        }

        private void btnConfirmarExcluirContrato_Click(object sender, EventArgs e)
        {
            int idContrato = Convert.ToInt32(lblExcluirCodContrato.Text);

            RetornoTO retorno = new RetornoTO();

            retorno = ContratoService.Remover(idContrato);

            //Todo: Retornar mensagem se nao for valido
            if (!retorno.Valido)
                MessageBox.Show(retorno.Mensagem);

            this.Close();
        }
    }
}
