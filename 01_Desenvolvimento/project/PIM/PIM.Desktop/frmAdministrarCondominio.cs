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
    public partial class frmAdministrarCondominio : Form
    {
        public frmAdministrarCondominio()
        {
            InitializeComponent();
        }

        private void btnIncluirMorador_Click(object sender, EventArgs e)
        {
            frmMoradorCadastrar cadastrarMorador = new frmMoradorCadastrar();
            cadastrarMorador.Show();
        }

        private void btnEditarMorador_Click(object sender, EventArgs e)
        {
            int idMorador = 0;

            if (dgMoradores.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgMoradores.SelectedRows)
                {
                    idMorador = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach(DataGridViewCell cell in dgMoradores.SelectedCells)
                {
                    DataGridViewRow row = dgMoradores.Rows[cell.RowIndex];
                    idMorador = (int)row.Cells[0].Value;
                }
            }

            frmMoradorEditar moradorEditar = new frmMoradorEditar(idMorador);
            moradorEditar.Show();
        }

        private void btnExcluirMorador_Click(object sender, EventArgs e)
        {
            int idMorador = 0;

            if (dgMoradores.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgMoradores.SelectedRows)
                {
                    idMorador = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgMoradores.SelectedCells)
                {
                    DataGridViewRow row = dgMoradores.Rows[cell.RowIndex];
                    idMorador = (int)row.Cells[0].Value;
                }
            }

            frmMoradorExcluir moradorExcluir = new frmMoradorExcluir(idMorador);
            moradorExcluir.Show();
        }

        private void btnVisualizarMorador_Click(object sender, EventArgs e)
        {
            int idMorador = 0;

            if (dgMoradores.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgMoradores.SelectedRows)
                {
                    idMorador = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgMoradores.SelectedCells)
                {
                    DataGridViewRow row = dgMoradores.Rows[cell.RowIndex];
                    idMorador = (int)row.Cells[0].Value;
                }
            }

            frmMoradorVisualizar moradorVisualizar = new frmMoradorVisualizar(idMorador);
            moradorVisualizar.Show();
        }

        private void btnAdmNovoDependente_Click(object sender, EventArgs e)
        {
            frmDependenteCadastrar admCadastrarDependente = new frmDependenteCadastrar();
            admCadastrarDependente.Show();
        }

        private void btnAdmEditarDependente_Click(object sender, EventArgs e)
        {
            int idDependente = 0;

            if (dgDependentes.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgDependentes.SelectedRows)
                {
                    idDependente = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgDependentes.SelectedCells)
                {
                    DataGridViewRow row = dgDependentes.Rows[cell.RowIndex];
                    idDependente = (int)row.Cells[0].Value;
                }
                frmDependenteEditar admDependenteExcluir = new frmDependenteEditar(idDependente);
                admDependenteExcluir.Show();
            
            }
        }

        private void btnAdmExcluirDependente_Click(object sender, EventArgs e)
        {
            int idVisitante = 0;

            if (dgDependentes.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgDependentes.SelectedRows)
                {
                    idVisitante = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgDependentes.SelectedCells)
                {
                    DataGridViewRow row = dgDependentes.Rows[cell.RowIndex];
                    idVisitante = (int)row.Cells[0].Value;
                }
            }

            frmDependenteExcluir admDependenteExcluir = new frmDependenteExcluir(idVisitante);
            admDependenteExcluir.Show();
        }

        private void btnAdmVisualizarDependente_Click(object sender, EventArgs e)
        {
            int idVisitante = 0;

            if (dgDependentes.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgDependentes.SelectedRows)
                {
                    idVisitante = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgDependentes.SelectedCells)
                {
                    DataGridViewRow row = dgDependentes.Rows[cell.RowIndex];
                    idVisitante = (int)row.Cells[0].Value;
                }
            }

            frmDependenteVisualizar admVisualizarDependente = new frmDependenteVisualizar(idVisitante);
            admVisualizarDependente.Show();
        }

        private void btnAdmCadastrarOcorrencia_Click(object sender, EventArgs e)
        {

            frmCadastrarOcorrencia admCadastrarOcorrencia = new frmCadastrarOcorrencia();
            admCadastrarOcorrencia.Show();
        }

        private void btnAdmEditarOcorrencia_Click(object sender, EventArgs e)
        {
            int idOcorrencia = 0;

            if (dgAdmOcorrencias.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgAdmOcorrencias.SelectedRows)
                {
                    idOcorrencia = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgAdmOcorrencias.SelectedCells)
                {
                    DataGridViewRow row = dgAdmOcorrencias.Rows[cell.RowIndex];
                    idOcorrencia = (int)row.Cells[0].Value;
                }
            }

            frmOcorrenciaEditar admEditarOcorrencia = new frmOcorrenciaEditar(idOcorrencia);
            admEditarOcorrencia.Show();
        }

        private void btnAdmExcluirOcorrencia_Click(object sender, EventArgs e)
        {
            int idOcorrencia = 0;

            if (dgAdmOcorrencias.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgAdmOcorrencias.SelectedRows)
                {
                    idOcorrencia = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgAdmOcorrencias.SelectedCells)
                {
                    DataGridViewRow row = dgAdmOcorrencias.Rows[cell.RowIndex];
                    idOcorrencia = (int)row.Cells[0].Value;
                }
            }

            frmOcorrenciaExcluir admExcluirOcorrencia = new frmOcorrenciaExcluir(idOcorrencia);
            admExcluirOcorrencia.Show();
        }

        private void btnAdmVisualizarOcorrencia_Click(object sender, EventArgs e)
        {
            int idOcorrencia = 0;

            if (dgAdmOcorrencias.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgAdmOcorrencias.SelectedRows)
                {
                    idOcorrencia = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgAdmOcorrencias.SelectedCells)
                {
                    DataGridViewRow row = dgAdmOcorrencias.Rows[cell.RowIndex];
                    idOcorrencia = (int)row.Cells[0].Value;
                }
            }

            frmOcorrenciaVisualizar admVisualizarOcorrencia = new frmOcorrenciaVisualizar(idOcorrencia);
            admVisualizarOcorrencia.Show();
        }

        private void frmAdministrarCondominio_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            ListaMoradorTO listaMoradoresTO = new ListaMoradorTO();
            listaMoradoresTO = MoradorService.Listar();

            dgMoradores.DataSource = listaMoradoresTO.Lista;
            dgMoradores.Columns["Identificador"].Visible = false;
            dgMoradores.Columns["Valido"].Visible = false;
            dgMoradores.Columns["Mensagem"].Visible = false;
            dgMoradores.ReadOnly = true;

            ListaContratoTO listaContratosTO = new ListaContratoTO();
            listaContratosTO = ContratoService.Listar();

            dgContratos.DataSource = listaContratosTO.Lista;
            dgContratos.Columns["Identificador"].Visible = false;
            dgContratos.Columns["Valido"].Visible = false;
            dgContratos.Columns["Mensagem"].Visible = false;
            dgContratos.ReadOnly = true;

            ListaDependenteTO listaDependentesTO = new ListaDependenteTO();
            listaDependentesTO = DependenteService.Listar();

            dgDependentes.DataSource = listaDependentesTO.Lista;
            dgDependentes.Columns["Identificador"].Visible = false;
            dgDependentes.Columns["Valido"].Visible = false;
            dgDependentes.Columns["Mensagem"].Visible = false;
            dgDependentes.ReadOnly = true;

            ListaEstacionamentoTO listaEstacionamentosTO = new ListaEstacionamentoTO();
            listaEstacionamentosTO = EstacionamentoService.Listar();

            ListaOcorrenciaTO listaOcorrenciasTO = new ListaOcorrenciaTO();
            listaOcorrenciasTO = OcorrenciaService.Listar();

            dgAdmOcorrencias.DataSource = listaOcorrenciasTO.Lista;
            dgAdmOcorrencias.Columns["Identificador"].Visible = false;
            dgAdmOcorrencias.Columns["Valido"].Visible = false;
            dgAdmOcorrencias.Columns["Mensagem"].Visible = false;
            dgAdmOcorrencias.ReadOnly = true;

            ListaReservaTO listaReservasTO = new ListaReservaTO();
            listaReservasTO = ReservaService.Listar();

            dgReservas.DataSource = listaReservasTO.Lista;
            dgReservas.Columns["Identificador"].Visible = false;
            dgReservas.Columns["Valido"].Visible = false;
            dgReservas.Columns["Mensagem"].Visible = false;
            dgReservas.ReadOnly = true;


            ListaAdvertenciaTO listaAdvertenciasTO = new ListaAdvertenciaTO();
            listaAdvertenciasTO = AdvertenciaService.Listar();

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnNovoContrato_Click(object sender, EventArgs e)
        {
            frmContratoCadastrar cadastrarContrato = new frmContratoCadastrar();
            cadastrarContrato.Show();
        }

        private void btnEditarContrato_Click(object sender, EventArgs e)
        {
            int idContrato = 0;

            if (dgContratos.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgContratos.SelectedRows)
                {
                    idContrato = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgContratos.SelectedCells)
                {
                    DataGridViewRow row = dgContratos.Rows[cell.RowIndex];
                    idContrato = (int)row.Cells[0].Value;
                }
            }

            frmContratoEditar editarContrato = new frmContratoEditar(idContrato);
            editarContrato.Show();
        }

        private void btnExcluirContrato_Click(object sender, EventArgs e)
        {
            int idContrato = 0;

            if (dgContratos.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgContratos.SelectedRows)
                {
                    idContrato = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgContratos.SelectedCells)
                {
                    DataGridViewRow row = dgContratos.Rows[cell.RowIndex];
                    idContrato = (int)row.Cells[0].Value;
                }
            }

            frmContratoExcluir excluirContrato = new frmContratoExcluir(idContrato);
            excluirContrato.Show();
        }

        private void btnVisualizarContrato_Click(object sender, EventArgs e)
        {
            int idContrato = 0;

            if (dgContratos.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgContratos.SelectedRows)
                {
                    idContrato = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgContratos.SelectedCells)
                {
                    DataGridViewRow row = dgContratos.Rows[cell.RowIndex];
                    idContrato = (int)row.Cells[0].Value;
                }
            }

            frmContratoVisualizar visualizarContrato = new frmContratoVisualizar(idContrato);
            visualizarContrato.Show();
        }

        private void btnNovaReserva_Click(object sender, EventArgs e)
        {
            frmReservaCadastrar cadastrarReserva = new frmReservaCadastrar();
            cadastrarReserva.Show();
        }

        private void btnEditarReserva_Click(object sender, EventArgs e)
        {
            int idReserva = 0;

            if (dgReservas.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgReservas.SelectedRows)
                {
                    idReserva = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgReservas.SelectedCells)
                {
                    DataGridViewRow row = dgReservas.Rows[cell.RowIndex];
                    idReserva = (int)row.Cells[0].Value;
                }
            }

            frmReservaEditar editarReserva = new frmReservaEditar(idReserva);
            editarReserva.Show();
        }

        private void btnExcluirReserva_Click(object sender, EventArgs e)
        {
            int idReserva = 0;

            if (dgReservas.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgReservas.SelectedRows)
                {
                    idReserva = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgReservas.SelectedCells)
                {
                    DataGridViewRow row = dgReservas.Rows[cell.RowIndex];
                    idReserva = (int)row.Cells[0].Value;
                }
            }

            frmReservaExcluir excluirReserva = new frmReservaExcluir(idReserva);
            excluirReserva.Show();
        
        }

        private void btnVisualizarReserva_Click(object sender, EventArgs e)
        {
            int idReserva = 0;

            if (dgReservas.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgReservas.SelectedRows)
                {
                    idReserva = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgReservas.SelectedCells)
                {
                    DataGridViewRow row = dgReservas.Rows[cell.RowIndex];
                    idReserva = (int)row.Cells[0].Value;
                }
            }

            frmReservaVisualizar visualizarReserva = new frmReservaVisualizar(idReserva);
            visualizarReserva.Show();
        }
    }
}
