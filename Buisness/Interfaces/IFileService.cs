using System.Collections.Generic;
using Business.Models;

namespace Business.Interfaces
{
    public interface IFileService
    {
        void SaveContacts(List<Contact> contacts);
        List<Contact> LoadContacts();
    }
}
