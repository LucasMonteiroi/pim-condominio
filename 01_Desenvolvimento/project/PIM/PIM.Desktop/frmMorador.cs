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
    public partial class frmMorador : Form
    {
        public frmMorador()
        {
            InitializeComponent();
        }

        private void btnMorNovoDep_Click(object sender, EventArgs e)
        {
            frmDependenteCadastrar morCadastrarDependente = new frmDependenteCadastrar();
            morCadastrarDependente.Show();
        }

        private void btnMorEditarDependente_Click(object sender, EventArgs e)
        {
            int idDependente = 0;

            if (dgMorDependentes.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgMorDependentes.SelectedRows)
                {
                    idDependente = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgMorDependentes.SelectedCells)
                {
                    DataGridViewRow row = dgMorDependentes.Rows[cell.RowIndex];
                    idDependente = (int)row.Cells[0].Value;
                }
                frmDependenteEditar morEditarDependente = new frmDependenteEditar(idDependente);
                morEditarDependente.Show();
            }


        }

        private void btnMorExcluirDepemdemte_Click(object sender, EventArgs e)
        {
            int idVisitante = 0;

            if (dgMorDependentes.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgMorDependentes.SelectedRows)
                {
                    idVisitante = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgMorDependentes.SelectedCells)
                {
                    DataGridViewRow row = dgMorDependentes.Rows[cell.RowIndex];
                    idVisitante = (int)row.Cells[0].Value;
                }
            }

            frmDependenteExcluir morExcluirDependente = new frmDependenteExcluir(idVisitante);
            morExcluirDependente.Show();
        }

        private void btnMorVisualizarDependente_Click(object sender, EventArgs e)
        {
            int idVisitante = 0;

            if (dgMorDependentes.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgMorDependentes.SelectedRows)
                {
                    idVisitante = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgMorDependentes.SelectedCells)
                {
                    DataGridViewRow row = dgMorDependentes.Rows[cell.RowIndex];
                    idVisitante = (int)row.Cells[0].Value;
                }
            }

            frmDependenteVisualizar morVisualizarDependente = new frmDependenteVisualizar(idVisitante);
            morVisualizarDependente.Show();
                
        }

        private void btnMorCadastrarOcorrencia_Click(object sender, EventArgs e)
        {
            frmOcorrenciaCadastrar cadastrarOcorrencia = new frmOcorrenciaCadastrar();
            cadastrarOcorrencia.Show();
        }

        private void btnMorEditarOcorrencia_Click(object sender, EventArgs e)
        {
            int idOcorrencia = 0;

            if (dgOcorrencia.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgOcorrencia.SelectedRows)
                {
                    idOcorrencia = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgOcorrencia.SelectedCells)
                {
                    DataGridViewRow row = dgOcorrencia.Rows[cell.RowIndex];
                    idOcorrencia = (int)row.Cells[0].Value;
                }
            }

            frmOcorrenciaEditar admEditarOcorrencia = new frmOcorrenciaEditar(idOcorrencia);
            admEditarOcorrencia.Show();
                        
        }

        private void btnMorExcluirOcorrencia_Click(object sender, EventArgs e)
        {
            int idOcorrencia = 0;

            if (dgOcorrencia.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgOcorrencia.SelectedRows)
                {
                    idOcorrencia = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgOcorrencia.SelectedCells)
                {
                    DataGridViewRow row = dgOcorrencia.Rows[cell.RowIndex];
                    idOcorrencia = (int)row.Cells[0].Value;
                }
            }

            frmOcorrenciaExcluir admExcluirOcorrencia = new frmOcorrenciaExcluir(idOcorrencia);
            admExcluirOcorrencia.Show();

            
        }

        private void btnMorVisualizarOcorrencia_Click(object sender, EventArgs e)
        {
            int idOcorrencia = 0;

            if (dgOcorrencia.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgOcorrencia.SelectedRows)
                {
                    idOcorrencia = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgOcorrencia.SelectedCells)
                {
                    DataGridViewRow row = dgOcorrencia.Rows[cell.RowIndex];
                    idOcorrencia = (int)row.Cells[0].Value;
                }
            }

            frmOcorrenciaVisualizar admVisualizarOcorrencia = new frmOcorrenciaVisualizar(idOcorrencia);
            admVisualizarOcorrencia.Show();
                        
        }

        private void btnNovoVisitante_Click(object sender, EventArgs e)
        {
            frmCadastrarVisitante visitante = new frmCadastrarVisitante();
            visitante.Show();
        }

        private void btnEditarVisitante_Click(object sender, EventArgs e)
        {
            int idVisitante = 0;

            if (dgVisitantes.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgVisitantes.SelectedRows)
                {
                    idVisitante = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgVisitantes.SelectedCells)
                {
                    DataGridViewRow row = dgVisitantes.Rows[cell.RowIndex];
                    idVisitante = (int)row.Cells[0].Value;
                }
            }

            frmVisitanteEditar editarVisitante = new frmVisitanteEditar(idVisitante);
            editarVisitante.Show();
        }

        private void btnExcluirVisitante_Click(object sender, EventArgs e)
        {
            int idVisitante = 0;

            if (dgVisitantes.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgVisitantes.SelectedRows)
                {
                    idVisitante = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgVisitantes.SelectedCells)
                {
                    DataGridViewRow row = dgVisitantes.Rows[cell.RowIndex];
                    idVisitante = (int)row.Cells[0].Value;
                }
            }

            frmVisitanteExcluir visitanteExcluir = new frmVisitanteExcluir(idVisitante);
            visitanteExcluir.Show();
        }

        private void btnVisualizarVisitante_Click(object sender, EventArgs e)
        {
            int idVisitante = 0;

            if (dgVisitantes.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgVisitantes.SelectedRows)
                {
                    idVisitante = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgVisitantes.SelectedCells)
                {
                    DataGridViewRow row = dgVisitantes.Rows[cell.RowIndex];
                    idVisitante = (int)row.Cells[0].Value;
                }
            }

            frmVisitanteVisualizar visitanteVisualizar = new frmVisitanteVisualizar(idVisitante);
            visitanteVisualizar.Show();
        }

        private void CarregarDados()
        {
            ListaOcorrenciaTO listaOcorrenciaTO = new ListaOcorrenciaTO();
            listaOcorrenciaTO = OcorrenciaService.Listar();

            dgOcorrencia.DataSource = listaOcorrenciaTO.Lista;
            dgOcorrencia.Columns["Identificador"].Visible = false;
            dgOcorrencia.Columns["Valido"].Visible = false;
            dgOcorrencia.Columns["Mensagem"].Visible = false;
            dgOcorrencia.ReadOnly = true;

            ListaVisitanteTO listaVisitanteTO = new ListaVisitanteTO();
            listaVisitanteTO = VisitanteService.Listar();

            dgVisitantes.DataSource = listaVisitanteTO.Lista;
            dgVisitantes.Columns["Identificador"].Visible = false;
            dgVisitantes.Columns["Valido"].Visible = false;
            dgVisitantes.Columns["Mensagem"].Visible = false;
            dgVisitantes.ReadOnly = true;


            ListaDependenteTO listaDependentesTO = new ListaDependenteTO();
            listaDependentesTO = DependenteService.Listar();

            dgMorDependentes.DataSource = listaDependentesTO.Lista;
            dgMorDependentes.Columns["Identificador"].Visible = false;
            dgMorDependentes.Columns["Valido"].Visible = false;
            dgMorDependentes.Columns["Mensagem"].Visible = false;
            dgMorDependentes.ReadOnly = true;

        }

        private void btnMorAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnNovaReservaMor_Click(object sender, EventArgs e)
        {
            frmReservaCadastrar cadastrarReserva = new frmReservaCadastrar();
            cadastrarReserva.Show();
        }

        private void btnEditarReservaMor_Click(object sender, EventArgs e)
        {
            int idReserva = 0;

            if (dgReservasMor.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgReservasMor.SelectedRows)
                {
                    idReserva = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgReservasMor.SelectedCells)
                {
                    DataGridViewRow row = dgReservasMor.Rows[cell.RowIndex];
                    idReserva = (int)row.Cells[0].Value;
                }
            }

            frmReservaEditar editarReserva = new frmReservaEditar(idReserva);
            editarReserva.Show();
        }

        private void btnExcluirReservaMor_Click(object sender, EventArgs e)
        {
            int idReserva = 0;

            if (dgReservasMor.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgReservasMor.SelectedRows)
                {
                    idReserva = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgReservasMor.SelectedCells)
                {
                    DataGridViewRow row = dgReservasMor.Rows[cell.RowIndex];
                    idReserva = (int)row.Cells[0].Value;
                }
            }

            frmReservaExcluir excluirReserva = new frmReservaExcluir(idReserva);
            excluirReserva.Show();
        }

        private void btnVisualizarReservaMor_Click(object sender, EventArgs e)
        {
            int idReserva = 0;

            if (dgReservasMor.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgReservasMor.SelectedRows)
                {
                    idReserva = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgReservasMor.SelectedCells)
                {
                    DataGridViewRow row = dgReservasMor.Rows[cell.RowIndex];
                    idReserva = (int)row.Cells[0].Value;
                }
            }

            frmReservaVisualizar visualizarReserva = new frmReservaVisualizar(idReserva);
            visualizarReserva.Show();
        }
    }
}
