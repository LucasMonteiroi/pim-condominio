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
    public partial class frmColaboradorEditar : Form
    {
        public frmColaboradorEditar(int id)
        {
            InitializeComponent();
            PreencherCampos(id);
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

            txtEditarNomeColab.Text = colaboradorTO.Nome;
            txtEditarColabRG.Text = colaboradorTO.RG;
            txtEditarCpfColab.Text = colaboradorTO.CPF;
            txtEditarSalarioColab.Text = Convert.ToString(colaboradorTO.Salario);
            txtEditarColabFuncao.Text = colaboradorTO.Funcao;
            dtDataContrato.Value = Convert.ToDateTime(colaboradorTO.DataContrato);

            lblEditarCodColab.Text = colaboradorTO.Identificador.ToString();                        
        }
        
        private void btnEditarColaborador_Click(object sender, EventArgs e)
        {
            ColaboradorTO colaboradorTO = new ColaboradorTO();
            
            colaboradorTO.Nome = txtEditarNomeColab.Text;
            colaboradorTO.RG = txtEditarColabRG.Text;
            colaboradorTO.CPF = txtEditarCpfColab.Text;
            colaboradorTO.Salario = Convert.ToInt32(txtEditarSalarioColab.Text);
            colaboradorTO.Funcao = txtEditarColabFuncao.Text;
            colaboradorTO.DataContrato = dtDataContrato.Value.Date;

            ColaboradorService.Atualizar(colaboradorTO);

            if (!colaboradorTO.Valido)
                MessageBox.Show(colaboradorTO.Mensagem);

            this.Close();
        }
    }
}
