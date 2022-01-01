using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem2
{
    internal class Booking
    {
        
        public string roomchoice;
        public string roomquantity;
        public string staytime;
        public  string Address;

        public Booking(string roomchoice, string roomquantity, string staytime,string Address)
        {
            this.roomchoice= roomchoice;
            this.roomquantity = roomquantity;
            this.staytime = staytime;
            this.Address = Address;



        }

        



    }
}
