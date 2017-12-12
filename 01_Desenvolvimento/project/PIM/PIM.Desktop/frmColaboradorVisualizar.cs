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
    public partial class frmColaboradorVisualizar : Form
    {
        public frmColaboradorVisualizar(int idColaborador)
        {
            InitializeComponent();
            PreencherCampos(idColaborador);
        }

        private void btnFecharColaborador_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BloquearCampos()
        {
            txtVisualizarNomeColab.ReadOnly = true;
            txtVisualizarColabRG.ReadOnly = true;
            txtVisualizarCpfColab.ReadOnly = true;
            txtVisualizarSalarioColab.ReadOnly = true;
            txtVisualizarColabFuncao.ReadOnly = true;
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

            txtVisualizarNomeColab.Text = colaboradorTO.Nome;
            txtVisualizarColabRG.Text = colaboradorTO.RG;
            txtVisualizarCpfColab.Text = colaboradorTO.CPF;
            txtVisualizarSalarioColab.Text = Convert.ToString(colaboradorTO.Salario);
            txtVisualizarColabFuncao.Text = colaboradorTO.Funcao;
            dtVisualizarDataContrato .Value = Convert.ToDateTime(colaboradorTO.DataContrato);

            lblVisualizarCodColab.Text = colaboradorTO.Identificador.ToString();
        }

        private void frmColaboradorVisualizar_Load(object sender, EventArgs e)
        {
            BloquearCampos();
        }
    }
}
