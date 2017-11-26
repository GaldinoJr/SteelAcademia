using SteelGymDesktop.Applications.Interfaces;
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

        public PesquisarAluno(IStudentAppService studentApp)
        {
            _studentApp = studentApp;
            InitializeComponent();
        }

        private void PesquisarAluno_Load(object sender, EventArgs e)
        {
            chkAtivo.Checked = true;
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

                if (!Util.ValidaString(txtIDAluno.Text))
                {
                    var student = _studentApp.GetById(Convert.ToInt32(txtIDAluno.Text));

                    if (student != null)
                        dtgAlunos.Rows.Add(student.StudentId, student.Name, student.RG, student.CPF, (student.Active ? "Sim" : "Não"), student.PayDay);
                    else
                        Util.ShowMessageWarning("Não foi encontrado Aluno com este Id.");
                }
                else
                {
                    var students = _studentApp.GetByFilter(chkAtivo.Checked, txtNome.Text, txtRG.Text, txtCPF.Text);

                    if (students != null)
                    {
                        foreach (var student in students)
                        {
                            dtgAlunos.Rows.Add(student.StudentId, student.Name, student.RG, student.CPF, (student.Active ? "Sim" : "Não"), student.PayDay);
                        }
                    }
                    else
                        Util.ShowMessageWarning("Não foi encontrado alunos com esses parametros.");
                }
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning(ex.Message);
            }

            Util.EnabledCursor();
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
