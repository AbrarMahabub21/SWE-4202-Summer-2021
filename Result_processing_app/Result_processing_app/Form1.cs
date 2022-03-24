using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Result_processing_app
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchOnClick(object sender, EventArgs e)
        {
            int Attendence = Convert.ToInt32(AttTextbox.Text);
            int Quiz1 = Convert.ToInt32(Quiz1Textbox.Text);
            int Quiz2 = Convert.ToInt32(Quiz2Textbox.Text);
            int Quiz3 = Convert.ToInt32(Quiz3Textbox.Text);
            int Quiz4 = Convert.ToInt32(Quiz4Textbox.Text);
            int mid = Convert.ToInt32(MidBox.Text);
            int final = Convert.ToInt32(FinalBox.Text);
            int viva = Convert.ToInt32(VivaBox.Text);
            
           
            if((Quiz1>Quiz2 && Quiz1>Quiz3 && Quiz1>Quiz4) && (Quiz2>Quiz3 && Quiz2 >Quiz4 ) && (Quiz3>Quiz4))
            {
                int Total_quiz = Convert.ToInt32(Quiz1Textbox.Text) + Convert.ToInt32(Quiz2Textbox.Text) + Convert.ToInt32(Quiz3Textbox.Text);
                total_QuizLabel.Text = "Quiz Total (Best 3)" + " " + Total_quiz.ToString();
                int Total = Total_quiz + Attendence + mid + final + viva;
                int Parcentage = (Total / 300) * 100;
                TotalLabel.Text = "Total(Out of 300)" + " " + Total.ToString();
                ParcentageLabel.Text = "Parcentage"+" "+ Parcentage.ToString();
                if (Parcentage >= 80)
                {
                    GradeLabel.Text = "Grade:"+" "+"A+";

                }
                else if (Parcentage>=75 && Parcentage<=79)
                {
                    GradeLabel.Text = "Grade" + " " + "A";
                }
                else if (Parcentage>=70 && Parcentage<=74)
                {
                    GradeLabel.Text = "Grade" + " " + "A-";
                }
                else if (Parcentage>=65 && Parcentage<=69)
                {
                    GradeLabel.Text = "Grade" + " " + "B+";
                }
                else if (Parcentage >= 60 && Parcentage <= 64)
                {
                    GradeLabel.Text = "Grade" + " " + "B";
                }
                else if (Parcentage >= 55 && Parcentage <= 59)
                {
                    GradeLabel.Text = "Grade" + " " + "B-";
                }
                else if (Parcentage >= 50 && Parcentage <= 54)
                {
                    GradeLabel.Text = "Grade" + " " + "C+";
                }
                else if (Parcentage >= 45 && Parcentage <= 49)
                {
                    GradeLabel.Text = "Grade" + " " + "C";
                }
                else if (Parcentage >= 40 && Parcentage <= 44)
                {
                    GradeLabel.Text = "Grade" + " " + "D";
                }
                else if (Parcentage >= 0 && Parcentage <= 39)
                {
                    GradeLabel.Text = "Grade" + " " + "F";
                }
            }
           
        }

        private void AddOnCLick(object sender, EventArgs e)
        {

            string Name = NameTextBox.Text;
            int ID = Convert.ToInt32(IDTextBox.Text);
            Student dummy_student = new Student(ID, Name);
            MessageBox.Show("Added Successfully!");
            students.Add(dummy_student);
        }
    }
}
