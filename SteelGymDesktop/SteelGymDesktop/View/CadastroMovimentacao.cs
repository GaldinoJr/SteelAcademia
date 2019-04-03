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
    public partial class CadastroMovimentacao : Form
    {
        private IMovimentationAppService _movimentationApp;
        private bool _isCreate;
        private int _movimentacaoId;
        private Movimentation _movimentation;
        public CadastroMovimentacao(IMovimentationAppService studentApp, bool isCreate, int movimentacaoId)
        {
            _movimentationApp = studentApp;
            this._isCreate = isCreate;
            this._movimentacaoId = movimentacaoId;
            InitializeComponent();
        }

        private void CadastroMovimentacao_Load(object sender, EventArgs e)
        {

            if (_movimentacaoId != int.MinValue)
            {
                LoadMovimentation(_movimentacaoId);
            }
            if (_isCreate)
            {
                btnSalvar.Visible = true;
                btnSalvar.Enabled = true;
                btnSalvar2.Visible = false;
                btnSalvar2.Enabled = false;
                btnCancel.Visible = false;
                btnCancel.Enabled = false;
            }
            else
            {

                btnSalvar.Visible = false;
                btnSalvar.Enabled = false;
                btnSalvar2.Visible = true;
                btnSalvar2.Enabled = true;
                btnCancel.Visible = true;
                btnCancel.Enabled = true;
            }
        }

        private void LoadMovimentation(int movimentacaoId)
        {
            try
            {
                _movimentation = _movimentationApp.GetById(movimentacaoId);
                txtDescricao.Text = _movimentation.Origin;
                txtValor.Text = _movimentation.Value.ToString();
                cboTipoPagamento.Text = _movimentation.tipoPagamento;
                dtpDataMovimentacao.Value = Convert.ToDateTime(_movimentation.DataMovimentacao);
                if(Convert.ToBoolean(_movimentation.FgEntrada))
                {
                    rbSaida.Checked = false;
                    rbEntrada.Checked = true;
                }
                else
                {
                    rbSaida.Checked = true;
                    rbEntrada.Checked = false;
                }
                DisableScreen();
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning(ex.Message);
            }

        }

        private void DisableScreen()
        {
            txtDescricao.Enabled =
            txtValor.Enabled =
            cboTipoPagamento.Enabled =
            dtpDataMovimentacao.Enabled =
            rbSaida.Enabled =
            rbEntrada.Enabled =
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
                    _movimentation = new Movimentation();
                _movimentation.Origin = txtDescricao.Text;
                _movimentation.Value = Convert.ToDecimal(txtValor.Text.ToString().Replace(",", ".").Replace(" ",""));
                _movimentation.tipoPagamento = cboTipoPagamento.Text;
                _movimentation.DataMovimentacao = dtpDataMovimentacao.Text;

                if (rbEntrada.Checked)
                    _movimentation.FgEntrada = 1;
                else
                    _movimentation.FgEntrada = 0;

                if (_isCreate)
                {
                    Util.DisabledCursor();

                    _movimentationApp.Add(_movimentation);
                    Util.ShowMessageWarning("Movimentação inserida com sucesso.");
                    Limpar();

                    Util.EnabledCursor();
                }
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning(ex.Message);
            }
        }

        private void Limpar()
        {
            txtDescricao.Text = "";
            txtValor.Text = "";
            cboTipoPagamento.Text = "";
            dtpDataMovimentacao.Text = "";
            rbSaida.Checked = true;
            rbEntrada.Checked = true;
        }

        private bool ValidateFields(out string msgError)
        {
            msgError = "";
            bool pass = true;
            if (!Util.ValidaString(txtDescricao.Text))
            {
                msgError += " - Campo 'Descrição' invalido.";
                pass = false;
                txtDescricao.Focus();
            }
            if (!Util.ValidaString(txtValor.Text))
            {
                msgError += " - Campo 'Valor R$' invalido.";
                if (pass)
                {
                    txtValor.Focus();
                }
                pass = false;
            }
            if (cboTipoPagamento.SelectedIndex == -1)
            {
                msgError += " - Campo 'Tipo de pagamento' invalido.";
                if (pass)
                {
                    cboTipoPagamento.Focus();
                }
                pass = false;
            }
            if (!Util.ValidaData(dtpDataMovimentacao.Value.Date))
            {
                msgError += " - Campo 'Data da movimentação' invalido.";
                if (pass)
                {
                    dtpDataMovimentacao.Focus();
                }
                pass = false;
            }
            if(rbEntrada.Checked == false && rbSaida.Checked == false)
            {
                msgError += " - Campo 'Tipo da movimentação' invalido.";
                if (pass)
                {
                    dtpDataMovimentacao.Focus();
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

        private void btnSalvar2_Click(object sender, EventArgs e)
        {
            BtnSalvar_Click(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
