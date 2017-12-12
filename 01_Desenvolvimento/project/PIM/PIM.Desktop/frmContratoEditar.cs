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
    public partial class frmContratoEditar : Form
    {
        public frmContratoEditar(int id)
        {
            InitializeComponent();
            PreencherCampos(id);
        }
        private void PreencherCampos(int id)
        {
           ContratoTO contratoTO = new ContratoTO();

            contratoTO = ContratoService.Obter(id);

            if (!contratoTO.Valido)
            {
                //Todo: Exibir Mensagem e Fechar Form
                MessageBox.Show(contratoTO.Mensagem, "Atenção");
            }

            txtCodMorador.Text = Convert.ToString(contratoTO.IdMorador);
            txtEditarDataContrato.Text = Convert.ToString(contratoTO.DataContrato);
            txtEditarParcelasContrato.Text = Convert.ToString(contratoTO.Parcelas);
            txtEditarValorContrato.Text = Convert.ToString(contratoTO.Valor);
            
            lblEditarCodContrato.Text = contratoTO.Identificador.ToString();
        }

        private void btnSalvarEdicaoContrato_Click(object sender, EventArgs e)
        {
            ContratoTO contratoTO = new ContratoTO();

            contratoTO.IdMorador = Convert.ToInt32(txtCodMorador.Text);
            contratoTO.Identificador = Convert.ToInt32(lblEditarCodContrato.Text);
            contratoTO.DataContrato = Convert.ToDateTime(txtEditarDataContrato.Text);
            contratoTO.Parcelas = Convert.ToInt32(txtEditarParcelasContrato.Text);
            contratoTO.Valor = Convert.ToDecimal(txtEditarValorContrato.Text);
            

            ContratoService.Atualizar(contratoTO);

            if (!contratoTO.Valido)
                MessageBox.Show(contratoTO.Mensagem);

            this.Close();
        }

        private void btnCancelarEdicaoContrato_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
