using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAccessLayer;

namespace PresentationLayer
{
    public partial class StudentRegistration : Form
    {
        private StudentDetails stdDetails;

        public StudentRegistration()
        {
            InitializeComponent();
        }

        public StudentRegistration(StudentDetails stdDetails, int ID)
        {
            InitializeComponent();
            this.stdDetails = stdDetails;
            idValueLabel.Text = ID.ToString();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        // cancel clears the entered value and closing the registration form by displaying
        // student details form without adding any data
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            activeCheckBox.Checked = false;
            gpaTextBox.Clear();

            this.Close();
            stdDetails.Show();
        }

        // Ok button click adds the registration form data to the datagridview as a new row
        // by adding new row to the existing data grid view data
        private void okBtn_Click(object sender, EventArgs e)
        {

            DataTable dt = stdDetails.studentDetailsGridView.DataSource as DataTable;

            dt.Rows.Add(idValueLabel.Text, nameTextBox.Text, dateTimePicker.Value, gpaTextBox.Text, activeCheckBox.Checked);

            this.Close();

            stdDetails.Show();

        }

        // GPA text box validates the numeric field
        // And also checks whether the inserted GPA is valid data.
        private void gpaTextBox_Validating(object sender, CancelEventArgs e)
        {
            decimal num;
            if (decimal.TryParse(gpaTextBox.Text, out num))
            {
                int integer_part = (int)Decimal.Truncate(num).ToString().Length;
                bool val = decimal.Round(num, 2) == num;

                if (integer_part >= 2 || !val)
                {
                    MessageBox.Show("Please Enter valid GPA");
                    gpaTextBox.Clear();
                    gpaTextBox.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter valid input");
                gpaTextBox.Clear();
                gpaTextBox.Focus();
                return;
            }

        }

    }
}
