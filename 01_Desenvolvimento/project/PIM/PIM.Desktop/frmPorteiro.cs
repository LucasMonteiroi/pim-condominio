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
    public partial class frmPorteiro : Form
    {
        public frmPorteiro()
        {
            InitializeComponent();
        }

        private void CarregarDados()
        {
            ListaColaboradorTO listaColaboradorTO = new ListaColaboradorTO();
            listaColaboradorTO = ColaboradorService.Listar();

            dgPorteiroVisualizarColab.DataSource = listaColaboradorTO.Lista;
            dgPorteiroVisualizarColab.Columns["Identificador"].Visible = false;
            dgPorteiroVisualizarColab.Columns["Valido"].Visible = false;
            dgPorteiroVisualizarColab.Columns["Mensagem"].Visible = false;
            dgPorteiroVisualizarColab.ReadOnly = true;

            ListaDependenteTO listaDependenteTO = new ListaDependenteTO();
            listaDependenteTO = DependenteService.Listar();

            dgPorteiroDependentes.DataSource = listaDependenteTO.Lista;
            dgPorteiroDependentes.Columns["Identificador"].Visible = false;
            dgPorteiroDependentes.Columns["Valido"].Visible = false;
            dgPorteiroDependentes.Columns["Mensagem"].Visible = false;
            dgPorteiroDependentes.ReadOnly = true;

            ListaVisitanteTO listaVisitanteTO = new ListaVisitanteTO();
            listaVisitanteTO = VisitanteService.Listar();

            dgPorteiroVisualizarVisitante.DataSource = listaVisitanteTO.Lista;
            dgPorteiroVisualizarVisitante.Columns["Identificador"].Visible = false;
            dgPorteiroVisualizarVisitante.Columns["Valido"].Visible = false;
            dgPorteiroVisualizarVisitante.Columns["Mensagem"].Visible = false;
            dgPorteiroVisualizarVisitante.ReadOnly = true;
        }

            private void btnVisualizarColab_Click(object sender, EventArgs e)
            {
            int idColaborador = 0;

            if (dgPorteiroVisualizarColab.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgPorteiroVisualizarColab.SelectedRows)
                {
                    idColaborador = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgPorteiroVisualizarColab.SelectedCells)
                {
                    DataGridViewRow row = dgPorteiroVisualizarColab.Rows[cell.RowIndex];
                    idColaborador = (int)row.Cells[0].Value;
                }
            }

            frmColaboradorVisualizar porteiroVisualizarColaborador = new frmColaboradorVisualizar(idColaborador);
            porteiroVisualizarColaborador.Show();
        }

        private void btnVisualizarDependentes_Click(object sender, EventArgs e)
        {
            int idDependentes = 0;

            if (dgPorteiroDependentes.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgPorteiroDependentes.SelectedRows)
                {
                    idDependentes = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgPorteiroDependentes.SelectedCells)
                {
                    DataGridViewRow row = dgPorteiroDependentes.Rows[cell.RowIndex];
                    idDependentes = (int)row.Cells[0].Value;
                }
            }

            frmDependenteVisualizar visualizarDependente = new frmDependenteVisualizar(idDependentes);
            visualizarDependente.Show();
        }

        private void btnVisualizarVisitante_Click(object sender, EventArgs e)
        {
            int idVisitante = 0;

            if (dgPorteiroVisualizarVisitante.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgPorteiroVisualizarVisitante.SelectedRows)
                {
                    idVisitante = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgPorteiroVisualizarVisitante.SelectedCells)
                {
                    DataGridViewRow row = dgPorteiroVisualizarVisitante.Rows[cell.RowIndex];
                    idVisitante = (int)row.Cells[0].Value;
                }
            }

            frmDependenteVisualizar visualizarDependente = new frmDependenteVisualizar(idVisitante);
            visualizarDependente.Show();
        }

        private void btnAtualizarJanelaPorteiro_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
    } 
}
