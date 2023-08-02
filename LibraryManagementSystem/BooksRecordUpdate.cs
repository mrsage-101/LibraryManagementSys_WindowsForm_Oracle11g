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
    public partial class BooksRecordUpdate : Form
    {
        OracleConnection con;
        public BooksRecordUpdate()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            update_grid();
        }

        private void BooksRecordUpdate_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=LIBUSER; PASSWORD=1234";
            con = new OracleConnection(conStr);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            
        }

        private void update_grid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Open();
            OracleCommand OC = new OracleCommand();
            OC = new OracleCommand("SELECT CHECKOUTID, BOOKID, MEMBERID, CHECKOUTDATE, DUEDATE, RETURNDATE FROM checkouts WHERE MEMBERID=:SUSR", con);
            OC.Parameters.Add(new OracleParameter("SUSR", txtSearchUsr.Text));

            using (OracleDataReader r = OC.ExecuteReader())
            {

                if (r.HasRows)
                {
                    DataTable DT = new DataTable();
                    DT.Load(r);
                    dataGridView1.DataSource = DT;
                }
            }

            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminOptionForm AOF = new AdminOptionForm();
            AOF.Show();
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            con.Open();

        }
    }
}
