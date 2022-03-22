using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CsvHelper;

namespace Lab10_CSV
{
    public partial class Form1 : Form
    {
        List<User> userList = new List<User>();
        public Form1()
        {
            InitializeComponent();

            List<DataGirdView> list;
            using (var reader = new StreamReader(@"C:\Users\user\OneDrive\Desktop\Lab10_CSV\UserInfo_Copy.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                list = csv.GetRecords<DataGirdView>().ToList();

            }
            dataGridView1.DataSource = list;
            using (var reader = new StreamReader(@"C:\Users\user\OneDrive\Desktop\Lab10_CSV\UserInfo.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    string addinList = "";
                    //for (int i = 0; i < 5; i++)
                    //{
                    //    addinList += values[i] + "\n";
                    //}
                    ShowAllUserListBox.Items.Add(values[0],values[1],values[9]);

                    User dummy = new User(values[0], values[1], values[2], values[3], values[4],
                        values[5], values[6], values[7], values[8], values[9]);
                    userList.Add(dummy);
                }

            }
            
        }

        private void showInfo(object sender, EventArgs e)
        {
            dataGridView1.ResetText();

            User dummy = null;
            foreach (User user in userList)
            {
                if (User.eMail == SearchBox.Text)
                {
                    MessageBox.Show("NotFound");
                }
                dummy = user;
            }

                string toShow = SearchBox.Text + "\t" + DateTime.Now.ToString() + "\t";

                if (dummy == null)
                {
                    toShow += "NotFound";
                    MessageBox.Show("User Not found!");
                }
                else
                {
                    textBox1.Text = dummy.getDetailedInfo();
                    ShowUserInfoListBox.Items.Add("Name: " + dummy.first_name + " " + dummy.last_name);
                    ShowUserInfoListBox.Items.Add("Address: " + dummy.Address);
                    ShowUserInfoListBox.Items.Add("City: " + dummy.City);
                    ShowUserInfoListBox.Items.Add("Country: " + dummy.Country);
                    ShowUserInfoListBox.Items.Add("State: " + dummy.State);
                    ShowUserInfoListBox.Items.Add("Zip: " + dummy.Zip);
                    ShowUserInfoListBox.Items.Add("Phone 1: " + dummy.Phone1);
                    ShowUserInfoListBox.Items.Add("Phone 2: " + dummy.Phone2);
                    ShowUserInfoListBox.Items.Add("Email: " + dummy.eMail);
                    //ShowUserInfoListBox.Items.Add(dummy.getDetailedInfo());
                    toShow += dummy.first_name + "_" + dummy.last_name + "_" + dummy.Address + "_"
                        + dummy.City + "_" + dummy.Country + "_" + dummy.State + "_" + dummy.Zip + "_"
                        + dummy.Phone1 + "_" + dummy.Phone2 + "_" + dummy.eMail;
                }
                string path = @"C:\Users\user\OneDrive\Desktop\Lab10_CSV\Log.txt";
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(toShow);
                    }
                }
                else
                {
                    using (StreamWriter sr = File.AppendText(path))
                    {
                        sr.WriteLine(toShow);
                    }
                }
            
        }
    }
}
