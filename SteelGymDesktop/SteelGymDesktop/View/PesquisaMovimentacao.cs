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
    public partial class PesquisaMovimentacao : Form
    {
        private IMovimentationAppService _MovimentacaoApp;

        public PesquisaMovimentacao(IMovimentationAppService movimentacaoApp)
        {
            _MovimentacaoApp = movimentacaoApp;
            InitializeComponent();
        }
    }
}
