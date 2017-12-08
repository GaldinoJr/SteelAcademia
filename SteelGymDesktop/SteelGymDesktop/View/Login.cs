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

            var user = _userApp.Login(txtUser.Text, txtPassword.Text);

            if(user != null)
            {
                Program.SessionUser.Admin = user.IsAdmin;
                Program.SessionUser.Id = user.UserId;
                Program.SessionUser.Password = user.Password;
                Program.SessionUser.UserName = user.UserName;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
