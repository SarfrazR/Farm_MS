namespace F_M_S
{
    partial class ProductionMenu
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
            this.txtCname = new System.Windows.Forms.TextBox();
            this.lblCname = new System.Windows.Forms.Label();
            this.txtTcharges = new System.Windows.Forms.TextBox();
            this.lblTCharge = new System.Windows.Forms.Label();
            this.cmbPType = new System.Windows.Forms.ComboBox();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtPAmount = new System.Windows.Forms.TextBox();
            this.lblPAmount = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblPCost = new System.Windows.Forms.Label();
            this.lblPtype = new System.Windows.Forms.Label();
            this.txtOid = new System.Windows.Forms.TextBox();
            this.lblOID = new System.Windows.Forms.Label();
            this.lblDisc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.lblProductionMenu = new System.Windows.Forms.Label();
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
            this.pnlAUD.Controls.Add(this.txtCname);
            this.pnlAUD.Controls.Add(this.lblCname);
            this.pnlAUD.Controls.Add(this.txtTcharges);
            this.pnlAUD.Controls.Add(this.lblTCharge);
            this.pnlAUD.Controls.Add(this.cmbPType);
            this.pnlAUD.Controls.Add(this.btnSearch1);
            this.pnlAUD.Controls.Add(this.dataGridView1);
            this.pnlAUD.Controls.Add(this.btnUpdate);
            this.pnlAUD.Controls.Add(this.btnDelete);
            this.pnlAUD.Controls.Add(this.btnDone);
            this.pnlAUD.Controls.Add(this.txtPAmount);
            this.pnlAUD.Controls.Add(this.lblPAmount);
            this.pnlAUD.Controls.Add(this.txtCost);
            this.pnlAUD.Controls.Add(this.lblPCost);
            this.pnlAUD.Controls.Add(this.lblPtype);
            this.pnlAUD.Controls.Add(this.txtOid);
            this.pnlAUD.Controls.Add(this.lblOID);
            this.pnlAUD.Location = new System.Drawing.Point(236, 89);
            this.pnlAUD.Name = "pnlAUD";
            this.pnlAUD.Size = new System.Drawing.Size(555, 385);
            this.pnlAUD.TabIndex = 28;
            this.pnlAUD.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAUD_Paint);
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(200, 218);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(288, 20);
            this.txtCname.TabIndex = 27;
            // 
            // lblCname
            // 
            this.lblCname.AutoSize = true;
            this.lblCname.BackColor = System.Drawing.Color.White;
            this.lblCname.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCname.Location = new System.Drawing.Point(34, 221);
            this.lblCname.Name = "lblCname";
            this.lblCname.Size = new System.Drawing.Size(122, 17);
            this.lblCname.TabIndex = 26;
            this.lblCname.Text = "Collector\'s Name";
            // 
            // txtTcharges
            // 
            this.txtTcharges.Location = new System.Drawing.Point(200, 192);
            this.txtTcharges.Name = "txtTcharges";
            this.txtTcharges.Size = new System.Drawing.Size(288, 20);
            this.txtTcharges.TabIndex = 25;
            // 
            // lblTCharge
            // 
            this.lblTCharge.AutoSize = true;
            this.lblTCharge.BackColor = System.Drawing.Color.White;
            this.lblTCharge.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCharge.Location = new System.Drawing.Point(34, 195);
            this.lblTCharge.Name = "lblTCharge";
            this.lblTCharge.Size = new System.Drawing.Size(163, 17);
            this.lblTCharge.TabIndex = 24;
            this.lblTCharge.Text = "Transportation Charges";
            // 
            // cmbPType
            // 
            this.cmbPType.FormattingEnabled = true;
            this.cmbPType.Items.AddRange(new object[] {
            "Cow Milk",
            "Buffalo Milk",
            "Desi Eggs",
            "Regular Eggs"});
            this.cmbPType.Location = new System.Drawing.Point(200, 113);
            this.cmbPType.Name = "cmbPType";
            this.cmbPType.Size = new System.Drawing.Size(287, 21);
            this.cmbPType.TabIndex = 23;
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 251);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(220, 289);
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
            this.btnDelete.Location = new System.Drawing.Point(220, 289);
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
            this.btnDone.Location = new System.Drawing.Point(220, 289);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(175, 48);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtPAmount
            // 
            this.txtPAmount.Location = new System.Drawing.Point(200, 166);
            this.txtPAmount.Name = "txtPAmount";
            this.txtPAmount.Size = new System.Drawing.Size(288, 20);
            this.txtPAmount.TabIndex = 13;
            // 
            // lblPAmount
            // 
            this.lblPAmount.AutoSize = true;
            this.lblPAmount.BackColor = System.Drawing.Color.White;
            this.lblPAmount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPAmount.Location = new System.Drawing.Point(34, 169);
            this.lblPAmount.Name = "lblPAmount";
            this.lblPAmount.Size = new System.Drawing.Size(114, 17);
            this.lblPAmount.TabIndex = 12;
            this.lblPAmount.Text = "Product Amount";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(200, 140);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(288, 20);
            this.txtCost.TabIndex = 11;
            // 
            // lblPCost
            // 
            this.lblPCost.AutoSize = true;
            this.lblPCost.BackColor = System.Drawing.Color.White;
            this.lblPCost.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCost.Location = new System.Drawing.Point(34, 143);
            this.lblPCost.Name = "lblPCost";
            this.lblPCost.Size = new System.Drawing.Size(94, 17);
            this.lblPCost.TabIndex = 10;
            this.lblPCost.Text = "Product Cost";
            // 
            // lblPtype
            // 
            this.lblPtype.AutoSize = true;
            this.lblPtype.BackColor = System.Drawing.Color.White;
            this.lblPtype.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPtype.Location = new System.Drawing.Point(34, 117);
            this.lblPtype.Name = "lblPtype";
            this.lblPtype.Size = new System.Drawing.Size(95, 17);
            this.lblPtype.TabIndex = 8;
            this.lblPtype.Text = "Product Type";
            // 
            // txtOid
            // 
            this.txtOid.Location = new System.Drawing.Point(200, 87);
            this.txtOid.Name = "txtOid";
            this.txtOid.Size = new System.Drawing.Size(288, 20);
            this.txtOid.TabIndex = 7;
            // 
            // lblOID
            // 
            this.lblOID.AutoSize = true;
            this.lblOID.BackColor = System.Drawing.Color.White;
            this.lblOID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOID.Location = new System.Drawing.Point(34, 90);
            this.lblOID.Name = "lblOID";
            this.lblOID.Size = new System.Drawing.Size(69, 17);
            this.lblOID.TabIndex = 6;
            this.lblOID.Text = "Order ID";
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.BackColor = System.Drawing.Color.Transparent;
            this.lblDisc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisc.Location = new System.Drawing.Point(361, 54);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(263, 19);
            this.lblDisc.TabIndex = 27;
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
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Welcome to Farmage";
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainMenu.Controls.Add(this.lblProductionMenu);
            this.pnlMainMenu.Controls.Add(this.btnReturn);
            this.pnlMainMenu.Controls.Add(this.btnAdd);
            this.pnlMainMenu.Controls.Add(this.btnDisplay);
            this.pnlMainMenu.Controls.Add(this.btnSearch);
            this.pnlMainMenu.Controls.Add(this.btnDel);
            this.pnlMainMenu.Controls.Add(this.btnUpd);
            this.pnlMainMenu.Location = new System.Drawing.Point(12, 11);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(204, 452);
            this.pnlMainMenu.TabIndex = 25;
            // 
            // lblProductionMenu
            // 
            this.lblProductionMenu.AutoSize = true;
            this.lblProductionMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblProductionMenu.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductionMenu.Location = new System.Drawing.Point(32, 8);
            this.lblProductionMenu.Name = "lblProductionMenu";
            this.lblProductionMenu.Size = new System.Drawing.Size(157, 66);
            this.lblProductionMenu.TabIndex = 4;
            this.lblProductionMenu.Text = "Production \r\n    Menu";
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
            // ProductionMenu
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
            this.Name = "ProductionMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductionMenu";
            this.Load += new System.EventHandler(this.ProductionMenu_Load);
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
        private System.Windows.Forms.ComboBox cmbPType;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtPAmount;
        private System.Windows.Forms.Label lblPAmount;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblPtype;
        private System.Windows.Forms.TextBox txtOid;
        private System.Windows.Forms.Label lblOID;
        private System.Windows.Forms.Label lblDisc;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Label lblProductionMenu;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Label lblPCost;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.Label lblCname;
        private System.Windows.Forms.TextBox txtTcharges;
        private System.Windows.Forms.Label lblTCharge;
    }
}