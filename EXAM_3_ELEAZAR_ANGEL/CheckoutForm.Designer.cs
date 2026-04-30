namespace EXAM_3_ELEAZAR_ANGEL
{
    partial class CheckoutForm
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
            txtLastName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFirstName = new TextBox();
            txtMiddleInitial = new TextBox();
            label5 = new Label();
            cmbType = new ComboBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(243, 38);
            label1.TabIndex = 0;
            label1.Text = "Fill up the details";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(184, 58);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(189, 39);
            txtLastName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 112);
            label3.Name = "label3";
            label3.Size = new Size(129, 32);
            label3.TabIndex = 3;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 165);
            label4.Name = "label4";
            label4.Size = new Size(154, 32);
            label4.TabIndex = 4;
            label4.Text = "Middle Initial";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(184, 109);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(189, 39);
            txtFirstName.TabIndex = 5;
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiddleInitial.Location = new Point(184, 162);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(189, 39);
            txtMiddleInitial.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 231);
            label5.Name = "label5";
            label5.Size = new Size(77, 32);
            label5.TabIndex = 7;
            label5.Text = "Type: ";
            // 
            // cmbType
            // 
            cmbType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Student", "Faculty", "Guest" });
            cmbType.Location = new Point(95, 231);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(278, 40);
            cmbType.TabIndex = 8;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.DarkRed;
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(67, 287);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(258, 51);
            btnConfirm.TabIndex = 9;
            btnConfirm.Text = "Confirm Checkout";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(67, 348);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(258, 42);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // CheckoutForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 405);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(cmbType);
            Controls.Add(label5);
            Controls.Add(txtMiddleInitial);
            Controls.Add(txtFirstName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtLastName);
            Controls.Add(label1);
            Name = "CheckoutForm";
            Text = "CheckoutForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLastName;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFirstName;
        private TextBox txtMiddleInitial;
        private Label label5;
        private ComboBox cmbType;
        private Button btnConfirm;
        private Button btnCancel;
    }
}