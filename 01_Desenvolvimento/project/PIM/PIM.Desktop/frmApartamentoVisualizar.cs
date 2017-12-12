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
    public partial class frmApartamentoVisualizar : Form
    {
        public frmApartamentoVisualizar(int idApartamento)
        {
            InitializeComponent();
            PreencherCampos(idApartamento);
        }

        private void btnFecharVisualizacaoApto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BloquearCampos()
        {
            txtVisualizarBlocoApto.ReadOnly = true;
            txtVisualizarCodContrato.ReadOnly = true;
            txtVisualizarNumeroApto.ReadOnly = true;
        }

        private void frmApartamentoVisualizar_Load(object sender, EventArgs e)
        {
            BloquearCampos();
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

            txtVisualizarBlocoApto.Text = Convert.ToString(apartamentoTO.Bloco);
            txtVisualizarNumeroApto.Text = apartamentoTO.Numero;
            txtVisualizarCodContrato.Text = Convert.ToString(apartamentoTO.IdContrato);

            lblVisualizarCodigoApto.Text = apartamentoTO.Identificador.ToString();
        }
    }
 }
