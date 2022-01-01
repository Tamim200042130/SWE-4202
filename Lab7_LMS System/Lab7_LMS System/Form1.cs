using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_LMS_System
{
    public partial class Form1 : Form
    {
        List<Student> StudentList=new List<Student>();
        List<Teacher> TeacherLsit=new List<Teacher>();  
        List<Course> CourseList=new List<Course>();
        string CourseCode;
        string Semester;
        string CourseType;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddTeacher_Click(object sender, EventArgs e)
        {
            string TeacherName = TeacherNameBox.Text;

            Teacher dummy = new Teacher(TeacherName);
            TeacherLsit.Add(dummy);
            MessageBox.Show("Teacher has been added successfully!");
            TeacherSelectComboBox.Items.Add(TeacherName);
            TeacherInfoShowComboBox.Items.Add(TeacherName);
            
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            string StudentName = StudentNameBox.Text;
            string CourseCode = CourseCodeComboBox.Text;
            Student dummy = new Student(StudentName);
            StudentList.Add(dummy);
            MessageBox.Show("Student has been added successfully!");
            StudentShowInfoComboBox.Items.Add(StudentName);
            CourseEnrolledComboBox.Items.Add(CourseCode);
        }

        private void AddCourse_Click(object sender, EventArgs e)
        {

            string Coursetitle = CourseTitleBox.Text;
            Course dummy = new Course(Coursetitle);
            CourseList.Add(dummy);
            MessageBox.Show("Course has been added successfully!");



        }

        private void ShowTeacher_Click(object sender, EventArgs e)
        {
            string TeacherName = TeacherNameBox.Text;
            string TeacherType = TeacherTypeComboBox.Text;
            string CourseCode = CourseCodeComboBox.Text;
            string CourseType=CourseTypeComboBox.Text;  
            string Coursetitle=CourseTitleBox.Text;
            string Semester = SemesterComboBox.Text;


            TeacherInfoShowListBox.Items.Add(TeacherName);
            TeacherInfoShowListBox.Items.Add(TeacherType);
            TeacherInfoShowListBox.Items.Add(CourseCode);
            TeacherInfoShowListBox.Items.Add(CourseType);
            TeacherInfoShowListBox.Items.Add(Coursetitle);
            TeacherInfoShowListBox.Items.Add(Semester);


        }

        private void ShowStudent_Click(object sender, EventArgs e)
        {
            string StudentName=StudentNameBox.Text;
            string Semester = StudentSemesterComboBox.Text;
            string CourseEnrolled = CourseEnrolledComboBox.Text;

            StudentInfoShowListBox.Items.Add(StudentName);
            StudentInfoShowListBox.Items.Add(Semester);
            StudentInfoShowListBox.Items.Add(CourseEnrolled);

        }
    }
}
