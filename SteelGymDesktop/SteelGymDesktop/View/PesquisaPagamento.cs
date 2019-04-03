using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SteelGymDesktop.Applications.Interfaces;
using SteelGymDesktop.Domain.Entities;

namespace SteelGymDesktop.View
{
    public partial class PesquisaPagamento : Form
    {
        private IPaymentAppService _PaymentApp;

        public PesquisaPagamento(IPaymentAppService paymentApp)
        {
            _PaymentApp = paymentApp;
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            //Util.DisabledCursor();

            //try
            //{
            //    dtgPagamentos.Rows.Clear();
            //    bool fgTodos = false;
            //    bool fgEntrada = false;

            //    if (rbPago.Checked == false && rbNaoPago.Checked == false)
            //    {
            //        fgTodos = true;
            //    }
            //    else
            //    {
            //        if (rbPago.Checked)
            //            fgEntrada = true;
            //    }

            //    var movimentations = _MovimentacaoApp.GetByFilter(dtpDe.Value.Date, dtpAte.Value.Date, fgEntrada, fgTodos);
            //    Filter(movimentations);
            //}
            //catch (Exception ex)
            //{
            //    Util.ShowMessageWarning(ex.Message);
            //}

            //Util.EnabledCursor();
        }

        private void Filter(IEnumerable<Movimentation> movimentations)
        {
            //if (movimentations != null)
            //{
            //    decimal totalValueEnter = 0;
            //    decimal totalValueExit = 0;
            //    decimal result = 0;

            //    foreach (var m in movimentations)
            //    {
            //        dtgPagamentos.Rows.Add(
            //            m.MovimentationId,
            //            m.Origin,
            //            m.Value,
            //            m.tipoPagamento,
            //            (Convert.ToBoolean(m.FgEntrada) ? "Entrada" : "Saída"),
            //            m.DataMovimentacao
            //        );

            //        if (Convert.ToBoolean(m.FgEntrada))
            //        {
            //            totalValueEnter += m.Value;
            //        }
            //        else
            //        {
            //            totalValueExit += m.Value;
            //        }
            //    }

            //    result = totalValueEnter - totalValueExit;
            //    lblTotalEntrada.Text = totalValueEnter.ToString();
            //    lblTotalSaida.Text = totalValueExit.ToString();
            //    lblResultado.Text = result.ToString();
            //}
            //else
            //{
            //    Util.ShowMessageWarning("Não foram encontradas movimentações com esses parametros.");
            //}
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dtpDe.Text = "";
            dtpAte.Text = "";
            rbPago.Checked = false;
            rbNaoPago.Checked = false;
        }

        private void DtgPagamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                var row = dtgPagamentos.Rows[index];

                showMovimentation(Convert.ToInt32(row.Cells[0].Value));
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning(ex.Message);
            }
        }

        private void showMovimentation(int idMovimentation)
        {
            //    CadastroMovimentacao p = new CadastroMovimentacao(_MovimentacaoApp, false, idMovimentation);
            //    p.ShowDialog();

            //    BtnPesquisar_Click(null, null);
        }

    private void dtgPagamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
