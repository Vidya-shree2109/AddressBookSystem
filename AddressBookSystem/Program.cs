using AddressBookSystem;

namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----------WELCOME TO ADDRESS BOOK SYSTEM PROGRAM----------\n");
            bool finish = true;
            Console.WriteLine("Enter :\n1.Adding Details And Display\n2.Display Details\n3.Edit Contact\n4.Delete Contact\n5.Add data to dictionary\n6.Edit dictionary data\n7.Delete dictionary data\n8.Search A Person By City\n9.End Of Program");
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
                        address.DisplayInfo();
                        break;
                    case 3:
                        Console.WriteLine("\nEDITING AN EXISTING CONTACT BY NAME -->");
                        Console.WriteLine("Enter the first name to edit : ");
                        string firstNameForEdit = Console.ReadLine();
                        Console.WriteLine("Enter the last name to edit : ");
                        string lastNameForEdit = Console.ReadLine();
                        address.EditContact(firstNameForEdit, lastNameForEdit);
                        break;
                    case 4:
                        Console.WriteLine("\nDELETING AN EXISTING CONTACT BY NAME -->");
                        Console.Write("\nEnter the name to delete a contact : ");
                        string nameToDelete = Console.ReadLine();
                        address.DeleteContact(nameToDelete);
                        break;
                    case 5:
                        Console.Write("\nEnter the name to add data in Dictionary : ");
                        string dictionaryName = Console.ReadLine();
                        address.AddDictionary(dictionaryName);
                        break;
                    case 6:
                        Console.Write("\nEnter the name to edit data in Dictionary : ");
                        string dictName1 = Console.ReadLine();
                        string contactName1 = Console.ReadLine();
                        address.EditDictionary(dictName1, contactName1); 
                        break;
                    case 7:
                        Console.Write("\nEnter the name to delete data in Dictionary : ");
                        string deleteName = Console.ReadLine();
                        address.DeleteDictionary(deleteName);
                        break;
                    case 8:
                        Console.Write("\nEnter The City Name To Search A Person : ");
                        string cityName = Console.ReadLine();
                        address.SearchingPersonByCity(cityName);
                        break;
                    case 9:
                        finish = false;
                        Console.WriteLine("\nEND OF THE PROGRAM.. !");
                        break;
                }
            }
        }
    }
}