using Business.Models;
using Business.Services;
using Business.Factories;
using System;

namespace Presentation_ConsoleApp.Dialogs
{
    public class MenuDialogs
    {
        private readonly ContactService _contactService;
        private readonly FileService _fileService;

        public MenuDialogs(ContactService contactService, FileService fileService)
        {
            _contactService = contactService;
            _fileService = fileService;
        }

        public void CreateNewContactOption()
        {
            Console.Clear();
            Console.WriteLine("-- NEW CONTACT --");

            var contactForm = new Contact();

            Console.Write("First Name: ");
            contactForm.FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            contactForm.LastName = Console.ReadLine();

            Console.Write("Email: ");
            contactForm.Email = Console.ReadLine();

            Console.Write("Phone Number: ");
            contactForm.PhoneNumber = Console.ReadLine();

            Console.Write("Street Address: ");
            contactForm.StreetAddress = Console.ReadLine();

            Console.Write("Postal Code: ");
            contactForm.PostalCode = Console.ReadLine();

            Console.Write("City: ");
            contactForm.City = Console.ReadLine();

            var newContact = UserFactory.CreateContact(
                contactForm.FirstName, contactForm.LastName, contactForm.Email,
                contactForm.PhoneNumber, contactForm.StreetAddress, contactForm.PostalCode, contactForm.City);

            _contactService.AddContact(newContact);
            _fileService.SaveContacts(_contactService.GetAllContacts());

            Console.WriteLine("Contact was created successfully.");
            Console.ReadKey();
        }

        public void ViewAllContactsOption()
        {
            Console.Clear();
            Console.WriteLine("-- VIEW ALL CONTACTS --");

            var contacts = _contactService.GetAllContacts();
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts found.");
            }
            else
            {
                foreach (var contact in contacts)
                {
                    Console.WriteLine(contact);
                }
            }

            Console.WriteLine("\nPress any key to return to the menu.");
            Console.ReadKey();
        }
    }
}
