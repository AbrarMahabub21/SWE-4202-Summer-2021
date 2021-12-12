using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_02
{
    public partial class Form1 : Form
    {
        List<StudentList> Students = new List<StudentList>();
        List<Teacher> Teachers = new List<Teacher>();
        List<Admin> Admins = new List<Admin>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SaveOnClick(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(S_IdTextbox.Text);
            string Student_Name = S_nameTextbox.Text;
            string Department = S_DeptTextbox.Text;
            int Semester = Convert.ToInt32(S_semTextbox.Text);
            StudentList student_dummy = new StudentList(Student_Name,ID,Department,Semester);
            Students.Add(student_dummy);
            MessageBox.Show("Student has been added successfully");
              


        }

        private void ClearOnSave(object sender, EventArgs e)
        {
            S_nameTextbox.Text = String.Empty;
            S_IdTextbox.Text = String.Empty;
            S_DeptTextbox.Text = String.Empty;
            S_semTextbox.Text = String.Empty;
            MessageBox.Show("cleared successfully");
        }

        private void ShowOnClick(object sender, EventArgs e)
        {
            Student_Listbox.Items.Clear();
            foreach(StudentList student_dummy in Students)
            {
                Student_Listbox.Items.Add(student_dummy.GetInfo());
            }

        }

        private void T_SaveOnClick(object sender, EventArgs e)
        {
            string Teacher_Name = T_NameTextbox.Text;
            int ID = Convert.ToInt32(T_IDTextbox.Text);
            string Department = T_DeptTextbox.Text;
            string Designation = T_DesignationTextbox.Text;
            int Salary = Convert.ToInt32(T_SalaryTextbox.Text);
            Teacher teacher_dummy = new Teacher(Teacher_Name, ID, Department, Designation, Salary);
            Teachers.Add(teacher_dummy);
            MessageBox.Show("Teacher has been added successfully");
        }

        private void T_clearOnClick(object sender, EventArgs e)
        {
            T_NameTextbox.Text = string.Empty;
            T_IDTextbox.Text = string.Empty;
            T_DeptTextbox.Text = string.Empty;
            T_DesignationTextbox.Text = string.Empty;
            T_SalaryTextbox.Text = string.Empty;
            MessageBox.Show("Cleared Successfully!");
        }

        private void TShowOnClick(object sender, EventArgs e)
        {
            Teacher_Listbox.Items.Clear();
            foreach(Teacher teacher_dummy in Teachers)
            {
                Teacher_Listbox.Items.Add(teacher_dummy.GetInfo());
            }
        }

        private void ASaveOnClick(object sender, EventArgs e)
        {
            string Admin_Name = A_NameTextbox.Text;
            int ID = Convert.ToInt32(A_IDTextbox.Text);
            string Department = A_DeptTextbox.Text;
            string Designation = A_designationTextbox.Text;
            int Salary = Convert.ToInt32(A_salaryTextbox.Text);
            Admin admin_dummy = new Admin(Admin_Name, ID, Department, Designation, Salary);
            Admins.Add(admin_dummy);
            MessageBox.Show("Admin has been added successfully");
        }

        private void AClearOnClick(object sender, EventArgs e)
        {
            A_NameTextbox.Text = string.Empty;
            A_IDTextbox.Text = string.Empty;
            A_DeptTextbox.Text = string.Empty;
            A_designationTextbox.Text = string.Empty;
            A_salaryTextbox.Text = string.Empty;
            MessageBox.Show("Cleared Successfully!");
        }

        private void AShowOnClick(object sender, EventArgs e)
        {
            Admin_Listbox.Items.Clear();
            foreach (Admin admin_dummy in Admins)
            {
                Admin_Listbox.Items.Add(admin_dummy.GetInfo());
            }
        }
    }
}
