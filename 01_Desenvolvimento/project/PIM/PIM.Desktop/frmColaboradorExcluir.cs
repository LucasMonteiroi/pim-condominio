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
    public partial class frmColaboradorExcluir : Form
    {
        public frmColaboradorExcluir(int idColaborador)
        {
            InitializeComponent();
            PreencherCampos(idColaborador);
        }

        private void PreencherCampos(int id)
        {
            ColaboradorTO colaboradorTO = new ColaboradorTO();

            colaboradorTO = ColaboradorService.Obter(id);

            if (!colaboradorTO.Valido)
            {
                MessageBox.Show(colaboradorTO.Mensagem);
                this.Close();
            }

            txtExcluirNomeColab.Text = colaboradorTO.Nome;
            txtExcluirColabRG.Text = colaboradorTO.RG;
            txtExcluirCpfColab.Text = colaboradorTO.CPF;
            txtExcluirSalarioColab.Text = Convert.ToString(colaboradorTO.Salario);
            txtExcluirColabFuncao.Text = colaboradorTO.Funcao;
            dtExcluirDataContrato.Value = Convert.ToDateTime(colaboradorTO.DataContrato);

            lblExcluirCodColab.Text = colaboradorTO.Identificador.ToString();
        }

        private void BloquearCampos()
        {
            txtExcluirNomeColab.ReadOnly = true;
            txtExcluirColabRG.ReadOnly = true;
            txtExcluirCpfColab.ReadOnly = true;
            txtExcluirSalarioColab.ReadOnly = true;
            txtExcluirColabFuncao.ReadOnly = true;
        }

        private void frmColaboradorExcluir_Load(object sender, EventArgs e)
        {
            BloquearCampos();
        }

        private void btnExcluirColaborador_Click(object sender, EventArgs e)
        {
            int idColaborador = Convert.ToInt32(lblExcluirCodColab.Text);

            RetornoTO retorno = new RetornoTO();

            retorno = ColaboradorService.Remover(idColaborador);

            //Todo: Retornar mensagem se nao for valido
            if (!retorno.Valido)
            {
                MessageBox.Show(retorno.Mensagem, "Atenção");
            }

            this.Close();
        }

        private void btnCancelarExclusaoColab_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
