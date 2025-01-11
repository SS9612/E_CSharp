namespace Business.Services
{
    using Business.Models;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json;

    public class FileService
    {
        private const string FileName = "contacts.json";

        public void SaveContacts(List<Contact> contacts)
        {
            var json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FileName, json);
        }

        public List<Contact> LoadContacts()
        {
            if (File.Exists(FileName))
            {
                var json = File.ReadAllText(FileName);
                return JsonSerializer.Deserialize<List<Contact>>(json) ?? new List<Contact>();
            }
            return new List<Contact>();
        }
    }
}
