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
    public partial class frmDependenteVisualizar : Form
    {
        public frmDependenteVisualizar(int idVisitante)
        {
            InitializeComponent();
            PreencherCampos(idVisitante);
        }

        private void btnFecharVisualizacaoDep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BloquearCampos()
        {
            txtVisualizarNomeDep.ReadOnly = true;
            txtVisualizarRgDep.ReadOnly = true;
            txtVisualizarTelefoneDep.ReadOnly = true;
            txtVisualizarMoradorResp.ReadOnly = true;
            txtVisualizarGrauParentesco.ReadOnly = true;
        }

        private void frmDependenteVisualizar_Load(object sender, EventArgs e)
        {
            BloquearCampos();
        }

        private void PreencherCampos(int id)
        {
            DependenteTO dependenteTO = new DependenteTO();
            dependenteTO = DependenteService.Obter(id);

            if (!dependenteTO.Valido)
            {
                //Todo: Exibir Mensagem e Fechar Form
                MessageBox.Show(dependenteTO.Mensagem);
                this.Close();
            }

            txtVisualizarNomeDep.Text = dependenteTO.Nome;
            txtVisualizarRgDep.Text = dependenteTO.RG;
            txtVisualizarTelefoneDep.Text = dependenteTO.Telefone;
            txtVisualizarGrauParentesco.Text = dependenteTO.GrauParentesco;
            txtVisualizarMoradorResp.Text = Convert.ToString(dependenteTO.IdMorador);
            lblVisualizarCodigoDep.Text = dependenteTO.Identificador.ToString();
        }
    }
}
