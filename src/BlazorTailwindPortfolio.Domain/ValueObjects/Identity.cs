using BlazorTailwindPortfolio.Domain.Enums;

namespace BlazorTailwindPortfolio.Domain.ValueObjects
{
    public record Identity(string Name, string Description, Location Location, List<ContactLinks> ContactLinks, string ProfilePicture);

    public record Location(string Place, string Url);

    public record ContactLinks(string Label, string Url, string Icon, ContactType Type, DisplayOptions DisplayOptions);
}
