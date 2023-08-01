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
    public partial class StuMainForm : Form
    {
        OracleConnection con;
        public StuMainForm()
        {
            InitializeComponent();
        }

        private void StuMainForm_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=LIBUSER; PASSWORD=1234";
            con = new OracleConnection(conStr);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();

            if (textUsername.Text == string.Empty || textPassword.Text == string.Empty)
            {
                MessageBox.Show("Please! Fill in the box");
            }
            else
            {
                con.Open();
                cmd = new OracleCommand("SELECT NAME, PASSWORDS FROM members WHERE NAME= :nam AND PASSWORDS= :pass", con);
                cmd.Parameters.Add(new OracleParameter("nam", textUsername.Text));
                cmd.Parameters.Add(new OracleParameter("pass", textPassword.Text));

                OracleDataReader r = cmd.ExecuteReader();
                string[] feilds = new string[3];
                if (r.Read() && r.GetValue(0).ToString() == textUsername.Text && r.GetValue(1).ToString() == textPassword.Text)
                {
                    this.Hide();
                    StuOptionsForms SOF = new StuOptionsForms();
                    SOF.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Enter valid username or password. Register if not");
                }
                con.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
