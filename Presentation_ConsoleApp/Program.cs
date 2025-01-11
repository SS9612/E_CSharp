using System;
using Business.Services;
using Presentation_ConsoleApp.Dialogs;

namespace Presentation_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var contactService = new ContactService();
            var fileService = new FileService();

            var contacts = fileService.LoadContacts();
            contacts.ForEach(contact => contactService.AddContact(contact));

            var menuDialogs = new MenuDialogs(contactService, fileService);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("== CONTACT LIST APP ==");
                Console.WriteLine("1. View All Contacts");
                Console.WriteLine("2. Create New Contact");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        menuDialogs.ViewAllContactsOption();
                        break;
                    case "2":
                        menuDialogs.CreateNewContactOption();
                        break;
                    case "3":
                        Console.WriteLine("Exiting... Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
