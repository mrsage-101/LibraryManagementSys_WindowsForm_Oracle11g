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
    public partial class AdminOptionForm : Form
    {
        public AdminOptionForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentCRUDAdmin SCA = new StudentCRUDAdmin();
            SCA.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BooksRecordUpdate BRU = new BooksRecordUpdate();
            BRU.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MF = new MainForm();
            MF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RerservationAdmin RA = new RerservationAdmin();
            RA.Show();
        }
    }
}
