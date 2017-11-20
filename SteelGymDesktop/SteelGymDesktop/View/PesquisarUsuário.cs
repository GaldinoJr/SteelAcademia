using SteelGymDesktop.Applications.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SteelGymDesktop.View
{
    public partial class PesquisarUsuário : Form
    {
        private readonly IUserAppService _userApp;
        private int _userId;

        public PesquisarUsuário(IUserAppService userApp)
        {
            _userApp = userApp;
            InitializeComponent();
        }

        private void PesquisarUsuário_Load(object sender, EventArgs e)
        {
            chkAtivo.Checked = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Util.DisabledCursor();

            try
            {
                dtgUsuario.Rows.Clear();

                if (Util.ValidaString(txtIDAluno.Text))
                {
                    var user = _userApp.GetById(Convert.ToInt32(txtIDAluno.Text));

                    if (user != null)
                        dtgUsuario.Rows.Add(user.UserId, user.Name + " " + user.LastName, user.RG, user.CPF, (user.Active ? "Sim" : "Não"));
                    else
                        Util.ShowMessageWarning("Não foi encontrado usuário com este Id.");
                }
                else
                {
                    var users = _userApp.GetByFilter(chkAtivo.Checked, txtNome.Text, txtRG.Text, txtCPF.Text);

                    if (users != null)
                    {
                        foreach (var user in users)
                        {
                            dtgUsuario.Rows.Add(user.UserId, user.Name + " " + user.LastName, user.RG, user.CPF, (user.Active ? "Sim" : "Não"));
                        }
                    }
                    else
                        Util.ShowMessageWarning("Não foi encontrado usuários com esses parametros.");
                }
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning(ex.Message);
            }

            Util.EnabledCursor();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCPF.Text = "";
            txtIDAluno.Text = "";
            txtNome.Text = "";
            txtRG.Text = "";
            dtgUsuario.Rows.Clear();
        }

        private void UpdateUser()
        {
            CadastroUsuario p = new CadastroUsuario(_userApp, false, _userId);
            p.ShowDialog();

            btnPesquisar_Click(null, null);
        }

        private void dtgUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                var row = dtgUsuario.Rows[index];

                _userId = Convert.ToInt32(row.Cells[0].Value);

                UpdateUser();
            }
            catch (Exception ex)
            {
                Util.ShowMessageWarning(ex.Message);
            }
        }
    }
}
