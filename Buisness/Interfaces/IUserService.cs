using System.Collections.Generic;
using Business.Models;

namespace Business.Interfaces
{
    public interface IUserService
    {
        void AddContact(Contact contact);
        List<Contact> GetAllContacts();
    }
}
