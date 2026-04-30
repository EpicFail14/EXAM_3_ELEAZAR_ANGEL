namespace EXAM_3_ELEAZAR_ANGEL
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelTop = new Panel();
            panelMain = new Panel();
            panelHeaderr = new Panel();
            txtSearch = new TextBox();
            label1 = new Label();
            panelSidebar = new Panel();
            btnMembers = new Button();
            btnAuthors = new Button();
            btnBooks = new Button();
            btnDashboard = new Button();
            panelContainer = new Panel();
            panelMembers = new Panel();
            panelMembersTable = new Panel();
            gridMembers = new DataGridView();
            colMemberId = new DataGridViewTextBoxColumn();
            colMemberName = new DataGridViewTextBoxColumn();
            colMemberType = new DataGridViewTextBoxColumn();
            colMemberStatus = new DataGridViewTextBoxColumn();
            colBorrowedBooks = new DataGridViewTextBoxColumn();
            colTimeline = new DataGridViewTextBoxColumn();
            lblMembersTitle = new Label();
            panelAuthors = new Panel();
            panelAuthorsTable = new Panel();
            gridAuthors = new DataGridView();
            colAuthorName = new DataGridViewTextBoxColumn();
            colBooksCount = new DataGridViewTextBoxColumn();
            lblAuthorsTitle = new Label();
            panelBooks = new Panel();
            gridBooks = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colIsbn = new DataGridViewTextBoxColumn();
            colYear = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            txtSearchBooks = new TextBox();
            btnDelete = new Button();
            btnAddBook = new Button();
            lblBooksTitle = new Label();
            panelDashboard = new Panel();
            panelFee = new Panel();
            lblFee = new Label();
            label4 = new Label();
            btnCalculate = new Button();
            txtDays = new TextBox();
            lblDays = new Label();
            cmbMemberType = new ComboBox();
            lblMemberType = new Label();
            lblFeeTitle = new Label();
            panelCheckout = new Panel();
            btnCheckout = new Button();
            txtBookId = new TextBox();
            lblBookId = new Label();
            lblCheckoutTitle = new Label();
            panel4 = new Panel();
            label10 = new Label();
            lblOverdue = new Label();
            panel3 = new Panel();
            label9 = new Label();
            lblCheckedOut = new Label();
            panel2 = new Panel();
            label8 = new Label();
            lblActiveMembers = new Label();
            panel1 = new Panel();
            label2 = new Label();
            lblTotalBooks = new Label();
            panelHeaderr.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelContainer.SuspendLayout();
            panelMembers.SuspendLayout();
            panelMembersTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridMembers).BeginInit();
            panelAuthors.SuspendLayout();
            panelAuthorsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridAuthors).BeginInit();
            panelBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridBooks).BeginInit();
            panelDashboard.SuspendLayout();
            panelFee.SuspendLayout();
            panelCheckout.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1778, 100);
            panelTop.TabIndex = 1;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.LightGray;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1778, 744);
            panelMain.TabIndex = 1;
            // 
            // panelHeaderr
            // 
            panelHeaderr.BackColor = Color.DarkRed;
            panelHeaderr.Controls.Add(txtSearch);
            panelHeaderr.Controls.Add(label1);
            panelHeaderr.Dock = DockStyle.Top;
            panelHeaderr.Location = new Point(0, 0);
            panelHeaderr.Name = "panelHeaderr";
            panelHeaderr.Size = new Size(1778, 100);
            panelHeaderr.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1207, 39);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(493, 34);
            txtSearch.TabIndex = 1;
            txtSearch.Text = "Search...";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.KeyDown += txtSearch_KeyDown;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 26);
            label1.Name = "label1";
            label1.Size = new Size(500, 48);
            label1.TabIndex = 0;
            label1.Text = "Library Management System";
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.DarkRed;
            panelSidebar.Controls.Add(btnMembers);
            panelSidebar.Controls.Add(btnAuthors);
            panelSidebar.Controls.Add(btnBooks);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 100);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(300, 644);
            panelSidebar.TabIndex = 1;
            // 
            // btnMembers
            // 
            btnMembers.BackColor = Color.Transparent;
            btnMembers.FlatStyle = FlatStyle.Flat;
            btnMembers.ForeColor = Color.White;
            btnMembers.Location = new Point(68, 240);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(160, 45);
            btnMembers.TabIndex = 3;
            btnMembers.Text = "Members";
            btnMembers.UseVisualStyleBackColor = false;
            btnMembers.Click += btnMembers_Click;
            // 
            // btnAuthors
            // 
            btnAuthors.BackColor = Color.Transparent;
            btnAuthors.FlatStyle = FlatStyle.Flat;
            btnAuthors.ForeColor = Color.White;
            btnAuthors.Location = new Point(68, 170);
            btnAuthors.Name = "btnAuthors";
            btnAuthors.Size = new Size(160, 45);
            btnAuthors.TabIndex = 2;
            btnAuthors.Text = "Authors";
            btnAuthors.UseVisualStyleBackColor = false;
            btnAuthors.Click += btnAuthors_Click;
            // 
            // btnBooks
            // 
            btnBooks.BackColor = Color.Transparent;
            btnBooks.FlatStyle = FlatStyle.Flat;
            btnBooks.ForeColor = Color.White;
            btnBooks.Location = new Point(68, 100);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(160, 45);
            btnBooks.TabIndex = 1;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = false;
            btnBooks.Click += btnBooks_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(68, 30);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(160, 45);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.RosyBrown;
            panelContainer.Controls.Add(panelMembers);
            panelContainer.Controls.Add(panelAuthors);
            panelContainer.Controls.Add(panelBooks);
            panelContainer.Controls.Add(panelDashboard);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(300, 100);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1478, 644);
            panelContainer.TabIndex = 1;
            // 
            // panelMembers
            // 
            panelMembers.Controls.Add(panelMembersTable);
            panelMembers.Controls.Add(lblMembersTitle);
            panelMembers.Dock = DockStyle.Fill;
            panelMembers.Location = new Point(0, 0);
            panelMembers.Name = "panelMembers";
            panelMembers.Size = new Size(1478, 644);
            panelMembers.TabIndex = 2;
            panelMembers.Visible = false;
            // 
            // panelMembersTable
            // 
            panelMembersTable.BackColor = Color.White;
            panelMembersTable.BorderStyle = BorderStyle.FixedSingle;
            panelMembersTable.Controls.Add(gridMembers);
            panelMembersTable.Location = new Point(61, 100);
            panelMembersTable.Name = "panelMembersTable";
            panelMembersTable.Size = new Size(1339, 497);
            panelMembersTable.TabIndex = 1;
            // 
            // gridMembers
            // 
            gridMembers.AllowUserToAddRows = false;
            gridMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridMembers.BackgroundColor = Color.White;
            gridMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridMembers.Columns.AddRange(new DataGridViewColumn[] { colMemberId, colMemberName, colMemberType, colMemberStatus, colBorrowedBooks, colTimeline });
            gridMembers.Dock = DockStyle.Fill;
            gridMembers.EnableHeadersVisualStyles = false;
            gridMembers.GridColor = Color.LightGray;
            gridMembers.Location = new Point(0, 0);
            gridMembers.Name = "gridMembers";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridMembers.RowHeadersVisible = false;
            gridMembers.RowHeadersWidth = 62;
            gridMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridMembers.Size = new Size(1337, 495);
            gridMembers.TabIndex = 0;
            gridMembers.CellClick += gridMembers_CellClick;
            // 
            // colMemberId
            // 
            colMemberId.HeaderText = "ID";
            colMemberId.MinimumWidth = 8;
            colMemberId.Name = "colMemberId";
            colMemberId.Visible = false;
            // 
            // colMemberName
            // 
            colMemberName.HeaderText = "Name";
            colMemberName.MinimumWidth = 8;
            colMemberName.Name = "colMemberName";
            // 
            // colMemberType
            // 
            colMemberType.HeaderText = "Type";
            colMemberType.MinimumWidth = 8;
            colMemberType.Name = "colMemberType";
            // 
            // colMemberStatus
            // 
            colMemberStatus.HeaderText = "Status";
            colMemberStatus.MinimumWidth = 8;
            colMemberStatus.Name = "colMemberStatus";
            // 
            // colBorrowedBooks
            // 
            colBorrowedBooks.HeaderText = "Borrowed Books";
            colBorrowedBooks.MinimumWidth = 8;
            colBorrowedBooks.Name = "colBorrowedBooks";
            // 
            // colTimeline
            // 
            colTimeline.HeaderText = "Timeline";
            colTimeline.MinimumWidth = 8;
            colTimeline.Name = "colTimeline";
            // 
            // lblMembersTitle
            // 
            lblMembersTitle.AutoSize = true;
            lblMembersTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMembersTitle.Location = new Point(42, 31);
            lblMembersTitle.Name = "lblMembersTitle";
            lblMembersTitle.Size = new Size(177, 48);
            lblMembersTitle.TabIndex = 0;
            lblMembersTitle.Text = "Members";
            // 
            // panelAuthors
            // 
            panelAuthors.Controls.Add(panelAuthorsTable);
            panelAuthors.Controls.Add(lblAuthorsTitle);
            panelAuthors.Dock = DockStyle.Fill;
            panelAuthors.Location = new Point(0, 0);
            panelAuthors.Name = "panelAuthors";
            panelAuthors.Size = new Size(1478, 644);
            panelAuthors.TabIndex = 5;
            panelAuthors.Visible = false;
            // 
            // panelAuthorsTable
            // 
            panelAuthorsTable.BackColor = Color.White;
            panelAuthorsTable.BorderStyle = BorderStyle.FixedSingle;
            panelAuthorsTable.Controls.Add(gridAuthors);
            panelAuthorsTable.Location = new Point(46, 125);
            panelAuthorsTable.Name = "panelAuthorsTable";
            panelAuthorsTable.Size = new Size(1390, 481);
            panelAuthorsTable.TabIndex = 1;
            // 
            // gridAuthors
            // 
            gridAuthors.AllowUserToAddRows = false;
            gridAuthors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridAuthors.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridAuthors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridAuthors.Columns.AddRange(new DataGridViewColumn[] { colAuthorName, colBooksCount });
            gridAuthors.Dock = DockStyle.Fill;
            gridAuthors.EnableHeadersVisualStyles = false;
            gridAuthors.GridColor = Color.LightGray;
            gridAuthors.Location = new Point(0, 0);
            gridAuthors.Name = "gridAuthors";
            gridAuthors.RowHeadersVisible = false;
            gridAuthors.RowHeadersWidth = 62;
            gridAuthors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridAuthors.Size = new Size(1388, 479);
            gridAuthors.TabIndex = 0;
            // 
            // colAuthorName
            // 
            colAuthorName.HeaderText = "Name";
            colAuthorName.MinimumWidth = 8;
            colAuthorName.Name = "colAuthorName";
            // 
            // colBooksCount
            // 
            colBooksCount.HeaderText = "Books Count";
            colBooksCount.MinimumWidth = 8;
            colBooksCount.Name = "colBooksCount";
            // 
            // lblAuthorsTitle
            // 
            lblAuthorsTitle.AutoSize = true;
            lblAuthorsTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthorsTitle.Location = new Point(32, 46);
            lblAuthorsTitle.Name = "lblAuthorsTitle";
            lblAuthorsTitle.Size = new Size(155, 48);
            lblAuthorsTitle.TabIndex = 0;
            lblAuthorsTitle.Text = "Authors";
            // 
            // panelBooks
            // 
            panelBooks.Controls.Add(gridBooks);
            panelBooks.Controls.Add(txtSearchBooks);
            panelBooks.Controls.Add(btnDelete);
            panelBooks.Controls.Add(btnAddBook);
            panelBooks.Controls.Add(lblBooksTitle);
            panelBooks.Dock = DockStyle.Fill;
            panelBooks.Location = new Point(0, 0);
            panelBooks.Name = "panelBooks";
            panelBooks.Size = new Size(1478, 644);
            panelBooks.TabIndex = 4;
            panelBooks.Visible = false;
            // 
            // gridBooks
            // 
            gridBooks.AllowUserToAddRows = false;
            gridBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridBooks.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridBooks.Columns.AddRange(new DataGridViewColumn[] { colId, colTitle, colIsbn, colYear, colStatus, colQuantity });
            gridBooks.EnableHeadersVisualStyles = false;
            gridBooks.Location = new Point(42, 196);
            gridBooks.Name = "gridBooks";
            gridBooks.RowHeadersVisible = false;
            gridBooks.RowHeadersWidth = 62;
            gridBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridBooks.Size = new Size(1394, 401);
            gridBooks.TabIndex = 4;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            // 
            // colTitle
            // 
            colTitle.HeaderText = "Title";
            colTitle.MinimumWidth = 8;
            colTitle.Name = "colTitle";
            // 
            // colIsbn
            // 
            colIsbn.HeaderText = "ISBN";
            colIsbn.MinimumWidth = 8;
            colIsbn.Name = "colIsbn";
            // 
            // colYear
            // 
            colYear.HeaderText = "Year";
            colYear.MinimumWidth = 8;
            colYear.Name = "colYear";
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Quantity";
            colQuantity.MinimumWidth = 8;
            colQuantity.Name = "colQuantity";
            // 
            // txtSearchBooks
            // 
            txtSearchBooks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchBooks.Location = new Point(1093, 127);
            txtSearchBooks.Name = "txtSearchBooks";
            txtSearchBooks.Size = new Size(343, 39);
            txtSearchBooks.TabIndex = 3;
            txtSearchBooks.Text = "Search books...";
            txtSearchBooks.TextChanged += txtSearchBooks_TextChanged_1;
            txtSearchBooks.Enter += txtSearchBooks_Enter;
            txtSearchBooks.KeyDown += txtSearchBooks_KeyDown;
            txtSearchBooks.Leave += txtSearchBooks_Leave;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.RosyBrown;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(206, 115);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(145, 49);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.DarkRed;
            btnAddBook.FlatStyle = FlatStyle.Flat;
            btnAddBook.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddBook.ForeColor = Color.White;
            btnAddBook.Location = new Point(42, 115);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(145, 49);
            btnAddBook.TabIndex = 1;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // lblBooksTitle
            // 
            lblBooksTitle.AutoSize = true;
            lblBooksTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBooksTitle.Location = new Point(27, 30);
            lblBooksTitle.Name = "lblBooksTitle";
            lblBooksTitle.Size = new Size(123, 48);
            lblBooksTitle.TabIndex = 0;
            lblBooksTitle.Text = "Books";
            // 
            // panelDashboard
            // 
            panelDashboard.Controls.Add(panelFee);
            panelDashboard.Controls.Add(panelCheckout);
            panelDashboard.Controls.Add(panel4);
            panelDashboard.Controls.Add(panel3);
            panelDashboard.Controls.Add(panel2);
            panelDashboard.Controls.Add(panel1);
            panelDashboard.Dock = DockStyle.Fill;
            panelDashboard.Location = new Point(0, 0);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(1478, 644);
            panelDashboard.TabIndex = 0;
            // 
            // panelFee
            // 
            panelFee.BackColor = Color.White;
            panelFee.BorderStyle = BorderStyle.FixedSingle;
            panelFee.Controls.Add(lblFee);
            panelFee.Controls.Add(label4);
            panelFee.Controls.Add(btnCalculate);
            panelFee.Controls.Add(txtDays);
            panelFee.Controls.Add(lblDays);
            panelFee.Controls.Add(cmbMemberType);
            panelFee.Controls.Add(lblMemberType);
            panelFee.Controls.Add(lblFeeTitle);
            panelFee.Location = new Point(42, 415);
            panelFee.Name = "panelFee";
            panelFee.Size = new Size(1398, 203);
            panelFee.TabIndex = 3;
            // 
            // lblFee
            // 
            lblFee.AutoSize = true;
            lblFee.ForeColor = Color.Red;
            lblFee.Location = new Point(74, 162);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(38, 28);
            lblFee.TabIndex = 8;
            lblFee.Text = "0.0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 162);
            label4.Name = "label4";
            label4.Size = new Size(46, 28);
            label4.TabIndex = 4;
            label4.Text = "Fee:";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.DarkRed;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(1063, 105);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(294, 43);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate Fee";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtDays
            // 
            txtDays.Location = new Point(542, 112);
            txtDays.Name = "txtDays";
            txtDays.Size = new Size(489, 34);
            txtDays.TabIndex = 7;
            txtDays.Text = "Enter Days";
            txtDays.Enter += txtDays_Enter;
            txtDays.Leave += txtDays_Leave;
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Location = new Point(531, 72);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(134, 28);
            lblDays.TabIndex = 6;
            lblDays.Text = "Days Overdue";
            // 
            // cmbMemberType
            // 
            cmbMemberType.FormattingEnabled = true;
            cmbMemberType.Items.AddRange(new object[] { "Student", "Faculty", "Guest" });
            cmbMemberType.Location = new Point(36, 112);
            cmbMemberType.Name = "cmbMemberType";
            cmbMemberType.Size = new Size(455, 36);
            cmbMemberType.TabIndex = 5;
            // 
            // lblMemberType
            // 
            lblMemberType.AutoSize = true;
            lblMemberType.Location = new Point(20, 72);
            lblMemberType.Name = "lblMemberType";
            lblMemberType.Size = new Size(132, 28);
            lblMemberType.TabIndex = 4;
            lblMemberType.Text = "Member Type";
            // 
            // lblFeeTitle
            // 
            lblFeeTitle.AutoSize = true;
            lblFeeTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFeeTitle.Location = new Point(20, 22);
            lblFeeTitle.Name = "lblFeeTitle";
            lblFeeTitle.Size = new Size(229, 32);
            lblFeeTitle.TabIndex = 4;
            lblFeeTitle.Text = "Late Fee Calculator";
            // 
            // panelCheckout
            // 
            panelCheckout.BackColor = Color.White;
            panelCheckout.BorderStyle = BorderStyle.FixedSingle;
            panelCheckout.Controls.Add(btnCheckout);
            panelCheckout.Controls.Add(txtBookId);
            panelCheckout.Controls.Add(lblBookId);
            panelCheckout.Controls.Add(lblCheckoutTitle);
            panelCheckout.Location = new Point(42, 209);
            panelCheckout.Name = "panelCheckout";
            panelCheckout.Size = new Size(1398, 176);
            panelCheckout.TabIndex = 2;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.DarkRed;
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(1153, 106);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(204, 43);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "Check Out Book";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(36, 110);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(1083, 34);
            txtBookId.TabIndex = 2;
            txtBookId.Text = "Enter Book ID";
            txtBookId.Enter += txtBookId_Enter;
            txtBookId.Leave += txtBookId_Leave;
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Location = new Point(20, 64);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(81, 28);
            lblBookId.TabIndex = 1;
            lblBookId.Text = "Book ID";
            // 
            // lblCheckoutTitle
            // 
            lblCheckoutTitle.AutoSize = true;
            lblCheckoutTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckoutTitle.Location = new Point(18, 17);
            lblCheckoutTitle.Name = "lblCheckoutTitle";
            lblCheckoutTitle.Size = new Size(185, 32);
            lblCheckoutTitle.TabIndex = 0;
            lblCheckoutTitle.Text = "Checkout Book";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label10);
            panel4.Controls.Add(lblOverdue);
            panel4.Location = new Point(1140, 30);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 150);
            panel4.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 117);
            label10.Name = "label10";
            label10.Size = new Size(145, 28);
            label10.TabIndex = 4;
            label10.Text = "Overdue Books";
            // 
            // lblOverdue
            // 
            lblOverdue.AutoSize = true;
            lblOverdue.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOverdue.ForeColor = Color.Red;
            lblOverdue.Location = new Point(21, 39);
            lblOverdue.Name = "lblOverdue";
            lblOverdue.Size = new Size(46, 54);
            lblOverdue.TabIndex = 4;
            lblOverdue.Text = "0";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(lblCheckedOut);
            panel3.Location = new Point(774, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 150);
            panel3.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 117);
            label9.Name = "label9";
            label9.Size = new Size(182, 28);
            label9.TabIndex = 3;
            label9.Text = "Books Checked Out";
            // 
            // lblCheckedOut
            // 
            lblCheckedOut.AutoSize = true;
            lblCheckedOut.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckedOut.ForeColor = Color.Red;
            lblCheckedOut.Location = new Point(21, 39);
            lblCheckedOut.Name = "lblCheckedOut";
            lblCheckedOut.Size = new Size(46, 54);
            lblCheckedOut.TabIndex = 3;
            lblCheckedOut.Text = "0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(lblActiveMembers);
            panel2.Location = new Point(406, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 150);
            panel2.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 117);
            label8.Name = "label8";
            label8.Size = new Size(153, 28);
            label8.TabIndex = 2;
            label8.Text = "Active Members";
            // 
            // lblActiveMembers
            // 
            lblActiveMembers.AutoSize = true;
            lblActiveMembers.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveMembers.ForeColor = Color.Red;
            lblActiveMembers.Location = new Point(17, 39);
            lblActiveMembers.Name = "lblActiveMembers";
            lblActiveMembers.Size = new Size(46, 54);
            lblActiveMembers.TabIndex = 2;
            lblActiveMembers.Text = "0";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblTotalBooks);
            panel1.Location = new Point(42, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 150);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 117);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 1;
            label2.Text = "Total Books";
            // 
            // lblTotalBooks
            // 
            lblTotalBooks.AutoSize = true;
            lblTotalBooks.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBooks.ForeColor = Color.Red;
            lblTotalBooks.Location = new Point(22, 39);
            lblTotalBooks.Name = "lblTotalBooks";
            lblTotalBooks.Size = new Size(46, 54);
            lblTotalBooks.TabIndex = 0;
            lblTotalBooks.Text = "0";
            // 
            // Form1
            // 
            BackColor = Color.White;
            ClientSize = new Size(1778, 744);
            Controls.Add(panelContainer);
            Controls.Add(panelSidebar);
            Controls.Add(panelHeaderr);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            panelHeaderr.ResumeLayout(false);
            panelHeaderr.PerformLayout();
            panelSidebar.ResumeLayout(false);
            panelContainer.ResumeLayout(false);
            panelMembers.ResumeLayout(false);
            panelMembers.PerformLayout();
            panelMembersTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridMembers).EndInit();
            panelAuthors.ResumeLayout(false);
            panelAuthors.PerformLayout();
            panelAuthorsTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridAuthors).EndInit();
            panelBooks.ResumeLayout(false);
            panelBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridBooks).EndInit();
            panelDashboard.ResumeLayout(false);
            panelFee.ResumeLayout(false);
            panelFee.PerformLayout();
            panelCheckout.ResumeLayout(false);
            panelCheckout.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            // 
            // Form1
            // 

        }

        #endregion
        private Panel panelTop;
        private Panel panelMain;
        private Panel panelHeaderr;
        private Panel panelSidebar;
        private Panel panelContainer;
        private Label label1;
        private Button btnMembers;
        private Button btnAuthors;
        private Button btnBooks;
        private Button btnDashboard;
        private TextBox txtSearch;
        private Panel panelDashboard;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label lblOverdue;
        private Label lblCheckedOut;
        private Label label8;
        private Label lblActiveMembers;
        private Label label10;
        private Label label9;
        private Panel panelFee;
        private Panel panelCheckout;
        private Panel panel1;
        private Label label2;
        private Label lblTotalBooks;
        private Button btnCheckout;
        private TextBox txtBookId;
        private Label lblBookId;
        private Label lblCheckoutTitle;
        private Label lblFeeTitle;
        private ComboBox cmbMemberType;
        private Label lblMemberType;
        private TextBox textBox1;
        private Label label4;
        private Button btnCalculate;
        private TextBox txtDays;
        private Label lblDays;
        private Label lblFee;
        private Panel panelBooks;
        private Button btnAddBook;
        private Label lblBooksTitle;
        private Button btnDelete;
        private DataGridView gridBooks;
        private TextBox txtSearchBooks;
        private Panel panelAuthors;
        private Label lblAuthorsTitle;
        private Panel panelAuthorsTable;
        private DataGridView gridAuthors;
        private DataGridViewTextBoxColumn colAuthorName;
        private DataGridViewTextBoxColumn colBooksCount;
        private Panel panelMembers;
        private Panel panelMembersTable;
        private DataGridView gridMembers;
        private Label lblMembersTitle;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colIsbn;
        private DataGridViewTextBoxColumn colYear;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colMemberId;
        private DataGridViewTextBoxColumn colMemberName;
        private DataGridViewTextBoxColumn colMemberType;
        private DataGridViewTextBoxColumn colMemberStatus;
        private DataGridViewTextBoxColumn colBorrowedBooks;
        private DataGridViewTextBoxColumn colTimeline;
    }
}
