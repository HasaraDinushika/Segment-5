using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class StudentBAL
    {
        // create data properties for the Registration table
        public int StudentID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Gpa { get; set; }
        public Boolean Active { get; set; }

        // this returns the list of students who registered to the course
        public DataTable GetStudents()
        {
            try
            {
                StudentDAL student = new StudentDAL();
                return student.Read();
            }
            catch
            {
                throw;
            }
        }

        // this saves the each students data to the data base Registration table
        public int SaveStudents(int id, string name, DateTime dob, decimal gpa, bool active)
        {
            try
            {
                StudentDAL stdDAL = new StudentDAL();
                int noOfRowsAffected = stdDAL.InsertData(id, name, dob, gpa, active);
                return noOfRowsAffected;
            }
            catch
            {
                throw;
            }
        }

        // this uses to check the given id is exists or not in the database table
        public bool CheckIDExist(int id)
        {
            StudentDAL stdDAL = new StudentDAL();
            bool exist = stdDAL.CheckIDExist(id);
            return exist;
        }
    }
}
