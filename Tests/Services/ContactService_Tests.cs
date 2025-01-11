using Business.Models;
using Business.Services;
using Xunit;

public class ContactService_Tests
{
    [Fact]
    public void AddContact_ShouldAddContactToList()
    {
        var service = new ContactService();
        var contact = new Contact { FirstName = "Anna", LastName = "Svensson" };

        service.AddContact(contact);

        Assert.Single(service.GetAllContacts());
    }
}
