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
    public partial class CheckoutForm : Form
    {
        OracleConnection con;
        public string txtmid = "\0";
        public CheckoutForm()
        {
            InitializeComponent();
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=LIBUSER; PASSWORD=1234";
            con = new OracleConnection(conStr);
            txtmid = StuMainForm.memberid;
            update_valuemid();
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        void update_valuemid()
        {
            txtMemberId.Text = txtmid;
        }
        private void btnDONE_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand OC = new OracleCommand("INSERT INTO CHECKOUTS (BookID, MemberID, CheckoutDate) VALUES (:BOOKID, :MEMBERID, :CHECKOUTDATE)", con);
           
   
            OC.Parameters.Add(new OracleParameter(":BOOKID", txtBookid.Text));
            OC.Parameters.Add(new OracleParameter(":MEMBERID", txtMemberId.Text));
            OC.Parameters.Add(new OracleParameter(":CHECKOUTDATE", dateTimePicker1.Value));
            
            OC.ExecuteNonQuery();

            MessageBox.Show("INSERTED SUCCESSFULLY");
            con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            StuOptionsForms SOF = new StuOptionsForms();
            SOF.Show();
        }
    }
}
