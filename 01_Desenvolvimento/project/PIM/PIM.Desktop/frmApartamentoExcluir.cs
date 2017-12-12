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
    public partial class frmApartamentoExcluir : Form
    {
        public frmApartamentoExcluir(int idApartamento)
        {
            InitializeComponent();
            PreencherCampos(idApartamento);
        }

        private void PreencherCampos(int id)
        {
             ApartamentoTO apartamentoTO = new ApartamentoTO();
            apartamentoTO = ApartamentoService.Obter(id);

            if (!apartamentoTO.Valido)
            {
                MessageBox.Show(apartamentoTO.Mensagem, "Atenção");
                this.Close();
            }

            txtExcluirBlocoApto.Text = Convert.ToString(apartamentoTO.Bloco);
            txtExcluirNumeroApto.Text = apartamentoTO.Numero;
            txtExcluirCodContrato.Text = apartamentoTO.Numero;
            
            lblExcluirCodigoApto.Text = apartamentoTO.Identificador.ToString();
        }

        private void BloquearCampos()
        {
            txtExcluirBlocoApto.ReadOnly = true;
            txtExcluirNumeroApto.ReadOnly = true;
            txtExcluirCodContrato.ReadOnly = true;
        }

        private void frmApartamentoExcluir_Load(object sender, EventArgs e)
        {
            BloquearCampos();
        }

        private void btnConfirmarExclusaoApartamento_Click(object sender, EventArgs e)
        {
            int idApartamento = Convert.ToInt32(lblExcluirCodigoApto.Text);

            RetornoTO retorno = new RetornoTO();

            retorno = ApartamentoService.Remover(idApartamento);


            //Todo: Retornar mensagem se nao for valido
            if (!retorno.Valido)
            {
                MessageBox.Show(retorno.Mensagem, "Atenção");
            }

            this.Close();
        }

        private void btnCancelarExclusaoApartamento_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
