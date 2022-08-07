using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F_M_S
{
    public partial class AccountsMenu : Form
    {
        string connectionstr = @"Data Source = DESKTOP-58TMAQD ; Initial Catalog = FMS ; Integrated Security = true;";

        public AccountsMenu()
        {
            InitializeComponent();
            pnlAUD.Visible = false;
            dataGridView1.Visible = false;
            SqlDataReader reader = DataAccessLayer.GetOrderID();
            string result = "";
            while (reader.Read())
            {
                string Oredr_Id = reader["OredrID"].ToString();
                result = string.Format("{0}\n", Oredr_Id);
                cmbOid.Items.Add(result);
            }
            SqlDataReader reader1 = DataAccessLayer.GetTreatmentID();
            string result1 = "";
            while (reader1.Read())
            {
                string Treat_Id = reader1["treatmentID"].ToString();
                result1 = string.Format("{0}\n", Treat_Id);
                cmbTid.Items.Add(result1);
            }
        }

        private void AccountsMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

            pnlAUD.Visible = true;
            lblAccNo.Hide();
            lblOid.Hide();
            lblTCost.Hide();
            lblTid.Hide();
            lblTotal.Hide();
            cmbOid.Hide();
            cmbTid.Hide();
            txtAccNo.Hide();
            txtTCost.Hide();
            txtTotal.Hide();
            btnDone.Hide();
            btnSearch1.Hide();
            btnUpdate.Hide();
            btnDelete.Hide();
            dataGridView1.Show();
            using (SqlConnection conn = new SqlConnection(connectionstr))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Accounts", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlAUD.Visible = true;
            lblAccNo.Show();
            lblOid.Hide();
            lblTCost.Hide();
            lblTid.Hide();
            lblTotal.Hide();
            cmbOid.Hide();
            cmbTid.Hide();
            txtAccNo.Show();
            txtTCost.Hide();
            txtTotal.Hide();
            btnDone.Hide();
            btnSearch1.Show();
            btnUpdate.Hide();
            btnDelete.Hide();
            dataGridView1.Show();

        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            pnlAUD.Visible = true;
            lblAccNo.Show();
            lblOid.Hide();
            lblTCost.Hide();
            lblTid.Hide();
            lblTotal.Hide();
            cmbOid.Hide();
            cmbTid.Hide();
            txtAccNo.Show();
            txtTCost.Hide();
            txtTotal.Hide();
            btnDone.Hide();
            btnSearch1.Show();
            btnUpdate.Hide();
            btnDelete.Hide();
            dataGridView1.Show();
            using (SqlConnection conn = new SqlConnection(connectionstr))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Accounts where AcountNo = '" + txtAccNo.Text + "';", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            pnlAUD.Visible = true;
            lblAccNo.Show();
            lblOid.Hide();
            lblTCost.Hide();
            lblTid.Hide();
            lblTotal.Hide();
            cmbOid.Hide();
            cmbTid.Hide();
            txtAccNo.Show();
            txtTCost.Hide();
            txtTotal.Hide();
            btnDone.Hide();
            btnSearch1.Hide();
            btnUpdate.Hide();
            btnDelete.Show();
            dataGridView1.Hide();

        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            pnlAUD.Visible = true;
            lblAccNo.Show();
            lblOid.Show();
            lblTCost.Show();
            lblTid.Show();
            lblTotal.Show();
            cmbOid.Show();
            cmbTid.Show();
            txtAccNo.Show();
            txtTCost.Show();
            txtTotal.Show();
            btnDone.Hide();
            btnSearch1.Hide();
            btnUpdate.Show();
            btnDelete.Hide();
            dataGridView1.Hide();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAUD.Visible = true;
            lblAccNo.Show();
            lblOid.Show();
            lblTCost.Show();
            lblTid.Show();
            lblTotal.Show();
            cmbOid.Show();
            cmbTid.Show();
            txtAccNo.Show();
            txtTCost.Show();
            txtTotal.Show();
            btnDone.Show();
            btnSearch1.Hide();
            btnUpdate.Hide();
            btnDelete.Hide();
            dataGridView1.Hide();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccessLayer.AddAccounts(txtAccNo.Text, cmbOid.Text, int.Parse(txtTotal.Text), cmbTid.Text, int.Parse(txtTCost.Text));
                MessageBox.Show("Data Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccessLayer.UpdateAccounts(txtAccNo.Text, cmbOid.Text, int.Parse(txtTotal.Text), cmbTid.Text, int.Parse(txtTCost.Text));
                MessageBox.Show("Data Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccessLayer.DeleteAccounts(txtAccNo.Text);
                MessageBox.Show("Data Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
