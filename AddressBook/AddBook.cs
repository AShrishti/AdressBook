using System;

namespace AddressBook
{
    internal class AddBook
    {
        public Contact[] contacts;
        public int inc = 0;
        public AddBook(int size)
        {
            contacts = new Contact[size];
        }
        public void AddnewContact()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter Name");
            contact.Name=Console.ReadLine();
            Console.WriteLine("Enter phone no");
            contact.PhoneNumber=long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Address");
            contact.Address=Console.ReadLine();
            Console.WriteLine("Enter pincode");
            contact.PinCode = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter city");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            contact.State = Console.ReadLine();

            contacts[0] = contact;


        }

        public void PrintAllContacts()
        {
            Contact contact = contacts[0];
            string statement = "Name is" + contact.Name + "Phone number is" + contact.PhoneNumber;
        Console.WriteLine(statement);
        
        }

    }
}
