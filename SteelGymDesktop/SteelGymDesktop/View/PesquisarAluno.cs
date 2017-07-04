using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteelGymDesktop.View
{
    public partial class PesquisarAluno : Form
    {
        public PesquisarAluno()
        {
            InitializeComponent();
        }

        private void PesquisarAluno_Load(object sender, EventArgs e)
        {

        }

        private void txtIDAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Util.ValidaNumero(e);
        }

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Util.ValidaNumero(e);
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Util.ValidaNumero(e);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //dtgAlunos.DataSource = new DataView();

            dtgAlunos.Rows.Clear();

            for (int i = 0; i < 100; i++)
            {
                dtgAlunos.Rows.Add("", "", i.ToString(), "Teste " + i.ToString(), "12.345.678-" + i.ToString(), "123.456.789-0" + i.ToString(),
                    "Sim", "28/05/2017");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCPF.Text = "";
            txtIDAluno.Text = "";
            txtNome.Text = "";
            txtRG.Text = "";
            //dtgAlunos.DataSource = new DataView();
            dtgAlunos.Rows.Clear();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }
    }
}
