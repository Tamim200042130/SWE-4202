using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem2
{
    public partial class Form1 : Form
    {

        List<User> user = new List<User>();
        List<Booking> bookings = new List<Booking>();



        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(IDBox.Text);
            string Name = NameBox.Text;
            string CotactNumber = NumberBox.Text;
            string Address = AddressBox.Text;

            User dummy = new User(ID, Name, CotactNumber, Address);
            user.Add(dummy);
            MessageBox.Show("User has been added successfully!");
        }

        private void PlaceBooking_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(UserBookingIDBox.Text);
            MessageBox.Show("Room Booking successfull!");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void SeeOrderDetails_Click(object sender, EventArgs e)
        {
            int ammount;
            foreach (Booking booking in bookings)
            {
                for (int i = 0; i < bookings.Count; i++)

                {
                    if (i == Convert.ToInt32(BookingIDBox.Text))
                    {
                        RoomQuantityLabel.Text = booking.roomquantity.ToString();
                      
                    }
                }


            }

        }

        private void BookingIDBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
