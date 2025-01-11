using Business.Factories;
using Xunit;

public class UserFactory_Tests
{
    [Fact]
    public void CreateContact_ShouldReturnContactWithValidProperties()
    {
        var contact = UserFactory.CreateContact("Anna", "Svensson", "anna@example.com", "0701234567", "Gatan 1", "12345", "Stockholm");

        Assert.NotNull(contact);
        Assert.Equal("Anna", contact.FirstName);
        Assert.Equal("Svensson", contact.LastName);
    }
}
