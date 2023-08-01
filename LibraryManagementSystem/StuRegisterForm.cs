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
    public partial class StuRegisterForm : Form
    {
        OracleConnection con;
        public StuRegisterForm()
        {
            InitializeComponent();
        }

        private void StuRegisterForm_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=LIBUSER; PASSWORD=1234";
            con = new OracleConnection(conStr);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand OC = new OracleCommand("INSERT INTO members VALUES(:MEMBERID, :NAME, :EMAIL, :PHONE, :ADDRESS, :PASSWORDS)", con);
            OC.Parameters.Add(new OracleParameter("MID", txtMemberid.Text));
            OC.Parameters.Add(new OracleParameter("NME", textUsername.Text));
            OC.Parameters.Add(new OracleParameter("EM", textEmail.Text));
            OC.Parameters.Add(new OracleParameter("PHN", textPhone.Text));
            OC.Parameters.Add(new OracleParameter("ADRS", textAddress.Text));
            OC.Parameters.Add(new OracleParameter("PASS", textPassword.Text));
            OC.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Successfully!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            StuMainForm SMF = new StuMainForm();
            SMF.Show();
        }
    }
}
