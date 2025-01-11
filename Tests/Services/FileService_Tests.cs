using Business.Models;
using Business.Services;
using System.Collections.Generic;
using System.IO;
using Xunit;

public class FileService_Tests
{
    [Fact]
    public void SaveAndLoadContacts_ShouldPersistData()
    {
        var service = new FileService();
        var contacts = new List<Contact>
        {
            new Contact { FirstName = "Anna", LastName = "Svensson" }
        };

        service.SaveContacts(contacts);
        var loadedContacts = service.LoadContacts();

        Assert.Single(loadedContacts);
        Assert.Equal("Anna", loadedContacts[0].FirstName);
    }
}
