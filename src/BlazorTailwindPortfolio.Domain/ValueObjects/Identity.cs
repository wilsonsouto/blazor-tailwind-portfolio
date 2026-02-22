namespace BlazorTailwindPortfolio.Domain.ValueObjects
{
    public record Identity(string Name, string Description, Location Location, List<ContactLinks> ContactLinks, string ProfilePicture);
}
