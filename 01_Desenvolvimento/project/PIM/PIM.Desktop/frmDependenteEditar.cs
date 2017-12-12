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
    public partial class frmDependenteEditar : Form
    {
        public frmDependenteEditar(int id)
        {
            InitializeComponent();
            PreencherCampos(id);
        }

        private void btnCancelarEdicaoDep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreencherCampos(int id)
        {
            DependenteTO dependenteTO = new DependenteTO();

            dependenteTO = DependenteService.Obter(id);

            if (!dependenteTO.Valido)
            {
                MessageBox.Show(dependenteTO.Mensagem, "Atenção");
                this.Close();
            }

            txtEditarNomeDep.Text = dependenteTO.Nome;
            txtEditarRgDep.Text = dependenteTO.RG;
            txtEditarTelefoneDep.Text = dependenteTO.Telefone;
            cboEditarGrauParentesco.SelectedItem = dependenteTO.GrauParentesco;
            txtEditarMoradorResp.Text = Convert.ToString(dependenteTO.IdMorador);
            lblEditarCodigoDep.Text = dependenteTO.Identificador.ToString();
        }

        private void btnSalvarEdicaoDep_Click(object sender, EventArgs e)
        {
            DependenteTO dependenteTO = new DependenteTO();

            dependenteTO.Nome = txtEditarNomeDep.Text;
            dependenteTO.Identificador = Convert.ToInt32(lblEditarCodigoDep.Text);
            dependenteTO.RG = txtEditarRgDep.Text;
            dependenteTO.Telefone = txtEditarTelefoneDep.Text;
            dependenteTO.IdMorador = Convert.ToInt32(txtEditarMoradorResp.Text);
            DependenteService.Atualizar(dependenteTO);

            if (!dependenteTO.Valido)
                MessageBox.Show(dependenteTO.Mensagem);

            this.Close();
        }
    }
}
