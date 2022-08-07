using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F_M_S
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnimalMenu animalMenu = new AnimalMenu();
            animalMenu.Show();
            
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            ProductionMenu productionMenu = new ProductionMenu();   
            productionMenu.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            StaffMenu staffMenu = new StaffMenu();
            staffMenu.Show();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            AccountsMenu accountsMenu = new AccountsMenu();
            accountsMenu.Show();
        }

        private void btnMedical_Click(object sender, EventArgs e)
        {
            MedicalMenu medicicalMenu = new MedicalMenu();
            medicicalMenu.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
