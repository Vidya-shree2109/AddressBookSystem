using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddDetails
    {
        List<Contact> address_book = new List<Contact>();
        Contact contact = new Contact();
        public AddDetails()
        {
            Contact contact1 = new Contact()
            {
                first_name = "Vidya",
                last_name = "Shree",
                address = "Maruthi Nagar",
                email = "vidyashree2109@gmail.com",
                phone_number = "9620796710",
                city = "Tumkur",
                state = "Karnataka",
                zip_code = "572102"
            };
            Contact contact2 = new Contact()
            {
                first_name = "Neha",
                last_name = "Sharma",
                address = "Jay Nagar",
                email = "neha786@gmail.com",
                phone_number = "7259925439",
                city = "Bangalore",
                state = "Karnataka",
                zip_code = "560001"
            };
            address_book.Add(contact1);
            address_book.Add(contact2);
        }
        public void AddContacts(Contact contact)
        {
            Console.WriteLine("\nENTER THE PERSONAL DETAILS -->\n");
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
            address_book.Add(contact);
        }
        public void DisplayInfo()
        {
            int count = 1;
            foreach (var contact in address_book)
            {
                Console.WriteLine("\n--------PERSONAL DETAILS OF CONTACT {0}--------\n",count);
                Console.WriteLine("First Name :" + contact.first_name);
                Console.WriteLine("Last Name :" + contact.last_name);
                Console.WriteLine("Address :" + contact.address);
                Console.WriteLine("Email :" + contact.email);
                Console.WriteLine("Phone Number :" + contact.phone_number);
                Console.WriteLine("City :" + contact.city);
                Console.WriteLine("State :" + contact.state);
                Console.WriteLine("Zip Code :" + contact.zip_code);
                count++;
            }
        }
    }
}
