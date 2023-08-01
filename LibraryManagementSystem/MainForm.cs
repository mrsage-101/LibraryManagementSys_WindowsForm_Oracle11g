using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace LibraryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnAdminclick_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentclick_Click(object sender, EventArgs e)
        {

        }

        private void btnExitclick_Click(object sender, EventArgs e)
        {

        }
    }
}
