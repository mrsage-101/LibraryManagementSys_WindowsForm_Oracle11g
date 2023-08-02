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
    public partial class StudentCRUDAdmin : Form
    {
        public static string usr = "\0";
        public static string pass = "\0";
        OracleConnection con;
        public StudentCRUDAdmin()
        {
            InitializeComponent();
        }

        private void StudentCRUDAdmin_Load(object sender, EventArgs e)
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
            AdminOptionForm AOF = new AdminOptionForm();
            AOF.Show();
        }

        // search
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand OC = new OracleCommand();
            OC = new OracleCommand("SELECT MEMBERID, NAME, EMAIL, PHONE, ADDRESS, PASSWORDS FROM MEMBERS WHERE MEMBERID=:mid AND PASSWORDS=:pass", con);
            OC.Parameters.Add(new OracleParameter("mid", txtSearchUsr.Text));
            OC.Parameters.Add(new OracleParameter("pass", txtSearchPass.Text));

            OracleDataReader r = OC.ExecuteReader();
            if (r.Read())
            {
                txtMemberid.Text = r[0].ToString();
                textUsername.Text = r[1].ToString();
                textEmail.Text = r[2].ToString();
                textPhone.Text = r[3].ToString();
                textAddress.Text = r[4].ToString();
                textPassword.Text = r[5].ToString();
            }
            con.Close();

        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand updateMember = con.CreateCommand();
            updateMember.CommandText = "UPDATE MEMBERS SET NAME = :name, EMAIL = :email, PHONE = :phone, ADDRESS = :address, PASSWORDS = :passwords WHERE MEMBERID = :memberid AND PASSWORDS = :password";
            updateMember.Parameters.Add(new OracleParameter(":name", textUsername.Text));
            updateMember.Parameters.Add(new OracleParameter(":email", textEmail.Text));
            updateMember.Parameters.Add(new OracleParameter(":phone", textPhone.Text));
            updateMember.Parameters.Add(new OracleParameter(":address", textAddress.Text));
            updateMember.Parameters.Add(new OracleParameter(":passwords", textPassword.Text));
            updateMember.Parameters.Add(new OracleParameter(":memberid", txtSearchUsr.Text));
            updateMember.Parameters.Add(new OracleParameter(":password", txtSearchPass.Text));

            updateMember.CommandType = CommandType.Text;
            int rowsUpdated = updateMember.ExecuteNonQuery();
            con.Close();

        }
    }
}
