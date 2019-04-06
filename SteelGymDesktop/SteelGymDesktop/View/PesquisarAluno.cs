using SteelGymDesktop.Applications.Interfaces;
using SteelGymDesktop.Domain.Entities;
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
    public partial class PesquisarAluno : Form
    {
        private readonly IStudentAppService _studentApp;
        private int _studenId;
        bool fgActive;
        public const int DEF_SEARCH_LATE_PAYMENTS = 1001;
        public const int DEF_SEARCH_LATE_EVALUATIONS = 1002;

        public PesquisarAluno(IStudentAppService studentApp, int typeSearch)
        {
            _studentApp = studentApp;
            InitializeComponent();
            this.fgActive = true;
            switch(typeSearch)
            {
                case DEF_SEARCH_LATE_EVALUATIONS:
                    FilterLateEvaluations();
                    break;
                case DEF_SEARCH_LATE_PAYMENTS:
                    break;
            }
        }

        public PesquisarAluno(IStudentAppService studentApp, bool fgActive)
        {
            _studentApp = studentApp;
            InitializeComponent();
            FilterSearch(fgActive, "", "", "", null);
            this.fgActive = fgActive;
        }

        public PesquisarAluno(IStudentAppService studentApp)
        {
            _studentApp = studentApp;
            InitializeComponent();
            this.fgActive = true;
        }

        private void PesquisarAluno_Load(object sender, EventArgs e)
        {
            chkAtivo.Checked = true;
            chkAtivo.Checked = fgActive;
        }

        private void TxtIDAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Util.ValidaNumero(e);
        }

        private void TxtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Util.ValidaNumero(e);
        }

        private void TxtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Util.ValidaNumero(e);
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            Util.DisabledCursor();

            try
            {
                dtgAlunos.Rows.Clear();

                int? idAluno = null;

                if (Util.ValidaString(txtIDAluno.Text))
                {
                    idAluno = Convert.ToInt32(txtIDAluno.Text);
                }

                FilterSearch(chkAtivo.Checked, txtNome.Text, txtRG.Text, txtCPF.Text, idAluno);
                
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning(ex.Message);
            }

            Util.EnabledCursor();
        }

        private void Filter(IEnumerable<Student> students)
        {
            if (students != null)   
            {
                foreach (var student in students)
                {
                    dtgAlunos.Rows.Add(student.StudentId, student.Name, student.RG, student.CPF, (student.Active == 1 ? "Sim" : "Não"), student.PayDay);
                }
            }
            else
                Util.ShowMessageWarning("Não foi encontrado alunos com esses parametros.");
        }

        private void FilterSearch(bool @checked, string nome, string rg, string cpf, int? idAluno)
        {
            int nChecked = 0;
            if(@checked)
            {
                nChecked = 1;
            }
            var students = _studentApp.GetByFilter(nChecked, nome, rg, cpf, idAluno);
            Filter(students);
        }

        private void FilterLateEvaluations()
        {
            var students = _studentApp.LoadLateAvaliations();
            Filter(students);
        }

        private void FilterLoadLatePayments()
        {
            var students = _studentApp.LoadLatePayments();
            Filter(students);
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtCPF.Text = "";
            txtIDAluno.Text = "";
            txtNome.Text = "";
            txtRG.Text = "";
            dtgAlunos.Rows.Clear();
        }

        private void DtgAlunos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                var row = dtgAlunos.Rows[index];

                _studenId = Convert.ToInt32(row.Cells[0].Value);

                UpdateStudent();
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning(ex.Message);
            }
        }

        private void UpdateStudent()
        {
            CadastroAluno p = new CadastroAluno(_studentApp, false, _studenId);
            p.ShowDialog();

            BtnPesquisar_Click(null, null);
        }
    }
}
