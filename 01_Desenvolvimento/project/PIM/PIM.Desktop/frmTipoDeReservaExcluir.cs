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
    public partial class frmTipoDeReservaExcluir : Form
    {
        public frmTipoDeReservaExcluir(int idtTipoReserva)
        {
            InitializeComponent();
            PreencherCampos(idtTipoReserva);
        }

        private void PreencherCampos(int id)
        {
            TipoReservaTO tipoReservaTO = new TipoReservaTO(); 
            tipoReservaTO = TipoReservaService.Obter(id);

            if (!tipoReservaTO.Valido)
            {
                //Todo: Exibir Mensagem e Fechar Form
                MessageBox.Show(tipoReservaTO.Mensagem, "Atenção");
            }

            txtExcluirCodTipoReserva.Text = Convert.ToString(tipoReservaTO.Identificador);
            txtExcluirTipoReserva.Text = tipoReservaTO.Tipo;

        }

        private void BloquearCampos()
        {
            txtExcluirCodTipoReserva.ReadOnly = true;
            txtExcluirTipoReserva.ReadOnly = true;
        }

        private void btnConfirmarExclusaoTipoReserva_Click(object sender, EventArgs e)
        {
            int idTipoReserva = Convert.ToInt32(lblExcluirCodTipoReserva.Text);

            RetornoTO retorno = new TipoReservaTO();

            retorno = TipoReservaService.Remover(idTipoReserva);

            //Todo: Retornar mensagem se nao for valido
            if (!retorno.Valido)
            {
                MessageBox.Show(retorno.Mensagem, "Atenção");
            }


            this.Close();
        }

        private void frmTipoDeReservaExcluir_Load(object sender, EventArgs e)
        {
            BloquearCampos();
        }

        private void btnCancelarExclusaoTipoReserva_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
