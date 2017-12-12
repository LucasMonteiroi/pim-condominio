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
    public partial class frmReservaExcluir : Form
    {
        public frmReservaExcluir(int idReserva)
        {
            InitializeComponent();
            PreencherCampos(idReserva);
        }

        private void btnCancelarExclusaoReserva_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreencherCampos(int id)
        {
            ReservaTO reservaTO = new ReservaTO();

            reservaTO = ReservaService.Obter(id);

            if (!reservaTO.Valido)
            {
                MessageBox.Show(reservaTO.Mensagem, "Atenção");
            }

            txtExcluirCodMorReserva.Text = Convert.ToString(reservaTO.IdMorador);
            cboExcluirTipoReserva.Text = Convert.ToString(reservaTO.IdTipoReserva);
            dtExcluirDataReserva.Text = Convert.ToString(reservaTO.DataReserva);

            lblExcluirCodReserva.Text = reservaTO.Identificador.ToString();
        }

        private void BloquearCampos()
        {
            txtExcluirCodMorReserva.ReadOnly = true;
            //cboExcluirTipoReserva.ReadOnly = true;
            //dtExcluirDataReserva.ReadOnly = true;            
        }

        private void frmReservaExcluir_Load(object sender, EventArgs e)
        {
            BloquearCampos();
        }

        private void btnConfirmaExclusaoReserva_Click(object sender, EventArgs e)
        {
            int idReserva = Convert.ToInt32(lblExcluirCodReserva.Text);

            RetornoTO retorno = new RetornoTO();

            retorno = ReservaService.Remover(idReserva);

            //Todo: Retornar mensagem se nao for valido
            if (!retorno.Valido)
            {
                MessageBox.Show(retorno.Mensagem, "Atenção");
            }

            this.Close();
        }
    }
}
