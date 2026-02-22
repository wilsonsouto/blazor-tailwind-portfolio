namespace BlazorTailwindPortfolio.Domain.ValueObjects
{
    public record Identity(string Name, string Description, Location Location, List<Contact> Contact, string ProfilePicture);
}
