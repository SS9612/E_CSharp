namespace Business.Services
{
    using Business.Models;
    using System.Collections.Generic;

    public class ContactService
    {
        private readonly List<Contact> _contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public List<Contact> GetAllContacts()
        {
            return _contacts;
        }
    }
}
