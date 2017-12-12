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
    public partial class frmTipoDeReservaCadastrar : Form
    {
        public frmTipoDeReservaCadastrar()
        {
            InitializeComponent();
        }

        private void btnSalvarTipoReserva_Click(object sender, EventArgs e)
        {
            string erro = String.Empty;

            if (!ValidarCampos(out erro))
            {
                MessageBox.Show(erro, "Atenção");
            }

            TipoReservaTO tipoReservaTO = new TipoReservaTO();

            tipoReservaTO.Identificador = Convert.ToInt32(txtCodTipoReserva.Text);
            tipoReservaTO.Tipo = txtTipoReserva.Text;

            TipoReservaService.Criar(tipoReservaTO);

            if (!tipoReservaTO.Valido)
            {
                MessageBox.Show(tipoReservaTO.Mensagem, "Atenção");
                return;
            }

            this.Close();
        }

        private bool ValidarCampos(out string erro)
        {
            string msgErro = string.Empty;
            erro = string.Empty;

            if (string.IsNullOrEmpty(txtCodTipoReserva.Text))
            {
                msgErro += "Preenchimento do código obrigatório\n";
            }

            if (string.IsNullOrEmpty(txtTipoReserva.Text))
            {
                msgErro += "Preenchimento do Tipo de Reserva é obrigatório\n";
            }


            if (!string.IsNullOrEmpty(msgErro))
            {
                erro = msgErro;
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnCancelarTipoReserva_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
