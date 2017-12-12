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
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void admCondomínioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrarCondominio admCondominio = new frmAdministrarCondominio();
            admCondominio.Show();
        }

        private void moradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMorador janelaMorador = new frmMorador();
            janelaMorador.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIncluirColab_Click(object sender, EventArgs e)
        {
            frmColaboradorCadastrar janelaCadastroColaborador = new frmColaboradorCadastrar();
            janelaCadastroColaborador.Show();
        }

        private void btnExcluirColab_Click(object sender, EventArgs e)
        {
            int idColaborador = 0;

            if (dgColaborador.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgColaborador.SelectedRows)
                {
                    idColaborador = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgColaborador.SelectedCells)
                {
                    DataGridViewRow row = dgColaborador.Rows[cell.RowIndex];
                    idColaborador = (int)row.Cells[0].Value;
                }
            }

            frmColaboradorExcluir excluirColaborador = new frmColaboradorExcluir(idColaborador);
            excluirColaborador.Show();
        }

        private void btnEditarColaborador_Click(object sender, EventArgs e)
        {
            int idColaborador = 0;

            if (dgColaborador.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgColaborador.SelectedRows)
                {
                    idColaborador = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgColaborador.SelectedCells)
                {
                    DataGridViewRow row = dgColaborador.Rows[cell.RowIndex];
                    idColaborador = (int)row.Cells[0].Value;
                }
            }

            frmColaboradorEditar editarColaborador = new frmColaboradorEditar(idColaborador);
            editarColaborador.Show();
        }

        private void btnVisualizarColab_Click(object sender, EventArgs e)
        {
            int idColaborador = 0;

            if (dgColaborador.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgColaborador.SelectedRows)
                {
                    idColaborador = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgUsuario.SelectedCells)
                {
                    DataGridViewRow row = dgColaborador.Rows[cell.RowIndex];
                    idColaborador = (int)row.Cells[0].Value;
                }
            }

            frmColaboradorVisualizar visualizarColaborador = new frmColaboradorVisualizar(idColaborador);
            visualizarColaborador.Show();

        }

        private void btnIncluirUsuario_Click(object sender, EventArgs e)
        {
            frmUsuarioCadastrar usuarioCadastrar = new frmUsuarioCadastrar();
            usuarioCadastrar.Show();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            int idUsuario = 0;

            if (dgUsuario.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgUsuario.SelectedRows)
                {
                    idUsuario = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgUsuario.SelectedCells)
                {
                    DataGridViewRow row = dgUsuario.Rows[cell.RowIndex];
                    idUsuario = (int)row.Cells[0].Value;
                }
            }

            frmUsuarioEditar editarUsuario = new frmUsuarioEditar(idUsuario);
            editarUsuario.Show();
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            int idUsuario = 0;

            if (dgUsuario.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgUsuario.SelectedRows)
                {
                    idUsuario = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgUsuario.SelectedCells)
                {
                    DataGridViewRow row = dgUsuario.Rows[cell.RowIndex];
                    idUsuario = (int)row.Cells[0].Value;
                }
            }

            frmUsuarioExcluir excluirUsuario = new frmUsuarioExcluir(idUsuario);
            excluirUsuario.Show();
        }

        private void btnVisualzarUsuario_Click(object sender, EventArgs e)
        {
            int idUsuario = 0;

            if (dgUsuario.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgUsuario.SelectedRows)
                {
                    idUsuario = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgUsuario.SelectedCells)
                {
                    DataGridViewRow row = dgUsuario.Rows[cell.RowIndex];
                    idUsuario = (int)row.Cells[0].Value;
                }
            }

            frmUsuarioVisualizar visualizarUsuario = new frmUsuarioVisualizar(idUsuario);
            visualizarUsuario.Show();
        }

        private void CarregarDados()
        {
            ListaUsuarioTO listaUsuarioTO = new ListaUsuarioTO();
            listaUsuarioTO = UsuarioService.Listar();

            dgUsuario.DataSource = listaUsuarioTO.Lista;
            dgUsuario.Columns["Identificador"].Visible = false;
            dgUsuario.Columns["Valido"].Visible = false;
            dgUsuario.Columns["Mensagem"].Visible = false;
            dgUsuario.ReadOnly = true;

            ListaApartamentoTO listaApartamentoTO = new ListaApartamentoTO();
            listaApartamentoTO = ApartamentoService.Listar();

            dgApartamento.DataSource = listaUsuarioTO.Lista;
            dgApartamento.Columns["Identificador"].Visible = false;
            dgApartamento.Columns["Valido"].Visible = false;
            dgApartamento.Columns["Mensagem"].Visible = false;
            dgApartamento.ReadOnly = true;

            ListaColaboradorTO listaColaboradorTO = new ListaColaboradorTO();
            listaColaboradorTO = ColaboradorService.Listar();

            dgColaborador.DataSource = listaColaboradorTO.Lista;
            dgColaborador.Columns["Identificador"].Visible = false;
            dgColaborador.Columns["Valido"].Visible = false;
            dgColaborador.Columns["Mensagem"].Visible = false;
            dgColaborador.ReadOnly = true;

            ListaTipoReservaTO listaTipoReservaTO = TipoReservaService.Listar();

            dgTipoReserva.DataSource = listaTipoReservaTO.Lista;
            dgTipoReserva.Columns["Identificador"].Visible = false;
            dgTipoReserva.Columns["Valido"].Visible = false;
            dgTipoReserva.Columns["Mensagem"].Visible = false;
            dgTipoReserva.ReadOnly = true;



        }

        private void btnAtualizarAdministrador_Click(object sender, EventArgs e)
        {
            CarregarDados();

        }

        private void btnNovoTipoReserva_Click(object sender, EventArgs e)
        {
            frmTipoDeReservaCadastrar cadastrarTipoReserva = new frmTipoDeReservaCadastrar();
            cadastrarTipoReserva.Show();
        }

        private void btnEditarTipoReserva_Click(object sender, EventArgs e)
        {
            int idTipoReserva = 0;

            if (dgTipoReserva.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgTipoReserva.SelectedRows)
                {
                    idTipoReserva = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgTipoReserva.SelectedCells)
                {
                    DataGridViewRow row = dgTipoReserva.Rows[cell.RowIndex];
                    idTipoReserva = (int)row.Cells[0].Value;
                }
            }
            

            frmTipoDeReservaEditar editarTipoReserva = new frmTipoDeReservaEditar(idTipoReserva);
            editarTipoReserva.Show();
        }

        private void btnExcluirTipoReserva_Click(object sender, EventArgs e)
        {
            int idTipoReserva = 0;

            if (dgTipoReserva.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgTipoReserva.SelectedRows)
                {
                    idTipoReserva = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgTipoReserva.SelectedCells)
                {
                    DataGridViewRow row = dgTipoReserva.Rows[cell.RowIndex];
                    idTipoReserva = (int)row.Cells[0].Value;
                }
            }

            frmTipoDeReservaExcluir excluirTipoReserva = new frmTipoDeReservaExcluir(idTipoReserva);
            excluirTipoReserva.Show();
        }

        private void btnVisualizarTippoReserva_Click(object sender, EventArgs e)
        {
            int idTipoReserva = 0;

            if (dgTipoReserva.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgTipoReserva.SelectedRows)
                {
                    idTipoReserva = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgTipoReserva.SelectedCells)
                {
                    DataGridViewRow row = dgUsuario.Rows[cell.RowIndex];
                    idTipoReserva = (int)row.Cells[0].Value;
                }
            }

            frmTipoDeReservaVisualizar visualizarTipoReserva = new frmTipoDeReservaVisualizar(idTipoReserva);
            visualizarTipoReserva.Show();
        }

        private void btnNovoApartamento_Click(object sender, EventArgs e)
        {            
            frmApartamentoCadastrar cadastrarApartamento = new frmApartamentoCadastrar();
            cadastrarApartamento.Show();
        }

        private void btnEditarApartamento_Click(object sender, EventArgs e)
        {
            int idApartamento = 0;

            if (dgApartamento.SelectedRows.Count > 0)
            { 
                foreach (DataGridViewRow row in dgApartamento.SelectedRows)
                {
                    idApartamento = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgApartamento.SelectedCells)
                {
                    DataGridViewRow row = dgApartamento.Rows[cell.RowIndex];
                    idApartamento = (int)row.Cells[0].Value;
                }
            }

            frmApartamentoEditar editarApartamento = new frmApartamentoEditar(idApartamento);
            editarApartamento.Show();
        }

        private void btnExcluirApartamento_Click(object sender, EventArgs e)
        {
            int idApartamento = 0;

            if (dgApartamento.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgApartamento.SelectedRows)
                {
                    idApartamento = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgApartamento.SelectedCells)
                {
                    DataGridViewRow row = dgApartamento.Rows[cell.RowIndex];
                    idApartamento = (int)row.Cells[0].Value;
                }
            }

            frmApartamentoExcluir excluirApartamento = new frmApartamentoExcluir(idApartamento);
            excluirApartamento.Show();
        }

        private void btnVisualizarApartamento_Click(object sender, EventArgs e)
        {
            int idApartamento = 0;

            if (dgApartamento.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgApartamento.SelectedRows)
                {
                    idApartamento = (int)row.Cells[0].Value;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dgApartamento.SelectedCells)
                {
                    DataGridViewRow row = dgApartamento.Rows[cell.RowIndex];
                    idApartamento = (int)row.Cells[0].Value;
                }
            }

            frmApartamentoVisualizar visualizarApartamento = new frmApartamentoVisualizar(idApartamento);
            visualizarApartamento.Show();
        }
        
    }
}


