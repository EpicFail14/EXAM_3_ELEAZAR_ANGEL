namespace EXAM_3_ELEAZAR_ANGEL
{
    partial class MemberDetailsForm
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
            lblNameTitle = new Label();
            lblName = new Label();
            lblTypeTitle = new Label();
            lblType = new Label();
            lblBooksTitle = new Label();
            lstBooks = new ListBox();
            btnReturn = new Button();
            btnExtend = new Button();
            SuspendLayout();
            // 
            // lblNameTitle
            // 
            lblNameTitle.AutoSize = true;
            lblNameTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameTitle.Location = new Point(16, 26);
            lblNameTitle.Name = "lblNameTitle";
            lblNameTitle.Size = new Size(135, 32);
            lblNameTitle.TabIndex = 0;
            lblNameTitle.Text = "Full Name: ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(157, 26);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 32);
            lblName.TabIndex = 1;
            // 
            // lblTypeTitle
            // 
            lblTypeTitle.AutoSize = true;
            lblTypeTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTypeTitle.Location = new Point(16, 75);
            lblTypeTitle.Name = "lblTypeTitle";
            lblTypeTitle.Size = new Size(77, 32);
            lblTypeTitle.TabIndex = 2;
            lblTypeTitle.Text = "Type: ";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblType.Location = new Point(157, 75);
            lblType.Name = "lblType";
            lblType.Size = new Size(0, 32);
            lblType.TabIndex = 3;
            // 
            // lblBooksTitle
            // 
            lblBooksTitle.AutoSize = true;
            lblBooksTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBooksTitle.Location = new Point(16, 123);
            lblBooksTitle.Name = "lblBooksTitle";
            lblBooksTitle.Size = new Size(192, 32);
            lblBooksTitle.TabIndex = 4;
            lblBooksTitle.Text = "Borrowed Books:";
            // 
            // lstBooks
            // 
            lstBooks.FormattingEnabled = true;
            lstBooks.Location = new Point(43, 167);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(393, 179);
            lstBooks.TabIndex = 5;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.DarkRed;
            btnReturn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(43, 363);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(165, 48);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "Return Book";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnExtend
            // 
            btnExtend.BackColor = Color.DarkGreen;
            btnExtend.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExtend.ForeColor = Color.White;
            btnExtend.Location = new Point(271, 363);
            btnExtend.Name = "btnExtend";
            btnExtend.Size = new Size(165, 48);
            btnExtend.TabIndex = 7;
            btnExtend.Text = "Extend Book";
            btnExtend.UseVisualStyleBackColor = false;
            btnExtend.Click += btnExtend_Click;
            // 
            // MemberDetailsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 432);
            Controls.Add(btnExtend);
            Controls.Add(btnReturn);
            Controls.Add(lstBooks);
            Controls.Add(lblBooksTitle);
            Controls.Add(lblType);
            Controls.Add(lblTypeTitle);
            Controls.Add(lblName);
            Controls.Add(lblNameTitle);
            Name = "MemberDetailsForm";
            Text = "Member Details";
            Load += MemberDetailsForm_Load;
            Click += MemberDetailsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNameTitle;
        private Label lblName;
        private Label lblTypeTitle;
        private Label lblType;
        private Label lblBooksTitle;
        private ListBox lstBooks;
        private Button btnReturn;
        private Button btnExtend;
    }
}