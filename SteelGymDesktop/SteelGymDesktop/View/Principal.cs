using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteelGymDesktop.View
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            Home home = new Home();
            abrirModulo(home, Models.Modulos.DF_NOME_MODULO_HOME);
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroAluno p = new CadastroAluno();
            abrirModulo(p, Models.Modulos.DF_NOME_MODULO_ALUNO);
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarAluno p = new PesquisarAluno();
            abrirModulo(p, Models.Modulos.DF_NOME_MODULO_ALUNO);
        }

        private void pagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comprovantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuario p = new CadastroUsuario();
            abrirModulo(p, Models.Modulos.DF_NOME_MODULO_USUARIO);
        }

        private void pesquisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PesquisarUsuário p = new PesquisarUsuário();
            abrirModulo(p, Models.Modulos.DF_NOME_MODULO_USUARIO);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            abrirModulo(h, Models.Modulos.DF_NOME_MODULO_HOME);
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
            targetForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            targetForm.WindowState = FormWindowState.Normal;
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Login l = new Login();
            l.TopLevel = false;
            l.AutoScroll = true;

            panel1.Controls.Add(l);
            l.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            l.Show();
        }

        private void abrirModulo(Form form, String nomeModulo)
        {
            // Muda o nome do módulo na toolbar
            txtNomeModulo.Text = nomeModulo;
            // Infla o módulo
            panel1.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            panel1.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Show();
        }
    }
}
