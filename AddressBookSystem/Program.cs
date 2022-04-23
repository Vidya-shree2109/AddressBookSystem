using AddressBookSystem;

namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----------WELCOME TO ADDRESS BOOK SYSTEM PROGRAM----------\n");
            bool finish = true;
            Console.WriteLine("Enter :\n1.Display Contacts\n2.Edit Contact\n3.Delete Contact\n4.Add Multiple Contacts\n5.End Of Program");
            Contact contact = new Contact();
            AddDetails add_contact = new AddDetails();
            while (finish)
            {
                Console.Write("\nEnter the option to execute : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        add_contact.DisplayInfo();
                        break;
                    case 2:
                        add_contact.EditContact();
                        break;
                    case 3:
                        add_contact.DeleteContact();
                        break;
                    case 4:
                        Console.Write("\nEnter the name to add data in Dictionary ");
                        string dictionary_name = Console.ReadLine();
                        add_contact.AddDictionary(dictionary_name);
                        break;
                    case 5:
                        finish = false;
                        Console.WriteLine("\nEND OF THE PROGRAM ..!");
                        break;
                }
            }
        }
    }
}