using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddDetails
    {
        Contact contact = new Contact();
        public void AddContacts()
        {
            Console.WriteLine("ENTER THE PERSONAL DETAILS -->\n");
            Console.Write("First Name : ");
            contact.first_name = Console.ReadLine();
            Console.Write("Last Name : ");
            contact.last_name = Console.ReadLine();
            Console.Write("Address : ");
            contact.address = Console.ReadLine();
            Console.Write("Email : ");
            contact.email = Console.ReadLine();
            Console.Write("Phone Number : ");
            contact.phone_number = Console.ReadLine();
            Console.Write("City : ");
            contact.city = Console.ReadLine();
            Console.Write("State : ");
            contact.state = Console.ReadLine();
            Console.Write("Zip Code : ");
            contact.zip_code = Console.ReadLine();
        }
        public void DisplayInfo()
        {
            Console.WriteLine("\n--------PERSONAL DETAILS--------\n");
            Console.WriteLine("First Name :" + contact.first_name);
            Console.WriteLine("Last Name :" + contact.last_name);
            Console.WriteLine("Address :" + contact.address);
            Console.WriteLine("Email :" + contact.email);
            Console.WriteLine("Phone Number :" + contact.phone_number);
            Console.WriteLine("City :" + contact.city);
            Console.WriteLine("State :" + contact.state);
            Console.WriteLine("Zip Code :" + contact.zip_code);
        }
    }
}
