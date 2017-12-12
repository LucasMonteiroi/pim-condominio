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
    public partial class frmReservaVisualizar : Form
    {
        public frmReservaVisualizar(int idReserva)
        {
            InitializeComponent();
            PreencherCampos(idReserva);
        }

        private void btnFecharVisualizacaoReserva_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BloquearCampos()
        {
            txtVisualizarrCodMorReserva.ReadOnly = true;
            //cboVisualizarTipoReserva.ReadOnly = true;
            //dtVisualizarDataReserva.ReadOnly = true;            
        }

        private void frmReservaVisualizar_Load(object sender, EventArgs e)
        {
            BloquearCampos();
        }

        private void PreencherCampos(int id)
        {
            ReservaTO reservaTO = new ReservaTO();

            reservaTO = ReservaService.Obter(id);

            if (!reservaTO.Valido)
            {
                MessageBox.Show(reservaTO.Mensagem, "Atenção");
            }

            txtVisualizarrCodMorReserva.Text = Convert.ToString(reservaTO.IdMorador);
            cboVisualizarTipoReserva.Text = Convert.ToString(reservaTO.IdTipoReserva);
            dtVisualizarDataReserva.Text = Convert.ToString(reservaTO.DataReserva);

            lblVisualizarCodMorReserva.Text = reservaTO.Identificador.ToString();
        }
    }
}
