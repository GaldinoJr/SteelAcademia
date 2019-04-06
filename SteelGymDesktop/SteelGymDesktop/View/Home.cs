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

namespace SteelGymDesktop.View
{
    public partial class Home : Form
    {
        private readonly IStudentAppService _studentApp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtNomeModulo;
        public Home(IStudentAppService _studentApp, System.Windows.Forms.Panel panel1, System.Windows.Forms.Label txtNomeModulo)
        {
            InitializeComponent();
            this._studentApp = _studentApp;
            this.panel1 = panel1;
            this.txtNomeModulo = txtNomeModulo;
            LoadControls();
        }

        private void LoadControls()
        {
            LoadActiveStudents();
            LoadInativeStudents();
            LoadLatePayments();
            LoadLateAvaliations();
        }

        private void LoadLatePayments()
        {
            var qttLatePayments = _studentApp.GetCountLatePayments();
            txtQuatityLatePayments.Text = qttLatePayments.ToString();
        }

        private void LoadLateAvaliations()
        {
            var qttLatePayments = _studentApp.GetCountLateAvaliations();
            txtQuantityLateAvaliations.Text = qttLatePayments.ToString();
        }

        private void LoadInativeStudents()
        {
            var qttActive = _studentApp.GetCount(0);
            txtQuantityInativeStudents.Text = qttActive.ToString();
        }

        private void LoadActiveStudents()
        {
            var qttActive = _studentApp.GetCount(1);
            txtQuantityActiveStudents.Text = qttActive.ToString();
        }

        private void Panel_late_payment_Click(object sender, EventArgs e)
        {
            OnClickQuatityLatePayments();
        }

        private void Panel_late_avaliation_Click(object sender, EventArgs e)
        {
            OnClickQuantityLateAvaliations();
        }

        private void Panel_inative_student_Click(object sender, EventArgs e)
        {
            OnClickInativeStudent();
        }

        private void Panel_active_student_Click(object sender, EventArgs e)
        {
            OnClickActiveStudent();
        }

        private void OnClickActiveStudent()
        {
            PesquisarAluno p = new PesquisarAluno(_studentApp,true);
            AbrirModulo(p, Models.Modulos.DF_NOME_MODULO_ALUNO);
        }

        private void OnClickInativeStudent()
        {
            PesquisarAluno p = new PesquisarAluno(_studentApp,false);
            AbrirModulo(p, Models.Modulos.DF_NOME_MODULO_ALUNO);
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
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Show();
        }

        private void TxtQuatityLatePayments_Click(object sender, EventArgs e)
        {
            OnClickQuatityLatePayments();
        }

        private void OnClickQuatityLatePayments()
        {
            // TODO DESCOMENTAR
            PesquisarAluno p = new PesquisarAluno(_studentApp, PesquisarAluno.DEF_SEARCH_LATE_PAYMENTS);
            AbrirModulo(p, Models.Modulos.DF_NOME_MODULO_ALUNO);
        }

        private void TxtQuantityLateAvaliations_Click(object sender, EventArgs e)
        {
            OnClickQuantityLateAvaliations();
        }

        private void OnClickQuantityLateAvaliations()
        {
            PesquisarAluno p = new PesquisarAluno(_studentApp, PesquisarAluno.DEF_SEARCH_LATE_EVALUATIONS);
            AbrirModulo(p, Models.Modulos.DF_NOME_MODULO_ALUNO);
        }

        private void TxtQuantityActiveStudents_Click(object sender, EventArgs e)
        {
            OnClickActiveStudent();
        }

        private void TxtQuantityInativeStudents_Click(object sender, EventArgs e)
        {
            OnClickInativeStudent();
        }
    }
}
