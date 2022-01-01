using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem2
{
    internal class User
    {
        public int ID;
        public string Name;
        public string CotactNumber;
        public string Address;
        

        


        public User(int ID, string Name, string CotactNumber,string Address)
        {
            this.ID = ID;
            this.Name = Name;
            this.CotactNumber = CotactNumber;
            this.Address = Address;
            


        }

        public string history()
        {
            return this.ID.ToString() + "\t" + this.Name;
        }
    }
}
