using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double attendance_cnt = Convert.ToInt32(textBox6.Text);
            int attendance_mark = (int)Math.Ceiling(attendance_cnt * 30 / 28);
            label20.Text = Convert.ToString(attendance_mark) + "/30";
            label21.Text = textBox5.Text + "/75";
            label23.Text = textBox4.Text + "/150";

            int quiz_mark1 = Convert.ToInt32(textBox3.Text), quiz_mark2 = Convert.ToInt32(textBox2.Text);
            int quiz_mark3 = Convert.ToInt32(textBox10.Text), quiz_mark4 = Convert.ToInt32(textBox9.Text);
            int quiz_mark = quiz_mark1 + quiz_mark2 + quiz_mark3 + quiz_mark4;
            quiz_mark -= Math.Min(quiz_mark1, Math.Min(quiz_mark2, Math.Min(quiz_mark3, quiz_mark4)));

            label22.Text = Convert.ToString(quiz_mark) + "/45";

            int total_mark = quiz_mark + attendance_mark + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox4.Text);
            label24.Text = Convert.ToString(total_mark);
            label24.Text += "/300";

            label26.Text = textBox8.Text + " obtained " + Convert.ToString(Math.Ceiling(total_mark / 3D));
            label26.Text += "% marks.";
            int grade_mark = (int)Math.Ceiling(total_mark / 3.0);

            if (grade_mark >= 80) label25.Text = "A+";
            else if (grade_mark >= 75 && grade_mark < 80) label25.Text = "A";
            else if (grade_mark >= 70 && grade_mark < 75) label25.Text = "A-";
            else if (grade_mark >= 65 && grade_mark < 70) label25.Text = "B+";
            else if (grade_mark >= 60 && grade_mark < 65) label25.Text = "B";
            else if (grade_mark >= 55 && grade_mark < 60) label25.Text = "B-";
            else if (grade_mark >= 50 && grade_mark < 55) label25.Text = "C+";
            else if (grade_mark >= 45 && grade_mark < 50) label25.Text = "C-";
            else if (grade_mark >= 40 && grade_mark < 45) label25.Text = "D";
            else label25.Text = "F";
            label25.Visible = label26.Visible = label20.Visible = label21.Visible = true;
            label23.Visible = label22.Visible = true;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
