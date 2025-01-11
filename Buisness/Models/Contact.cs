namespace Business.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $@"ID: {Id}
Namn: {FirstName} {LastName}
E-post: {Email}
Telefon: {PhoneNumber}
Adress: {StreetAddress}, {PostalCode} {City}";
        }
    }
}
