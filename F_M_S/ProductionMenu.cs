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
    public partial class ProductionMenu : Form
    {
        string connectionstr = @"Data Source = DESKTOP-58TMAQD ; Initial Catalog = FMS ; Integrated Security = true;";

        public ProductionMenu()
        {
            InitializeComponent();
            pnlAUD.Hide();
            dataGridView1.Hide();
        }

        private void pnlAUD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductionMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            pnlAUD.Visible = true;
            lblOID.Hide();
            lblPAmount.Hide();
            lblPCost.Hide();
            lblPtype.Hide();
            lblTCharge.Hide();
            lblCname.Hide();
            cmbPType.Hide();
            txtCname.Hide();
            txtCost.Hide();
            txtOid.Hide();
            txtPAmount.Hide();
            txtTcharges.Hide();
            btnDone.Hide();
            btnSearch1.Hide();
            btnUpdate.Hide();
            btnDelete.Hide();
            dataGridView1.Visible = true;
            using (SqlConnection conn = new SqlConnection(connectionstr))
            {
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Product", conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            pnlAUD.Visible = true;
            lblOID.Show();
            lblPAmount.Hide();
            lblPCost.Hide();
            lblPtype.Hide();
            lblTCharge.Hide();
            lblCname.Hide();
            cmbPType.Hide();
            txtCname.Hide();
            txtCost.Hide();
            txtOid.Show();
            txtPAmount.Hide();
            txtTcharges.Hide();
            btnDone.Hide();
            btnSearch1.Show();
            btnUpdate.Hide();
            btnDelete.Hide();
            dataGridView1.Visible = true;
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {

            pnlAUD.Visible = true;
            lblOID.Show();
            lblPAmount.Hide();
            lblPCost.Hide();
            lblPtype.Hide();
            lblTCharge.Hide();
            lblCname.Hide();
            cmbPType.Hide();
            txtCname.Hide();
            txtCost.Hide();
            txtOid.Show();
            txtPAmount.Hide();
            txtTcharges.Hide();
            btnDone.Hide();
            btnSearch1.Show();
            btnUpdate.Hide();
            btnDelete.Hide();
            dataGridView1.Visible = true;
            using (SqlConnection conn = new SqlConnection(connectionstr))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Product where ProductID = '" + txtOid.Text + "';", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            pnlAUD.Visible = true;
            lblOID.Show();
            lblPAmount.Hide();
            lblPCost.Hide();
            lblPtype.Hide();
            lblTCharge.Hide();
            lblCname.Hide();
            cmbPType.Hide();
            txtCname.Hide();
            txtCost.Hide();
            txtOid.Show();
            txtPAmount.Hide();
            txtTcharges.Hide();
            btnDone.Hide();
            btnSearch1.Hide();
            btnUpdate.Hide();
            btnDelete.Show();
            dataGridView1.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            pnlAUD.Visible = true;
            lblOID.Show();
            lblPAmount.Show();
            lblPCost.Show();
            lblPtype.Show();
            lblTCharge.Show();
            lblCname.Show();
            cmbPType.Show();
            txtCname.Show();
            txtCost.Show();
            txtOid.Show();
            txtPAmount.Show();
            txtTcharges.Show();
            btnDone.Show();
            btnSearch1.Hide();
            btnUpdate.Hide();
            btnDelete.Hide();
            dataGridView1.Visible = false;
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {

            pnlAUD.Visible = true;
            lblOID.Show();
            lblPAmount.Show();
            lblPCost.Show();
            lblPtype.Show();
            lblTCharge.Show();
            lblCname.Show();
            cmbPType.Show();
            txtCname.Show();
            txtCost.Show();
            txtOid.Show();
            txtPAmount.Show();
            txtTcharges.Show();
            btnDone.Hide();
            btnSearch1.Hide();
            btnUpdate.Show();
            btnDelete.Hide();
            dataGridView1.Visible = false;

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccessLayer.AddProduct(txtOid.Text, cmbPType.Text, int.Parse(txtCost.Text), int.Parse(txtPAmount.Text), txtCname.Text, int.Parse(txtTcharges.Text));
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
                DataAccessLayer.UpdateProduct(txtOid.Text, cmbPType.Text, int.Parse(txtCost.Text), int.Parse(txtPAmount.Text), txtCname.Text, int.Parse(txtTcharges.Text));
                MessageBox.Show("Data Updated");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccessLayer.DeleteProduct(txtOid.Text);
                MessageBox.Show("Data Deleted");
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
