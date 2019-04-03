using System;
using System.Windows.Forms;
using SteelGymDesktop.Applications.Interfaces;
using SteelGymDesktop.Domain.Entities;
using System.Collections.Generic;
using SteelGymDesktop.Models;

namespace SteelGymDesktop.View
{
    public partial class CadastroPagamento : Form
    {
        private readonly IStudentAppService _studentApp;
        private readonly IPaymentAppService _paymentApp;
        private bool _isCreate;
        private int _pagamentoId;
        private Payment _payment;
        public IEnumerable<Student> students;

        public CadastroPagamento(
            IPaymentAppService paymentApp,
            IStudentAppService studentApp,
            bool isCreate, 
            int pagamentoId
        )
        {
            _paymentApp = paymentApp;
            _studentApp = studentApp;

           
            this._isCreate = isCreate;
            this._pagamentoId = pagamentoId;
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

        private void CadastroPagamento_Load(object sender, EventArgs e)
        {
            if (_pagamentoId != int.MinValue)
            {
                LoadPayment(_pagamentoId);
            }
            if(_isCreate)
            {
                btnSalvar.Visible = true;
                btnSalvar.Enabled = true;
                btnSalvar2.Visible = false;
                btnSalvar2.Enabled = false;
                btnCancel.Visible = false;
                btnCancel.Enabled = false;
            } else
            {

                btnSalvar.Visible = false;
                btnSalvar.Enabled = false;
                btnSalvar2.Visible = true;
                btnSalvar2.Enabled = true;
                btnCancel.Visible = true;
                btnCancel.Enabled = true;
            }
        }

        private void LoadPayment(int pagamentoId)
        {
            try
            {

                PaymentId.Text = pagamentoId.ToString();
                _payment = _paymentApp.GetById(pagamentoId);
                txtValor.Text = _payment.Value.ToString();
                var students = _studentApp.GetAllActive();
                cboAlunos.Items.Clear();
                if (students != null)
                {
                    int index = 0;
                    foreach (var student in students)
                    {
                        cboAlunos.Items.Add(new ComboItem(student.Name, student.StudentId));

                        if (_payment.StudentId.ToString() == student.StudentId.ToString())
                        {
                            cboAlunos.SelectedIndex = index;
                        }

                        index++;
                    }
                }
                
                dtpDataPagamento.Value = Convert.ToDateTime(_payment.DataPagamento);
                if(Convert.ToBoolean(_payment.FgPago))
                {
                    rbNaoPago.Checked = false;
                    rbPago.Checked = true;
                }
                else
                {
                    rbNaoPago.Checked = true;
                    rbPago.Checked = false;
                }
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning(ex.Message);
            }

        }

        private void DisableScreen()
        {
            txtValor.Enabled =
            cboAlunos.Enabled =
            dtpDataPagamento.Enabled =
            rbNaoPago.Enabled =
            rbPago.Enabled =
            btnSalvar.Enabled = false;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string msgError = "";

                if (!ValidateFields(out msgError))
                {
                    Util.ShowMessageWarning(msgError);
                    return;
                }
                if (_isCreate)
                {
                    _payment = new Payment();
                }

                _payment.Value = Convert.ToDecimal(txtValor.Text.ToString().Replace(",", ".").Replace(" ",""));
                _payment.StudentId = (int) ((ComboItem)cboAlunos.SelectedItem).Value;
                _payment.DataPagamento = dtpDataPagamento.Text;

                if (rbPago.Checked)
                    _payment.FgPago = 1;
                else
                    _payment.FgPago = 0;

                if (_isCreate)
                {
                    Util.DisabledCursor();

                    _paymentApp.Add(_payment);
                    Util.ShowMessageWarning("Pagamento inserido com sucesso.");
                    Limpar();

                    Util.EnabledCursor();
                }
                else
                {
                    Util.DisabledCursor();

                    _payment.PaymentId = Convert.ToInt32(PaymentId.Text);
                    _paymentApp.Update(_payment);
                    Util.ShowMessageWarning("Pagamento alterado com sucesso.");

                    Util.EnabledCursor();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning(ex.Message);
            }
        }

        private void Limpar()
        {
            txtValor.Text = "";
            cboAlunos.Text = "";
            dtpDataPagamento.Text = "";
            rbNaoPago.Checked = true;
            rbPago.Checked = true;
        }

        private bool ValidateFields(out string msgError)
        {
            msgError = "";
            bool pass = true;
            if (!Util.ValidaString(txtValor.Text))
            {
                msgError += " - Campo 'Valor R$' invalido.";
                if (pass)
                {
                    txtValor.Focus();
                }
                pass = false;
            }
            if (cboAlunos.SelectedIndex == -1)
            {
                msgError += " - Campo 'Aluno' invalido.";
                if (pass)
                {
                    cboAlunos.Focus();
                }
                pass = false;
            }
            if (!Util.ValidaData(dtpDataPagamento.Value.Date))
            {
                msgError += " - Campo 'Data do Pagamento' invalido.";
                if (pass)
                {
                    dtpDataPagamento.Focus();
                }
                pass = false;
            }
            if(rbPago.Checked == false && rbNaoPago.Checked == false)
            {
                msgError += " - Campo 'Pago?' invalido.";
                if (pass)
                {
                    dtpDataPagamento.Focus();
                }
                pass = false;
            }
            return pass;
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            if ((e.KeyChar == ',') && (((MaskedTextBox)sender).Text.IndexOf(',') > -1))
                e.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BtnSalvar_Click(sender, e);
        }
    }
}
