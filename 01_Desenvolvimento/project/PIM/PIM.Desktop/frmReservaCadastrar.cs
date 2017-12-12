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
    public partial class frmReservaCadastrar : Form
    {
        public frmReservaCadastrar()
        {
            InitializeComponent();
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarReserva_Click(object sender, EventArgs e)
        {
            string erro = String.Empty;

            if (!ValidarCampos(out erro))
            {
                MessageBox.Show(erro, "Atenção");
            }

            ReservaTO reservaTO = new ReservaTO();

            reservaTO.IdMorador = Convert.ToInt32(txtCodMorReserva.Text);
            reservaTO.IdTipoReserva = Convert.ToInt32(cboTipoReserva.SelectedValue);
            reservaTO.DataReserva = dtDataReserva.Value.Date;
            
            ReservaService.Criar(reservaTO);

            if (!reservaTO.Valido)
            {
                MessageBox.Show(reservaTO.Mensagem, "Atenção");
                return;
            }

            this.Close();
        }

        private bool ValidarCampos(out string erro)
        {
            string msgErro = string.Empty;
            erro = string.Empty;

            if (string.IsNullOrEmpty(txtCodMorReserva.Text))
            {
                msgErro += "Preenchimento do Código do Morador obrigatório\n";
            }

            if (string.IsNullOrEmpty(cboTipoReserva.Text))
            {
                msgErro += "Preenchimento do Tipo de Reserva obrigatório\n";
            }

            if (string.IsNullOrEmpty(dtDataReserva.Text))
            {
                msgErro += "Preenchimento da Data obrigatório\n";
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

        
        private void frmReservaCadastrar_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
        }

        private void CarregarComboBox()
        {
            var listaTipoReserva = TipoReservaService.Listar();

            cboTipoReserva.DisplayMember = "Tipo";
            cboTipoReserva.ValueMember = "Identificador";
            cboTipoReserva.DataSource = listaTipoReserva.Lista;
        }
    }
}
