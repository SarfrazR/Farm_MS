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
    public partial class MedicalMenu : Form
    {
        string connectionstr = @"Data Source = DESKTOP-58TMAQD ; Initial Catalog = FMS ; Integrated Security = true;";

        public MedicalMenu()
        {
            InitializeComponent();
            pnlAUD.Visible = false;
            dataGridView1.Visible = false;
            SqlDataReader reader = DataAccessLayer.GetAnimalID();
            string result = "";
            while (reader.Read())
            {
                string Animal_Id = reader["AnimalID"].ToString();
                result = string.Format("{0}\n", Animal_Id);
                cmbAid.Items.Add(result);
            }
            SqlDataReader reader1 = DataAccessLayer.GetEmployeID();
            string result1 = "";
            while (reader1.Read())
            {
                string Emp_Id = reader1["ID"].ToString();
                result1 = string.Format("{0}\n", Emp_Id);
                cmbEid.Items.Add(result1);
            }
        }

        private void cmbEid_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbAid_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            pnlAUD.Visible = true;
            lblAID.Visible = false;
            lblCNIC.Visible = false;
            lblEID.Visible = false;
            lblMExp.Visible = false;
            lblMname.Visible = false;
            lblTCost.Visible = false;
            lblTDate.Visible = false;
            lblTID.Visible = false;
            lblTitle.Visible = true;
            dtpExp.Visible = false;
            dtpTDate.Visible = false;
            cmbAid.Visible = false;
            cmbEid.Visible = false;
            txtMname.Visible = false;
            txtMType.Visible = false;
            txtTCost.Visible = false;
            txtTid.Visible = false;
            btnDone.Visible = false;
            btnSearch1.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            dataGridView1.Visible = true;
            using (SqlConnection conn = new SqlConnection(connectionstr))
            {
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Treatment", conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlAUD.Visible = true;
            lblAID.Visible = false;
            lblCNIC.Visible = false;
            lblEID.Visible = false;
            lblMExp.Visible = false;
            lblMname.Visible = false;
            lblTCost.Visible = false;
            lblTDate.Visible = false;
            lblTID.Visible = true;
            lblTitle.Visible = true;
            dtpExp.Visible = false;
            dtpTDate.Visible = false;
            cmbAid.Visible = false;
            cmbEid.Visible = false;
            txtMname.Visible = false;
            txtMType.Visible = false;
            txtTCost.Visible = false;
            txtTid.Visible = true;
            btnDone.Visible = false;
            btnSearch1.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            dataGridView1.Visible = true;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAUD.Visible = true;
            lblAID.Visible = true;
            lblCNIC.Visible = true;
            lblEID.Visible = true;
            lblMExp.Visible = true;
            lblMname.Visible = true;
            lblTCost.Visible = true;
            lblTDate.Visible = true;
            lblTID.Visible = true;
            lblTitle.Visible = true;
            dtpExp.Visible = true;
            dtpTDate.Visible = true;
            cmbAid.Visible = true;
            cmbEid.Visible = true;
            txtMname.Visible = true;
            txtMType.Visible = true;
            txtTCost.Visible = true;
            txtTid.Visible = true;
            btnDone.Visible = true;
            btnSearch1.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            dataGridView1.Visible = false;
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {

            pnlAUD.Visible = true;
            lblAID.Visible = true;
            lblCNIC.Visible = true;
            lblEID.Visible = true;
            lblMExp.Visible = true;
            lblMname.Visible = true;
            lblTCost.Visible = true;
            lblTDate.Visible = true;
            lblTID.Visible = true;
            lblTitle.Visible = true;
            dtpExp.Visible = true;
            dtpTDate.Visible = true;
            cmbAid.Visible = true;
            cmbEid.Visible = true;
            txtMname.Visible = true;
            txtMType.Visible = true;
            txtTCost.Visible = true;
            txtTid.Visible = true;
            btnDone.Visible = false;
            btnSearch1.Visible = false;
            btnUpdate.Visible = true;
            btnDelete.Visible = false;
            dataGridView1.Visible = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            pnlAUD.Visible = true;
            lblAID.Visible = false;
            lblCNIC.Visible = false;
            lblEID.Visible = false;
            lblMExp.Visible = false;
            lblMname.Visible = false;
            lblTCost.Visible = false;
            lblTDate.Visible = false;
            lblTID.Visible = true;
            lblTitle.Visible = true;
            dtpExp.Visible = false;
            dtpTDate.Visible = false;
            cmbAid.Visible = false;
            cmbEid.Visible = false;
            txtMname.Visible = false;
            txtMType.Visible = false;
            txtTCost.Visible = false;
            txtTid.Visible = true;
            btnDone.Visible = false;
            btnSearch1.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = true;
            dataGridView1.Visible = false;

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            pnlAUD.Visible = true;
            lblAID.Visible = false;
            lblCNIC.Visible = false;
            lblEID.Visible = false;
            lblMExp.Visible = false;
            lblMname.Visible = false;
            lblTCost.Visible = false;
            lblTDate.Visible = false;
            lblTID.Visible = true;
            lblTitle.Visible = true;
            dtpExp.Visible = false;
            dtpTDate.Visible = false;
            cmbAid.Visible = false;
            cmbEid.Visible = false;
            txtMname.Visible = false;
            txtMType.Visible = false;
            txtTCost.Visible = false;
            txtTid.Visible = true;
            btnDone.Visible = false;
            btnSearch1.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            dataGridView1.Visible = true;
            using (SqlConnection conn = new SqlConnection(connectionstr))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Treatment where ID = '" + txtTid.Text + "';", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
        }

        private void MedicalMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccessLayer.AddTreatment(txtTid.Text, dtpTDate.Text, txtMname.Text, txtMType.Text, dtpExp.Text, cmbEid.Text, int.Parse(txtTCost.Text), cmbAid.Text);
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
                DataAccessLayer.UpdateTreatment(txtTid.Text, dtpTDate.Text, txtMname.Text, txtMType.Text, dtpExp.Text, cmbEid.Text, int.Parse(txtTCost.Text), cmbAid.Text);
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
                DataAccessLayer.DeleteTrearment(txtTid.Text);
                MessageBox.Show("Data Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
