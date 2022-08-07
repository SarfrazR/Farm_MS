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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (txtUsername.Text == "Umer" && txtPassword.Text == "1234")
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show(this);
            }
            else if (txtUsername.Text == "Arzu" && txtPassword.Text == "5678")
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show(this);
            }
            else
            {
                    MessageBox.Show("Wrong Username or Password!\n\tTry Again\n");
            }

        }
    }
}
