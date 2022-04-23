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
        Dictionary<string, List<Contact>> dict_name = new Dictionary<string, List<Contact>>();
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
                Console.WriteLine("First Name : " + contact.first_name);
                Console.WriteLine("Last Name : " + contact.last_name);
                Console.WriteLine("Address : " + contact.address);
                Console.WriteLine("Email : " + contact.email);
                Console.WriteLine("Phone Number : " + contact.phone_number);
                Console.WriteLine("City : " + contact.city);
                Console.WriteLine("State : " + contact.state);
                Console.WriteLine("Zip Code : " + contact.zip_code);
                count++;
            }
        }
        public void EditContact()
        {
            foreach (var contact in address_book)
            {
                Console.WriteLine("\nEDITING AN EXISTING CONTACT BY NAME -->");
                Console.Write("\nEnter the name to edit a contact : ");
                string name = Console.ReadLine();
                if (contact.first_name.Equals(name))
                {
                    Console.WriteLine("\nEnter the option to edit\n1.FirstName\n2.LastName\n3.Address\n4.Email\n5.PhoneNumber\n6.City\n7.State\n8.ZipCode\n");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.Write("Enter the new First Name : ");
                            string new_first_name = Console.ReadLine();
                            contact.first_name = new_first_name;
                            break;
                        case 2:
                            Console.Write("Enter the new Last Name : ");
                            string new_last_name = Console.ReadLine();
                            contact.last_name = new_last_name;
                            break;
                        case 3:
                            Console.Write("Enter the new Address : ");
                            string new_address = Console.ReadLine();
                            contact.address = new_address;
                            break;
                        case 4:
                            Console.Write("Enter the new Email : ");
                            string new_email = Console.ReadLine();
                            contact.email = new_email;
                            break;
                        case 5:
                            Console.Write("Enter the new Phone Number : ");
                            string new_phone_number = Console.ReadLine();
                            contact.phone_number = new_phone_number;
                            break;
                        case 6:
                            Console.Write("Enter the new City : ");
                            string new_city = Console.ReadLine();
                            contact.city = new_city;
                            break;
                        case 7:
                            Console.Write("Enter the new State : ");
                            string new_state = Console.ReadLine();
                            contact.state = new_state;
                            break;
                        case 8:
                            Console.Write("Enter the new Zip Code : ");
                            string new_zip_code = Console.ReadLine();
                            contact.zip_code = new_zip_code;
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("\nENTERED NAME DOESNOT EXIST.. !");
                }
            }
            DisplayInfo();
        }
        public void DeleteContact()
        {
            Contact delete = new Contact();
            Console.WriteLine("\nDELETING AN EXISTING CONTACT BY NAME -->");
            Console.Write("\nEnter the name to delete a contact : ");
            string name_to_delete = Console.ReadLine();
            foreach (var contact in address_book)
            {

                if (contact.first_name.Equals(name_to_delete))
                {
                    delete = contact;
                }
            }
            address_book.Remove(delete);
            Console.WriteLine("\nContact Deleted.. !\n");
            DisplayInfo();
        }
        public void AddDictionary(string name)
        {
            if (dict_name == null)
            {
                dict_name.Add(name, address_book);
            }
            if (NameExists(name) == false)
            {
                dict_name.Add(name, address_book);
            }
            Console.WriteLine(dict_name);
        }
        public bool NameExists(string name)
        {
            foreach (var data in dict_name.Keys)
            {
                if (data.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
    }
}