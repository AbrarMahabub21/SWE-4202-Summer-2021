namespace lab_02
{
    partial class Form1
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
            this.Student_Name = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            this.Semester = new System.Windows.Forms.Label();
            this.S_nameTextbox = new System.Windows.Forms.TextBox();
            this.S_IdTextbox = new System.Windows.Forms.TextBox();
            this.S_DeptTextbox = new System.Windows.Forms.TextBox();
            this.S_semTextbox = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Student_Listbox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Teacher_Listbox = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.T_DesignationTextbox = new System.Windows.Forms.TextBox();
            this.T_DeptTextbox = new System.Windows.Forms.TextBox();
            this.T_IDTextbox = new System.Windows.Forms.TextBox();
            this.T_NameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.T_SalaryTextbox = new System.Windows.Forms.TextBox();
            this.A_salaryTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.Admin_Listbox = new System.Windows.Forms.ListBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.A_designationTextbox = new System.Windows.Forms.TextBox();
            this.A_DeptTextbox = new System.Windows.Forms.TextBox();
            this.A_IDTextbox = new System.Windows.Forms.TextBox();
            this.A_NameTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Student_Name
            // 
            this.Student_Name.AutoSize = true;
            this.Student_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Name.Location = new System.Drawing.Point(22, 23);
            this.Student_Name.Name = "Student_Name";
            this.Student_Name.Size = new System.Drawing.Size(65, 18);
            this.Student_Name.TabIndex = 0;
            this.Student_Name.Text = "Student";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(25, 52);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(24, 18);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID";
            this.ID.Click += new System.EventHandler(this.label2_Click);
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.Location = new System.Drawing.Point(25, 79);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(95, 18);
            this.Department.TabIndex = 2;
            this.Department.Text = "Department";
            this.Department.Click += new System.EventHandler(this.label3_Click);
            // 
            // Semester
            // 
            this.Semester.AutoSize = true;
            this.Semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Semester.Location = new System.Drawing.Point(22, 106);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(80, 18);
            this.Semester.TabIndex = 3;
            this.Semester.Text = "Semester";
            // 
            // S_nameTextbox
            // 
            this.S_nameTextbox.Location = new System.Drawing.Point(144, 23);
            this.S_nameTextbox.Name = "S_nameTextbox";
            this.S_nameTextbox.Size = new System.Drawing.Size(100, 22);
            this.S_nameTextbox.TabIndex = 4;
            // 
            // S_IdTextbox
            // 
            this.S_IdTextbox.Location = new System.Drawing.Point(144, 52);
            this.S_IdTextbox.Name = "S_IdTextbox";
            this.S_IdTextbox.Size = new System.Drawing.Size(100, 22);
            this.S_IdTextbox.TabIndex = 5;
            // 
            // S_DeptTextbox
            // 
            this.S_DeptTextbox.Location = new System.Drawing.Point(144, 79);
            this.S_DeptTextbox.Name = "S_DeptTextbox";
            this.S_DeptTextbox.Size = new System.Drawing.Size(100, 22);
            this.S_DeptTextbox.TabIndex = 6;
            // 
            // S_semTextbox
            // 
            this.S_semTextbox.Location = new System.Drawing.Point(144, 106);
            this.S_semTextbox.Name = "S_semTextbox";
            this.S_semTextbox.Size = new System.Drawing.Size(100, 22);
            this.S_semTextbox.TabIndex = 7;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(25, 171);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 34);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.SaveOnClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(118, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ClearOnSave);
            // 
            // Student_Listbox
            // 
            this.Student_Listbox.FormattingEnabled = true;
            this.Student_Listbox.ItemHeight = 16;
            this.Student_Listbox.Location = new System.Drawing.Point(273, 23);
            this.Student_Listbox.Name = "Student_Listbox";
            this.Student_Listbox.Size = new System.Drawing.Size(269, 180);
            this.Student_Listbox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(273, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowOnClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(932, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(345, 28);
            this.button3.TabIndex = 23;
            this.button3.Text = "Show";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.TShowOnClick);
            // 
            // Teacher_Listbox
            // 
            this.Teacher_Listbox.FormattingEnabled = true;
            this.Teacher_Listbox.ItemHeight = 16;
            this.Teacher_Listbox.Location = new System.Drawing.Point(932, 16);
            this.Teacher_Listbox.Name = "Teacher_Listbox";
            this.Teacher_Listbox.Size = new System.Drawing.Size(345, 180);
            this.Teacher_Listbox.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(761, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 34);
            this.button4.TabIndex = 21;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.T_clearOnClick);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(668, 170);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 34);
            this.button5.TabIndex = 20;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.T_SaveOnClick);
            // 
            // T_DesignationTextbox
            // 
            this.T_DesignationTextbox.Location = new System.Drawing.Point(787, 105);
            this.T_DesignationTextbox.Name = "T_DesignationTextbox";
            this.T_DesignationTextbox.Size = new System.Drawing.Size(100, 22);
            this.T_DesignationTextbox.TabIndex = 19;
            // 
            // T_DeptTextbox
            // 
            this.T_DeptTextbox.Location = new System.Drawing.Point(787, 78);
            this.T_DeptTextbox.Name = "T_DeptTextbox";
            this.T_DeptTextbox.Size = new System.Drawing.Size(100, 22);
            this.T_DeptTextbox.TabIndex = 18;
            // 
            // T_IDTextbox
            // 
            this.T_IDTextbox.Location = new System.Drawing.Point(787, 51);
            this.T_IDTextbox.Name = "T_IDTextbox";
            this.T_IDTextbox.Size = new System.Drawing.Size(100, 22);
            this.T_IDTextbox.TabIndex = 17;
            // 
            // T_NameTextbox
            // 
            this.T_NameTextbox.Location = new System.Drawing.Point(787, 22);
            this.T_NameTextbox.Name = "T_NameTextbox";
            this.T_NameTextbox.Size = new System.Drawing.Size(100, 22);
            this.T_NameTextbox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(665, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Designation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(668, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(668, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(665, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Teacher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(668, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Salary";
            // 
            // T_SalaryTextbox
            // 
            this.T_SalaryTextbox.Location = new System.Drawing.Point(787, 142);
            this.T_SalaryTextbox.Name = "T_SalaryTextbox";
            this.T_SalaryTextbox.Size = new System.Drawing.Size(100, 22);
            this.T_SalaryTextbox.TabIndex = 25;
            // 
            // A_salaryTextbox
            // 
            this.A_salaryTextbox.Location = new System.Drawing.Point(139, 485);
            this.A_salaryTextbox.Name = "A_salaryTextbox";
            this.A_salaryTextbox.Size = new System.Drawing.Size(100, 22);
            this.A_salaryTextbox.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 38;
            this.label6.Text = "Salary";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(284, 574);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(345, 28);
            this.button6.TabIndex = 37;
            this.button6.Text = "Show";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.AShowOnClick);
            // 
            // Admin_Listbox
            // 
            this.Admin_Listbox.FormattingEnabled = true;
            this.Admin_Listbox.ItemHeight = 16;
            this.Admin_Listbox.Location = new System.Drawing.Point(284, 359);
            this.Admin_Listbox.Name = "Admin_Listbox";
            this.Admin_Listbox.Size = new System.Drawing.Size(345, 180);
            this.Admin_Listbox.TabIndex = 36;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(113, 513);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 34);
            this.button7.TabIndex = 35;
            this.button7.Text = "Clear";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.AClearOnClick);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(20, 513);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 34);
            this.button8.TabIndex = 34;
            this.button8.Text = "Save";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ASaveOnClick);
            // 
            // A_designationTextbox
            // 
            this.A_designationTextbox.Location = new System.Drawing.Point(139, 448);
            this.A_designationTextbox.Name = "A_designationTextbox";
            this.A_designationTextbox.Size = new System.Drawing.Size(100, 22);
            this.A_designationTextbox.TabIndex = 33;
            // 
            // A_DeptTextbox
            // 
            this.A_DeptTextbox.Location = new System.Drawing.Point(139, 421);
            this.A_DeptTextbox.Name = "A_DeptTextbox";
            this.A_DeptTextbox.Size = new System.Drawing.Size(100, 22);
            this.A_DeptTextbox.TabIndex = 32;
            // 
            // A_IDTextbox
            // 
            this.A_IDTextbox.Location = new System.Drawing.Point(139, 394);
            this.A_IDTextbox.Name = "A_IDTextbox";
            this.A_IDTextbox.Size = new System.Drawing.Size(100, 22);
            this.A_IDTextbox.TabIndex = 31;
            // 
            // A_NameTextbox
            // 
            this.A_NameTextbox.Location = new System.Drawing.Point(139, 365);
            this.A_NameTextbox.Name = "A_NameTextbox";
            this.A_NameTextbox.Size = new System.Drawing.Size(100, 22);
            this.A_NameTextbox.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 29;
            this.label7.Text = "Designation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "Department";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 18);
            this.label9.TabIndex = 27;
            this.label9.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "Admin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 714);
            this.Controls.Add(this.A_salaryTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Admin_Listbox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.A_designationTextbox);
            this.Controls.Add(this.A_DeptTextbox);
            this.Controls.Add(this.A_IDTextbox);
            this.Controls.Add(this.A_NameTextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.T_SalaryTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Teacher_Listbox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.T_DesignationTextbox);
            this.Controls.Add(this.T_DeptTextbox);
            this.Controls.Add(this.T_IDTextbox);
            this.Controls.Add(this.T_NameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Student_Listbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.S_semTextbox);
            this.Controls.Add(this.S_DeptTextbox);
            this.Controls.Add(this.S_IdTextbox);
            this.Controls.Add(this.S_nameTextbox);
            this.Controls.Add(this.Semester);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Student_Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Student_Name;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label Semester;
        private System.Windows.Forms.TextBox S_nameTextbox;
        private System.Windows.Forms.TextBox S_IdTextbox;
        private System.Windows.Forms.TextBox S_DeptTextbox;
        private System.Windows.Forms.TextBox S_semTextbox;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox Student_Listbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox Teacher_Listbox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox T_DesignationTextbox;
        private System.Windows.Forms.TextBox T_DeptTextbox;
        private System.Windows.Forms.TextBox T_IDTextbox;
        private System.Windows.Forms.TextBox T_NameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox T_SalaryTextbox;
        private System.Windows.Forms.TextBox A_salaryTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox Admin_Listbox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox A_designationTextbox;
        private System.Windows.Forms.TextBox A_DeptTextbox;
        private System.Windows.Forms.TextBox A_IDTextbox;
        private System.Windows.Forms.TextBox A_NameTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

