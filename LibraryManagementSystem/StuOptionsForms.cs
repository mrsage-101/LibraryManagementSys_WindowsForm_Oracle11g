using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class StuOptionsForms : Form
    {
        public StuOptionsForms()
        {
            InitializeComponent();
        }

        private void StuOptionsForms_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            StuMainForm SMF = new StuMainForm();
            this.Show();*/
            System.Windows.Forms.Application.Exit();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            this.Hide();
            IssueBookForm IBF = new IssueBookForm();
            IBF.Show();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckoutForm COF = new CheckoutForm();
            COF.Show();
        }
    }
}
