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
    public partial class frmMoradorVisualizar : Form
    {
        public frmMoradorVisualizar(int idMorador)
        {
            InitializeComponent();
            PreencherCampos(idMorador);
        }

        private void BloquearCampos()
        {
            txtVisualizaNomeMor.ReadOnly = true;
            txtVisualizaCelularMor.ReadOnly = true;
            txtVisualizaCpfMor.ReadOnly = true;
            txtVisualizaEmailMor.ReadOnly = true;
            txtVisualizaRgMor.ReadOnly = true;
            txtVisualizaTelefoneMor.ReadOnly = true;
        }

        private void frmMoradorVisualizar_Load(object sender, EventArgs e)
        {
            BloquearCampos();
        }

        private void PreencherCampos(int id)
        {
            MoradorTO moradorTO = new MoradorTO();

            moradorTO = MoradorService.Obter(id);

            if (!moradorTO.Valido)
            {
                MessageBox.Show(moradorTO.Mensagem, "Atenção");
                this.Close();
            }

            txtVisualizaNomeMor.Text = moradorTO.Nome;
            txtVisualizaCelularMor.Text = moradorTO.Celular;
            txtVisualizaCpfMor.Text = moradorTO.CPF;
            txtVisualizaEmailMor.Text = moradorTO.Email;
            txtVisualizaRgMor.Text = moradorTO.RG;
            txtVisualizaTelefoneMor.Text = moradorTO.Telefone;

            lblCodigoMorador.Text = moradorTO.Identificador.ToString();
        }
    }
}
