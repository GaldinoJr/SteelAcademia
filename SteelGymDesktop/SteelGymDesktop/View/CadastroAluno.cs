using SteelGymDesktop.Applications.Interfaces;
using SteelGymDesktop.Domain.Entities;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace SteelGymDesktop.View
{
    public partial class CadastroAluno : Form
    {
        private readonly IStudentAppService _studentApp;
        private readonly bool _isCreate;
        private readonly int _studentId;
        private Student _student;
        private bool isMenor;
        public CadastroAluno(IStudentAppService studentApp, bool isCreate, int studentId)
        {
            _studentApp = studentApp;
            _studentId = studentId;
            _isCreate = isCreate;
            InitializeComponent();
        }

        private void CadastrarAluno_Load(object sender, EventArgs e)
        {
            chkAtivo.Checked = true;

            if (_studentId != int.MinValue)
            {
                LoadStudent(_studentId);
                HabilityResponsibleData();
            }
            else
            {
                InitWithAdultAge();
            }
        }
        
        private void InitWithAdultAge()
        {
            DateTime initialDate = DateTime.Today;
            int year = initialDate.Year - 18;
            DateTime upDate = new DateTime(year, initialDate.Month, initialDate.Day);
            dtpNascimento.Text = upDate.ToString("dd/MM/yyyy");
        }

        

        private void HabilityResponsibleData()
        {
            if(Util.IsMinor(dtpNascimento.Value.Date))
            {
                isMenor = true;
            }
            else
            {
                isMenor = false;
            }
            gbMenor.Visible = isMenor;
        }

        private void LoadStudent(int studentId)
        {
            try
            {
                _student = _studentApp.GetById(studentId);

                txtIDAluno.Text = _student.StudentId.ToString();
                txtNome.Text = _student.Name;
                cboEstadoCivil.Text = _student.CivilStatus;
                txtCPF.Text = _student.CPF;
                cboPeriodicidadeAvaliacao.Text = _student.EvaluationPeriodicity.ToString();
                dtpNascimento.Value = (DateTime)_student.BirthDate;
                dtpAvaliacao.Value = (DateTime)_student.EvaliationDate;
                txtEmail.Text = _student.Email;
                cboSexo.Text = _student.Sex;
                txtRG.Text = _student.RG;
                txtIMC.Text = _student.IMC.ToString();
                chkAtivo.Checked = _student.Active;
                txtEndereco.Text = _student.Address;
                txtNumero.Text = _student.Number.ToString();
                txtComplemento.Text = _student.Complement;
                txtBairro.Text = _student.Neighborhood;
                txtCidade.Text = _student.City;
                cboUF.Text = _student.UF;
                txtCEP.Text = _student.CEP;
                txtTel1.Text = _student.Phone1;
                txtTel2.Text = _student.Phone2;
                txtNomeParentesco1.Text = _student.RelativeName1;
                txtNomeParentesco2.Text = _student.RelativeName2;
                txtNomeParentesco3.Text = _student.RelativeName3;
                cboParentesco1.Text = _student.RelativeDegree1;
                cboParentesco2.Text = _student.RelativeDegree2;
                cboParentesco3.Text = _student.RelativeDegree3;
                txtResponsavel.Text = _student.ResponsibleName;
                cboRespomsavel.Text = _student.ResponsibleDegree;
                txtEnderecoResp.Text = _student.ResponsibleAddress;
                txtNumeroResp.Text = _student.ResponsibleNumber.ToString();
                txtComplementoResp.Text =_student.ResponsibleComplement;
                txtCidadeResp.Text = _student.ResponsibleCity;
                txtBairroResp.Text = _student.ResponsibleNeighborhood;
                cboUFRep.Text = _student.ResponsibleUF;
                txtCEPResp.Text = _student.ResponsibleCEP;
                txtTelResp1.Text = _student.ResponsiblePhone1;
                txtTelResp2.Text = _student.ResponsiblePhone2;
                cboDiaPagamento.Text =_student.PayDay.ToString();
                txtMensalidade.Text = _student.PaymentAmount.ToString();

                txtIDAluno.Enabled = false;
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning(ex.Message);
            }
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
                    _student = new Student();

                _student.Name = txtNome.Text;
                _student.CivilStatus = cboEstadoCivil.Text;
                _student.CPF = txtCPF.Text;
                _student.BirthDate = Convert.ToDateTime(dtpNascimento.Text);
                _student.EvaliationDate = Convert.ToDateTime(dtpAvaliacao.Text);
                _student.EvaluationPeriodicity = Convert.ToInt32(cboPeriodicidadeAvaliacao.Text);
                _student.PayDay = Convert.ToInt32(cboDiaPagamento.Text);
                if (Util.ValidaString(txtMensalidade.Text))
                {
                    _student.PaymentAmount = Convert.ToDecimal(txtMensalidade.Text.ToString().Replace(",","."));
                }
                _student.Email = txtEmail.Text;
                _student.Sex = cboSexo.Text;
                _student.RG = txtRG.Text;
                if (Util.ValidaString(txtIMC.Text))
                {
                    _student.IMC = Convert.ToDecimal(txtIMC.Text);
                }
                _student.Active = chkAtivo.Checked;
                _student.Address = txtEndereco.Text;
                if (Util.ValidaString(txtNumero.Text))
                {
                    _student.Number = Convert.ToInt32(txtNumero.Text);
                }
                _student.Complement = txtComplemento.Text;
                _student.Neighborhood = txtBairro.Text;
                _student.City = txtCidade.Text;
                _student.UF = cboUF.Text;
                _student.CEP = txtCEP.Text;
                _student.Phone1 = txtTel1.Text;
                _student.Phone2 = txtTel2.Text;
                _student.RelativeName1 = txtNomeParentesco1.Text;
                _student.RelativeName2 = txtNomeParentesco2.Text;
                _student.RelativeName3 = txtNomeParentesco3.Text;
                _student.RelativeDegree1 = cboParentesco1.Text;
                _student.RelativeDegree2 = cboParentesco2.Text;
                _student.RelativeDegree3 = cboParentesco3.Text;
                _student.ResponsibleName = txtResponsavel.Text;
                _student.ResponsibleDegree = cboRespomsavel.Text;
                _student.ResponsibleAddress = txtEnderecoResp.Text;
                if (Util.ValidaString(txtNumeroResp.Text))
                {
                    _student.ResponsibleNumber = Convert.ToInt32(txtNumeroResp.Text);
                }
                _student.ResponsibleComplement = txtComplementoResp.Text;
                _student.ResponsibleNeighborhood = txtBairroResp.Text;
                _student.ResponsibleCity = txtCidadeResp.Text;
                _student.ResponsibleUF = cboUFRep.Text;
                _student.ResponsibleCEP = txtCEPResp.Text;
                _student.ResponsiblePhone1 = txtTelResp1.Text;
                _student.ResponsiblePhone2 = txtTelResp2.Text;

                if (_isCreate)
                {
                    Util.DisabledCursor();

                    _studentApp.Add(_student);
                    Util.ShowMessageWarning("Aluno criado com sucesso.");
                    Limpar();

                    Util.EnabledCursor();
                }
                else
                {
                    Util.DisabledCursor();

                    _student.StudentId = Convert.ToInt32(txtIDAluno.Text);
                    _studentApp.Update(_student);
                    Util.ShowMessageWarning("Aluno alterado com sucesso.");

                    Util.EnabledCursor();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning(ex.Message);
            }
        }

        private bool ValidateFields(out string msgError)
        {
            msgError = "";
            bool pass = true;
            if (!Util.ValidaString(txtNome.Text))
            {
                msgError += " - Campo 'Nome' invalido.";
                pass = false;
                txtNome.Focus();
            }
            if (!Util.ValidaData(dtpNascimento.Value.Date))
            {
                msgError += " - Campo 'Data de nascimento' invalido.";
                if (pass)
                {
                    dtpNascimento.Focus();
                }
                pass = false;
            }
            if(!Util.ValidaRg(txtRG.Text))
            {
                msgError += " - Campo 'RG' invalido.";
                if (pass)
                {
                    txtRG.Focus();
                }
                pass = false;
            }
            if (!Util.ValidaCpf(txtCPF.Text))
            {
                msgError += " - Campo 'CPF' invalido.";
                if (pass)
                {
                    txtCPF.Focus();
                }
                pass = false;
            }
            if(cboSexo.SelectedIndex == -1)
            {
                msgError += " - Campo 'Sexo' não selecionado.";
                if (pass)
                {
                    cboSexo.Focus();
                }
                pass = false;
            }
            if (cboDiaPagamento.SelectedIndex == -1)
            {
                msgError += " - Campo 'Data de pagamento' invalido.";
                if (pass)
                {
                    cboDiaPagamento.Focus();
                }
                pass = false;
            }
            if (!Util.ValidaString(txtMensalidade.Text))
            {
                msgError += " - Campo 'Mensalidade R$' invalido.";
                if (pass)
                {
                    txtCPF.Focus();
                }
                pass = false;
            }
            if (!Util.ValidaString(dtpAvaliacao.Text))
            {
                msgError += " - Campo 'Data de avaliação' invalido.";
                if (pass)
                {
                    dtpAvaliacao.Focus();
                }
                pass = false;
            }
            if (cboPeriodicidadeAvaliacao.SelectedIndex == -1)
            {
                msgError += " - Campo 'Periodicidade' invalido.";
                if (pass)
                {
                    cboPeriodicidadeAvaliacao.Focus();
                }
                pass = false;
            }
            //E caso o aluno seja menor, eu Obrigo o nome e o grau de parentesco 
            if (isMenor)
            {
                if(!Util.ValidaString(txtResponsavel.Text))
                {
                    msgError += " - Campo 'Nome do responsável' invalido.";
                    if (pass)
                    {
                        txtResponsavel.Focus();
                    }
                    pass = false;
                }
                if(cboRespomsavel.SelectedIndex == -1)
                {
                    msgError += " - Campo 'Parentesco do responsável' não selecionado.";
                    if (pass)
                    {
                        cboRespomsavel.Focus();
                    }
                    pass = false;
                }
                if(!Util.ValidaTelefone(txtTelResp1.Text))
                {
                    msgError += " - Campo 'Telefone do responsável' invalido.";
                    if (pass)
                    {
                        txtTelResp1.Focus();
                    }
                    pass = false;
                }
            }
           
            return pass;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void TxtIMC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Util.ValidaNumero(e);
        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Util.ValidaNumero(e);
        }

        private void TxtNumeroResp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Util.ValidaNumero(e);
        }

        private void Limpar()
        {
            txtNome.Text = "";
            cboEstadoCivil.Text = "";
            txtCPF.Text = "";
            dtpNascimento.Text = "";
            dtpAvaliacao.Text = "";
            txtEmail.Text = "";
            cboSexo.Text = "";
            txtRG.Text = "";
            txtIMC.Text = "";
            chkAtivo.Checked = true;
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            cboUF.Text = "";
            txtCEP.Text = "";
            txtTel1.Text = "";
            txtTel2.Text = "";
            txtNomeParentesco1.Text = "";
            txtNomeParentesco2.Text = "";
            txtNomeParentesco3.Text = "";
            cboParentesco1.Text = "";
            cboParentesco2.Text = "";
            cboParentesco3.Text = "";
            txtBairroResp.Text = "";
            txtResponsavel.Text = "";
            cboRespomsavel.Text = "";
            txtEnderecoResp.Text = "";
            txtNumeroResp.Text = "";
            txtComplementoResp.Text = "";
            txtCidadeResp.Text = "";
            cboUFRep.Text = "";
            txtCEPResp.Text = "";
            txtTelResp1.Text = "";
            txtTelResp2.Text = "";
            txtProfissao.Text = "";
            txtMensalidade.Text = "";
            cboDiaPagamento.Text ="";
            cboPeriodicidadeAvaliacao.Text = "";
            HabilityResponsibleData();
        }

        private void DtpNascimento_ValueChanged(object sender, EventArgs e)
        {
            HabilityResponsibleData();
        }
    }
}
