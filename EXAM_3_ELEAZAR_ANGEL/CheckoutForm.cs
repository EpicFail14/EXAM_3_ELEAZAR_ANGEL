using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EXAM_3_ELEAZAR_ANGEL
{
    public partial class CheckoutForm : Form
    {
        public string LastName { get; private set; } = "";
        public string FirstName { get; private set; } = "";
        public string MiddleInitial { get; private set; } = "";
        public string MemberType => cmbType.Text;

        public CheckoutForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text) ||
        string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please fill all required fields");
                return;
            }

            LastName = txtLastName.Text;
            FirstName = txtFirstName.Text;
            MiddleInitial = txtMiddleInitial.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
