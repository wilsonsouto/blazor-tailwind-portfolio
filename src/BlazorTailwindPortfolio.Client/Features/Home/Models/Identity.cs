using BlazorTailwindPortfolio.Client.Features.Home.Enums;

namespace BlazorTailwindPortfolio.Client.Features.Home.Models
{
    public record Identity(string Name, string Description, Location Location, List<ContactLinks> ContactLinks, string ProfilePicture);

    public record Location(string Place, string Url);

    public record ContactLinks(string Label, string Url, string Icon, ContactType Type, DisplayOptions DisplayOptions);
}
