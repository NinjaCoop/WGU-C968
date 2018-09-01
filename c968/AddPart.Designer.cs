namespace c968
{
    partial class AddPartScreen
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
            this.lblAddPart = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInv = new System.Windows.Forms.Label();
            this.lblPriceCost = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddPartSave = new System.Windows.Forms.Button();
            this.btnAddPartCancel = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.addPartIDBox = new System.Windows.Forms.TextBox();
            this.addPartNameBox = new System.Windows.Forms.TextBox();
            this.addPartInvBox = new System.Windows.Forms.TextBox();
            this.addPartPriceBox = new System.Windows.Forms.TextBox();
            this.addPartMachComBox = new System.Windows.Forms.TextBox();
            this.addPartMaxBox = new System.Windows.Forms.TextBox();
            this.addPartMinBox = new System.Windows.Forms.TextBox();
            this.radioAddOutsourced = new System.Windows.Forms.RadioButton();
            this.radioAddInHouse = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblAddPart
            // 
            this.lblAddPart.AutoSize = true;
            this.lblAddPart.Location = new System.Drawing.Point(13, 13);
            this.lblAddPart.Name = "lblAddPart";
            this.lblAddPart.Size = new System.Drawing.Size(48, 13);
            this.lblAddPart.TabIndex = 0;
            this.lblAddPart.Text = "Add Part";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(45, 70);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblInv
            // 
            this.lblInv.AutoSize = true;
            this.lblInv.Location = new System.Drawing.Point(45, 150);
            this.lblInv.Name = "lblInv";
            this.lblInv.Size = new System.Drawing.Size(22, 13);
            this.lblInv.TabIndex = 5;
            this.lblInv.Text = "Inv";
            // 
            // lblPriceCost
            // 
            this.lblPriceCost.AutoSize = true;
            this.lblPriceCost.Location = new System.Drawing.Point(45, 190);
            this.lblPriceCost.Name = "lblPriceCost";
            this.lblPriceCost.Size = new System.Drawing.Size(57, 13);
            this.lblPriceCost.TabIndex = 6;
            this.lblPriceCost.Text = "Price/Cost";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(45, 230);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(27, 13);
            this.lblMax.TabIndex = 7;
            this.lblMax.Text = "Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Machine ID";
            // 
            // btnAddPartSave
            // 
            this.btnAddPartSave.Location = new System.Drawing.Point(195, 325);
            this.btnAddPartSave.Name = "btnAddPartSave";
            this.btnAddPartSave.Size = new System.Drawing.Size(75, 23);
            this.btnAddPartSave.TabIndex = 9;
            this.btnAddPartSave.Text = "Save";
            this.btnAddPartSave.UseVisualStyleBackColor = true;
            this.btnAddPartSave.Click += new System.EventHandler(this.btnAddPartSave_Click);
            // 
            // btnAddPartCancel
            // 
            this.btnAddPartCancel.Location = new System.Drawing.Point(285, 325);
            this.btnAddPartCancel.Name = "btnAddPartCancel";
            this.btnAddPartCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAddPartCancel.TabIndex = 10;
            this.btnAddPartCancel.Text = "Cancel";
            this.btnAddPartCancel.UseVisualStyleBackColor = true;
            this.btnAddPartCancel.Click += new System.EventHandler(this.btnAddPartCancel_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(220, 230);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(24, 13);
            this.lblMin.TabIndex = 8;
            this.lblMin.Text = "Min";
            // 
            // addPartIDBox
            // 
            this.addPartIDBox.Location = new System.Drawing.Point(130, 67);
            this.addPartIDBox.Name = "addPartIDBox";
            this.addPartIDBox.ReadOnly = true;
            this.addPartIDBox.Size = new System.Drawing.Size(120, 20);
            this.addPartIDBox.TabIndex = 12;
            this.addPartIDBox.Text = "Auto Gen - Disabled";
            // 
            // addPartNameBox
            // 
            this.addPartNameBox.Location = new System.Drawing.Point(130, 107);
            this.addPartNameBox.Name = "addPartNameBox";
            this.addPartNameBox.Size = new System.Drawing.Size(120, 20);
            this.addPartNameBox.TabIndex = 13;
            this.addPartNameBox.Text = "Part Name";
            // 
            // addPartInvBox
            // 
            this.addPartInvBox.Location = new System.Drawing.Point(130, 147);
            this.addPartInvBox.Name = "addPartInvBox";
            this.addPartInvBox.Size = new System.Drawing.Size(120, 20);
            this.addPartInvBox.TabIndex = 14;
            this.addPartInvBox.Text = "Inv";
            // 
            // addPartPriceBox
            // 
            this.addPartPriceBox.Location = new System.Drawing.Point(130, 187);
            this.addPartPriceBox.Name = "addPartPriceBox";
            this.addPartPriceBox.Size = new System.Drawing.Size(120, 20);
            this.addPartPriceBox.TabIndex = 15;
            this.addPartPriceBox.Text = "Price/Cost";
            // 
            // addPartMachComBox
            // 
            this.addPartMachComBox.Location = new System.Drawing.Point(130, 267);
            this.addPartMachComBox.Name = "addPartMachComBox";
            this.addPartMachComBox.Size = new System.Drawing.Size(120, 20);
            this.addPartMachComBox.TabIndex = 18;
            this.addPartMachComBox.Text = "Mach ID";
            // 
            // addPartMaxBox
            // 
            this.addPartMaxBox.Location = new System.Drawing.Point(130, 227);
            this.addPartMaxBox.Name = "addPartMaxBox";
            this.addPartMaxBox.Size = new System.Drawing.Size(60, 20);
            this.addPartMaxBox.TabIndex = 16;
            this.addPartMaxBox.Text = "Max";
            // 
            // addPartMinBox
            // 
            this.addPartMinBox.Location = new System.Drawing.Point(260, 227);
            this.addPartMinBox.Name = "addPartMinBox";
            this.addPartMinBox.Size = new System.Drawing.Size(60, 20);
            this.addPartMinBox.TabIndex = 17;
            this.addPartMinBox.Text = "Min";
            // 
            // radioAddOutsourced
            // 
            this.radioAddOutsourced.AutoSize = true;
            this.radioAddOutsourced.Location = new System.Drawing.Point(210, 25);
            this.radioAddOutsourced.Name = "radioAddOutsourced";
            this.radioAddOutsourced.Size = new System.Drawing.Size(80, 17);
            this.radioAddOutsourced.TabIndex = 2;
            this.radioAddOutsourced.TabStop = true;
            this.radioAddOutsourced.Text = "Outsourced";
            this.radioAddOutsourced.UseVisualStyleBackColor = true;
            this.radioAddOutsourced.CheckedChanged += new System.EventHandler(this.radioAddOutsourced_CheckedChanged);
            // 
            // radioAddInHouse
            // 
            this.radioAddInHouse.AutoSize = true;
            this.radioAddInHouse.Checked = true;
            this.radioAddInHouse.Location = new System.Drawing.Point(110, 25);
            this.radioAddInHouse.Name = "radioAddInHouse";
            this.radioAddInHouse.Size = new System.Drawing.Size(68, 17);
            this.radioAddInHouse.TabIndex = 1;
            this.radioAddInHouse.TabStop = true;
            this.radioAddInHouse.Text = "In-House";
            this.radioAddInHouse.UseVisualStyleBackColor = true;
            this.radioAddInHouse.CheckedChanged += new System.EventHandler(this.radioAddInHouse_CheckedChanged);
            // 
            // AddPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.addPartMinBox);
            this.Controls.Add(this.addPartMaxBox);
            this.Controls.Add(this.addPartMachComBox);
            this.Controls.Add(this.addPartPriceBox);
            this.Controls.Add(this.addPartInvBox);
            this.Controls.Add(this.addPartNameBox);
            this.Controls.Add(this.addPartIDBox);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.btnAddPartCancel);
            this.Controls.Add(this.btnAddPartSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblPriceCost);
            this.Controls.Add(this.lblInv);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.radioAddOutsourced);
            this.Controls.Add(this.radioAddInHouse);
            this.Controls.Add(this.lblAddPart);
            this.Name = "AddPartScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddPart;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInv;
        private System.Windows.Forms.Label lblPriceCost;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddPartSave;
        private System.Windows.Forms.Button btnAddPartCancel;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox addPartIDBox;
        private System.Windows.Forms.TextBox addPartNameBox;
        private System.Windows.Forms.TextBox addPartInvBox;
        private System.Windows.Forms.TextBox addPartPriceBox;
        private System.Windows.Forms.TextBox addPartMachComBox;
        private System.Windows.Forms.TextBox addPartMaxBox;
        private System.Windows.Forms.TextBox addPartMinBox;
        private System.Windows.Forms.RadioButton radioAddOutsourced;
        private System.Windows.Forms.RadioButton radioAddInHouse;

        public int AddPartIDBoxText
        {
            get { return int.Parse(addPartIDBox.Text); }
            set { addPartIDBox.Text = value.ToString(); }
        }
        public string AddPartNameBoxText
        {
            get { return addPartNameBox.Text; }
            set { addPartNameBox.Text = value; }
        }
        public int AddPartInvBoxText
        {
            get { return int.Parse(addPartInvBox.Text); }
            set { addPartInvBox.Text = value.ToString(); }
        }
        public decimal AddPartPriceBoxText
        {
            get { return decimal.Parse(addPartPriceBox.Text); }
            set { addPartPriceBox.Text = value.ToString(); }
        }
        public int AddPartMaxBoxText
        {
            get { return int.Parse(addPartMaxBox.Text); }
            set { addPartMaxBox.Text = value.ToString(); }
        }
        public int AddPartMinBoxText
        {
            get { return int.Parse(addPartMinBox.Text); }
            set { addPartMinBox.Text = value.ToString(); }
        }
        // Keep this as a string since no calculations will be done
        public string AddPartMachComBoxText
        {
            get { return addPartMachComBox.Text; }
            set { addPartMachComBox.Text = value; }
        }
    }
}