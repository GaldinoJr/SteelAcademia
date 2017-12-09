using SteelGymDesktop.Applications.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SteelGymDesktop.View
{
    public partial class Principal : Form
    {
        private readonly IUserAppService _userApp;
        private readonly IStudentAppService _studentApp;

        public Principal(IUserAppService userApp, IStudentAppService studentApp)
        {
            _userApp = userApp;
            _studentApp = studentApp;
            InitializeComponent();

            // Full screen
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            // Centralizar Painel
            int largura = ((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2);
            int altura = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            panel1.Location = new Point(largura, altura);
            panel1.Anchor = AnchorStyles.None;

            // Centralizar titulo
            int larguraTitulo = Screen.PrimaryScreen.WorkingArea.Width / 2 - txtNomeModulo.Height;
            int alturaTitulo = this.toolbar.Height/4;
            txtNomeModulo.Location = new Point(larguraTitulo,alturaTitulo);

            if(!Program.SessionUser.Admin)
            {
                pagamentoToolStripMenuItem.Enabled = Program.SessionUser.CanAccessFinancial;
                comprovantesToolStripMenuItem.Enabled = Program.SessionUser.CanAccessFinancial;
                movimentaçõesToolStripMenuItem.Enabled = Program.SessionUser.CanAccessFinancial;
            }
        }

        private void Index_Load(object sender, EventArgs e)
        {
            Home home = new Home();
            AbrirModulo(home, Models.Modulos.DF_NOME_MODULO_HOME);
        }

        private void CadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroAluno p = new CadastroAluno(_studentApp, true, int.MinValue);
            AbrirModulo(p, Models.Modulos.DF_NOME_MODULO_ALUNO);
        }

        private void PesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarAluno p = new PesquisarAluno(_studentApp);
            AbrirModulo(p, Models.Modulos.DF_NOME_MODULO_ALUNO);
        }

        private void PagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ComprovantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void IncluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuario p = new CadastroUsuario(_userApp, true, int.MinValue);
            AbrirModulo(p, Models.Modulos.DF_NOME_MODULO_USUARIO);
        }

        private void PesquisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PesquisarUsuário p = new PesquisarUsuário(_userApp);
            AbrirModulo(p, Models.Modulos.DF_NOME_MODULO_USUARIO);
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            AbrirModulo(h, Models.Modulos.DF_NOME_MODULO_HOME);
        }

        // Métodos
        public void EnterFullScreenMode(Form targetForm)
        {
            targetForm.WindowState = FormWindowState.Normal;
            targetForm.FormBorderStyle = FormBorderStyle.None;
            targetForm.WindowState = FormWindowState.Maximized;
        }

        public void LeaveFullScreenMode(Form targetForm)
        {
            targetForm.FormBorderStyle = FormBorderStyle.Sizable;
            targetForm.WindowState = FormWindowState.Normal;
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Login l = new Login(_userApp);
            l.TopLevel = false;
            l.AutoScroll = true;

            panel1.Controls.Add(l);
            l.FormBorderStyle = FormBorderStyle.None;
            l.Show();
        }

        public void AbrirModulo(Form form, String nomeModulo)
        {
            // Muda o nome do módulo na toolbar
            txtNomeModulo.Text = nomeModulo;
            // Infla o módulo
            panel1.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            panel1.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }

        private void trocarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var user = _userApp.GetById(Program.SessionUser.Id);

                TrocarSenha t = new TrocarSenha(_userApp, user);

                if (t.ShowDialog() == DialogResult.OK)
                {
                    Program.SessionUser.Admin = user.IsAdmin;
                    Program.SessionUser.Id = user.UserId;
                    Program.SessionUser.Password = user.Password;
                    Program.SessionUser.UserName = user.UserName;
                    Program.SessionUser.CanAccessFinancial = user.CanAccessFinancial;
                }
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning(ex.Message);
            }
        }
    }
}
