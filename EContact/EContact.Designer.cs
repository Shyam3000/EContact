namespace EContact
{
    partial class EContact
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxContactID = new TextBox();
            lblContactID = new Label();
            cmbGender = new ComboBox();
            dgvContactList = new DataGridView();
            lblFirstNameID = new Label();
            textBoxFirstName = new TextBox();
            lblContactNumberID = new Label();
            textBoxContactNumber = new TextBox();
            lblLastNameID = new Label();
            textBoxLastName = new TextBox();
            lblAddressID = new Label();
            textBoxAddress = new TextBox();
            lblGenderID = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            lblSearch = new Label();
            textBoxSearch = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnClose = new Button();
            btnMax = new Button();
            btnMin = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContactList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxContactID
            // 
            textBoxContactID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxContactID.Location = new Point(187, 100);
            textBoxContactID.Name = "textBoxContactID";
            textBoxContactID.ReadOnly = true;
            textBoxContactID.Size = new Size(295, 39);
            textBoxContactID.TabIndex = 0;
            // 
            // lblContactID
            // 
            lblContactID.AutoSize = true;
            lblContactID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContactID.Location = new Point(51, 102);
            lblContactID.Name = "lblContactID";
            lblContactID.Size = new Size(126, 32);
            lblContactID.TabIndex = 1;
            lblContactID.Text = "Contact ID";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cmbGender.Location = new Point(187, 555);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(215, 33);
            cmbGender.TabIndex = 2;
            cmbGender.Text = "Select Gender";
            // 
            // dgvContactList
            // 
            dgvContactList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactList.Location = new Point(531, 177);
            dgvContactList.Name = "dgvContactList";
            dgvContactList.RowHeadersWidth = 62;
            dgvContactList.RowTemplate.Height = 33;
            dgvContactList.Size = new Size(634, 412);
            dgvContactList.TabIndex = 3;
            dgvContactList.CellContentClick += dataGridView1_CellContentClick;
            dgvContactList.RowHeaderMouseClick += dgvContactList_RowHeaderMouseClick;
            // 
            // lblFirstNameID
            // 
            lblFirstNameID.AutoSize = true;
            lblFirstNameID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstNameID.Location = new Point(51, 178);
            lblFirstNameID.Name = "lblFirstNameID";
            lblFirstNameID.Size = new Size(129, 32);
            lblFirstNameID.TabIndex = 5;
            lblFirstNameID.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFirstName.Location = new Point(187, 177);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(295, 39);
            textBoxFirstName.TabIndex = 4;
            textBoxFirstName.TextChanged += textBoxFirstName_TextChanged;
            // 
            // lblContactNumberID
            // 
            lblContactNumberID.AutoSize = true;
            lblContactNumberID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContactNumberID.Location = new Point(51, 323);
            lblContactNumberID.Name = "lblContactNumberID";
            lblContactNumberID.Size = new Size(135, 32);
            lblContactNumberID.TabIndex = 9;
            lblContactNumberID.Text = "Contact No";
            // 
            // textBoxContactNumber
            // 
            textBoxContactNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxContactNumber.Location = new Point(187, 322);
            textBoxContactNumber.Name = "textBoxContactNumber";
            textBoxContactNumber.Size = new Size(295, 39);
            textBoxContactNumber.TabIndex = 8;
            // 
            // lblLastNameID
            // 
            lblLastNameID.AutoSize = true;
            lblLastNameID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastNameID.Location = new Point(51, 247);
            lblLastNameID.Name = "lblLastNameID";
            lblLastNameID.Size = new Size(126, 32);
            lblLastNameID.TabIndex = 7;
            lblLastNameID.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastName.Location = new Point(187, 243);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(295, 39);
            textBoxLastName.TabIndex = 6;
            // 
            // lblAddressID
            // 
            lblAddressID.AutoSize = true;
            lblAddressID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddressID.Location = new Point(51, 392);
            lblAddressID.Name = "lblAddressID";
            lblAddressID.Size = new Size(98, 32);
            lblAddressID.TabIndex = 11;
            lblAddressID.Text = "Address";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.Location = new Point(187, 388);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(295, 142);
            textBoxAddress.TabIndex = 10;
            // 
            // lblGenderID
            // 
            lblGenderID.AutoSize = true;
            lblGenderID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenderID.Location = new Point(57, 557);
            lblGenderID.Name = "lblGenderID";
            lblGenderID.Size = new Size(92, 32);
            lblGenderID.TabIndex = 12;
            lblGenderID.Text = "Gender";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 192, 0);
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(193, 633);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(193, 58);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(437, 633);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(193, 58);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(909, 633);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(193, 58);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(666, 633);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(193, 58);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.Location = new Point(531, 122);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(85, 32);
            lblSearch.TabIndex = 19;
            lblSearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(666, 118);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(501, 39);
            textBoxSearch.TabIndex = 18;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1237, 51);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 26);
            label1.TabIndex = 21;
            label1.Text = "Contact Form";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(1167, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(55, 42);
            btnClose.TabIndex = 23;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMax
            // 
            btnMax.BackColor = Color.White;
            btnMax.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnMax.Location = new Point(1106, 5);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(55, 42);
            btnMax.TabIndex = 24;
            btnMax.Text = "[]";
            btnMax.UseVisualStyleBackColor = false;
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.White;
            btnMin.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnMin.Location = new Point(1045, 5);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(55, 42);
            btnMin.TabIndex = 25;
            btnMin.Text = "-";
            btnMin.UseVisualStyleBackColor = false;
            // 
            // EContact
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1237, 740);
            Controls.Add(btnMin);
            Controls.Add(btnMax);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lblSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblGenderID);
            Controls.Add(lblAddressID);
            Controls.Add(textBoxAddress);
            Controls.Add(lblContactNumberID);
            Controls.Add(textBoxContactNumber);
            Controls.Add(lblLastNameID);
            Controls.Add(textBoxLastName);
            Controls.Add(lblFirstNameID);
            Controls.Add(textBoxFirstName);
            Controls.Add(dgvContactList);
            Controls.Add(cmbGender);
            Controls.Add(lblContactID);
            Controls.Add(textBoxContactID);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "EContact";
            Text = "EContact";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContactList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxContactID;
        private Label lblContactID;
        private ComboBox cmbGender;
        private DataGridView dgvContactList;
        private Label lblFirstNameID;
        private TextBox textBoxFirstName;
        private Label lblContactNumberID;
        private TextBox textBoxContactNumber;
        private Label lblLastNameID;
        private TextBox textBoxLastName;
        private Label lblAddressID;
        private TextBox textBoxAddress;
        private Label lblGenderID;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnDelete;
        private Label lblSearch;
        private TextBox textBoxSearch;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button btnClose;
        private Button btnMax;
        private Button btnMin;
    }
}