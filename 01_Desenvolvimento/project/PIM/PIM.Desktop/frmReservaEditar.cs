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
    public partial class frmReservaEditar : Form
    {
        public frmReservaEditar(int id)
        {
            InitializeComponent();
            PreencherCampos(id);
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
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

            txtEditarCodMorReserva.Text = Convert.ToString(reservaTO.IdMorador);
            cboEditarTipoReserva.Text = Convert.ToString(reservaTO.IdTipoReserva);
            dtEditarDataReserva.Text = Convert.ToString(reservaTO.DataReserva);
            
            lblEditarCodReserva.Text = reservaTO.Identificador.ToString();                       
        }

        private void btnSalvarReserva_Click(object sender, EventArgs e)
        {
            ReservaTO reservaTO = new ReservaTO();

            reservaTO.IdMorador = Convert.ToInt32(txtEditarCodMorReserva.Text);
            reservaTO.Identificador = Convert.ToInt32(lblEditarCodReserva.Text);
            reservaTO.IdTipoReserva = Convert.ToInt32(cboEditarTipoReserva.Text);
            reservaTO.DataReserva = Convert.ToDateTime(dtEditarDataReserva.Text);
            
            ReservaService.Atualizar(reservaTO);

            if (!reservaTO.Valido)
                MessageBox.Show(reservaTO.Mensagem);

            this.Close();
        }

        private void frmReservaEditar_Load(object sender, EventArgs e)
        {
            cboEditarTipoReserva.Items.Add("Churrasqueira");
            cboEditarTipoReserva.Items.Add("Salão de Festas");
        }
    }
}
