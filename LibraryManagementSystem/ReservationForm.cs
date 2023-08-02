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
    public partial class ReservationForm : Form
    {
        OracleConnection con;

        public static string memberid = "\0";
        public static string status = "\0";
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=LIBUSER; PASSWORD=1234";
            con = new OracleConnection(conStr);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            memberid = StuMainForm.memberid;
            txtMemberID.Text = memberid;
            update_grid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void update_grid()
        {
            con.Open();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OracleCommand OC = new OracleCommand();
            OC = new OracleCommand("SELECT b.BOOKID,b.TITLE,b.AUTHOR,b.SUBJECTCATEGORY,b.PUBLICATIONDATE,b.RACKNUMBER, bi.status FROM Books b INNER JOIN BookItem bi ON b.BookID = bi.BookID", con);
            //OC.ExecuteNonQuery();

            using (OracleDataReader r = OC.ExecuteReader())
            {
                if (r.HasRows)
                {
                    //bkid = r["BOOKID"].ToString();
                    DataTable DT = new DataTable();
                    DT.Load(r);
                    dataGridView1.DataSource = DT;
                }
            }
            con.Close();
        }

        private void btnRESERVE_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand OC1 = new OracleCommand();
            OC1 = new OracleCommand("INSERT INTO RESERVATIONS (BOOKID, MEMBERID, RESERVATIONDATE) VALUES (:bkid, :mid, :rd)", con);
            OC1.Parameters.Add(new OracleParameter("bkid", txtBookid.Text));
            OC1.Parameters.Add(new OracleParameter("mid", txtMemberID.Text));
            OC1.Parameters.Add(new OracleParameter("rd", dateTimePicker1.Value));

            OC1.ExecuteNonQuery();
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
