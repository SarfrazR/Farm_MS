namespace F_M_S
{
    partial class AnimalMenu
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
            this.pnlAUD = new System.Windows.Forms.Panel();
            this.lblDet = new System.Windows.Forms.Label();
            this.cmAType = new System.Windows.Forms.ComboBox();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.lblProd = new System.Windows.Forms.Label();
            this.txtFeed = new System.Windows.Forms.TextBox();
            this.lblFeed = new System.Windows.Forms.Label();
            this.lblAtype = new System.Windows.Forms.Label();
            this.txtAid = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDisc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.lblAnimalMenu = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.pnlAUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAUD
            // 
            this.pnlAUD.BackColor = System.Drawing.Color.Transparent;
            this.pnlAUD.Controls.Add(this.lblDet);
            this.pnlAUD.Controls.Add(this.cmAType);
            this.pnlAUD.Controls.Add(this.btnSearch1);
            this.pnlAUD.Controls.Add(this.dataGridView1);
            this.pnlAUD.Controls.Add(this.btnUpdate);
            this.pnlAUD.Controls.Add(this.btnDelete);
            this.pnlAUD.Controls.Add(this.btnDone);
            this.pnlAUD.Controls.Add(this.txtOut);
            this.pnlAUD.Controls.Add(this.lblProd);
            this.pnlAUD.Controls.Add(this.txtFeed);
            this.pnlAUD.Controls.Add(this.lblFeed);
            this.pnlAUD.Controls.Add(this.lblAtype);
            this.pnlAUD.Controls.Add(this.txtAid);
            this.pnlAUD.Controls.Add(this.lblID);
            this.pnlAUD.Location = new System.Drawing.Point(236, 89);
            this.pnlAUD.Name = "pnlAUD";
            this.pnlAUD.Size = new System.Drawing.Size(555, 385);
            this.pnlAUD.TabIndex = 24;
            // 
            // lblDet
            // 
            this.lblDet.AutoSize = true;
            this.lblDet.BackColor = System.Drawing.Color.White;
            this.lblDet.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDet.Location = new System.Drawing.Point(3, 186);
            this.lblDet.Name = "lblDet";
            this.lblDet.Size = new System.Drawing.Size(242, 14);
            this.lblDet.TabIndex = 24;
            this.lblDet.Text = "( Enter Number of litres of Milk or Eggs Produced)";
            // 
            // cmAType
            // 
            this.cmAType.FormattingEnabled = true;
            this.cmAType.Items.AddRange(new object[] {
            "Chicken",
            "Cow",
            "Buffalo"});
            this.cmAType.Location = new System.Drawing.Point(176, 116);
            this.cmAType.Name = "cmAType";
            this.cmAType.Size = new System.Drawing.Size(287, 21);
            this.cmAType.TabIndex = 23;
            // 
            // btnSearch1
            // 
            this.btnSearch1.BackColor = System.Drawing.Color.White;
            this.btnSearch1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch1.Location = new System.Drawing.Point(220, 3);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(175, 48);
            this.btnSearch1.TabIndex = 22;
            this.btnSearch1.Text = "Search";
            this.btnSearch1.UseVisualStyleBackColor = false;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(220, 281);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(175, 48);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(220, 281);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 48);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.White;
            this.btnDone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(220, 281);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(175, 48);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(176, 166);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(288, 20);
            this.txtOut.TabIndex = 13;
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.BackColor = System.Drawing.Color.White;
            this.lblProd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.Location = new System.Drawing.Point(53, 169);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(59, 17);
            this.lblProd.TabIndex = 12;
            this.lblProd.Text = "Product";
            // 
            // txtFeed
            // 
            this.txtFeed.Location = new System.Drawing.Point(176, 140);
            this.txtFeed.Name = "txtFeed";
            this.txtFeed.Size = new System.Drawing.Size(288, 20);
            this.txtFeed.TabIndex = 11;
            // 
            // lblFeed
            // 
            this.lblFeed.AutoSize = true;
            this.lblFeed.BackColor = System.Drawing.Color.White;
            this.lblFeed.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeed.Location = new System.Drawing.Point(53, 143);
            this.lblFeed.Name = "lblFeed";
            this.lblFeed.Size = new System.Drawing.Size(41, 17);
            this.lblFeed.TabIndex = 10;
            this.lblFeed.Text = "Feed";
            // 
            // lblAtype
            // 
            this.lblAtype.AutoSize = true;
            this.lblAtype.BackColor = System.Drawing.Color.White;
            this.lblAtype.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtype.Location = new System.Drawing.Point(53, 117);
            this.lblAtype.Name = "lblAtype";
            this.lblAtype.Size = new System.Drawing.Size(90, 17);
            this.lblAtype.TabIndex = 8;
            this.lblAtype.Text = "Animal Type";
            // 
            // txtAid
            // 
            this.txtAid.Location = new System.Drawing.Point(176, 88);
            this.txtAid.Name = "txtAid";
            this.txtAid.Size = new System.Drawing.Size(288, 20);
            this.txtAid.TabIndex = 7;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.White;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(53, 91);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(75, 17);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "Animal ID";
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.BackColor = System.Drawing.Color.Transparent;
            this.lblDisc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisc.Location = new System.Drawing.Point(361, 54);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(263, 19);
            this.lblDisc.TabIndex = 23;
            this.lblDisc.Text = "( A Solution to problems of your Farm )";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(327, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(343, 43);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Welcome to Farmage";
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainMenu.Controls.Add(this.lblAnimalMenu);
            this.pnlMainMenu.Controls.Add(this.btnReturn);
            this.pnlMainMenu.Controls.Add(this.btnAdd);
            this.pnlMainMenu.Controls.Add(this.btnDisplay);
            this.pnlMainMenu.Controls.Add(this.btnSearch);
            this.pnlMainMenu.Controls.Add(this.btnDel);
            this.pnlMainMenu.Controls.Add(this.btnUpd);
            this.pnlMainMenu.Location = new System.Drawing.Point(12, 11);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(204, 452);
            this.pnlMainMenu.TabIndex = 21;
            // 
            // lblAnimalMenu
            // 
            this.lblAnimalMenu.AutoSize = true;
            this.lblAnimalMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblAnimalMenu.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimalMenu.Location = new System.Drawing.Point(8, 8);
            this.lblAnimalMenu.Name = "lblAnimalMenu";
            this.lblAnimalMenu.Size = new System.Drawing.Size(182, 33);
            this.lblAnimalMenu.TabIndex = 4;
            this.lblAnimalMenu.Text = "Animal Menu";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Red;
            this.btnReturn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnReturn.Location = new System.Drawing.Point(14, 396);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(175, 48);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(14, 126);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 48);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.White;
            this.btnDisplay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDisplay.Location = new System.Drawing.Point(14, 342);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(175, 48);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(14, 288);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(175, 48);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.White;
            this.btnDel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDel.Location = new System.Drawing.Point(14, 234);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(175, 48);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.BackColor = System.Drawing.Color.White;
            this.btnUpd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpd.Location = new System.Drawing.Point(14, 180);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(175, 48);
            this.btnUpd.TabIndex = 1;
            this.btnUpd.Text = "Update";
            this.btnUpd.UseVisualStyleBackColor = false;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // AnimalMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::F_M_S.Properties.Resources.pexels_jonathan_petersson_1198507;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 484);
            this.Controls.Add(this.pnlAUD);
            this.Controls.Add(this.lblDisc);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AnimalMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnimalMenu";
            this.Load += new System.EventHandler(this.AnimalMenu_Load);
            this.pnlAUD.ResumeLayout(false);
            this.pnlAUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAUD;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.TextBox txtFeed;
        private System.Windows.Forms.Label lblFeed;
        private System.Windows.Forms.Label lblAtype;
        private System.Windows.Forms.TextBox txtAid;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDisc;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Label lblAnimalMenu;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.ComboBox cmAType;
        private System.Windows.Forms.Label lblDet;
    }
}