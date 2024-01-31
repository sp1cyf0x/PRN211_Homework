﻿namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            dgvMemberList = new DataGridView();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMemberId = new TextBox();
            txtMemberName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            cbCountry = new CheckBox();
            cbCity = new CheckBox();
            groupFilter = new GroupBox();
            btnFilter = new Button();
            groupBox1 = new GroupBox();
            txtMemberNameSearch = new TextBox();
            txtMemberIdSearch = new TextBox();
            label8 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            groupFilter.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMemberList
            // 
            dgvMemberList.AllowUserToOrderColumns = true;
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(10, 130);
            dgvMemberList.Margin = new Padding(3, 2, 3, 2);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new Size(654, 142);
            dgvMemberList.TabIndex = 0;
            dgvMemberList.CellContentClick += dgvMemberList_CellContentClick;
            dgvMemberList.CellValueChanged += dgvMemberList_CellValueChanged;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(164, 104);
            btnInsert.Margin = new Padding(3, 2, 3, 2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(82, 22);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(286, 104);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(402, 104);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(5, 115);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 6;
            label1.Text = "Member ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 44);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 7;
            label2.Text = "Member Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(402, 18);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(402, 44);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 68);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 10;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(402, 68);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 11;
            label6.Text = "Country";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(164, 16);
            txtMemberId.Margin = new Padding(3, 2, 3, 2);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.ReadOnly = true;
            txtMemberId.Size = new Size(148, 23);
            txtMemberId.TabIndex = 12;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(164, 40);
            txtMemberName.Margin = new Padding(3, 2, 3, 2);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.ReadOnly = true;
            txtMemberName.Size = new Size(148, 23);
            txtMemberName.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(517, 18);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(148, 23);
            txtEmail.TabIndex = 14;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(517, 42);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(148, 23);
            txtPassword.TabIndex = 15;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(164, 65);
            txtCity.Margin = new Padding(3, 2, 3, 2);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(148, 23);
            txtCity.TabIndex = 16;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(517, 65);
            txtCountry.Margin = new Padding(3, 2, 3, 2);
            txtCountry.Name = "txtCountry";
            txtCountry.ReadOnly = true;
            txtCountry.Size = new Size(148, 23);
            txtCountry.TabIndex = 17;
            // 
            // cbCountry
            // 
            cbCountry.AutoSize = true;
            cbCountry.Location = new Point(7, 20);
            cbCountry.Margin = new Padding(3, 2, 3, 2);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(69, 19);
            cbCountry.TabIndex = 19;
            cbCountry.Text = "Country";
            cbCountry.UseVisualStyleBackColor = true;
            cbCountry.Click += cbCountry_Click;
            // 
            // cbCity
            // 
            cbCity.AutoSize = true;
            cbCity.Location = new Point(7, 42);
            cbCity.Margin = new Padding(3, 2, 3, 2);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(47, 19);
            cbCity.TabIndex = 20;
            cbCity.Text = "City";
            cbCity.UseVisualStyleBackColor = true;
            cbCity.Click += cbCity_Click;
            // 
            // groupFilter
            // 
            groupFilter.Controls.Add(btnFilter);
            groupFilter.Controls.Add(cbCity);
            groupFilter.Controls.Add(cbCountry);
            groupFilter.Location = new Point(685, 16);
            groupFilter.Margin = new Padding(3, 2, 3, 2);
            groupFilter.Name = "groupFilter";
            groupFilter.Padding = new Padding(3, 2, 3, 2);
            groupFilter.Size = new Size(184, 95);
            groupFilter.TabIndex = 21;
            groupFilter.TabStop = false;
            groupFilter.Text = "Filter by:";
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(7, 64);
            btnFilter.Margin = new Padding(3, 2, 3, 2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(82, 22);
            btnFilter.TabIndex = 22;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMemberNameSearch);
            groupBox1.Controls.Add(txtMemberIdSearch);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Location = new Point(685, 130);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(184, 142);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search by:";
            // 
            // txtMemberNameSearch
            // 
            txtMemberNameSearch.Location = new Point(5, 83);
            txtMemberNameSearch.Margin = new Padding(3, 2, 3, 2);
            txtMemberNameSearch.Name = "txtMemberNameSearch";
            txtMemberNameSearch.Size = new Size(171, 23);
            txtMemberNameSearch.TabIndex = 26;
            // 
            // txtMemberIdSearch
            // 
            txtMemberIdSearch.Location = new Point(5, 34);
            txtMemberIdSearch.Margin = new Padding(3, 2, 3, 2);
            txtMemberIdSearch.Name = "txtMemberIdSearch";
            txtMemberIdSearch.Size = new Size(171, 23);
            txtMemberIdSearch.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 66);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 24;
            label8.Text = "Member Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 17);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 24;
            label7.Text = "Member ID:";
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 285);
            Controls.Add(groupBox1);
            Controls.Add(groupFilter);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dgvMemberList);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMemberManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Management";
            Load += frmMemberManagement_Load;
            Click += cbCity_Click;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            groupFilter.ResumeLayout(false);
            groupFilter.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMemberList;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox txtMemberName;
        private TextBox txtMemberId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupFilter;
        private CheckBox cbCity;
        private CheckBox cbCountry;
        private Button btnFilter;
        private GroupBox groupBox1;
        private TextBox txtMemberNameSearch;
        private TextBox txtMemberIdSearch;
        private Label label8;
        private Label label7;
    }
}