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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Util.DisabledCursor();

            try
            {
                dtgMovimentacoes.Rows.Clear();
                bool fgTodos = false;
                bool fgEntrada = false;
                if(rbEntrada.Checked == false && rbEntrada.Checked == false)
                {
                    fgTodos = true;
                }
                else
                {
                    if(rbEntrada.Checked)
                    {
                        fgEntrada = true;
                    }
                }
                var movimentations = _MovimentacaoApp.GetByFilter(dtpDe.Value, dtpAte.Value, fgEntrada, fgTodos);
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
                foreach (var m in movimentations)
                {
                    dtgMovimentacoes.Rows.Add(m.MovimentationId, m.Origin, m.Value, (m.FgEntrada ? "Entrada" : "Saída"), m.DataMovimentacao);
                }
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
    }
}
