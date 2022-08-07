using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace F_M_S
{

    public partial class StaffMenu : Form
    {
        
        string connectionstr = @"Data Source = DESKTOP-58TMAQD ; Initial Catalog = FMS ; Integrated Security = true;";
        string eid = "";
        public StaffMenu()
        {
            InitializeComponent();
            pnlAUD.Visible = false;
            dataGridView1.Hide();
            
            eid = txtEid.Text;
        }
        
        private void btnAccounts_Click(object sender, EventArgs e)
        {
            pnlAUD.Visible = true;
            lblAddress.Hide();
            lblCNIC.Hide();
            lblCont.Hide();
            lblEmail.Hide();
            lblEname.Hide();
            lblJT.Hide();
            txtAddress.Hide();
            txtCnic.Hide();
            txtCont.Hide();
            txtEmail.Hide();
            txtEName.Hide();
            txtJT.Hide();
            btnDone.Hide();
            btnUpdate.Hide();
            btnDelete.Hide();
            lblID.Hide();
            txtEid.Hide();
            btnSearch1.Hide();
            dataGridView1.Show();
            using (SqlConnection conn = new SqlConnection(connectionstr))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Employe", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt; 
                conn.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAUD.Visible = true;
            lblAddress.Show();
            lblCNIC.Show();
            lblCont.Show();
            lblEmail.Show();
            lblEname.Show();
            lblJT.Show();
            txtAddress.Show();
            txtCnic.Show();
            txtCont.Show();
            txtEmail.Show();
            txtEName.Show();
            txtJT.Show();
            btnDone.Show();
            btnUpdate.Hide();
            btnDelete.Hide();
            btnSearch1.Hide();
            dataGridView1.Hide();
        }

        private void StaffMenu_Load(object sender, EventArgs e)
        {
            
    }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            pnlAUD.Visible = true;
            lblAddress.Show();
            lblCNIC.Show();
            lblCont.Show();
            lblEmail.Show();
            lblEname.Show();
            lblJT.Show();
            txtAddress.Show();
            txtCnic.Show();
            txtCont.Show();
            txtEmail.Show();
            txtEName.Show();
            txtJT.Show();
            btnDone.Hide();
            btnUpdate.Show();
            btnDelete.Hide();
            btnSearch1.Hide();
            dataGridView1.Hide();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            pnlAUD.Visible = true;
            lblAddress.Hide();
            lblCNIC.Hide();
            lblCont.Hide();
            lblEmail.Hide();
            lblEname.Hide();
            lblJT.Hide();
            txtAddress.Hide();
            txtCnic.Hide();
            txtCont.Hide();
            txtEmail.Hide();
            txtEName.Hide();
            txtJT.Hide();
            btnDone.Hide();
            btnUpdate.Hide();
            lblID.Show();
            txtEid.Show();
            btnDelete.Show();
            btnSearch1.Hide();
            dataGridView1.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlAUD.Visible = true;
            lblAddress.Hide();
            lblCNIC.Hide();
            lblCont.Hide();
            lblEmail.Hide();
            lblEname.Hide();
            lblJT.Hide();
            txtAddress.Hide();
            txtCnic.Hide();
            txtCont.Hide();
            txtEmail.Hide();
            txtEName.Hide();
            txtJT.Hide();
            btnDone.Hide();
            btnUpdate.Hide();
            lblID.Show();
            txtEid.Show();
            btnDelete.Hide();
            btnSearch1.Show();
            dataGridView1.Hide();

        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            pnlAUD.Visible = true;
            lblAddress.Hide();
            lblCNIC.Hide();
            lblCont.Hide();
            lblEmail.Hide();
            lblEname.Hide();
            lblJT.Hide();
            txtAddress.Hide();
            txtCnic.Hide();
            txtCont.Hide();
            txtEmail.Hide();
            txtEName.Hide();
            txtJT.Hide();
            btnDone.Hide();
            btnUpdate.Hide();
            btnDelete.Hide();
            lblID.Show();
            txtEid.Show();
            dataGridView1.Show();
            using (SqlConnection conn = new SqlConnection(connectionstr))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Employe where ID = '" + eid + "';", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccessLayer.AddEmploye(txtEid.Text, txtEName.Text, txtJT.Text, txtCnic.Text, txtCont.Text, txtAddress.Text, txtEmail.Text);
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
                DataAccessLayer.UpdateEmploye(txtEid.Text, txtEName.Text, txtJT.Text, txtCnic.Text, txtCont.Text, txtAddress.Text, txtEmail.Text);
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
                DataAccessLayer.DeleteEmploye(txtEid.Text);
                MessageBox.Show("Data Deleted");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
