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
    public partial class PesquisarUsuário : Form
    {
        public PesquisarUsuário()
        {
            InitializeComponent();
        }

        private void PesquisarUsuário_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dtgUsuario.Rows.Clear();

            for (int i = 0; i < 100; i++)
            {
                dtgUsuario.Rows.Add("", "", i.ToString(), "Teste " + i.ToString(), "12.345.678-" + i.ToString(), "123.456.789-0" + i.ToString(),
                    "Sim");
            }
        }
    }
}
