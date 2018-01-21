using SteelGymDesktop.Applications.Interfaces;
using System;
using System.Windows.Forms;

namespace SteelGymDesktop.View
{
    public partial class Login : Form
    {
        private readonly IUserAppService _userApp;

        public Login(IUserAppService userApp)
        {
            _userApp = userApp;
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!Util.ValidaString(txtUser.Text))
            {
                Util.ShowMessageWarning("Preencha o campo Usuário.");
                return;
            }

            if (!Util.ValidaString(txtPassword.Text))
            {
                Util.ShowMessageWarning("Preencha o campo Senha.");
                return;
            }

            try
            {
                Util.DisabledCursor();

                var user = _userApp.Login(txtUser.Text, txtPassword.Text);

                Util.EnabledCursor();

                if (user != null)
                {
                    if (user.FirstLogin)
                    {
                        TrocarSenha t = new TrocarSenha(_userApp, user, false);

                        if (t.ShowDialog() == DialogResult.OK)
                        {
                            
                        }
                    }

                    Program.SessionUser.Admin = user.IsAdmin;
                    Program.SessionUser.Id = user.UserId;
                    Program.SessionUser.Password = user.Password;
                    Program.SessionUser.UserName = user.UserName;
                    Program.SessionUser.CanAccessFinancial = user.CanAccessFinancial;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    Util.ShowMessageWarning("Usuário não encontrado.");
                    return;
                }
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning("Erro ao efetuar o login. Exception: " + ex);
            }
        }

        private void btnLostPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Util.ValidaString(txtUser.Text))
                {
                    Util.ShowMessageWarning("Preencha o campo Usuário.");
                    return;
                }

                Util.DisabledCursor();

                var userr = _userApp.GetByUserName(txtUser.Text);

                Util.EnabledCursor();

                if (userr == null)
                {
                    Util.ShowMessageWarning("Usuário não encontrado.");
                    return;
                }

                TrocarSenha t = new TrocarSenha(_userApp, userr, true);

                if (t.ShowDialog() == DialogResult.OK)
                {

                }
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning("Erro ao efetuar o login. Exception: " + ex.Message);
            }
        }
    }
}
