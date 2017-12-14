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
    // É possivel modularizar passando a mensagem por construtor pra reaproveitar o dialog
    public partial class DialogForm : Form
    {
        public DialogForm()
        {
            InitializeComponent();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
