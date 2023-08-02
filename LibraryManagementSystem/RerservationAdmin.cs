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
    public partial class RerservationAdmin : Form
    {
        OracleConnection con;
        public RerservationAdmin()
        {
            InitializeComponent();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            update_grid();
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
            OracleCommand updateMember = con.CreateCommand();
            updateMember.CommandText = "UPDATE RESERVATIONS SET EXPIRYDATE= :ed, STATUS =:st WHERE MEMBERID = :memberid";
            updateMember.Parameters.Add(new OracleParameter(":ed", dateTimePicker1.Value));
            updateMember.Parameters.Add(new OracleParameter(":st", textSTATUS.Text));
            updateMember.Parameters.Add(new OracleParameter(":memberid", txtSearchUsr.Text));

            updateMember.CommandType = CommandType.Text;
            int rowsUpdated = updateMember.ExecuteNonQuery();
            
            con.Close();
            update_grid();
        }

        private void RerservationAdmin_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=LIBUSER; PASSWORD=1234";
            con = new OracleConnection(conStr);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            update_grid();
        }

        private void update_grid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Open();
            OracleCommand OC = new OracleCommand();
            OC = new OracleCommand("SELECT RESERVATIONSID, BOOKID, MEMBERID, RESERVATIONDATE, EXPIRYDATE, STATUS FROM RESERVATIONS WHERE MEMBERID=:SUSR", con);
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
    }
}
