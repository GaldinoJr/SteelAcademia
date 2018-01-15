using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SteelGymDesktop.Applications.Interfaces;
using SteelGymDesktop.Domain.Entities;

namespace SteelGymDesktop.View
{
    public partial class PesquisaMovimentacao : Form
    {
        private IMovimentationAppService _MovimentacaoApp;

        public PesquisaMovimentacao(IMovimentationAppService movimentacaoApp)
        {
            _MovimentacaoApp = movimentacaoApp;
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            Util.DisabledCursor();

            try
            {
                dtgMovimentacoes.Rows.Clear();
                bool fgTodos = false;
                bool fgEntrada = false;
                if (rbEntrada.Checked == false && rbSaida.Checked == false)
                {
                    fgTodos = true;
                }
                else
                {
                    if (rbEntrada.Checked)
                    {
                        fgEntrada = true;
                    }
                }
                var movimentations = _MovimentacaoApp.GetByFilter(dtpDe.Value.Date, dtpAte.Value.Date, fgEntrada, fgTodos);
                Filter(movimentations);
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning(ex.Message);
            }

            Util.EnabledCursor();
        }

        private void Filter(IEnumerable<Movimentation> movimentations)
        {
            if (movimentations != null)
            {
                decimal totalValueEnter = 0;
                decimal totalValueExit = 0;
                decimal result = 0;
                foreach (var m in movimentations)
                {
                    dtgMovimentacoes.Rows.Add(m.MovimentationId, m.Origin, m.Value, (m.FgEntrada ? "Entrada" : "Saída"), m.DataMovimentacao);
                    if (m.FgEntrada)
                    {
                        totalValueEnter += m.Value;
                    }
                    else
                    {
                        totalValueExit += m.Value;
                    }
                }
                result = totalValueEnter - totalValueExit;
                lblTotalEntrada.Text = totalValueEnter.ToString();
                lblTotalSaida.Text = totalValueExit.ToString();
                lblResultado.Text = result.ToString();
            }
            else
                Util.ShowMessageWarning("Não foram encontradas movimentações com esses parametros.");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dtpDe.Text = "";
            dtpAte.Text = "";
            rbEntrada.Checked = false;
            rbSaida.Checked = false;
        }
        private void DtgMovimentacoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                var row = dtgMovimentacoes.Rows[index];

                showMovimentation(Convert.ToInt32(row.Cells[0].Value));
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning(ex.Message);
            }
        }

        private void showMovimentation(int idMovimentation)
        {
            CadastroMovimentacao p = new CadastroMovimentacao(_MovimentacaoApp, false, idMovimentation);
            p.ShowDialog();

            BtnPesquisar_Click(null, null);
        }
    }
}
