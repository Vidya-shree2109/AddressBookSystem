using AddressBookSystem;

namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----------WELCOME TO ADDRESS BOOK SYSTEM PROGRAM----------\n");
            bool finish = true;
            Console.WriteLine("Enter :\n1.Add Contact\n2.Display\n3.Edit Contact\n4.End Of Program");
            Contact contact = new Contact();
            AddDetails add_contact = new AddDetails();
            while (finish)
            {
                Console.Write("\nEnter the option to execute : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        add_contact.AddContacts(contact);
                        break;
                    case 2:
                        add_contact.DisplayInfo();
                        break;
                    case 3:
                        add_contact.EditContact();
                        break;
                    case 4:
                        finish = false;
                        Console.WriteLine("\nEND OF THE PROGRAM ..!");
                        break;
                }
            }
        }
    }
}