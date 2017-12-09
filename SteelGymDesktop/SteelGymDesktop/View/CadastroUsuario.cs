using SteelGymDesktop.Applications.Interfaces;
using SteelGymDesktop.Domain.Entities;
using System;
using System.Windows.Forms;

namespace SteelGymDesktop.View
{
    public partial class CadastroUsuario : Form
    {
        private readonly IUserAppService _userApp;
        private readonly bool _isCreate;
        private readonly int _userId;
        private User _user;

        public CadastroUsuario(IUserAppService userApp, bool isCreate, int userId)
        {
            _userApp = userApp;
            _isCreate = isCreate;
            _userId = userId;

            InitializeComponent();
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            chkAtivo.Checked = true;

            if(_userId != int.MinValue)
                LoadUser(_userId);

            if (Program.SessionUser.Admin)
                chkCanAccessFinancial.Visible = true;
        }

        private void LoadUser(int userId)
        {
            try
            {
                _user = _userApp.GetById(userId);

                txtNome.Text = _user.Name;
                txtSobrenome.Text = _user.LastName;
                txtRG.Text = _user.RG;
                txtCPF.Text = _user.CPF;
                txtEmail.Text = _user.Email;
                txtEndereco.Text = _user.Address;
                txtNumero.Text = _user.Number.ToString();
                txtComplemento.Text = _user.Complement;
                txtBairro.Text = _user.Neighborhood;
                txtCidade.Text = _user.City;
                cboUF.Text = _user.UF;
                txtCEP.Text = _user.CEP;
                txtTel1.Text = _user.Phone1;
                txtTel2.Text = _user.Phone2;
                txtUserName.Text = _user.UserName;
                chkAtivo.Checked = _user.Active;
                txtUsuario.Text = _user.UserId.ToString();

                if(Program.SessionUser.Admin)
                    chkCanAccessFinancial.Checked = _user.CanAccessFinancial;

                txtUserName.Enabled = false;
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning(ex.Message);
            }
        }

        private void BtnSalvar_Click(object sender, System.EventArgs e)
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
                    _user = new User();

                _user.Name = txtNome.Text;
                _user.LastName = txtSobrenome.Text;
                _user.RG = txtRG.Text;
                _user.CPF = txtCPF.Text;
                _user.Email = txtEmail.Text;
                _user.Address = txtEndereco.Text;
                if(Util.ValidaString(txtNumero.Text))
                    _user.Number = Convert.ToInt32(txtNumero.Text);
                _user.Complement = txtComplemento.Text;
                _user.Neighborhood = txtBairro.Text;
                _user.City = txtCidade.Text;
                _user.UF = cboUF.Text;
                _user.CEP = txtCEP.Text;
                _user.Phone1 = txtTel1.Text;
                _user.Phone2 = txtTel2.Text;
                _user.UserName = txtUserName.Text;
                _user.Active = chkAtivo.Checked;

                if(Program.SessionUser.Admin)
                    _user.CanAccessFinancial = chkCanAccessFinancial.Checked;

                if (_isCreate)
                {
                    Util.DisabledCursor();

                    string password = GeneratePassword(txtUserName.Text);
                    _user.Password = password;

                    _userApp.Add(_user);
                    Util.ShowMessageWarning("Usuário criado com sucesso. Senha: " + password);
                    Limpar();

                    Util.EnabledCursor();
                }
                else
                {
                    Util.DisabledCursor();

                    _user.UserId = Convert.ToInt32(txtUsuario.Text);
                    _userApp.Update(_user);
                    Util.ShowMessageWarning("Usuário alterado com sucesso.");

                    Util.EnabledCursor();

                    this.Close();
                }
            }
            catch (Exception ex )
            {
                Util.ShowMessageWarning(ex.Message);
            }
        }

        private bool ValidateFields(out string msgError)
        {
            msgError = "";
            bool pass = true;

            if (!Util.ValidaStringSemEspaco(txtUserName.Text))
            {
                msgError += " - Campo 'Nome de Usuário' invalido.";
                txtUserName.Focus();
                pass = false;
            }
            if (!Util.ValidaString(txtNome.Text))
            {
                msgError += " - Campo 'Nome' invalido."; 
                if (pass)
                {
                    txtNome.Focus();
                }
                pass = false;
            }

            if (Util.ValidaRg(txtRG.Text.Replace(",", ".")))
            {
                msgError += " - Campo 'RG' invalido.";
                if(pass)
                {
                    txtRG.Focus();
                }
                pass = false;
            }

            if (Util.ValidaCpf(txtCPF.Text.Replace(",", ".")))
            {
                msgError += " - Campo 'CPF' invalido.";
                if (pass)
                {
                    txtCPF.Focus();
                }
                pass = false;
            }

            if (!Util.ValidaString(txtEmail.Text))
            {
                msgError += " - Campo 'e-Mail' invalido.";
                if (pass)
                {
                    txtEmail.Focus();
                }
                pass = false;
            }

            return pass;
        }

        private void Limpar()
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtRG.Text = "";
            txtCPF.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtCEP.Text = "";
            txtTel1.Text = "";
            txtTel2.Text = "";
            txtUserName.Text = "";
            cboUF.SelectedIndex = 0;
        }

        private string GeneratePassword(string name)
        {
            Random r = new Random();
            int number = r.Next(999);

            return name.ToLower() + "@" + number;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
