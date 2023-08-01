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
    public partial class IssueBookForm : Form
    {
        OracleConnection con;
        public string bkcategory = "\0";
        public string bkname = "\0";
        public string bkauthor = "\0";
        public string bkid = "\0";

        public IssueBookForm()
        {
            InitializeComponent();
        }

        private void IssueBookForm_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=LIBUSER; PASSWORD=1234";
            con = new OracleConnection(conStr);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }


        private void updateGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Open();
            OracleCommand OC = new OracleCommand();
            OC = new OracleCommand("SELECT BOOKID, TITLE, AUTHOR, SUBJECTCATEGORY, PUBLICATIONDATE, RACKNUMBER FROM books WHERE SUBJECTCATEGORY=:SC AND TITLE=:BN AND AUTHOR=:AU", con);
            OC.Parameters.Add(new OracleParameter("SC", txtSubCategory.Text));
            OC.Parameters.Add(new OracleParameter("BN", txtBookName.Text));
            OC.Parameters.Add(new OracleParameter("AU", txtAuthor.Text));

            using (OracleDataReader r = OC.ExecuteReader())
            {
                if (r.HasRows)
                {
                    bkid = r["BOOKID"].ToString();
                    DataTable DT = new DataTable();
                    DT.Load(r);
                    dataGridView1.DataSource = DT;
                }
            }
            con.Close();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            StuOptionsForms STF = new StuOptionsForms();
            STF.Show();
        }

        private void btnCheckouts_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckoutForm COF = new CheckoutForm();
            COF.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
