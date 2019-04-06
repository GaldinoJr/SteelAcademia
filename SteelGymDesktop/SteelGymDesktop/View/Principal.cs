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
        private readonly IMovimentationAppService _MovimentacaoApp;
        private readonly IPaymentAppService _PaymentApp;

        public Principal(
            IUserAppService userApp, 
            IStudentAppService studentApp, 
            IMovimentationAppService movimentacaoApp,
            IPaymentAppService paymentApp)
        {
            _userApp = userApp;
            _studentApp = studentApp;
            _MovimentacaoApp = movimentacaoApp;
            _PaymentApp = paymentApp;

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
                //pagamentoToolStripMenuItem.Visible = Program.SessionUser.CanAccessFinancial;
                //comprovantesToolStripMenuItem.Visible = Program.SessionUser.CanAccessFinancial;
                
                movimentaçõesToolStripMenuItem.Enabled = false;
                //movimentaçõesToolStripMenuItem.Visible = false;
            } else {
                pagamentoToolStripMenuItem.Enabled = true;
                comprovantesToolStripMenuItem.Enabled = true;
                movimentaçõesToolStripMenuItem.Enabled = true;
               // pagamentoToolStripMenuItem.Visible = true;
                //comprovantesToolStripMenuItem.Visible = true;
               // movimentaçõesToolStripMenuItem.Visible = true;
            }
        }

        private void Index_Load(object sender, EventArgs e)
        {
            Home home = new Home(_studentApp, panel1, txtNomeModulo);
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
            Home h = new Home(_studentApp, panel1, txtNomeModulo);
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
            DialogForm p = new DialogForm();
            p.ShowDialog();
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

            controlPanelSelected(nomeModulo);

            form.Show();
        }

        private void controlPanelSelected(string nomeModulo)
        {
            panelSelectedHome.Visible =
                panelSelectedMovimentation.Visible =
                panelSelectedPayment.Visible =
                panelSelectedReceipt.Visible =
                panelSelectedStudent.Visible =
                panelSelectedUser.Visible = false;
            switch (nomeModulo)
            {
                case Models.Modulos.DF_NOME_MODULO_HOME:
                    panelSelectedHome.Visible = true;
                    break;
                case Models.Modulos.DF_NOME_MODULO_ALUNO:
                    panelSelectedStudent.Visible = true;
                    break;
                case Models.Modulos.DF_NOME_MODULO_PAGAMENTO:
                    panelSelectedPayment.Visible = true;
                    break;
                case Models.Modulos.DF_NOME_MODULO_COMPROVANTE:
                    panelSelectedReceipt.Visible = true;
                    break;
                case Models.Modulos.DF_NOME_MODULO_USUARIO:
                    panelSelectedUser.Visible = true;
                    break;
                case Models.Modulos.DF_NOME_MODULO_MOVIMENTACOES:
                    panelSelectedMovimentation.Visible = true;
                    break;
            }
        }

        private void trocarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var user = _userApp.GetById(Program.SessionUser.Id);

                TrocarSenha t = new TrocarSenha(_userApp, user, false);

                if (t.ShowDialog() == DialogResult.OK)
                {
                    Program.SessionUser.Admin = Convert.ToBoolean(user.IsAdmin);
                    Program.SessionUser.Id = user.UserId;
                    Program.SessionUser.Password = user.Password;
                    Program.SessionUser.UserName = user.UserName;
                    Program.SessionUser.CanAccessFinancial = Convert.ToBoolean(user.CanAccessFinancial);
                }
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning(ex.Message);
            }
        }

        private void InclusãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroMovimentacao p = new CadastroMovimentacao(_MovimentacaoApp, true, int.MinValue);
            AbrirModulo(p, Models.Modulos.DF_NOME_MODULO_MOVIMENTACOES);
        }

        private void PesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisaMovimentacao p = new PesquisaMovimentacao(_MovimentacaoApp);
            AbrirModulo(p, Models.Modulos.DF_NOME_MODULO_MOVIMENTACOES);
        }

        private void pesquisarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PesquisaPagamento pay = new PesquisaPagamento(_PaymentApp, _studentApp);
            AbrirModulo(pay, Models.Modulos.DF_NOME_MODULO_PAGAMENTO);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void incluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroPagamento pay = new CadastroPagamento(_PaymentApp, _studentApp, true, int.MinValue);
            AbrirModulo(pay, Models.Modulos.DF_NOME_MODULO_PAGAMENTO);
        }
    }
}
