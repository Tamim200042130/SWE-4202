using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_CSV
{
     public class User
    {


        


        public string first_name { get; }
        public string last_name { get; }
        public string Address { get; }
        public string City { get; }
        public string Country { get; }
        public string State { get; }
        public string Zip { get; }
        public string Phone1 { get; }
        public string Phone2 { get; }
        public string eMail { get; }
        public User(string firstName, string lastName, string Address,
            string City, string Country, string State, string Zip, string Phone1, string Phone2,
            string eMail)
        {
            this.first_name = firstName;
            this.last_name = lastName;
            this.Address = Address;
            this.City = City;
            this.Country = Country;
            this.State = State;
            this.Zip = Zip;
            this.Phone1 = Phone1;
            this.Phone2 = Phone2;
            this.eMail = eMail;
        }
        public string getDetailedInfo()
        {
            return "Name: " + first_name + " " + last_name + "\nAddress: " + Address
                + "\nCity: " + City + "\nCountry: " + Country + "\nState: " + State
                + "\nzip code: " + Zip + "\nPhone 1: " + Phone1 + "\nPhone 2: "
                + Phone2 + "\nEmail: " + eMail;
        }
    }
}
