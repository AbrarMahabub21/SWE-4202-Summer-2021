using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    internal class Teacher
    {
        public string Teacher_Name;
        public int ID;
        public string Department;
        public string Designation;
        public int Salary;
        public Teacher(string Teacher_Name, int ID, string Department, string Designation, int Salary)
        {
            this.Teacher_Name = Teacher_Name;
            this.ID = ID;
            this.Department = Department;
            this.Designation = Designation;
            this.Salary = Salary;
        }
        public string GetInfo()
        {
            string Info = Teacher_Name + "\t" + ID + "\t" + Department + "\t" + Designation + "\t" + Salary + "\t";
            return Info;
        }

    }
}
