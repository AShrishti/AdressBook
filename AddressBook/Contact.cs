using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contact
    {
        public string Name;
        public long PhoneNumber;
        public string Address;
        public string City;
        public int PinCode;
        public string State;


       public Contact(String Name, int Pincode, String City, String State)
        {
            this.Name = Name;
            this.PinCode= Pincode;
            this.City= City;
            this.State= State;
        }
        public override string ToString()
        {
            string result = "";
            result = result + "Name" + Name + "pincode" + PinCode;
            return result;

        }

    
    }
}
