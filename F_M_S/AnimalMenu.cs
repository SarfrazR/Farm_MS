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
    public partial class AnimalMenu : Form
    {

        string connectionstr = @"Data Source = DESKTOP-58TMAQD ; Initial Catalog = FMS ; Integrated Security = true;";
        string Aid = "";
        public AnimalMenu()
        {
            InitializeComponent();
            pnlAUD.Visible = false;
            dataGridView1.Hide();
            Aid = txtAid.Text;
            lblDet.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            pnlAUD.Visible = true;
            lblAtype.Hide();
            lblFeed.Hide();
            lblID.Hide();
            lblProd.Hide();
            txtAid.Hide();
            txtFeed.Hide();
            txtOut.Hide();
            cmAType.Hide();
            btnDone.Hide();
            btnSearch1.Hide();
            btnUpdate.Hide();
            btnDelete.Hide();
            lblDet.Hide();
            dataGridView1.Show();
            using (SqlConnection conn = new SqlConnection(connectionstr))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Animal", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAUD.Visible=true;
            pnlAUD.Show();
            lblAtype.Show();
            lblFeed.Show();
            lblID.Show();
            lblProd.Show();
            txtAid.Show();
            txtFeed.Show();
            txtOut.Show();
            cmAType.Show();
            btnDone.Show();
            btnDelete.Hide();
            btnUpdate.Hide();
            btnSearch1.Hide();
            lblDet.Show();
            dataGridView1.Hide();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            pnlAUD.Visible = true;
            lblAtype.Show();
            lblFeed.Show();
            lblID.Show();
            lblProd.Show();
            txtAid.Show();
            txtFeed.Show();
            cmAType.Show();
            txtOut.Show();
            btnDone.Hide();
            btnDelete.Hide();
            btnUpdate.Show();
            lblDet.Show();
            btnSearch1.Hide();
            dataGridView1.Hide();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            pnlAUD.Visible=true;
            lblAtype.Hide();
            lblFeed.Hide();
            lblID.Show();
            lblProd.Hide();
            txtAid.Show();
            txtFeed.Hide();
            txtOut.Hide();
            cmAType.Hide();
            btnDone.Hide();
            btnSearch1.Hide();
            btnUpdate.Hide();
            btnDelete.Show();
            lblDet.Hide();
            dataGridView1.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlAUD.Visible=true ;
            lblAtype.Hide();
            lblFeed.Hide();
            lblID.Show();
            lblProd.Hide();
            txtAid.Show();
            txtFeed.Hide();
            txtOut.Hide();
            cmAType.Hide();
            btnDone.Hide();
            btnSearch1.Show();
            btnUpdate.Hide();
            btnDelete.Hide();
            lblDet.Hide();
            dataGridView1.Hide();
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            pnlAUD.Visible = true ;
            lblAtype.Hide();
            lblFeed.Hide();
            lblID.Show();
            lblProd.Hide();
            txtAid.Show();
            txtFeed.Hide();
            txtOut.Hide();
            cmAType.Hide();
            btnDone.Hide();
            btnSearch1.Show();
            btnUpdate.Hide();
            btnDelete.Hide();
            lblDet.Hide();
            dataGridView1.Show();
            using (SqlConnection conn = new SqlConnection(connectionstr))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Animal where AnimalID = '" + Aid + "';", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
        }

        private void AnimalMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccessLayer.AddAnimal(txtAid.Text, cmAType.Text, txtFeed.Text, int.Parse(txtOut.Text));
                MessageBox.Show("Data Added");
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
                DataAccessLayer.DeleteAnimal(txtAid.Text);
                MessageBox.Show("Data Deleted");
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
                DataAccessLayer.UpdateAnimal(txtAid.Text, cmAType.Text, txtFeed.Text, int.Parse(txtOut.Text));
                MessageBox.Show("Data Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
