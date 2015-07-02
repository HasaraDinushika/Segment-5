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
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();

            // get the data from business layer and bind it to datagridview data source
            StudentBAL student = new StudentBAL();
            this.studentDetailsGridView.DataSource = student.GetStudents();
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            // this uses to get the next student id value and 
            // display it in the student registration form 
            int rowCount = studentDetailsGridView.Rows.Count;
            int StudentID;

            if (rowCount != 0)
            {
                StudentID = Convert.ToInt16(studentDetailsGridView.Rows[rowCount - 1].Cells["StudentID"].Value.ToString()) + 1;
            }
            else
            {
                StudentID = 1;
            }

            // pass the student id and current student detail form to the student registration constructor
            // display student registration form with the next student id value
            StudentRegistration sr = new StudentRegistration(this, StudentID);
            sr.Show();

        }

        // when user clicks ok button data is saved in to the database
        private void saveBtn_Click(object sender, EventArgs e)
        {
            StudentBAL student = new StudentBAL();
            int noOfRowsAffected = 0;

            // iterate through all the datagridview rows and check the id exists in the database or not
            // if it finds the new id save that row data to database
            foreach (DataGridViewRow row in studentDetailsGridView.Rows)
            {
                var exist = student.CheckIDExist(Convert.ToInt16(row.Cells["StudentID"].Value));
                if (!exist)
                {
                    int id = Convert.ToInt16(row.Cells["StudentID"].Value);
                    string name = row.Cells["Name"].Value.ToString();
                    DateTime dob = Convert.ToDateTime(row.Cells["Date Of Birth"].Value);
                    decimal gpa = Convert.ToDecimal(row.Cells["Grade Point Average"].Value);
                    bool active = Convert.ToBoolean(row.Cells["Active"].Value);

                    noOfRowsAffected = student.SaveStudents(id, name, dob, gpa, active);
                }
            }

            // this uses to check whether data inserted successfully to database table
            if (noOfRowsAffected != 0)
            {
                MessageBox.Show("data inserted successfully");
            }

            this.Close();

        }
    }
}
