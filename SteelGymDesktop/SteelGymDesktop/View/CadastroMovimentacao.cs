﻿using System;
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
    public partial class CadastroMovimentacao : Form
    {
        public CadastroMovimentacao(Applications.Interfaces.IMovimentationAppService _MovimentacaoApp)
        {
            InitializeComponent();
        }
    }
}
