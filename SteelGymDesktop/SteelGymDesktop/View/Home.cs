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
        public Home(IStudentAppService _studentApp)
        {
            InitializeComponent();
            this._studentApp = _studentApp;
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
            
        }

        private void LoadLateAvaliations()
        {
           
        }

        private void LoadInativeStudents()
        {
            var qttActive = _studentApp.GetCount(false);
            txtQuantityInativeStudents.Text = qttActive.ToString();
        }

        private void LoadActiveStudents()
        {
            var qttActive = _studentApp.GetCount(true);
            txtQuantityActiveStudents.Text = qttActive.ToString();
        }

        private void Panel_late_payment_Click(object sender, EventArgs e)
        {

        }

        private void Panel_late_avaliation_Click(object sender, EventArgs e)
        {

        }

        private void Panel_inative_student_Click(object sender, EventArgs e)
        {

        }

        private void Panel_active_student_Click(object sender, EventArgs e)
        {

        }

    }
}
