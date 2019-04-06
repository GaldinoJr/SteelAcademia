using System;
using System.Windows.Forms;
using SteelGymDesktop.Applications.Interfaces;
using SteelGymDesktop.Domain.Entities;
using System.Collections.Generic;
using SteelGymDesktop.Models;
using System.Globalization;

namespace SteelGymDesktop.View
{
    public partial class ImprimePagamento : Form
    {
        private readonly IStudentAppService _studentApp;
        private readonly IPaymentAppService _paymentApp;
        private bool _isCreate;
        private int _pagamentoId;
        private Payment _payment;
        public IEnumerable<Student> students;

        public ImprimePagamento(
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

        private void ImprimePagamento_Load(object sender, EventArgs e)
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
                btnSalvar2.Visible = _payment.FgPago != 1;
                btnSalvar2.Enabled = _payment.FgPago != 1;
                btnCancel.Visible = true;
                btnCancel.Enabled = true;

                btnComprovante.Visible = _payment.FgPago == 1;
                btnComprovante.Enabled = _payment.FgPago == 1;


                cboAlunos.Enabled = false;
                txtValor.Enabled = false;
                dtpDataPagamento.Enabled = false;
                rbNaoPago.Enabled = rbPago.Enabled = _payment.FgPago != 1;
            }
        }

        private void LoadPayment(int pagamentoId)
        {
            try
            {
                _payment = _paymentApp.GetById(pagamentoId);
                var student = _studentApp.GetById(_payment.StudentId);

                //txtValue = _payment.Value.ToString();
                //dtpDataPagamento.Value = Convert.ToDateTime(_payment.DataPagamento);
                //txtStudent = student.Name;
                //txtMatricula = student.StudentId;
                //while("".Length < 4)
                //{
                //    txtMatricula = "0" + txtMatricula;
                //}
                //txtPayDay = student.PayDay;
            
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning(ex.Message);
            }

        }

        private void btnComprovante_Click(object sender, EventArgs e)
        {

        }
    }
}
