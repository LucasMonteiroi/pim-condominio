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
    public partial class frmTipoDeReservaEditar : Form
    {
        public frmTipoDeReservaEditar(int id)
        {
            InitializeComponent();
            PreencherCampos(id);
        }

        private void btnCancelarEdicaoTipoReserva_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarEdicaoTipoReserva_Click(object sender, EventArgs e)
        {
            TipoReservaTO tipoReservaTO = new TipoReservaTO();

            tipoReservaTO.Identificador = Convert.ToInt32(txtEditarCodTipoReserva.Text);
            tipoReservaTO.Tipo = txtEditarTipoReserva.Text;

            TipoReservaService.Atualizar(tipoReservaTO);

            if (!tipoReservaTO.Valido)
                MessageBox.Show(tipoReservaTO.Mensagem);

            this.Close();
        }

        private void PreencherCampos(int id)
        {
            TipoReservaTO tipoReservaTO = new TipoReservaTO();

            tipoReservaTO = TipoReservaService.Obter(id);

            if (!tipoReservaTO.Valido)
            {
                //Todo: Exibir Mensagem e Fechar Form
                MessageBox.Show(tipoReservaTO.Mensagem);
            }

            txtEditarCodTipoReserva.Text = Convert.ToString(tipoReservaTO.Identificador);
            txtEditarTipoReserva.Text = tipoReservaTO.Tipo;
        }
    }
}
