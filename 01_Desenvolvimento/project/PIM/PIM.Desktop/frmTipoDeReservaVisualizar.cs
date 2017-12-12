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
    public partial class frmTipoDeReservaVisualizar : Form
    {
        public frmTipoDeReservaVisualizar(int idTipoReserva)
        {
            InitializeComponent();
            PreencherCampos(idTipoReserva);
        }

        private void btnFecharVisualizacao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BloquearCampos()
        {
            txtVisualizarCodTipoReserva.ReadOnly = true;
            txtVisualizarTipoReserva.ReadOnly = true;
        }

        private void frmTipoDeReservaVisualizar_Load(object sender, EventArgs e)
        {
            BloquearCampos();
        }

        private void PreencherCampos(int id)
        {
            TipoReservaTO tipoReservaTO = new TipoReservaTO();
            tipoReservaTO = TipoReservaService.Obter(id);

            if (!tipoReservaTO.Valido)
            {
                //Todo: Exibir Mensagem e Fechar Form
                MessageBox.Show(tipoReservaTO.Mensagem, "Atenção");
                this.Close();
            }

            txtVisualizarCodTipoReserva.Text = Convert.ToString(tipoReservaTO.Identificador);
            txtVisualizarTipoReserva.Text = tipoReservaTO.Tipo;
        }
    }
}
