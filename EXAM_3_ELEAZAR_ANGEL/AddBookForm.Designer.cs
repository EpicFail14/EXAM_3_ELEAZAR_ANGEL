namespace EXAM_3_ELEAZAR_ANGEL
{
    partial class AddBookForm
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
            label1 = new Label();
            label2 = new Label();
            txtTitle = new TextBox();
            txtISBN = new TextBox();
            label3 = new Label();
            txtAuthors = new TextBox();
            label4 = new Label();
            txtYear = new TextBox();
            label5 = new Label();
            txtQuantity = new TextBox();
            label6 = new Label();
            btnAddBook = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(248, 45);
            label1.TabIndex = 0;
            label1.Text = "Add New Book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(60, 32);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(119, 81);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(467, 39);
            txtTitle.TabIndex = 2;
            // 
            // txtISBN
            // 
            txtISBN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtISBN.Location = new Point(119, 139);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(467, 39);
            txtISBN.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 139);
            label3.Name = "label3";
            label3.Size = new Size(65, 32);
            label3.TabIndex = 3;
            label3.Text = "ISBN";
            // 
            // txtAuthors
            // 
            txtAuthors.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAuthors.Location = new Point(119, 199);
            txtAuthors.Name = "txtAuthors";
            txtAuthors.Size = new Size(467, 39);
            txtAuthors.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 199);
            label4.Name = "label4";
            label4.Size = new Size(87, 32);
            label4.TabIndex = 5;
            label4.Text = "Author";
            // 
            // txtYear
            // 
            txtYear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtYear.Location = new Point(119, 262);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(467, 39);
            txtYear.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 265);
            label5.Name = "label5";
            label5.Size = new Size(58, 32);
            label5.TabIndex = 7;
            label5.Text = "Year";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(119, 329);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(467, 39);
            txtQuantity.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 332);
            label6.Name = "label6";
            label6.Size = new Size(106, 32);
            label6.TabIndex = 9;
            label6.Text = "Quantity";
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.DarkRed;
            btnAddBook.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddBook.ForeColor = Color.White;
            btnAddBook.Location = new Point(14, 401);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(275, 62);
            btnAddBook.TabIndex = 11;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(311, 401);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(275, 59);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 484);
            Controls.Add(btnCancel);
            Controls.Add(btnAddBook);
            Controls.Add(txtQuantity);
            Controls.Add(label6);
            Controls.Add(txtYear);
            Controls.Add(label5);
            Controls.Add(txtAuthors);
            Controls.Add(label4);
            Controls.Add(txtISBN);
            Controls.Add(label3);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddBookForm";
            Text = "AddBookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTitle;
        private TextBox txtISBN;
        private Label label3;
        private TextBox txtAuthors;
        private Label label4;
        private TextBox txtYear;
        private Label label5;
        private TextBox txtQuantity;
        private Label label6;
        private Button btnAddBook;
        private Button btnCancel;
    }
}