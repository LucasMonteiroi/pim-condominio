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
    public partial class frmApartamentoEditar : Form
    {
        public frmApartamentoEditar(int id)
        {
            InitializeComponent();
            PreencherCampos(id);
        }

        private void btnCancelarEdicaoApartamento_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreencherCampos(int id)
        {
            ApartamentoTO apartamentoTO = new ApartamentoTO();

            apartamentoTO = ApartamentoService.Obter(id);

            if (!apartamentoTO.Valido)
            {
                MessageBox.Show(apartamentoTO.Mensagem, "Atenção");
            }

            txtEditarBlocoApto.Text = Convert.ToString(apartamentoTO.Bloco);
            txtEditarCodContrato.Text = Convert.ToString(apartamentoTO.IdContrato);
            txtEditarNumeroApto.Text = apartamentoTO.Numero;
            
            lblEditarCodigoApto.Text = Convert.ToString(apartamentoTO.Identificador);
        }

        private void btnSalvarEdicaoApartamento_Click(object sender, EventArgs e)
        {
            ApartamentoTO apartamentoTO = new ApartamentoTO();

            apartamentoTO.Bloco = Convert.ToInt32(txtEditarBlocoApto.Text);
            apartamentoTO.IdContrato = Convert.ToInt32(txtEditarCodContrato.Text);
            apartamentoTO.Numero = txtEditarNumeroApto.Text;
            
            ApartamentoService.Atualizar(apartamentoTO);

            if (!apartamentoTO.Valido)
                MessageBox.Show(apartamentoTO.Mensagem);

            this.Close();
        }
    }
 }
