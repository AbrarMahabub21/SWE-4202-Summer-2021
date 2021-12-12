using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    internal class Admin
    {

        public string Admin_Name;
        public int ID;
        public string Department;
        public string Designation;
        public int Salary;
        public Admin(string Admin_Name, int ID, string Department, string Designation, int Salary)
        {
            this.Admin_Name = Admin_Name;
            this.ID = ID;
            this.Department = Department;
            this.Designation = Designation;
            this.Salary = Salary;
        }
        public string GetInfo()
        {
            string Info = Admin_Name + "\t" + ID + "\t" + Department + "\t" + Designation + "\t" + Salary + "\t";
            return Info;
        }
    }
}
