using SteelGymDesktop.Applications.Interfaces;
using SteelGymDesktop.Domain.Entities;
using System;
using System.Windows.Forms;

namespace SteelGymDesktop.View
{
    public partial class TrocarSenha : Form
    {
        private readonly IUserAppService _userApp;
        private readonly User _user;

        public TrocarSenha(IUserAppService userApp, User user)
        {
            _userApp = userApp;
            _user = user;
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Util.ValidaString(txtCurrentPassword.Text))
            {
                Util.ShowMessageWarning("Preencha o campo Senha Atual.");
                return;
            }

            if (!Util.ValidaString(txtNewPassword.Text))
            {
                Util.ShowMessageWarning("Preencha o campo Nova Senha.");
                return;
            }

            if (!txtCurrentPassword.Text.Equals(_user.Password))
            {
                Util.ShowMessageWarning("Campo 'Senha Atual' difere da senha salva.");
                return;
            }

            if (!Util.ValidaString(txtConfirmPassword.Text))
            {
                Util.ShowMessageWarning("Preencha o campo Confirmação da Senha.");
                return;
            }

            if (txtCurrentPassword.Text.Equals(txtNewPassword.Text))
            {
                Util.ShowMessageWarning("A nova senha não pode ser igual à anterior.");
                return;
            }

            if (!txtConfirmPassword.Text.Equals(txtNewPassword.Text))
            {
                Util.ShowMessageWarning("A nova senha e confirmação de senha estão diferentes.");
                return;
            }

            try
            {
                Util.DisabledCursor();

                _user.Password = txtNewPassword.Text;
                _user.FirstLogin = false;

                _userApp.Update(_user);

                Util.EnabledCursor();

                Util.ShowMessageWarning("Senha alterada com sucesso.");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning("Erro ao efetuar a troca de senha: " + ex.Message);
            }
        }
    }
}
