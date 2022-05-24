using AddressBookSystem;

namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----------WELCOME TO ADDRESS BOOK SYSTEM PROGRAM----------\n");
            bool finish = true;
            Console.WriteLine("Enter :\n1.Adding Details And Display\n2.Edit Contact\n3.Delete Contact\n4.Add data to dictionary\n5.Edit dictionary data\n6.Delete dictionary data\n7.End Of Program");
            Contact contact = new Contact();
            AddDetails address = new AddDetails();
            while (finish)
            {
                Console.Write("\nEnter the option to execute : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nADDING DETAILS TO CONTACT BY NAME -->");
                        Console.WriteLine("Enter the first name : ");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Enter the last name : ");
                        string lastName = Console.ReadLine();
                        address.AddUniqueDetails(firstName, lastName);
                        break;
                    case 2:
                        Console.WriteLine("\nEDITING AN EXISTING CONTACT BY NAME -->");
                        Console.WriteLine("Enter the first name to edit : ");
                        string firstNameForEdit = Console.ReadLine();
                        Console.WriteLine("Enter the last name to edit : ");
                        string lastNameForEdit = Console.ReadLine();
                        address.EditContact(firstNameForEdit, lastNameForEdit);
                        break;
                    case 3:
                        Console.WriteLine("\nDELETING AN EXISTING CONTACT BY NAME -->");
                        Console.Write("\nEnter the name to delete a contact : ");
                        string name_to_delete = Console.ReadLine();
                        address.DeleteContact(name_to_delete);
                        break;
                    case 4:
                        Console.Write("\nEnter the name to add data in Dictionary : ");
                        string dictionary_name = Console.ReadLine();
                        address.AddDictionary(dictionary_name);
                        break;
                    case 5:
                        Console.WriteLine("Enter the name to edit data in Dictionary : ");
                        string dictName1 = Console.ReadLine();
                        string contactName1 = Console.ReadLine();
                        address.EditDictionary(dictName1, contactName1); 
                        break;
                    case 6:
                        Console.WriteLine("Enter the name to delete data in Dictionary : ");
                        string delete_name = Console.ReadLine();
                        address.DeleteDictionary(delete_name);
                        break;
                    case 7:
                        finish = false;
                        Console.WriteLine("\nEND OF THE PROGRAM ..!");
                        break;
                }
            }
        }
    }
}