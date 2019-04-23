﻿using System;
using System.Windows.Forms;
using SteelGymDesktop.Applications.Interfaces;
using SteelGymDesktop.Domain.Entities;
using System.Collections.Generic;
using SteelGymDesktop.Models;
using System.Globalization;
using System.Drawing.Printing;
using System.Drawing;

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

        private PrintDocument printDocument1 = new PrintDocument();

        public ImprimePagamento(
            IPaymentAppService paymentApp,
            IStudentAppService studentApp,
            bool isCreate, 
            int pagamentoId
        )
        {
            _paymentApp = paymentApp;
            _studentApp = studentApp;

            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            this._isCreate = isCreate;
            this._pagamentoId = pagamentoId;
            InitializeComponent();
        }

        private void ImprimePagamento_Load(object sender, EventArgs e)
        {
            LoadPayment(_pagamentoId);
        }

        private void LoadPayment(int pagamentoId)
        {
            try
            {
                _payment = _paymentApp.GetById(pagamentoId);
                var student = _studentApp.GetById(_payment.StudentId);

                txtValor.Text = _payment.Value.ToString("C2");

                txtPagamento.Text = Convert.ToDateTime(
                    _payment.DataPagamento
                ).ToString("dd/MM/yyyy");


                txtAluno.Text = student.Name;
                txtMatricula.Text = student.StudentId.ToString();

                txtVencimento.Text = "Dia " + student.PayDay.ToString();

                while (txtMatricula.Text.Length < 4)
                {
                    txtMatricula.Text = "0" + txtMatricula.Text;
                }

                txtMatricula.Text = "#" + txtMatricula.Text;
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning(ex.Message);
            }

        }

        private void btnComprovante_Click(object sender, EventArgs e)
        {

            CaptureScreen();
            printDocument1.Print();
        }

        Bitmap memoryImage;

        private void CaptureScreen()
        {

            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            s.Width = s.Width - 40;
            s.Height = s.Height- 85;

            float mmpi = 25.4f;
            int dpi = 150;
            memoryImage = new Bitmap((int)(342 / mmpi * dpi), (int)(210 / mmpi * dpi));
            memoryImage.SetResolution(dpi, dpi);

            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X + 8, this.Location.Y + 32, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender,
               System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }


    }
}