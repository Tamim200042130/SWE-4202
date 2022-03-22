using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SessionFinal
{
    public partial class Form1 : Form
    {



        Student student = new Student();
        public List<Student> studentList = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            using (var reader = new StreamReader(@"C:\Users\user\OneDrive - iut-dhaka.edu\Desktop\SessionFinal\marksheet.csv"))
            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                List<string> listC = new List<string>();
                List<string> listD = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    IDShowListBox.Items.Add(values[0]);
                    NameShowListBox.Items.Add(values[1]);
                    PercentageShowListBox.Items.Add(values[10]);
                    GradeShowListBox.Items.Add(values[11]);

                    Student student = new Student();
                    student.id = values[0];
                    student.name = values[1];
                    student.attendance = Convert.ToInt32(values[2]);
                    student.quizI = Convert.ToInt32(values[3]);
                    student.quizII = Convert.ToInt32(values[4]);
                    student.quizIII = Convert.ToInt32(values[5]);
                    student.quizIV = Convert.ToInt32(values[6]);
                    student.mid = Convert.ToInt32(values[7]);
                    student.final = Convert.ToInt32(values[8]);
                    student.viva = Convert.ToInt32(values[9]);

                    studentList.Add(student);
                }
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            foreach (Student i in studentList)
            {
                if (i.id == SearchTextBox.Text)
                {

                    Attendence.Text = Convert.ToString(i.attendance);
                    QuizI.Text = Convert.ToString(i.quizI);
                    QuizII.Text = Convert.ToString(i.quizII);
                    QuizIII.Text = Convert.ToString(i.quizIII);
                    QuizIV.Text = Convert.ToString(i.quizIV);

                    int sum = 0;
                    int[] arr = { i.quizI, i.quizII, i.quizIII, i.quizIV };
                    Array.Sort(arr);
                    for (int j = 1; j < arr.Length; j++)
                    {
                        sum += arr[j];
                    }
                    QuizTotal.Text = Convert.ToString(sum);
                    Mid.Text = Convert.ToString(i.mid);
                    Final.Text = Convert.ToString(i.final);
                    Viva.Text = Convert.ToString(i.viva);
                    double total = Convert.ToDouble(i.final + sum + i.attendance + i.mid + i.viva);
                    Total.Text = Convert.ToString(i.final + sum + i.attendance + i.mid + i.viva);


                    double Result = (total / 300.00) * 100.00;


                    if (Result >= 80 && Result <= 100)
                    {
                        Grade.Text = "A+";
                    }
                    else if (Result >= 75 && Result < 80)
                    {
                        Grade.Text = "A";
                    }
                    if (Result >= 70 && Result < 75)
                    {
                        Grade.Text = "A-";
                    }
                    if (Result >= 65 && Result < 70)
                    {
                        Grade.Text = "B+";
                    }
                    if (Result >= 60 && Result < 65)
                    {
                        Grade.Text = "B";
                    }
                    if (Result >= 55 && Result < 60)
                    {
                        Grade.Text = "B-";
                    }
                    if (Result >= 50 && Result < 55)
                    {
                        Grade.Text = "C+";
                    }
                    if (Result >= 45 && Result < 50)
                    {
                        Grade.Text = "C";
                    }
                    if (Result >= 40 && Result < 45)
                    {
                        Grade.Text = "D";
                    }
                    if (Result < 40)
                    {
                        Grade.Text = "F";
                    }
                    Parcentage.Text = Result + "%";
                }

            }

        }
    }

  
}

