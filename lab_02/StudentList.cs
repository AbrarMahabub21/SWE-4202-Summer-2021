using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    internal class StudentList
    {
        public int ID;
        public string Student_Name;
        public string Department;
        public int Semester;
        public StudentList(string Student_Name, int ID, string Department, int Semester)
        {
            this.ID = ID;
            this.Student_Name = Student_Name;
            this.Department = Department;
            this.Semester = Semester;
        }
        public string GetInfo()
        {

            string Info = ID +"\t"+ Student_Name +"\t"+ Department +"\t"+Semester+"\t";


            return Info;
        }



    }
}
