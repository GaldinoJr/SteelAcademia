using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SteelGymDesktop.Applications.Interfaces;
using SteelGymDesktop.Domain.Entities;
using SteelGymDesktop.Models;

namespace SteelGymDesktop.View
{
    public partial class PesquisaPagamento : Form
    {
        private readonly IStudentAppService _studentApp;
        private readonly IPaymentAppService _PaymentApp;
        public IEnumerable<Student> students;

        public PesquisaPagamento(IPaymentAppService paymentApp, IStudentAppService studentApp)
        {
            _PaymentApp = paymentApp;
            _studentApp = studentApp;

            InitializeComponent();

            var students = _studentApp.GetAllActive();
            cboAlunos.Items.Clear();
            if (students != null)
            {
                foreach (var student in students)
                {
                    cboAlunos.Items.Add(new ComboItem(student.Name, student.StudentId));
                }
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            Util.DisabledCursor();

            try
            {
                dtgPagamentos.Rows.Clear();
                bool fgTodos = false;
                bool fgPago = false;

                if (rbPago.Checked == false && rbNaoPago.Checked == false)
                {
                    fgTodos = true;
                }
                else
                {
                    if (rbPago.Checked)
                    {
                        fgPago = true;
                    }
                }

                int? StudentId = null;
                if (cboAlunos.SelectedItem != null)
                {
                    StudentId = (int)((ComboItem)cboAlunos.SelectedItem).Value;
                }

                var payments = _PaymentApp.GetByFilter(dtpDe.Value.Date, dtpAte.Value.Date, StudentId, fgPago, fgTodos);

                Filter(payments);
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning(ex.Message);
            }

            Util.EnabledCursor();
        }

        private void Filter(IEnumerable<Tuple<Payment, Student>> payments)
        {
            if (payments != null)
            {
                foreach (var m in payments)
                {
                    dtgPagamentos.Rows.Add(
                        m.Item1.PaymentId,
                        m.Item2.Name,
                        m.Item1.Value,
                        (Convert.ToBoolean(m.Item1.FgPago) ? "Pago" : "Não Pago"),
                        m.Item1.DataPagamento
                    );
                }
            }
            else
            {
                Util.ShowMessageWarning("Não foram encontrados pagamentos com esses parametros.");
            }
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

                showPagamento(Convert.ToInt32(row.Cells[0].Value));
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning(ex.Message);
            }
        }

        private void showPagamento(int idMovimentation)
        {
            CadastroPagamento p = new CadastroPagamento(_PaymentApp, _studentApp, false, idMovimentation);
            p.ShowDialog();
            BtnPesquisar_Click(null, null);
        }

        private void dtgPagamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
