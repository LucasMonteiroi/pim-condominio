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
    public partial class frmPorteiroVisualizarColaborador : Form
    {
        public frmPorteiroVisualizarColaborador()
        {
            InitializeComponent();
        }

        private void btnFecharVisualizacaoColab_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
