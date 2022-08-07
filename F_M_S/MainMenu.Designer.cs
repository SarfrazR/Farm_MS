namespace F_M_S
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnMedical = new System.Windows.Forms.Button();
            this.btnAnimals = new System.Windows.Forms.Button();
            this.lblDisc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainMenu.Controls.Add(this.label1);
            this.pnlMainMenu.Controls.Add(this.btnLogout);
            this.pnlMainMenu.Controls.Add(this.btnStaff);
            this.pnlMainMenu.Controls.Add(this.btnAccounts);
            this.pnlMainMenu.Controls.Add(this.btnSale);
            this.pnlMainMenu.Controls.Add(this.btnMedical);
            this.pnlMainMenu.Controls.Add(this.btnAnimals);
            this.pnlMainMenu.Location = new System.Drawing.Point(12, 12);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(204, 452);
            this.pnlMainMenu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Main Menu";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Location = new System.Drawing.Point(14, 396);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(175, 48);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.White;
            this.btnStaff.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.Location = new System.Drawing.Point(14, 126);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(175, 48);
            this.btnStaff.TabIndex = 5;
            this.btnStaff.Text = "Staff Details";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.BackColor = System.Drawing.Color.White;
            this.btnAccounts.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnAccounts.Location = new System.Drawing.Point(14, 342);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(175, 48);
            this.btnAccounts.TabIndex = 4;
            this.btnAccounts.Text = "Accounts Details";
            this.btnAccounts.UseVisualStyleBackColor = false;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.White;
            this.btnSale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnSale.Location = new System.Drawing.Point(14, 288);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(175, 48);
            this.btnSale.TabIndex = 3;
            this.btnSale.Text = "Production Details";
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnMedical
            // 
            this.btnMedical.BackColor = System.Drawing.Color.White;
            this.btnMedical.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnMedical.Location = new System.Drawing.Point(14, 234);
            this.btnMedical.Name = "btnMedical";
            this.btnMedical.Size = new System.Drawing.Size(175, 48);
            this.btnMedical.TabIndex = 2;
            this.btnMedical.Text = "Medical Details";
            this.btnMedical.UseVisualStyleBackColor = false;
            this.btnMedical.Click += new System.EventHandler(this.btnMedical_Click);
            // 
            // btnAnimals
            // 
            this.btnAnimals.BackColor = System.Drawing.Color.White;
            this.btnAnimals.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnAnimals.Location = new System.Drawing.Point(14, 180);
            this.btnAnimals.Name = "btnAnimals";
            this.btnAnimals.Size = new System.Drawing.Size(175, 48);
            this.btnAnimals.TabIndex = 1;
            this.btnAnimals.Text = "Animal Details";
            this.btnAnimals.UseVisualStyleBackColor = false;
            this.btnAnimals.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.BackColor = System.Drawing.Color.Transparent;
            this.lblDisc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisc.Location = new System.Drawing.Point(298, 55);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(263, 19);
            this.lblDisc.TabIndex = 3;
            this.lblDisc.Text = "( A Solution to problems of your Farm )";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(264, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(343, 43);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Welcome to Farmage";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::F_M_S.Properties.Resources.pexels_pixabay_235725;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 484);
            this.Controls.Add(this.lblDisc);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Button btnAnimals;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnMedical;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDisc;
        private System.Windows.Forms.Label lblTitle;
    }
}