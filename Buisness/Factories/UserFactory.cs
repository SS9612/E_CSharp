namespace Business.Factories
{
    using Business.Models;

    public static class UserFactory
    {
        public static Contact CreateContact(
            string firstName, string lastName, string email,
            string phoneNumber, string streetAddress, string postalCode, string city)
        {
            return new Contact
            {
                Id = Guid.NewGuid(),
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                PhoneNumber = phoneNumber,
                StreetAddress = streetAddress,
                PostalCode = postalCode,
                City = city
            };
        }
    }
}
